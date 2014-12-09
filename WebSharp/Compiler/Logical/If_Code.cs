using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Sharp
{
    class If_Code : BaseCode
    {
        public If_Code()
        {
            name = "if";
            highlight = "if";
        }

        public override bool Run()
        {
            if (NextToken() == "(")
            {
                AddCodeOnNewLine("if(");

                int _open = 0;
                bool _again = true;
                while (_again)
                {
                    string _token = NextToken();
                    if (_token == "")
                    {
                        return false;
                    }
                    else if (_token == "(")
                    {
                        _open++;
                    }

                    AddCode(_token);

                    //end
                    if (_token == ")")
                    {
                        if (_open == 0)
                        {
                            _again = false;
                        }
                        else
                        {
                            _open--;
                        }
                    }
                }

                if (NextToken() == "{")
                {
                    AddCodeOnNewLine("{");
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
                        AddCodeOnNewLine("}");
                        _again2 = false;
                    }
                }
            }
            return true;
        }
    }
}
