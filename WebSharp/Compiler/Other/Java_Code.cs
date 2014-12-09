using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Sharp
{
    class Java_Code : BaseCode
    {
        public Java_Code()
        {
            name = "§";
        }

        public override bool Run()
        {
            AddCodeOnNewLine("");
            bool _again = true;
            while (_again)
            {
                string _token = NextToken();
                if (_token == "§")
                {
                    _again = false;
                }
                else if (_token == "")
                {
                    return false;
                }
                else
                {
                    AddCode(_token);
                }
            }

            return true;
        }
    }
}
