using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Web_Sharp
{
    class String_Code : BaseCode
    {
        public String_Code()
        {
            name = "string";
            autoComplete = new List<string>() {};
            highlight = "string";
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