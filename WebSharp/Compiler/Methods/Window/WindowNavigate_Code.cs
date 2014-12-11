using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Sharp
{
    class WindowNavigate_Code : BaseCode
    {
        public WindowNavigate_Code()
        {
            name = "Navigate";
        }

        public override bool Run()
        {
            if (NextToken() == "(")
            {
                AddCode("location.href = ");
                ignoreSemicolon = true;
                if (!StopOnSymbol(")"))
                {
                    return false;
                }
                ignoreSemicolon = false;
                AddCode(";");

                //string _string = NextToken();
                //if (NextToken() == ")" && NextToken() == ";")
                //{
                //    AddCode("location.href = " + _string + ";");
                //}
                //else return false;
            }
            else return false;

            return true;
        }
    }
}
