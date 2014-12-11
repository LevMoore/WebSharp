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
                AddCode("go(");
                ignoreSemicolon = true;
                if (!StopOnSymbol(")"))
                {
                    return false;
                }
                ignoreSemicolon = false;
                AddCode(")");
                AddCode(";");

                //string _value = NextToken();
                //if (NextToken() == ")" && NextToken() == ";")
                //{
                //    AddCode("go(" + _value + ");");
                //}
            }
            return true;
        }
    }
}
