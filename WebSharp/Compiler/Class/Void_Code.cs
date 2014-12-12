using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Web_Sharp
{
    class Void_Code : BaseCode
    {
        public Void_Code()
        {
            name = "void";
            autoComplete = new List<string>() {};
            highlight = "void";
        }

        public override bool Run()
        {
            string _name = NextToken();
            if (NextToken() == "(")
            {
                if (_name == "Start")
                {
                    AddCodeOnNewLine("window.onload = function ()");
                }
                else
                {
                    AddCodeOnNewLine("function " + _name + "(");
                    ignoreSemicolon = true;
                    if (!StopOnSymbol(")"))
                    {
                        return false;
                    }
                    ignoreSemicolon = false;
                    AddCode(")");
                }
                AddCodeOnNewLine("{");
                tap++;

                bool _again = true;
                while (_again)
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
                        else if (_check == 2)
                        {
                            _check = CheckForDataTypeToken(_token);
                            if (_check == 1)//return error
                            {
                                return false;
                            }
                        }
                    }


                    //end
                    if (_token == "}")
                    {
                        tap--;
                        AddCodeOnNewLine("}");
                        _again = false;
                    }
                }
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
