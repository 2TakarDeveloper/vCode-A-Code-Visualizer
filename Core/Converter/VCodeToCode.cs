
using DTD.Entity;
using DTD.Entity.Enum;
using DTD.Entity.Helpers;
using DTD.Entity.vCodes;

namespace Core.Converter
{
    public  class VCodeToCode
    {
        public string Code { get; private set; }

        public VCodeToCode(VCode vcode)
        {
            Code = "";
            VCodeToString(vcode);
            
        }

        private void VariableToCode(Variable variable)
        {
         
            //Code += variable.AccessModifier.ToString().ToLower()+" ";
            Code += variable.Type.ToString().ToLower()+" ";
            Code += variable.Name+" ";
           
            if (variable.IsArray)
            {

                Code += "[" + variable.Row + "]";
                switch (variable.ArrayType)
                {
                   
                    case "2D":
                        Code += "[" + variable.Column + "]";
                        break;
                }

            

            }
            else
            {
                //Code += variable.Value[0, 0].ToString();
            }

          


            Code += ";";
        }

        private void VCodeToString(VCode vcode)
        {
            switch (vcode.VType)
            {
                case Enums.VType.GlobalScope:
                    var globalScope = (GlobalScope)vcode;
                    GlobalScopeToCode(globalScope.Scope);
                    break;
                case Enums.VType.Variable:
                    Variable variable = (Variable) vcode;
                    VariableToCode(variable);
                    break;
                case Enums.VType.If:
                    var If = (If) vcode;
                    Code += "if";
                    ConditionToCode(If.Condition);
                    ScopeToCode(If.Scope);
                    break;
                case Enums.VType.While:
                    var wWhile = (While) vcode;
                    Code += "while";
                    ConditionToCode(wWhile.Condition);
                    ScopeToCode(wWhile.Scope);
                    break;

                case Enums.VType.Assignment:
                    var assignment = (Assignment) vcode;
                    AssignmentToCode(assignment);
                    break;
                case Enums.VType.Function:
                    var function = (Function) vcode;
                    //Code += function.AccessModifier.ToString().ToLower() + " ";
                    if(function.IsBody)
                    Code += function.Type.ToString().ToLower() + " ";

                    Code += function.Name;
                    Code += "(";
                    string parameter = "";

                    if (function.Parameters.Count > 0)
                    {
                        foreach (Parameter p in function.Parameters)
                        {
                            parameter += p.Type + " " + p.Name + ",";
                        }
                        parameter =parameter.Remove(parameter.Length-1);
                    }


                    Code += parameter;
                    Code += ")";


                    if (function.IsBody)
                    {
                        ScopeToCode(function.Scope);
                    }
                    else
                    {
                        Code +=";";
                    }
                    break;
            }
        }

        private  void ScopeToCode(Scope scope)
        {
            
            Code += "{";
            foreach (VCode item in scope.Items)
            {
                VCodeToString(item);
               
            }
            Code += "}";

        }

        private void GlobalScopeToCode(Scope scope)
        {

            foreach (VCode item in scope.Items)
            {
                VCodeToString(item);
            }
          
        }

        private  void ConditionToCode(Condition condition)
        {
            Code += "(";
            Code += condition.LeftParameter;
            Code += condition.BooleanOperator;
            Code += condition.RightParameter;
            Code += ")";
        }


        private void AssignmentToCode(Assignment assignment)
        {
            Code += assignment.AssignmentString;
        }


    }
}
