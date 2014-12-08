using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Web_Sharp
{
    class Alert_Code : BaseCode
    {
        public Alert_Code()
        {
            name = "Alert";
            autoComplete = new List<string>() {};
            highlight = "Alert";
        }

        public override bool Run()
        {
            if (NextToken() == "(")
            {
                string _string = NextToken();
                if (NextToken() == ")" && NextToken() == ";")
                {
                    AddCodeOnNewLine("alert(" + _string + ");");
                }
                else
                {
                    return false;
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
