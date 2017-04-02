using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.Entity;
using DTD.Entity.Enum;
using DTD.Entity.Helpers;
using DTD.Entity.vCodes;
using GlobalLibrary;

namespace Core.Converter
{
    public class CodeToVCode
    {
        public Scope Scope { get; set; }
        private RegexPatterns regex;

        public CodeToVCode(string code)
        {
            regex = new RegexPatterns();

            //Call Function here.
            Scope = new Scope();
            code = Regex.Replace(code, @"\t|\n", "");
            CreateScopeObject(Scope, '{' + code.Trim() + '}');
        }

        #region LexicalAnalyzer

        private void CreateConditionObject(Condition condition, string text)
        {
            Match op = regex.BooleanOperator.Match(text);
            condition.BooleanOperator = op.Groups[0].ToString();

            Match param = regex.SingleInstructionRegex.Match(text);

            byte count = 0;
            while (param.Success)
            {
                if (count == 0)
                {
                    condition.LeftParameter = param.Groups[0].ToString();
                }
                else
                {
                    condition.RightParameter = param.Groups[0].ToString();
                }
                count++;
                param = param.NextMatch();
            }
        }

        private int CropScope(Scope scope, int start, string text)
        {
            Stack<char> stack = new Stack<char>();
            int end = start;
            while (text[start] != '{')
            {
                start = ++end;
            }
            stack.Push('{');

            while (stack.Count != 0)
            {
                end++;
                if (text[end] == '{')
                {
                    stack.Push('{');
                }
                else if (text[end] == '}')
                {
                    stack.Pop();
                }
            }
            CreateScopeObject(scope, text.Substring(start, end - start + 1));
            return ++end;
        }

        private void CreateScopeObject(Scope scope, string currentScope)
        {
            int start = 1, end = 1;
            while (end < currentScope.Length - 1)
            {
                string selectedText = currentScope.Substring(start, end - start + 1);
                if (regex.FunctionRegex.IsMatch(selectedText))
                {
                    Function funcObject = new Function();
                    scope.Items.Enqueue(funcObject);
                    CreateFunctionObject(funcObject, selectedText);
                    start = ++end;
                    start = end = CropScope(funcObject.Scope, start, currentScope);
                }
                else if (regex.FunctionCall.IsMatch(selectedText))
                {
                    Function funcObject = new Function();
                    scope.Items.Enqueue(funcObject);
                    CreateFunctionCallObject(funcObject, selectedText);
                    start = ++end;
                }
                else if (regex.VarDeclaration.IsMatch(selectedText))
                {
                    CreateVariableObject(scope, selectedText, false);
                    start = ++end;
                }
                else if (regex.ArrayRegex.IsMatch(selectedText))
                {
                    CreateVariableObject(scope, selectedText, true);
                    start = ++end;
                }
                else if (regex.IfRegex.IsMatch(selectedText))
                {
                    If ifObject = new If();
                    scope.Items.Enqueue(ifObject);
                    CreateConditionObject(ifObject.Condition, selectedText);
                    start = ++end;
                    start = end = CropScope(ifObject.Scope, start, currentScope);
                }
                else if (regex.WhileRegex.IsMatch(selectedText))
                {
                    While whileObject = new While();
                    scope.Items.Enqueue(whileObject);
                    CreateConditionObject(whileObject.Condition, selectedText);
                    start = ++end;
                    start = end = CropScope(whileObject.Scope, start, currentScope);
                }
                else if(regex.VarAssignmentRegex.IsMatch(selectedText))
                {
                    CreateAssignmentObject(scope,selectedText);
                }
                else if (currentScope[start] == ' ')
                {
                    start = ++end;
                }
                else if (selectedText == "\n")
                {
                    start = ++end;
                }
                else
                {
                    end++;
                }
            }
        }

        private void CreateFunctionCallObject(Function funcObject, string text)
        {
            if (regex.ParameterValueRegex.IsMatch(text))
            {
                Match parameters = regex.ParameterValueRegex.Match(text);
                Match m = regex.SingleInstructionRegex.Match(parameters.Groups[0].ToString());

                while (m.Success)
                {
                    funcObject.Parameters.Add(new Parameter(m.Groups[0].ToString()));
                    m = m.NextMatch();
                }
                text = regex.ParameterRegex.Replace(text, "");
            }
            if (regex.Variable.IsMatch(text))
            {
                Match m = regex.Variable.Match(text);
                funcObject.Name = m.Groups[0].ToString();
            }
        }

        //will return function object globaly declared
        private void CreateFunctionObject(Function funcObject, string text)
        {
            if (regex.ParameterRegex.IsMatch(text))
            {
                Match parameters = regex.ParameterRegex.Match(text);
                Regex param = new Regex("(" + regex.DataType + ")[\\s]+(" + regex.Variable + ")");
                Match m = param.Match(parameters.Groups[0].ToString());
                while (m.Success)
                {
                    Parameter p = new Parameter();
                    string[] parameterContent = m.ToString().Split(' ');
                    p.Type = parameterContent[0];
                    p.Name = parameterContent[1];

                    funcObject.Parameters.Add(p);


                    m = m.NextMatch();
                }
                text = regex.ParameterRegex.Replace(text, "");
            }

            #region Variable DataType
            if (regex.DataType.IsMatch(text))
            {
                Match m = regex.DataType.Match(text);
                switch (m.Groups[0].ToString())
                {
                    case "bool":
                        funcObject.Type = Enums.Type.Bool;
                        break;

                    case "int":
                        funcObject.Type = Enums.Type.Int;
                        break;

                    case "float":
                        funcObject.Type = Enums.Type.Float;
                        break;

                    case "double":
                        funcObject.Type = Enums.Type.Double;
                        break;

                    case "string":
                        funcObject.Type = Enums.Type.String;
                        break;
                }
                text = regex.DataType.Replace(text, "");
            }
            #endregion

            #region Variable AccessModifier
            if (regex.AccessModifier.IsMatch(text))
            {
                Match m = regex.AccessModifier.Match(text);

                switch (m.Groups[0].ToString())
                {
                    case "public":
                        funcObject.AccessModifier = Enums.AccessModifier.Public;
                        break;
                    case "private":
                        funcObject.AccessModifier = Enums.AccessModifier.Private;
                        break;
                    case "protected":
                        funcObject.AccessModifier = Enums.AccessModifier.Protected;
                        break;
                }
                text = regex.AccessModifier.Replace(text, "");
            }
            #endregion

            if (regex.IsStatic.IsMatch(text))
            {
                funcObject.IsStatic = true;
                text = regex.IsStatic.Replace(text, "");
            }

            if (regex.Variable.IsMatch(text))
            {
                Match m = regex.Variable.Match(text);
                funcObject.Name = m.Groups[0].ToString();
            }
        }

        private void CreateVariableObject(Scope scope, string text, bool isArray)
        {
            Variable varObject = new Variable();
            varObject.IsArray = isArray;

            #region Variable DataType
            if (regex.DataType.IsMatch(text))
            {
                Match m = regex.DataType.Match(text);
                switch (m.Groups[0].ToString())
                {
                    case "bool":
                        varObject.Type = Enums.Type.Bool;
                        break;

                    case "int":
                        varObject.Type = Enums.Type.Int;
                        break;

                    case "float":
                        varObject.Type = Enums.Type.Float;
                        break;

                    case "double":
                        varObject.Type = Enums.Type.Double;
                        break;

                    case "string":
                        varObject.Type = Enums.Type.String;
                        break;

                    case "char":
                        varObject.Type = Enums.Type.Char;
                        break;
                }
                text = regex.DataType.Replace(text, "");
            }

            #endregion

            #region Variable AccessModifier
            if (regex.AccessModifier.IsMatch(text))
            {
                Match m = regex.AccessModifier.Match(text);

                switch (m.Groups[0].ToString())
                {
                    case "public":
                        varObject.AccessModifier = Enums.AccessModifier.Public;
                        break;
                    case "private":
                        varObject.AccessModifier = Enums.AccessModifier.Private;
                        break;
                    case "protected":
                        varObject.AccessModifier = Enums.AccessModifier.Protected;
                        break;
                }
                text = regex.AccessModifier.Replace(text, "");
            }
            #endregion

            if (regex.IsStatic.IsMatch(text))
            {
                varObject.IsStatic = true;
                text = regex.IsStatic.Replace(text, "");
            }


            if (regex.Variable.IsMatch(text))
            {
                Match m = regex.Variable.Match(text);
                varObject.Name = m.Groups[0].ToString();
                text = regex.Variable.Replace(text, "");
            }

            if (isArray)
            {
                Match m = regex.NumberRegex.Match(text);
                byte count = 0;
                while (m.Success)
                {
                    if (count == 0)
                        varObject.Row = Convert.ToInt32(m.Groups[0].ToString());
                    else
                        varObject.Column = Convert.ToInt32(m.Groups[0].ToString());
                    m = m.NextMatch();
                    count++;
                }
            }
            scope.Items.Enqueue(varObject);
        }

        private void CreateAssignmentObject(Scope scope, string text)
        {
            Assignment assignment = new Assignment();
            Instruction instruction = new Instruction();

            Match m = regex.SingleInstructionRegex.Match(text);
            Match op = regex.OperatorRegex.Match(text);

            assignment.Variable = m.Groups[0].ToString();


            if (regex.ThreeAddressInstructionRegex.IsMatch(text))
            {
                instruction.InstructionType = Enums.InstructionType.ThreeAddress;
                ThreeAddressInstruction threeAddress = (ThreeAddressInstruction)instruction;
                m = m.NextMatch();
                threeAddress.LeftInstruction = m.Groups[0].ToString();
                m = m.NextMatch();
                threeAddress.RightInstruction = m.Groups[0].ToString();
                threeAddress.Operator = op.Groups[0].ToString();
            }
            else
            {
                instruction.InstructionType = Enums.InstructionType.SingleAddress;
                SingleInstruction single = (SingleInstruction)instruction;
                m = m.NextMatch();
                single.Instruction = m.Groups[0].ToString();
            }
        }
        #endregion

    }
}