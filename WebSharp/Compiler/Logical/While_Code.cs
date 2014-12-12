using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Sharp
{
    class While_Code : BaseCode
    {
        public While_Code()
        {
            name = "while";
            highlight = "while";
        }

        public override bool Run()
        {
            if (NextToken() == "(")
            {
                AddCodeJava("while(");

                ignoreSemicolon = true;
                if (!StopOnSymbol(")"))
                {
                    return false;
                }
                ignoreSemicolon = false;
                AddCodeJava(")");

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
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
