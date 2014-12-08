using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            if (NextToken() == "=")
            {
                string _value = NextToken();
                if (NextToken() == ";")
                {
                    AddCodeOnNewLine("var " + _name + " = " + _value + ";");
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