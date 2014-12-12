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
            if (_token == "value" || _token == "innerHTML")
            {
                AddCodeJava(_token);
                return true;
            }
            else return false;
        }
    }
}
