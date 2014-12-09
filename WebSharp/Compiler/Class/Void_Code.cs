using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            if (NextToken() == "(" && NextToken() == ")" && NextToken() == "{")
            {
                if (_name == "Start")
                {
                    AddCodeOnNewLine("window.onload = function ()");
                }
                else
                {
                    AddCodeOnNewLine("function " + _name + "()");
                }
                AddCodeOnNewLine("{");

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
                    else if(_check == 2)
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
