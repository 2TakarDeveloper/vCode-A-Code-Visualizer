using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DTD.Entity;
using DTD.Entity.Enum;
using DTD.Entity.Helpers;
using DTD.Entity.vCodes;

namespace Core.Converter
{
    public class CodeToVCode
    {
        public Scope Scope { get; set; }
  
        public CodeToVCode(string code)
        {
            initRegex();
            //Call Function here.
            Scope = new Scope();
            code = Regex.Replace(code, @"\t|\n", "");
            createScopeObject(Scope,'{'+code.Trim()+'}');
        }

        #region RegexPatterns

        private Regex AccessModifier, IsStatic, dataType;
        private Regex NumberRegex, StringRegex, boolValue;
        private Regex variable, VarDeclaration, FunctionRegex, FunctionCall;
        private Regex IfRegex, WhileRegex, Condition, booleanOperator;

        private void initRegex()
        {
            AccessModifier = new Regex("([p][u][b][l][i][c])|([p][r][i][v][a][t][e])|[p][r][o][t][e][c][t][e][d]");
            IsStatic = new Regex("[s][t][a][t][i][c]");
            NumberRegex = new Regex("([+]|[-])?[0-9]+([.][0-9]+)?");
            StringRegex = new Regex("([\\w]*[\\W]*)*");
            boolValue = new Regex("([t][r][u][e])|[f][a][l][s][e]");

            dataType = new Regex("([i][n][t])|([f][l][o][a][t])|([d][o][u][b][l][e])|([s][t][r][i][n][g])|([b][o][o][l])");

            variable = new Regex("[a-z|A-Z|_][a-z|A-Z|0-9]*");

            VarDeclaration = new Regex("^(" + AccessModifier + ")?[\\s]+" + "(" + IsStatic + ")?[\\s]+" + dataType + "[\\s]+" + variable +
                          "[\\s]*([=][\\s]*((" + NumberRegex + ")|([\"]" + StringRegex + "[\"])))?[\\s]*[;]$");

            booleanOperator = new Regex("([<]|[>]|[<][=]|[>][=]|[=][=])");
            Condition = new Regex("[(]" + variable + "[\\s]*"+ booleanOperator + "[\\s]*" + variable + "[)]");


            FunctionCall = new Regex("^[(][\\s]*(" + variable + "([,]" + variable + ")*)?" + "[\\s]*[)][;]$");

            IfRegex = new Regex("^[i][f][\\s]*" + Condition + "[\\s]*$");
            WhileRegex = new Regex("^[w][h][i][l][e][\\s]*" + Condition + "[\\s]*$");

            FunctionRegex = new Regex("((" + AccessModifier + ")?[\\s]+)?" + "((" + IsStatic + ")?[\\s]+" + dataType + "[\\s]+)?" +
                          variable + "[\\s]*[(](" + dataType + "[\\s]+" + variable + "[\\s]*([,][\\s]*" + dataType +
                          "[\\s]+" + variable + "[\\s]*)*)?[)][\\s]*");

        }

        #endregion

        #region LexicalAnalyzer

        private bool isVCode(string selectedText)
        {
            if (IfRegex.IsMatch(selectedText) ||
                WhileRegex.IsMatch(selectedText) ||
                FunctionCall.IsMatch(selectedText) ||
                VarDeclaration.IsMatch(selectedText)||
                FunctionRegex.IsMatch(selectedText))
            { return true; }
            return false;
        }

        private void createConditionObject(Condition condition,string text)
        {
            Match op = booleanOperator.Match(text);
            condition.BooleanOperator = op.Groups[0].ToString();

            Match param = variable.Match(text);
            condition.LeftParameter = op.Groups[0].ToString();
            condition.RightParameter = op.Groups[1].ToString();
        }

        private int cropScope(Scope scope, int start, string text)
        {
            Stack<char> stack = new Stack<char>();
            int end = start;
            while(text[start] != '{')
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
            createScopeObject(scope,text.Substring(start, end - start +1));
            return ++end;
        }

        private void createScopeObject(Scope scope, string currentScope)
        {
            int start = 1, end = 1;
            while (end < currentScope.Length - 1)
            {
                string selectedText = currentScope.Substring(start, end - start + 1);
                if (isVCode(selectedText))
                {
                    if(FunctionRegex.IsMatch(selectedText))
                    {
                        Function funcObject = new Function();
                        scope.Items.Enqueue(funcObject);
                        createFunctionObject(funcObject, selectedText);
                        start = ++end;
                        start = end = cropScope(funcObject.Scope, start, currentScope);
                    }
                    else if (VarDeclaration.IsMatch(selectedText))
                    {
                        createVariableObject(scope, selectedText);
                        start = ++end;
                    }
                    else if (IfRegex.IsMatch(selectedText))
                    {
                        If ifObject = new If();
                        scope.Items.Enqueue(ifObject);
                        createConditionObject(ifObject.Condition, selectedText);
                        start = ++end;
                        start = end = cropScope(ifObject.Scope, start, currentScope);
                    }
                    else if (WhileRegex.IsMatch(selectedText))
                    {
                        While whileObject = new While();
                        scope.Items.Enqueue(whileObject);
                        createConditionObject(whileObject.Condition, selectedText);
                        start = ++end;
                        start = end = cropScope(whileObject.Scope, start, currentScope);
                    }
                    else if(currentScope[start] == ' ')
                    {
                        start = ++end;
                    }
                    else if (selectedText == "\n")
                    {
                        start = ++end;
                    }
                }
                else
                {
                    end++;
                }
            }
        }
        
        //will return function object globaly declared
        private void createFunctionObject(Function funcObject,string text)
        {
            #region Variable DataType
            if (dataType.IsMatch(text))
            {
                Match m = dataType.Match(text);
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
                dataType.Replace(text, "");
            }
            #endregion

            #region Variable AccessModifier
            if (AccessModifier.IsMatch(text))
            {
                Match m = AccessModifier.Match(text);

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
                AccessModifier.Replace(text, "");
            }
            #endregion

            if (IsStatic.IsMatch(text))
            {
                funcObject.IsStatic = true;
                IsStatic.Replace(text, "");
            }

            if (variable.IsMatch(text))
            {
                if (variable.IsMatch(text))
                {
                    Match m = variable.Match(text);
                    funcObject.Name = m.Groups[0].ToString();
                }
            }
        }

        private void createVariableObject(Scope scope, string text)
        {
            dynamic varObject = new Variable<int>();

            #region Variable DataType
            if (dataType.IsMatch(text))
            {
                Match m = dataType.Match(text), mv;
                switch(m.Groups[0].ToString())
                {
                    case "bool":
                        varObject = new Variable<bool>();

                        mv = boolValue.Match(text);
                        varObject.Value = Convert.ToBoolean(m.Groups[0].ToString());

                        break;

                    case "int":
                        varObject = new Variable<int>();

                        mv = NumberRegex.Match(text);
                        varObject.Value = Convert.ToInt32(m.Groups[0].ToString());

                        break;

                    case "float":
                        varObject = new Variable<float>();

                        mv = NumberRegex.Match(text);
                        varObject.Value = Convert.ToSingle(m.Groups[0].ToString());

                        break;

                    case "double":
                        varObject = new Variable<double>();

                        mv = NumberRegex.Match(text);
                        varObject.Value = Convert.ToDouble(m.Groups[0].ToString());

                        break;

                    case "string":
                        varObject = new Variable<string>();
                        break;
                }
                dataType.Replace(text,"");
            }
            #endregion

            #region Variable AccessModifier
            if (AccessModifier.IsMatch(text))
            {
                Match m = AccessModifier.Match(text);

                switch(m.Groups[0].ToString())
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
                AccessModifier.Replace(text, "");
            }
            #endregion

            if (IsStatic.IsMatch(text))
            {
                varObject.IsStatic = true;
                IsStatic.Replace(text, "");
            }

            if(variable.IsMatch(text))
            {
                if(variable.IsMatch(text))
                {
                    Match m = variable.Match(text);
                    varObject.Name = m.Groups[0].ToString();
                }
            }

            scope.Items.Enqueue(varObject);
        }
                
        #endregion



    }
}
