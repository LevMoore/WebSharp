using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Web_Sharp
{
    class DocumentFindByID_Code : BaseCode
    {
        ElementValues_Code _code;
        public DocumentFindByID_Code()
        {
            _code = new ElementValues_Code();
            name = "FindByID";
            autoComplete = _code.autoComplete;
        }

        public override bool Run()
        {
            if (NextToken() == "(")
            {
                string _string = NextToken();
                if (NextToken() == ")" && NextToken() == ".")
                {
                    AddCode("getElementById(" + _string + ").");

                    return _code.Run();
                }
                else return false;
            }
            else return false;
        }
    }
}
