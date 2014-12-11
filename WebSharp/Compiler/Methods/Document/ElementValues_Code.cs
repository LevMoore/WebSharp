using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Sharp
{
    class ElementValues_Code : BaseCode
    {
        public ElementValues_Code()
        {
            autoComplete = new List<string>() { "value", "innerHTML" };
        }

        public override bool Run()
        {
            string _token = NextToken();
            //value
            if (_token == "value")
            {
                AddCode("value");
                _token = NextToken();
                if (_token == "=")
                {
                    AddCode("=" + NextToken());
                    AddCode(";");
                }
                else
                {
                    tokenIndex--;
                }
            }
            //innerHTML
            else if (_token == "innerHTML")
            {
                AddCode("innerHTML");
                _token = NextToken();
                if (_token == "=")
                {
                    AddCode("=" + NextToken());
                    AddCode(";");
                }
                else
                {
                    tokenIndex--;
                }
            }
            else return false;

            return true;
        }
    }
}
