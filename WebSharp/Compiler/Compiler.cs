using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Sharp
{
    class Compiler
    {
        public string CompileWSCode(string _source)
        {
            List<string> _tokens = GetTokens(_source);

            BaseCode.tokens = _tokens;
            BaseCode.tokenIndex = 0;
            BaseCode.code = "";

            string _code;
            Class_Code _class = new Class_Code();
            if(_class.Run())
            {
                _code = BaseCode.code;
            }
            else
            {
                _code = BaseCode.code + " #null";
            }

            BaseCode.tokens = new List<string>();
            BaseCode.tokenIndex = 0;
            BaseCode.code = "";

            return _code;
        }

        private List<string> GetTokens(string _source)
        {
            //remove "new line, tap space"
            string _fix = _source.Replace("\r\n", string.Empty);
            _fix = _fix.Replace("\t", string.Empty);

            //split code into tokens
            var values = new List<string>();
            int pos = 0;
            bool _inString = false;
            bool _useString = false;
            int _s = 0;
            int _c = 0;
            MatchCollection mc = Regex.Matches(_fix, "[§(){};=.,\" ]", RegexOptions.Multiline);
            foreach (Match m in mc)
            {
                string _value = m.Value;


                if (_value == "\"")
                {
                    _inString = !_inString;

                    if (!_inString)
                    {
                        _useString = true;
                        _c = m.Index;
                    }
                    else
                    {
                        _s = m.Index;
                    }
                }

                if (_inString)
                {

                }
                else
                {
                    if (_useString)
                    {
                        values.Add(_fix.Substring(_s, _c - _s + 1));
                        _useString = false;
                    }
                    else
                    {
                        values.Add(_fix.Substring(pos, m.Index - pos));
                        if (m.Value != " ")
                        {
                            values.Add(_value);
                        }
                    }
                }
                pos = m.Index + m.Length;
            }
            values.RemoveAll(str => String.IsNullOrEmpty(str));

            return values;
        }
    }
}