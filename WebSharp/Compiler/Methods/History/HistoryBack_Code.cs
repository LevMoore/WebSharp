using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Sharp
{
    class HistoryBack_Code : BaseCode
    {
        public HistoryBack_Code()
        {
            name = "Back";
        }

        public override bool Run()
        {
            if (NextToken() == "(" && NextToken() == ")" && NextToken() == ";")
            {
                AddCodeJava("back();");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
