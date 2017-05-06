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
        private readonly RegexPatterns _regex;

        public CodeToVCode(string code)
        {
            _regex = new RegexPatterns();

            //Call Function here.
            Scope = new Scope();
            code = Regex.Replace(code, @"\t|\n", "");
            CreateScopeObject(Scope, '{' + code.Trim() + '}');
        }

        #region LexicalAnalyzer

        private void CreateConditionObject(Condition condition, string text)
        {
            Match op = _regex.BooleanOperator.Match(text);
            condition.BooleanOperator = op.Groups[0].ToString();

            Match param = _regex.SingleInstructionRegex.Match(text);

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
                if (_regex.FunctionRegex.IsMatch(selectedText))
                {
                    Function funcObject = new Function();
                    scope.Items.Enqueue(funcObject);
                    CreateFunctionObject(funcObject, selectedText);
                    start = ++end;
                    start = end = CropScope(funcObject.Scope, start, currentScope);
                }
                else if (_regex.FunctionCall.IsMatch(selectedText))
                {
                    Function funcObject = new Function();
                    scope.Items.Enqueue(funcObject);
                    CreateFunctionCallObject(funcObject, selectedText);
                    start = ++end;
                }
                else if (_regex.VarDeclaration.IsMatch(selectedText))
                {
                    CreateVariableObject(scope, selectedText, false);
                    start = ++end;
                }
                else if (_regex.ArrayRegex.IsMatch(selectedText))
                {
                    CreateVariableObject(scope, selectedText, true);
                    start = ++end;
                }
                else if (_regex.IfRegex.IsMatch(selectedText))
                {
                    If ifObject = new If();
                    scope.Items.Enqueue(ifObject);
                    CreateConditionObject(ifObject.Condition, selectedText);
                    start = ++end;
                    start = end = CropScope(ifObject.Scope, start, currentScope);
                }
                else if (_regex.WhileRegex.IsMatch(selectedText))
                {
                    While whileObject = new While();
                    scope.Items.Enqueue(whileObject);
                    CreateConditionObject(whileObject.Condition, selectedText);
                    start = ++end;
                    start = end = CropScope(whileObject.Scope, start, currentScope);
                }
                else if(_regex.VarAssignmentRegex.IsMatch(selectedText))
                {
                    CreateAssignmentObject(scope,selectedText);
                    start = ++end;
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
            if (_regex.ParameterValueRegex.IsMatch(text))
            {
                Match parameters = _regex.ParameterValueRegex.Match(text);
                Match m = _regex.SingleInstructionRegex.Match(parameters.Groups[0].ToString());

                while (m.Success)
                {
                    funcObject.Parameters.Add(new Parameter(m.Groups[0].ToString()));
                    m = m.NextMatch();
                }
                text = _regex.ParameterRegex.Replace(text, "");
            }
            if (_regex.Variable.IsMatch(text))
            {
                Match m = _regex.Variable.Match(text);
                funcObject.Name = m.Groups[0].ToString();
            }
        }

        //will return function object globaly declared
        private void CreateFunctionObject(Function funcObject, string text)
        {
            if (_regex.ParameterRegex.IsMatch(text))
            {
                Match parameters = _regex.ParameterRegex.Match(text);
                Regex param = new Regex("(" + _regex.DataType + ")[\\s]+(" + _regex.Variable + ")");
                Match m = param.Match(parameters.Groups[0].ToString());
                while (m.Success)
                {
                    Parameter p = new Parameter();
                    string[] parameterContent = m.ToString().Split(' ');

                    switch (parameterContent[0])
                    {
                        case "int":
                            p.Type = Enums.Type.Int;
                            break;
                        case "float":
                            p.Type = Enums.Type.Float;
                            break;
                        case "double":
                            p.Type = Enums.Type.Double;
                            break;
                        case "string":
                            p.Type = Enums.Type.String;
                            break;
                        case "char":
                            p.Type = Enums.Type.Char;
                            break;
                        case "bool":
                            p.Type = Enums.Type.Bool;
                            break;
                    }
                    
                    p.Name = parameterContent[1];

                    funcObject.Parameters.Add(p);


                    m = m.NextMatch();
                }
                text = _regex.ParameterRegex.Replace(text, "");
            }

            #region Variable DataType
            if (_regex.DataType.IsMatch(text))
            {
                Match m = _regex.DataType.Match(text);
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
                text = _regex.DataType.Replace(text, "");
            }
            #endregion

            #region Variable AccessModifier
            if (_regex.AccessModifier.IsMatch(text))
            {
                Match m = _regex.AccessModifier.Match(text);

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
                text = _regex.AccessModifier.Replace(text, "");
            }
            #endregion

            if (_regex.IsStatic.IsMatch(text))
            {
                funcObject.IsStatic = true;
                text = _regex.IsStatic.Replace(text, "");
            }

            if (_regex.Variable.IsMatch(text))
            {
                Match m = _regex.Variable.Match(text);
                funcObject.Name = m.Groups[0].ToString();
            }
        }

        private void CreateVariableObject(Scope scope, string text, bool isArray)
        {
            Variable varObject = new Variable();
            varObject.IsArray = isArray;

            #region Variable DataType
            if (_regex.DataType.IsMatch(text))
            {
                Match m = _regex.DataType.Match(text);
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
                text = _regex.DataType.Replace(text, "");
            }

            #endregion

            #region Variable AccessModifier
            if (_regex.AccessModifier.IsMatch(text))
            {
                Match m = _regex.AccessModifier.Match(text);

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
                text = _regex.AccessModifier.Replace(text, "");
            }
            #endregion

            if (_regex.IsStatic.IsMatch(text))
            {
                varObject.IsStatic = true;
                text = _regex.IsStatic.Replace(text, "");
            }


            if (_regex.Variable.IsMatch(text))
            {
                Match m = _regex.Variable.Match(text);
                varObject.Name = m.Groups[0].ToString();
                text = _regex.Variable.Replace(text, "");
            }

            if (isArray)
            {
                Match m = _regex.NumberRegex.Match(text);
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
            scope.Items.Enqueue(assignment);

            Match m = _regex.InstructionRegex.Match(text);
            Match op = _regex.OperatorRegex.Match(text);

            assignment.Variable = m.Groups[0].ToString();


            if (_regex.ThreeAddressInstructionRegex.IsMatch(text))
            {
                ThreeAddressInstruction threeAddress = new ThreeAddressInstruction
                {
                    InstructionType = Enums.InstructionType.ThreeAddress
                };
                assignment.Instruction = threeAddress;


                m = m.NextMatch();
                byte count = 0;
                while (m.Success)
                {
                    TypedvCodes ins = new TypedvCodes();
                    if (_regex.Variable.IsMatch(m.Groups[0].ToString()))
                    {
                        ins.Name = m.Groups[0].ToString();
                    }
                    else if (_regex.FunctionCall.IsMatch(m.Groups[0].ToString()))
                    {
                        ins.Name = m.Groups[0].ToString();
                    }
                    else if (_regex.ConstantRegex.IsMatch(m.Groups[0].ToString()))
                    {
                        CreateInstructionObject(ins,m.Groups[0].ToString());
                    }
                    if (count == 0)
                    {
                        threeAddress.LeftInstruction = ins;
                        count++;
                    }
                    else
                    {
                        threeAddress.RightInstruction = ins;
                    }
                    m = m.NextMatch();
                }
                threeAddress.Operator = op.Groups[0].ToString();
            }
            else
            {

                SingleInstruction single = new SingleInstruction {InstructionType = Enums.InstructionType.SingleAddress};
                assignment.Instruction = single;

                m = m.NextMatch();
                TypedvCodes ins = new TypedvCodes();
                if (_regex.Variable.IsMatch(m.Groups[0].ToString()))
                {
                    ins.Name = m.Groups[0].ToString();
                }
                else if (_regex.FunctionCall.IsMatch(m.Groups[0].ToString()))
                {
                    ins.Name = m.Groups[0].ToString();
                }
                else if (_regex.ConstantRegex.IsMatch(m.Groups[0].ToString()))
                {
                    CreateInstructionObject(ins, m.Groups[0].ToString());
                }
                single.Instruction = ins;
            }
        }

        private void CreateInstructionObject(TypedvCodes ins,string text)
        {
            Constant cns = (Constant)ins;
            cns.Value = text;
            cns.VType = Enums.VType.Constant;

            if (_regex.StringRegex.IsMatch(text))
            {
                cns.Type = Enums.Type.String;
            }
            else if (_regex.DoubleRgex.IsMatch(text))
            {
                cns.Type = Enums.Type.Double;
            }
            else if (_regex.IntRegex.IsMatch(text))
            {
                cns.Type = Enums.Type.Int;
            }
            else if (_regex.BoolValue.IsMatch(text))
            {
                cns.Type = Enums.Type.Bool;
            }
            else if (_regex.CharRegex.IsMatch(text))
            {
                cns.Type = Enums.Type.Char;
            }
        }

        #endregion

    }
}