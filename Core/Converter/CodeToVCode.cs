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
        private string _code;
        public CodeToVCode(string code)
        {
            _code = code;
            //Call Function here.
            Scope = new Scope();
            Scope.Items = GetQueueOfFuncAndVars(code);

        }

        #region RegexPatterns

        private static readonly Regex AccessModifier = new Regex("([p][u][b][l][i][c])|([p][r][i][v][a][t][e])|[p][r][o][t][e][c][t][e][d]");
        private static readonly Regex IsStatic = new Regex("[s][t][a][t][i][c]");
        private static readonly Regex NumberRegex = new Regex("([+]|[-])?[0-9]+([.][0-9]+)?");
        private static readonly Regex StringRegex = new Regex("([\\w]*[\\W]*)*");

        private static readonly Regex dataType =
            new Regex("([i][n][t])|([f][l][o][a][t])|([d][o][u][b][l][e])|([s][t][r][i][n][g])|([b][o][o][l])");

        private static readonly Regex variable = new Regex("[a-z|A-Z|_][a-z|A-Z|0-9]*");

        private static readonly Regex VarDeclaration =
            new Regex("^(" + AccessModifier + ")?[\\s]+" + "(" + IsStatic + ")?[\\s]+" + dataType + "[\\s]+" + variable +
                      "[\\s]*([=][\\s]*((" + NumberRegex + ")|([\"]" + StringRegex + "[\"])))?[\\s]*[;]$");

        private static readonly Regex Condition =
            new Regex("[(]" + variable + "[\\s]*([<]|[>]|[<][=]|[>][=]|[=][=])[\\s]*" + variable + "[)]");


        private static readonly Regex FunctionCall =
            new Regex("^[(][\\s]*(" + variable + "([,]" + variable + ")*)?" + "[\\s]*[)][;]$");

        private static readonly Regex IfRegex = new Regex("^[i][f][\\s]*" + Condition + "[\\s]*$");
        private static readonly Regex WhileRegex = new Regex("^[w][h][i][l][e][\\s]*" + Condition + "[\\s]*$");

        private static readonly Regex FunctionRegex =
            new Regex("((" + AccessModifier + ")?[\\s]+)?" + "((" + IsStatic + ")?[\\s]+" + dataType + "[\\s]+)?" +
                      variable + "[\\s]*[(](" + dataType + "[\\s]+" + variable + "[\\s]*([,][\\s]*" + dataType +
                      "[\\s]+" + variable + "[\\s]*)*)?[)][\\s]*");

        private static Regex scope =
            new Regex("^[{][\\s]*([\\s]*((" + VarDeclaration + ")|(" + FunctionCall + ")|(" + IfRegex + ")|(" + WhileRegex + ")))*[\\s]*[}]$");

        #endregion

        #region LexicalAnalyzer



        private bool IsMatchPattern(string selectedText)
        {
            if (IfRegex.IsMatch(selectedText) ||
                WhileRegex.IsMatch(selectedText) ||
                FunctionCall.IsMatch(selectedText) ||
                VarDeclaration.IsMatch(selectedText))
            { return true; }
            return false;
        }

        private Condition GetConditionObject(string selectedText)
        {
            Condition condition = new Condition();
            Match m = Regex.Match(selectedText, condition.ToString());
            string conditionText = m.Groups[1].Value;
            m = Regex.Match(conditionText, variable.ToString());

            return condition;
        }

        private Scope GenerateScopeObject(string currentScope)
        {
            Scope scope = new Scope();
            Stack<char> stack = new Stack<char>();
            Queue<VCode> items = new Queue<VCode>();

            bool scopeStarted = false, ifType = false, whileType = false;
            If If = new If();
            While While = new While();

            int start = 1, end = 1;
            string selectedText = "" + currentScope[start];

            while (end < currentScope.Length - 1)
            {
                if (scopeStarted)
                {
                    if (end < currentScope.Length - 1)
                    {
                        end++;
                        selectedText += currentScope[end];
                    }
                    if (currentScope[end] == '{')
                    {
                        stack.Push('{');
                    }
                    else if (currentScope[end] == '}')
                    {
                        stack.Pop();
                    }

                    if (stack.Count == 0)
                    {
                        if (ifType)
                        {
                            If.Scope = GenerateScopeObject(selectedText);

                            if (end < currentScope.Length - 1)
                            {
                                start = ++end;
                                selectedText = "" + currentScope[start];
                            }
                            items.Enqueue(If);
                            ifType = false;
                        }
                        else if (whileType)
                        {
                            While.Scope = GenerateScopeObject(selectedText);
                            if (end < currentScope.Length - 1)
                            {
                                start = ++end;
                                selectedText = "" + currentScope[start];
                            }
                            items.Enqueue(While);
                            whileType = false;
                        }
                        scopeStarted = false;
                    }
                }
                else if (selectedText == "{")
                {
                    scopeStarted = true;
                    stack.Push('{');
                }
                else if (Regex.IsMatch(selectedText, "^[\\s]*$"))
                {
                    start = ++end;
                    selectedText = "" + currentScope[start];
                }
                else if (IsMatchPattern(selectedText))
                {
                    if (IfRegex.IsMatch(selectedText))
                    {
                        If = new If();
                        ifType = true;
                        Match m = Regex.Match("Some Variable here", Condition.ToString());
                        If.Condition = GetConditionObject(m.Groups[0].Value);
                    }
                    else if (WhileRegex.IsMatch(selectedText))
                    {
                        While = new While();
                        whileType = true;
                        Match m = Regex.Match("Some Variable here", Condition.ToString());
                        While.Condition = GetConditionObject(m.Groups[0].Value);
                    }
                    start = ++end;
                    selectedText = "" + currentScope[start];
                }
                else
                {
                    if (end < currentScope.Length - 1)
                    {
                        end++;
                        selectedText += currentScope[end];
                    }
                }
            }
            scope.Items = items;
            return scope;
        }



        //will return function object globaly declared
        private Function GetFunction(string function)
        {
            Function Function = new Function();

            //check for access modifier
            if (AccessModifier.IsMatch(function))
            {
                string[] accessModifier = Regex.Split(function, CodeToVCode.AccessModifier.ToString());
                if (accessModifier[0] == "public")
                {
                    Function.AccessModifier = Enums.AccessModifier.Public;
                }
                else if (accessModifier[0] == "private")
                {
                    Function.AccessModifier = Enums.AccessModifier.Private;
                }
                else if (accessModifier[0] == "protected")
                {
                    Function.AccessModifier = Enums.AccessModifier.Protected;
                }
                CodeToVCode.AccessModifier.Replace(function, "");
                function.Trim();
            }
            //check for static
            if (IsStatic.IsMatch(function))
            {
                string[] Static = Regex.Split(function, IsStatic.ToString());
                Function.IsStatic = true;
                IsStatic.Replace(function, "");
                function.Trim();
            }
            //check for data type
            if (dataType.IsMatch(function))
            {
                Match m = variable.Match(function);
                string dataType = m.Groups[0].ToString();
                if (dataType == "int")
                {
                    Function.Type = Enums.Type.Int;
                }
                else if (dataType == "float")
                {
                    Function.Type = Enums.Type.Double;
                }
                else if (dataType == "double")
                {
                    Function.Type = Enums.Type.Double;
                }
                else if (dataType == "string")
                {
                    Function.Type = Enums.Type.String;
                }
                else if (dataType == "bool")
                {
                    Function.Type = Enums.Type.Bool;
                }
                function = dataType.Replace(function, "");
                function.Trim();
            }
            //check for condition
            if (variable.IsMatch(function))
            {
                Match m = variable.Match(function);
                Function.Name = m.Groups[0].ToString();
            }
            return Function;
        }











        private Queue<VCode> GetQueueOfFuncAndVars(string userInput)
        {
            bool scopeStarted = false;
            Stack<char> Stack = new Stack<char>();
            Queue<VCode> queue = new Queue<VCode>();
            Function Function = new Function();

            int start = 0, end = 0;
            string selectedText = "" + userInput[start];
            while (end < userInput.Length - 1)
            {
                end++;
                if (FunctionRegex.IsMatch(userInput.Substring(start, end - start)))
                {
                    Function = GetFunction(userInput.Substring(start, end - start));
                    start = end;

                }
                if (userInput[start] == ' ')
                {
                    start++;
                    end = start;
                }
                else
                {
                    if (userInput[end] == '{')
                    {
                        scopeStarted = true;
                        Stack.Push('{');
                    }
                    else if (userInput[end] == '}')
                    {
                        Stack.Pop();
                    }
                }
                if (scopeStarted && Stack.Count == 0)
                {
                    Function.Scope = GenerateScopeObject(userInput.Substring(start, end - start));
                    scopeStarted = false;
                    start = end;
                    queue.Enqueue(Function);
                }
            }

            return queue;
        }

        #endregion



    }
}
