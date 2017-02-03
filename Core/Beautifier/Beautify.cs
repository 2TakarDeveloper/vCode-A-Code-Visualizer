using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTD.Entity;
using DTD.Entity.Enum;
using DTD.Entity.Helpers;
using DTD.Entity.vCodes;

namespace Core.Beautifier
{
    public class Beautify
    {
        public string CodeOutput { get; private set; }
        public int braces = 0;

        public Beautify(string code)
        {
            CodeOutput = "";
            CodeBeautifier(code);

        }
        private void CodeBeautifier(string codeInput)
        {
            for (int i = 0; i < codeInput.Length; i++)
            {

                if (codeInput[i] == ')' || codeInput[i] == ';' || codeInput[i] == '{')
                {
                    CodeOutput += codeInput[i];
                    CodeOutput += "\n";

                    if (codeInput[i] == '{')
                    {
                        braces++;
                    }

                    for (int j = 1; j <= braces; j++)
                    {
                        CodeOutput += "\t";
                    }


                }
                else if (codeInput[i] == '}')
                {
                    braces--;
                    CodeOutput += "\n";

                    for (int j = 1; j <= braces; j++)
                    {
                        CodeOutput += "\t";
                    }
                    CodeOutput += codeInput[i];
                    CodeOutput += "\n";
                    for (int j = 1; j <= braces; j++)
                    {
                        CodeOutput += "\t";
                    }
                }
                else
                {
                    CodeOutput += codeInput[i];
                }
            }
        }


    }
}



