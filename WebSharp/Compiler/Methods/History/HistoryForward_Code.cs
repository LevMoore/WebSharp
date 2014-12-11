using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Sharp
{
    class HistoryForward_Code : BaseCode
    {
        public HistoryForward_Code()
        {
            name = "Forward";
        }

        public override bool Run()
        {
            if (NextToken() == "(" && NextToken() == ")" && NextToken() == ";")
            {
                AddCode("forward();");
            }
            return true;
        }
    }
}
