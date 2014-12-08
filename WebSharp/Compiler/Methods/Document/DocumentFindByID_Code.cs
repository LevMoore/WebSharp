using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Web_Sharp
{
    class DocumentFindByID_Code : BaseCode
    {
        public DocumentFindByID_Code()
        {
            name = "FindByID";
            autoComplete = new List<string>() { "value", "innerHTML" };
        }

        public override bool Run()
        {
            if (NextToken() == "(")
            {
                string _string = NextToken();
                if (NextToken() == ")" && NextToken() == ".")
                {
                    AddCode("getElementById(" + _string + ").");

                    string _token = NextToken();
                    //value
                    if (_token == "value")
                    {
                        AddCode("value");
                        if (NextToken() == "=")
                        {
                            AddCode("=" + NextToken() + ";");
                        }
                        else return false;
                    }
                    //innerHTML
                    else if (_token == "innerHTML")
                    {
                        AddCode("innerHTML");
                        if (NextToken() == "=")
                        {
                            AddCode("=" + NextToken() + ";");
                        }
                        else return false;
                    }
                    else return false;
                }
                else return false;
            }
            else return false;

            return true;
        }
    }
}
