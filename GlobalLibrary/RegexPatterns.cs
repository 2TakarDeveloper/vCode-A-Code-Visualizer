using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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

        public Regex NumberRegex { get; private set; }
        public Regex StringRegex { get; private set; }
        public Regex BoolValue { get; private set; }
        public Regex ConstantRegex { get; private set; }


        public Regex Variable { get; private set; }
        public Regex VarDeclaration { get; private set; }
        public Regex ArrayRegex { get; private set; }
        public Regex SingleInstructionRegex { get; private set; }
        public Regex ThreeAddressInstructionRegex { get; private set; }
        public  Regex VarAssignmentRegex { get; private set; }

        public Regex FunctionRegex { get; private set; }
        public Regex ParameterRegex { get; private set; }
        public Regex FunctionCall { get; private set; }
        public Regex ParameterValueRegex { get; private set; }
        public Regex IfRegex { get; private set; }
        public Regex WhileRegex { get; private set; }
        public Regex Condition { get; private set; }
        public Regex BooleanOperator { get; private set; }
        public Regex OperatorRegex { get; private set; }

        private void InitRegex()
        {
            AccessModifier = new Regex("([p][u][b][l][i][c])|([p][r][i][v][a][t][e])|([p][r][o][t][e][c][t][e][d])");
            IsStatic = new Regex("[s][t][a][t][i][c]");

            NumberRegex = new Regex("([+]|[-])?[0-9]+([.][0-9]+)?");
            StringRegex = new Regex("([\"]([\\w]*[\\W]*)*[\"])");
            BoolValue = new Regex("(([t][r][u][e])|([f][a][l][s][e]))");
            ConstantRegex = new Regex("(" + NumberRegex + "|" + StringRegex + "|" + BoolValue + ")");
            OperatorRegex = new Regex("([+])|[-]|[*]|[/]");
            Variable = new Regex("([a-z|A-Z|_][a-z|A-Z|0-9]*)");
            DataType = new Regex("([i][n][t])|([f][l][o][a][t])|([d][o][u][b][l][e])|([s][t][r][i][n][g])|([b][o][o][l])");
            BooleanOperator = new Regex("([<][=]|[>][=]|([<])|([>])|([=][=]))");


            SingleInstructionRegex = new Regex("(" + Variable + ")|(" + ConstantRegex + ")");
            ThreeAddressInstructionRegex = new Regex(SingleInstructionRegex +"[\\s]*"+ OperatorRegex + "[\\s]*" + SingleInstructionRegex);
            


            VarDeclaration = new Regex("^((" + AccessModifier + ")[\\s]+)?" + "((" + IsStatic + ")[\\s]+)?((" + DataType + ")[\\s]+)" + Variable +"[\\s]*[;]$");
            ArrayRegex = new Regex("^((" + AccessModifier + ")[\\s]+)?" + "((" + IsStatic + ")[\\s]+)?((" + DataType + ")[\\s]+)" + Variable + "[\\s]*[\\[]((" + Variable+")|("+NumberRegex+"))?[\\]]" + "[\\s]*([\\[]((" + Variable + ")|(" + NumberRegex + "))?[\\]])?[;]$");
            VarAssignmentRegex = new Regex("^(" + Variable + ")[\\s]*" + "[=][\\s]*("+SingleInstructionRegex+")|("+ThreeAddressInstructionRegex+")[\\s]*[;]$");

            Condition = new Regex("[(]" + SingleInstructionRegex + "[\\s]*" + BooleanOperator + "[\\s]*" + SingleInstructionRegex + "[)]");
            IfRegex = new Regex("^[i][f][\\s]*" + Condition + "[\\s]*$");
            WhileRegex = new Regex("[w][h][i][l][e][\\s]*" + Condition + "[\\s]*");
            


            ParameterValueRegex = new Regex("[\\s]*[(][\\s]*((" + SingleInstructionRegex + ")[\\s]*([,][\\s]*(" + SingleInstructionRegex + ")[\\s]*)*)?[\\s]*[)]");
            FunctionCall = new Regex("^"+Variable+ParameterValueRegex+"[\\s]*[;]$");


            ParameterRegex = new Regex("[\\s]*[(][\\s]*(((" + DataType + ")[\\s]+)" + Variable + "[\\s]*([,][\\s]*((" + DataType + ")[\\s]+)" + Variable + "[\\s]*)*)?[)][\\s]*");
            FunctionRegex = new Regex("^((" + AccessModifier + ")[\\s]+)?((" + IsStatic + ")[\\s]+)?((" + DataType + ")[\\s]+)" +
                          Variable + "[\\s]*"+ParameterRegex+"$");
        }

        #endregion

    }
}