using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Web_Sharp
{
    abstract class BaseCode
    {
        public static List<string> tokens;
        public static int tokenIndex;
        public static string code;

        public string name;
        public List<string> autoComplete = new List<string>();
        public string highlight;
        public List<BaseCode> sub = new List<BaseCode>();

        abstract public bool Run();

        public string NextToken()
        {
            if (tokenIndex >= tokens.Count)
            {
                return "";
            }

            string _token = tokens[tokenIndex];
            tokenIndex++;
            return _token;
        }

        public void AddCodeOnNewLine(string _code)
        {
            code += "\r" + _code;
        }
        public void AddCode(string _code)
        {
            code += _code;
        }

        public short CheckForClasToken(string _token)
        {
            for (int i = 0; i < CodeList.listClass.Count; i++)
            {
                if (_token == CodeList.listClass[i].name)
                {
                    if (CodeList.listClass[i].Run())
                    {
                        i = CodeList.listClass.Count;
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }

            return 2;
        }
        public short CheckForDataTypeToken(string _token)
        {
            for (int i = 0; i < CodeList.listDataTypes.Count; i++)
            {
                if (_token == CodeList.listDataTypes[i].name)
                {
                    if (CodeList.listDataTypes[i].Run())
                    {
                        i = CodeList.listDataTypes.Count;
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }

            return 2;
        }
        public short CheckForMethodsToken(string _token)
        {
            for (int i = 0; i < CodeList.listMethods.Count; i++)
            {
                if (_token == CodeList.listMethods[i].name)
                {
                    if (CodeList.listMethods[i].Run())
                    {
                        i = CodeList.listMethods.Count;
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }

            return 2;
        }

        public bool RunSub(string _token)
        {
            for (int i = 0; i < sub.Count; i++)
            {
                if (_token == sub[i].name)
                {
                    return sub[i].Run();
                }
            }

            return false;
        }
    }
}
