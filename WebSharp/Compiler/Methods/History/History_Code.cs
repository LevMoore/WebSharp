using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Sharp
{
    class History_Code : BaseCode
    {
        public History_Code()
        {
            name = "History";
            autoComplete = new List<string>() { "Back", "Forward", "Go", "length" };
            highlight = "History";
            sub = new List<BaseCode>() {
                new HistoryBack_Code(),
                new HistoryForward_Code(),
                new HistoryGo_Code()
            };
        }

        public override bool Run()
        {
            AddCodeJava("window.history.");
            if (NextToken() == ".")
            {
                string _token = NextToken();
                if (_token == "length")
                {
                    AddCodeJava("length");
                    AddCodeJava(";");
                    return true;
                }
                else
                {
                    return RunSub(_token);
                }
            }
            else
            {
                return false;
            }
        }
    }
}
