using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GlobalLibrary
{
    public class RegexPatterns
    {
        public RegexPatterns()
        {
            InitRegex();
        }

        #region RegexPatterns

        public Regex AccessModifier { get; private set; }
        public Regex IsStatic { get; private set; }
        public Regex DataType { get; private set; }


        public Regex DoubleRgex { get; set; }
        public Regex IntRegex { get; set; }
        public Regex NumberRegex { get; private set; }
        public Regex StringRegex { get; private set; }
        public Regex BoolValue { get; private set; }
        public Regex ConstantRegex { get; private set; }
        public Regex CharRegex { get; set; }


        public Regex Variable { get; private set; }
        public Regex VarDeclaration { get; private set; }
        public Regex ArrayRegex { get; private set; }
        public Regex ArrayAssignment { get; private set; }
        public Regex InstructionRegex { get; private set; }
        public Regex SingleInstructionRegex { get; private set; }
        public Regex ThreeAddressInstructionRegex { get; private set; }
        public  Regex VarAssignmentRegex { get; private set; }

        public Regex FunctionRegex { get; private set; }
        public Regex ParameterRegex { get; private set; }
        public Regex FunctionCall { get; private set; }
        public Regex FunctionCallAsInst { get; private set; }
        public Regex ArgumentRegex { get; private set; }
        public Regex IfRegex { get; private set; }
        public Regex WhileRegex { get; private set; }
        public Regex Condition { get; private set; }
        public Regex BooleanOperator { get; private set; }
        public Regex OperatorRegex { get; private set; }
        public Regex Array { get; private set; }

        private void InitRegex()
        {
            AccessModifier = new Regex("([p][u][b][l][i][c])|([p][r][i][v][a][t][e])|([p][r][o][t][e][c][t][e][d])");
            IsStatic = new Regex("[s][t][a][t][i][c]");


            IntRegex = new Regex("[0-9]+");
            DoubleRgex = new Regex("[0-9]+([.][0-9]+)");
            NumberRegex = new Regex("("+IntRegex+")|("+DoubleRgex+")");
            StringRegex = new Regex("([\"]([\\w]*[\\W]*)*[\"])");
            BoolValue = new Regex("(([t][r][u][e])|([f][a][l][s][e]))");
            CharRegex = new Regex("['][\\w][\']");
            ConstantRegex = new Regex("(" + NumberRegex + "|" + StringRegex + "|" + BoolValue + ")");


            OperatorRegex = new Regex("([+])|([-])|([*])|([/])");
            Variable = new Regex("([a-z|A-Z|_][a-z|A-Z|0-9]*)");
            DataType = new Regex("([v][o][i][d])|([c][h][a][r])|([i][n][t])|([f][l][o][a][t])|([d][o][u][b][l][e])|([s][t][r][i][n][g])|([b][o][o][l])");
            BooleanOperator = new Regex("([<][=]|[>][=]|([<])|([>])|([=][=]))");
            Array = new Regex(Variable+"[\\s]*[\\[]((" + Variable + ")|(" + NumberRegex + "))[\\]]([\\s]*[\\[]((" + Variable + ")|(" + NumberRegex + "))?[\\]])?");
            ArgumentRegex = new Regex("[\\s]*[(][\\s]*(((" + Variable + ")|(" + ConstantRegex + "))[\\s]*([,][\\s]*((" + Variable + ")|(" + ConstantRegex + "))[\\s]*)*)?[\\s]*[)]");
            FunctionCallAsInst = new Regex("" + Variable + ArgumentRegex + "[\\s]*");
            FunctionCall = new Regex("^" + Variable + ArgumentRegex + "[\\s]*([;])?$");


            InstructionRegex = new Regex("((" + Variable + ")|(" + ConstantRegex + ")|(" + FunctionCallAsInst + "))");
            SingleInstructionRegex = new Regex("" + InstructionRegex + "[\\s]*[;]");
            ThreeAddressInstructionRegex = new Regex("[\\s]*("+ InstructionRegex +")[\\s]*("+ OperatorRegex + ")[\\s]*(" + InstructionRegex +")[\\s]*[;]");
           

            VarDeclaration = new Regex("^((" + AccessModifier + ")[\\s]+)?" + "((" + IsStatic + ")[\\s]+)?((" + DataType + ")[\\s]+)" + Variable +"[\\s]*[;]$");
            ArrayRegex = new Regex("^((" + AccessModifier + ")[\\s]+)?" + "((" + IsStatic + ")[\\s]+)?((" + DataType + ")[\\s]+)" + Variable + "[\\s]*[\\[]((" + Variable+")|("+NumberRegex+"))?[\\]]" + "[\\s]*([\\[]((" + Variable + ")|(" + NumberRegex + "))?[\\]])?[;]$");
            ArrayAssignment = new Regex("^" + Variable + "[\\s]*[\\[]((" + Variable + ")|(" + NumberRegex + "))?[\\]]" + "[\\s]*([\\[]((" + Variable + ")|(" + NumberRegex + "))?[\\]])?[\\s]*" + "[=][\\s]*(" + SingleInstructionRegex + ")|(" + ThreeAddressInstructionRegex + ")[\\s]*[;]$");
            VarAssignmentRegex = new Regex("^[\\s]*(" + Variable + ")[\\s]*" + "[=][\\s]*("+SingleInstructionRegex+")|("+ThreeAddressInstructionRegex+")[\\s]*$");

            Condition = new Regex("[(]" + InstructionRegex + "[\\s]*" + BooleanOperator + "[\\s]*" + InstructionRegex + "[)]");
            IfRegex = new Regex("^[i][f][\\s]*" + Condition + "[\\s]*$");
            WhileRegex = new Regex("^[w][h][i][l][e][\\s]*" + Condition + "[\\s]*$");


            ParameterRegex = new Regex("[\\s]*[(][\\s]*(((" + DataType + ")[\\s]+)" + Variable + "[\\s]*([,][\\s]*((" + DataType + ")[\\s]+)" + Variable + "[\\s]*)*)?[)][\\s]*");
            FunctionRegex = new Regex("^((" + AccessModifier + ")[\\s]+)?((" + IsStatic + ")[\\s]+)?((" + DataType + ")[\\s]+)" +
                          Variable + "[\\s]*"+ParameterRegex+"$");
        }


        #endregion


        public bool IsVariable(string data)
        {
            Regex tempVariableRegex = new Regex("^"+Variable+"$");
            return tempVariableRegex.IsMatch(data);
        }


       


    }
}
