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
            AddCodeOnNewLine("var " + _name + " = ");
            if (NextToken() == "=")
            {
                ignoreSemicolon = true;
                if (!StopOnSymbol(";"))
                {
                    return false;
                }
                ignoreSemicolon = false;
                AddCode(";");
            }
            else
            {
                return false;
            }

            return true;
        }
    }
}