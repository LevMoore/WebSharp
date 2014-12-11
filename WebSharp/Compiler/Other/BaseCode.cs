using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Web_Sharp
{
    abstract class BaseCode
    {
        public static bool ignoreSemicolon;

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
            if (_code == ";" && ignoreSemicolon)
	        {
                return;	   
	        }
            code += _code;
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
        public short CheckForLogicalsToken(string _token)
        {
            for (int i = 0; i < CodeList.listLogicals.Count; i++)
            {
                if (_token == CodeList.listLogicals[i].name)
                {
                    if (CodeList.listLogicals[i].Run())
                    {
                        i = CodeList.listLogicals.Count;
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

        public bool StopOnSymbol(string _symbol)
        {
            int _open = 0;
            bool _again = true;
            while (_again)
            {
                string _token = NextToken();
                if (_token == "")
                {
                    return false;
                }
                else if (_symbol == ")" && _token == "(")
                {
                    _open++;
                }

                bool _addToken = false;

                short _check = CheckForMethodsToken(_token);
                if (_check == 1)//return error
                {
                    return false;
                }
                else if (_check == 2)
                {
                    _check = CheckForLogicalsToken(_token);
                    if (_check == 1)//return error
                    {
                        return false;
                    }
                    else if (_check == 2)
                    {
                        _check = CheckForDataTypeToken(_token);
                        if (_check == 1)//return error
                        {
                            return false;
                        }
                        else if (_check == 2)
                        {
                            _addToken = true;
                        }
                    }
                }

                //end
                if (_token == _symbol)
                {
                    if (_open == 0)
                    {
                        _again = false;
                    }
                    else if (_symbol == ")")
                    {
                        _open--;
                        AddCode(_token);

                    }
                }
                else if(_addToken)
                {
                    AddCode(_token);
                }
            }

            return true;
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
