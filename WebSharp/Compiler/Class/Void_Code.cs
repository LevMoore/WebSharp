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
                    if (NextToken() == ")")
                    {
                        AddCodeJava("window.onload = function ()");
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    AddCodeJava("function " + _name + "(");
                    ignoreSemicolon = true;
                    if (!StopOnSymbol(")"))
                    {
                        return false;
                    }
                    ignoreSemicolon = false;
                    AddCodeJava(")");
                }
                if (NextToken() == "{")
                {
                    AddCodeJava("{");
                    tap++;

                    if (!StopOnSymbol("}"))
                    {
                        return false;
                    }

                    tap--;
                    AddCodeJava("}");
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
