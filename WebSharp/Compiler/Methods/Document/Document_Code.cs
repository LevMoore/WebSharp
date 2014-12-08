using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Web_Sharp
{
    class Document_Code : BaseCode
    {
        public Document_Code()
        {
            name = "Document";
            autoComplete = new List<string>() { "FindByID" };
            highlight = "Document";
            sub = new List<BaseCode>() {
                new DocumentFindByID_Code()
            };
        }

        public override bool Run()
        {
            AddCodeOnNewLine("document.");
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
