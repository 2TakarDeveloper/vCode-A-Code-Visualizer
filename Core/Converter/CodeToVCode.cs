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
            InitRegex();
            
            Scope = new Scope();
            code = Regex.Replace(code, @"\t|\n", "");
            CreateScopeObject(Scope,'{'+code.Trim()+'}');
        }

        #region RegexPatterns

        private Regex _accessModifierRegex, _isStatic, _dataType;
        private Regex _numberRegex, _stringRegex, _boolValue;
        private Regex _variableRegex, _varDeclaration, _functionRegex, _functionCall;
        private Regex _ifRegex, _whileRegex, _condition, _booleanOperator;

        private void InitRegex()
        {
            _accessModifierRegex = new Regex("([p][u][b][l][i][c])|([p][r][i][v][a][t][e])|[p][r][o][t][e][c][t][e][d]");
            _isStatic = new Regex("[s][t][a][t][i][c]");
            _numberRegex = new Regex("([+]|[-])?[0-9]+([.][0-9]+)?");
            _stringRegex = new Regex("([\\w]*[\\W]*)*");
            _boolValue = new Regex("([t][r][u][e])|[f][a][l][s][e]");

            _dataType = new Regex("([i][n][t])|([f][l][o][a][t])|([d][o][u][b][l][e])|([s][t][r][i][n][g])|([b][o][o][l])");

            _variableRegex = new Regex("[a-z|A-Z|_][a-z|A-Z|0-9]*");

            _varDeclaration = new Regex("^(" + _accessModifierRegex + ")?[\\s]+" + "(" + _isStatic + ")?[\\s]+" + _dataType + "[\\s]+" + _variableRegex +
                          "[\\s]*([=][\\s]*((" + _numberRegex + ")|([\"]" + _stringRegex + "[\"])))?[\\s]*[;]$");

            _booleanOperator = new Regex("([<]|[>]|[<][=]|[>][=]|[=][=])");
            _condition = new Regex("[(]" + _variableRegex + "[\\s]*"+ _booleanOperator + "[\\s]*" + _variableRegex + "[)]");


            _functionCall = new Regex("^[(][\\s]*(" + _variableRegex + "([,]" + _variableRegex + ")*)?" + "[\\s]*[)][;]$");

            _ifRegex = new Regex("^[i][f][\\s]*" + _condition + "[\\s]*$");
            _whileRegex = new Regex("^[w][h][i][l][e][\\s]*" + _condition + "[\\s]*$");

            _functionRegex = new Regex("((" + _accessModifierRegex + ")?[\\s]+)?" + "((" + _isStatic + ")?[\\s]+" + _dataType + "[\\s]+)?" +
                          _variableRegex + "[\\s]*[(](" + _dataType + "[\\s]+" + _variableRegex + "[\\s]*([,][\\s]*" + _dataType +
                          "[\\s]+" + _variableRegex + "[\\s]*)*)?[)][\\s]*");

        }

        #endregion

        #region LexicalAnalyzer
        

        private void CreateConditionObject(Condition condition,string text)
        {
            Match op = _booleanOperator.Match(text);
            condition.BooleanOperator = op.Groups[0].ToString();

            Match param = _variableRegex.Match(text);
            condition.LeftParameter = op.Groups[0].ToString();
            condition.RightParameter = op.Groups[1].ToString();
        }

        private int CropScope(Scope scope, int start, string text)
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
                switch (text[end])
                {
                    case '{':
                        stack.Push('{');
                        break;
                    case '}':
                        stack.Pop();
                        break;
                }
            }
            CreateScopeObject(scope,text.Substring(start, end - start +1));
            return ++end;
        }

        private void CreateScopeObject(Scope scope, string currentScope)
        {
            int start = 1, end = 1;
            while (end < currentScope.Length - 1)
            {
                string selectedText = currentScope.Substring(start, end - start + 1);

                #region Parse Code

                if (_functionRegex.IsMatch(selectedText))
                {
                    var funcObject = new Function();
                    scope.Items.Enqueue(funcObject);
                    CreateFunctionObject(funcObject, selectedText);
                    start = ++end;
                    start = end = CropScope(funcObject.Scope, start, currentScope);
                }
                else if (_varDeclaration.IsMatch(selectedText))
                {
                    CreateVariableObject(scope, selectedText);
                    start = ++end;
                }
                else if (_ifRegex.IsMatch(selectedText))
                {
                    var ifObject = new If();
                    scope.Items.Enqueue(ifObject);
                    CreateConditionObject(ifObject.Condition, selectedText);
                    start = ++end;
                    start = end = CropScope(ifObject.Scope, start, currentScope);
                }
                else if (_whileRegex.IsMatch(selectedText))
                {
                    var whileObject = new While();
                    scope.Items.Enqueue(whileObject);
                    CreateConditionObject(whileObject.Condition, selectedText);
                    start = ++end;
                    start = end = CropScope(whileObject.Scope, start, currentScope);
                }
                else if (currentScope[start] == ' ')        //Ensures that start variable is not pointing at space
                {
                    start = ++end;
                }
                else
                {
                    end++;
                }


                #endregion



            }
        }
        
        //will return function object globaly declared
        private void CreateFunctionObject(Function funcObject,string text)
        {
            #region Function ReturnType
            if (_dataType.IsMatch(text))
            {
                Match m = _dataType.Match(text);
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
                _dataType.Replace(text, "");
            }
            #endregion

            #region Function AccessModifierRegex
            if (_accessModifierRegex.IsMatch(text))
            {
                Match m = _accessModifierRegex.Match(text);

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
                _accessModifierRegex.Replace(text, "");
            }
            #endregion

            if (_isStatic.IsMatch(text))
            {
                funcObject.IsStatic = true;
                _isStatic.Replace(text, "");
            }

            if (_variableRegex.IsMatch(text))
            {
                if (_variableRegex.IsMatch(text))
                {
                    Match m = _variableRegex.Match(text);
                    funcObject.Name = m.Groups[0].ToString();
                }
            }
        }

        private void CreateVariableObject(Scope scope, string text)
        {
            Variable variable = new Variable();

            #region Variable DataType
            if (_dataType.IsMatch(text))
            {
                Match m = _dataType.Match(text);

                switch (m.Groups[0].ToString())
                {
                    case "bool":
                        variable.Type = Enums.Type.Bool;
                        break;

                    case "int":
                        variable.Type = Enums.Type.Int;
                        break;

                    case "float":
                        variable.Type = Enums.Type.Float;
                        break;

                    case "double":
                        variable.Type = Enums.Type.Double;
                        break;

                    case "string":
                        variable.Type = Enums.Type.String;
                        break;
                }
                _dataType.Replace(text,"");
            }
            #endregion

            #region Variable AccessModifierRegex
            if (_accessModifierRegex.IsMatch(text))
            {
                Match m = _accessModifierRegex.Match(text);

                switch(m.Groups[0].ToString())
                {
                    case "public":
                        variable.AccessModifier = Enums.AccessModifier.Public;
                        break;
                    case "private":
                        variable.AccessModifier = Enums.AccessModifier.Private;
                        break;
                    case "protected":
                        variable.AccessModifier = Enums.AccessModifier.Protected;
                        break;
                }
                _accessModifierRegex.Replace(text, "");
            }
            #endregion

            if (_isStatic.IsMatch(text))
            {
                variable.IsStatic = true;
                _isStatic.Replace(text, "");
            }

            if(_variableRegex.IsMatch(text))
            {
                if(_variableRegex.IsMatch(text))
                {
                    Match m = _variableRegex.Match(text);
                    variable.Name = m.Groups[0].ToString();
                }
            }

            scope.Items.Enqueue(variable);
        }
                
        #endregion



    }
}
