using ScintillaNET.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //create folder
            string path = Environment.CurrentDirectory;
            if (!Directory.Exists(path + @"\Preview\"))
            {
                Directory.CreateDirectory(path + @"\Preview\");
            }
            if (!Directory.Exists(path + @"\Save\"))
            {
                Directory.CreateDirectory(path + @"\Save\");
            }

            //show line number
            textbox_ws.Margins[0].Width = 15;
            textbox_html.Margins[0].Width = 15;


            //set default w# code
            string text = "";
            using (StreamReader sr = new StreamReader(path + @"\Default\webSharp.txt"))
            {
                text = sr.ReadToEnd();
            }
            textbox_ws.Text = text;

            //set default html code
            using (StreamReader sr = new StreamReader(path + @"\Default\html.txt"))
            {
                text = sr.ReadToEnd();
            }
            textbox_html.Text = text;

            //set default css code
            using (StreamReader sr = new StreamReader(path + @"\Default\css.txt"))
            {
                text = sr.ReadToEnd();
            }
            textbox_css.Text = text;

            //Lexer
            string _keywords0 = CodeList.GetDataTypeHighlights();
            _keywords0 += CodeList.GetLogicalHighlights();
            _keywords0 += CodeList.GetClassHighlights();
            string _keywords1 = CodeList.GetMethodsHighlights();

            textbox_ws.Lexing.Keywords[0] = _keywords0;
            textbox_ws.Lexing.Keywords[1] = _keywords1;
            

            //set autocomplete
            List<string> _list = CodeList.GetMethodNames();
            _list.AddRange(CodeList.GetDataTypeNames());
            _list.Sort();
            textbox_ws.AutoComplete.List = _list;
            textbox_ws.AutoComplete.SingleLineAccept = false;
        }

        private void button_compile_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + @"\Preview\";

            CompileJavaCode();

            UpdatePreview();
        }
        void CompileJavaCode()
        {
            string path = Environment.CurrentDirectory + @"\Preview\";

            //compile w# code to javascript
            Compiler _compiler = new Compiler();
            string _code = _compiler.CompileWSCode(textbox_ws.Text);
            
            //save javascript
            using (FileStream fs = File.Create(path + "script.js"))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(_code);
                fs.Write(info, 0, info.Length);
            }
        }
        void CompileHTML_CSS()
        {
            string path = Environment.CurrentDirectory + @"\Preview\";

            //save html
            using (FileStream fs = File.Create(path + "index.html"))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(textbox_html.Text);
                fs.Write(info, 0, info.Length);
            }

            //save css
            using (FileStream fs = File.Create(path + "style.css"))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(textbox_css.Text);
                fs.Write(info, 0, info.Length);
            }
        }

        private void textbox_ws_CharAdded(object sender, ScintillaNET.CharAddedEventArgs e)
        {
            char _c = e.Ch;
            if (Char.IsLetterOrDigit(_c) || _c == '.')
            {
                if (_c == '.')
                {
                    List<string> _words = FindAutoComplete(textbox_ws.CurrentPos);
                    _words.Reverse();

                    BaseCode _code = null;
                    for (int i = 0; i < CodeList.listMethods.Count; i++)
                    {
                        if (CodeList.listMethods[i].name == _words[0])
                        {
                            _code = CodeList.listMethods[i];
                            i = CodeList.listMethods.Count;
                        }
                    }
                    if (_code == null)
                    {

                    }
                    else
                    {
                        List<string> _list = new List<string>();
                        if (_words.Count > 1)
                        {
                            int _pos = 1;
                            bool _again = true;
                            while (_again)
                            {
                                bool _fund = false;
                                for (int i = 0; i < _code.sub.Count; i++)
                                {
                                    if (_code.sub[i].name == _words[_pos])
                                    {
                                        _fund = true;
                                        _pos++;
                                        _list = _code.sub[i].autoComplete;
                                        _code = _code.sub[i];
                                        i = _code.sub.Count;
                                    }
                                }
                                if (!_fund)
                                {
                                    if (_pos == _words.Count)
                                    {

                                    }
                                    else
                                    {
                                        _list = new List<string>();
                                    }
                                    _again = false;
                                }
                            }
                        }
                        else
                        {
                            _list = _code.autoComplete;
                        }
                        _list.Sort();

                        if (_list.Count != 0)
                        {
                            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
                            t.Interval = 10;
                            t.Tick += new EventHandler((obj, ev) =>
                            {
                                textbox_ws.AutoComplete.ShowUserList(0, _list);

                                t.Stop();
                                t.Enabled = false;
                                t.Dispose();
                            });
                            t.Start();
                        }
                    }
                }
                else
                {
                    char _char = textbox_ws.Text[textbox_ws.CurrentPos - 2];
                    if (_char == ' ' || _char == 10 || _char == 13 || _char == 9)
                    {
                        textbox_ws.AutoComplete.Show();
                    }
                }
            }
        }
        private List<string> FindAutoComplete(int _pos)
        {
            List<string> _return = new List<string>();
            _pos -= 1;
            string _lastWord = "";
            bool _again = true;
            while (_again)
            {
                if (_pos < 0)
                {
                    _again = false;
                }
                else
                {
                    char _char = textbox_ws.Text[_pos];
                    if (_char == '.')
                    {
                        _pos--;
                        if (textbox_ws.Text[_pos] == ')')
                        {
                            _pos--;
                            int _open = 1;
                            bool _again2 = true;
                            while (_again2)
                            {
                                if (_pos < 0)
                                {
                                    _again2 = false;
                                    return new List<string>();
                                }
                                else
                                {
                                    if (textbox_ws.Text[_pos] == ')')
                                    {
                                        _open++;
                                    }
                                    else if (textbox_ws.Text[_pos] == '(')
                                    {
                                        _open--;
                                        if (_open == 0)
                                        {
                                            _lastWord = textbox_ws.GetWordFromPosition(_pos - 1);
                                            _return.Add(_lastWord);
                                            _again2 = false;
                                        }
                                    }
                                    _pos--;
                                }
                            }
                        }
                        else
                        {
                            _lastWord = textbox_ws.GetWordFromPosition(_pos);
                            _return.Add(_lastWord);
                        }
                    }
                    else if (textbox_ws.GetWordFromPosition(_pos) != _lastWord)
                    {
                        _again = false;
                    }
                    else
                    {
                        _pos--;
                    }
                }
            }

            return _return;
        }

        private void textbox_html_CharAdded(object sender, ScintillaNET.CharAddedEventArgs e)
        {
            char _c = e.Ch;
            if (Char.IsLetterOrDigit(_c))
            {
                textbox_html.AutoComplete.Show();
            }
        }

        private void tabHTML_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabControl.SelectedIndex == 2)
            {
                CompileHTML_CSS();
                UpdatePreview();
            }
        }

        void UpdatePreview()
        {
            string path = Environment.CurrentDirectory + @"\Preview\index.html";
            webBrowserHTML.ScriptErrorsSuppressed = true;
            webBrowserHTML.Url = new Uri(path);
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory;

            CompileJavaCode();
            CompileHTML_CSS();

            System.IO.DirectoryInfo downloadedMessageInfo = new DirectoryInfo(path + @"\Save\");
            foreach (FileInfo file in downloadedMessageInfo.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in downloadedMessageInfo.GetDirectories())
            {
                dir.Delete(true);
            }

            DirectoryCopy(path + @"\Preview\", path + @"\Save\", true);

            UpdatePreview();

            //auto open
            if (checkBox_autoOpen.Checked)
            {
                Process.Start(path + @"\Save\index.html");
            }
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            // If the destination directory doesn't exist, create it. 
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location. 
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        private void button_openFolder_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory;

            Process.Start(path + @"\Save\");
        }
    }
}
