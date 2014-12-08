using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Web_Sharp
{
    class Class_Code : BaseCode
    {
        public Class_Code()
        {
            name = "";
            autoComplete = new List<string>() { "" };
            highlight = "";
        }

        public override bool Run()
        {
            while (tokenIndex < tokens.Count)
            {
                string _token = NextToken();

                //check for class tokens
                short _check = CheckForClasToken(_token);
                if (_check == 1)//return error
                {
                    return false;
                }
                else if (_check == 2)//return empty
                {
                    //check for data type tokens
                    _check = CheckForDataTypeToken(_token);
                    if (_check == 1)//return error
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
