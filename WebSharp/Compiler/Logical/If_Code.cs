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
                AddCodeJava("if(");

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
