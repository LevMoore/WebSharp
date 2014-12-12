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
                AddCodeJava("location.href = ");
                ignoreSemicolon = true;
                if (!StopOnSymbol(")"))
                {
                    return false;
                }
                ignoreSemicolon = false;

                return AddCodeJavaIf(";");
            }
            else return false;
        }
    }
}
