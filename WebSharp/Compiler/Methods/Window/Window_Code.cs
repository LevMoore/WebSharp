using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Web_Sharp
{
    class Window_Code : BaseCode
    {
        public Window_Code()
        {
            name = "Window";
            autoComplete = new List<string>() { "Navigate" };
            highlight = "Window";
            sub = new List<BaseCode>() {
                new WindowNavigate_Code()
            };
        }

        public override bool Run()
        {
            AddCodeJava("window.");
            if (NextToken() == ".")
            {
                return RunSub(NextToken());
            }
            else
            {
                return false;
            }
        }
    }
}
