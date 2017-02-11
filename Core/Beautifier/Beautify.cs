
namespace Core.Beautifier
{
    public class Beautify
    {
        public string CodeOutput { get; private set; }
        public int braces = 0; //curly brace count

        public Beautify(string code)
        {
            CodeOutput = "";
            CodeBeautifier(code);

        }
        private void CodeBeautifier(string codeInput)
        {
            for (int i = 0; i < codeInput.Length; i++)
            {
                if (codeInput[i] == '(')
                {
                    while (true)
                    {
                        if (codeInput[i] == ')')
                            break;

                        CodeOutput += codeInput[i];
                        i++;
                    }
                }

                if (codeInput[i] == ')' || codeInput[i] == ';' || codeInput[i] == '{')
                {
                    CodeOutput += codeInput[i];
                    CodeOutput += "\n"; //add newline

                    if (codeInput[i] == '{')
                    {
                        braces++; //increase brace count
                    }

                    for (int j = 1; j <= braces; j++)
                    {
                        CodeOutput += "\t"; //add tab space
                    }


                }
                else if (codeInput[i] == '}')
                {
                    braces--; //decrease brace count
                    CodeOutput += "\n"; //add newline

                    for (int j = 1; j <= braces; j++)
                    {
                        CodeOutput += "\t"; //add tab space
                    }

                    CodeOutput += codeInput[i];
                    CodeOutput += "\n"; //add newline

                    for (int j = 1; j <= braces; j++)
                    {
                        CodeOutput += "\t"; //add tab space
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


