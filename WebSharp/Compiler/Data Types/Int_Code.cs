using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Web_Sharp
{
    class Int_Code : BaseCode
    {
        public Int_Code()
        {
            name = "int";
            autoComplete = new List<string>() {};
            highlight = "int";
        }

        public override bool Run()
        {
            string _name = NextToken();
            string _token = NextToken();

            if (_token == "=")
            {
                AddCodeOnNewLine("var " + _name + " = ");
                ignoreSemicolon = true;
                if (!StopOnSymbol(";"))
                {
                    return false;
                }
                ignoreSemicolon = false;
                AddCode(";");
            }
            else if (_token == ",")
            {
                AddCode(_name + ",");
            }
            else if (_token == ")")
            {
                AddCode(_name);
                tokenIndex--;
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}