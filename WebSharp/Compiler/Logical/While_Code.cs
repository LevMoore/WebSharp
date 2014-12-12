using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Sharp
{
    class While_Code : BaseCode
    {
        public While_Code()
        {
            name = "while";
            highlight = "while";
        }

        public override bool Run()
        {
            if (NextToken() == "(")
            {
                AddCodeOnNewLine("while(");

                ignoreSemicolon = true;
                if (!StopOnSymbol(")"))
                {
                    return false;
                }
                ignoreSemicolon = false;
                AddCode(")");

                if (NextToken() == "{")
                {
                    AddCodeOnNewLine("{");
                    tap++;
                }
                else
                {
                    return false;
                }

                bool _again2 = true;
                while (_again2)
                {
                    //check for methods tokens
                    string _token = NextToken();
                    if (_token == "")
                    {
                        return false;
                    }

                    short _check = CheckForMethodsToken(_token);
                    if (_check == 1)//return error
                    {
                        return false;
                    }
                    else if (_check == 2)
                    {
                        _check = CheckForLogicalsToken(_token);
                        if (_check == 1)//return error
                        {
                            return false;
                        }
                    }

                    //end
                    if (_token == "}")
                    {
                        tap--;
                        AddCodeOnNewLine("}");
                        _again2 = false;
                    }
                }
            }
            return true;
        }
    }
}
