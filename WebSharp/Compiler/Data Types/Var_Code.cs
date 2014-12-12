using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Web_Sharp
{
    class Var_Code : BaseCode
    {
        public Var_Code()
        {
            name = "var";
            autoComplete = new List<string>() {};
            highlight = "var";
        }

        public override bool Run()
        {
            string _name = NextToken();
            string _token = NextToken();

            if (_token == "=")
            {
                AddCodeJava("var " + _name + " = ");
                ignoreSemicolon = true;
                if (!StopOnSymbol(";"))
                {
                    return false;
                }
                ignoreSemicolon = false;
                AddCodeJava(";");
            }
            else if (_token == ";")
            {
                AddCodeJava("var " + _name);
                AddCodeJava(";");
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}