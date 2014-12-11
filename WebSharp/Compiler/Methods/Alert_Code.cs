﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Web_Sharp
{
    class Alert_Code : BaseCode
    {
        public Alert_Code()
        {
            name = "Alert";
            autoComplete = new List<string>() {};
            highlight = "Alert";
        }

        public override bool Run()
        {
            if (NextToken() == "(")
            {
                AddCodeOnNewLine("alert(");
                ignoreSemicolon = true;
                if (!StopOnSymbol(")"))
                {
                    return false;
                }
                ignoreSemicolon = false;
                AddCode(")");
                AddCode(";");
            }
            else
            {
                return false;
            }

            return true;
        }
    }
}
