using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Web_Sharp
{
    class CodeList
    {
        //Data types
        public static List<BaseCode> listDataTypes = new List<BaseCode>() {
            new String_Code(),
            new Int_Code()
        };

        //Class
        public static List<BaseCode> listClass = new List<BaseCode>() {
            new Void_Code()
        };

        //Methods
        public static List<BaseCode> listMethods = new List<BaseCode>() {
            new Alert_Code(),
            new Document_Code()
        };

        public static string GetDataTypeHighlights()
        {
            string _keywords = "";
            for (int i = 0; i < listDataTypes.Count; i++)
            {
                _keywords += listDataTypes[i].highlight + " ";
            }
            return _keywords;
        }
        public static string GetMethodsHighlights()
        {
            string _keywords = "";
            for (int i = 0; i < listMethods.Count; i++)
            {
                _keywords += listMethods[i].highlight + " ";
            }
            return _keywords;
        }
        public static string GetClassHighlights()
        {
            string _keywords = "";
            for (int i = 0; i < listClass.Count; i++)
            {
                _keywords += listClass[i].highlight + " ";
            }
            return _keywords;
        }

        public static List<string> GetClassAutoCompleteList()
        {
            List<string> _list = new List<string>();
            for (int i = 0; i < listClass.Count; i++)
            {
                _list.AddRange(listClass[i].autoComplete);
            }
            return _list;
        }
        public static List<string> GetDataTypeAutoCompleteList()
        {
            List<string> _list = new List<string>();
            for (int i = 0; i < listDataTypes.Count; i++)
            {
                _list.AddRange(listDataTypes[i].autoComplete);
            }
            return _list;
        }
        public static List<string> GetMethodAutoCompleteList()
        {
            List<string> _list = new List<string>();
            for (int i = 0; i < listMethods.Count; i++)
            {
                _list.AddRange(listMethods[i].autoComplete);
            }
            return _list;
        }

        public static List<string> GetDataTypeNames()
        {
            List<string> _list = new List<string>();
            for (int i = 0; i < listDataTypes.Count; i++)
            {
                _list.Add(listDataTypes[i].name);
            }
            return _list;
        }
        public static List<string> GetClassNames()
        {
            List<string> _list = new List<string>();
            for (int i = 0; i < listClass.Count; i++)
            {
                _list.Add(listClass[i].name);
            }
            return _list;
        }
        public static List<string> GetMethodNames()
        {
            List<string> _list = new List<string>();
            for (int i = 0; i < listMethods.Count; i++)
            {
                _list.Add(listMethods[i].name);
            }
            return _list;
        }
    }
}
