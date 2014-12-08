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
            if (NextToken() == "=")
            {
                try
                {
                    int _value = int.Parse(NextToken());
                    if (NextToken() == ";")
                    {
                        AddCodeOnNewLine("var " + _name + " = " + _value + ";");
                    }
                    else
                    {
                        return false;
                    }
                }
                catch
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