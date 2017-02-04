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
        private int _braces = 0;

        public Beautify(string code)
        {
            CodeOutput = "";
            CodeBeautifier(code);

        }
        private void CodeBeautifier(string codeInput)
        {
            foreach (char t in codeInput)
            {
                if (t == ')' || t == ';' || t == '{')
                {
                    CodeOutput += t;
                    CodeOutput += "\n";

                    if (t == '{')
                    {
                        _braces++;
                    }

                    for (int j = 1; j <= _braces; j++)
                    {
                        CodeOutput += "\t";
                    }


                }
                else if (t == '}')
                {
                    _braces--;
                    CodeOutput += "\n";

                    for (int j = 1; j <= _braces; j++)
                    {
                        CodeOutput += "\t";
                    }
                    CodeOutput += t;
                    CodeOutput += "\n";
                    for (int j = 1; j <= _braces; j++)
                    {
                        CodeOutput += "\t";
                    }
                }
                else
                {
                    CodeOutput += t;
                }
            }
        }


    }
}



