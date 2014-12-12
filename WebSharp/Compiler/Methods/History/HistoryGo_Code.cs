using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Sharp
{
    class HistoryGo_Code : BaseCode
    {
        public HistoryGo_Code()
        {
            name = "Go";
        }

        public override bool Run()
        {
            if (NextToken() == "(")
            {
                AddCodeJava("go(");
                ignoreSemicolon = true;
                if (!StopOnSymbol(")"))
                {
                    return false;
                }
                ignoreSemicolon = false;
                AddCodeJava(")");

                return AddCodeJavaIf(";");
            }
            return true;
        }
    }
}
