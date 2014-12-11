namespace Web_Sharp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textbox_ws = new ScintillaNET.Scintilla();
            this.textbox_html = new ScintillaNET.Scintilla();
            this.button_compile = new System.Windows.Forms.Button();
            this.checkBox_autoOpen = new System.Windows.Forms.CheckBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab1HTML = new System.Windows.Forms.TabPage();
            this.tab1CSS = new System.Windows.Forms.TabPage();
            this.textbox_css = new ScintillaNET.Scintilla();
            this.tab1Web = new System.Windows.Forms.TabPage();
            this.webBrowserHTML = new System.Windows.Forms.WebBrowser();
            this.button_save = new System.Windows.Forms.Button();
            this.button_openFolder = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab2WSharp = new System.Windows.Forms.TabPage();
            this.tab2Java = new System.Windows.Forms.TabPage();
            this.tab2PHP = new System.Windows.Forms.TabPage();
            this.textbox_java = new ScintillaNET.Scintilla();
            ((System.ComponentModel.ISupportInitialize)(this.textbox_ws)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textbox_html)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tab1HTML.SuspendLayout();
            this.tab1CSS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textbox_css)).BeginInit();
            this.tab1Web.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab2WSharp.SuspendLayout();
            this.tab2Java.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textbox_java)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox_ws
            // 
            this.textbox_ws.AutoComplete.ListString = "";
            this.textbox_ws.AutoComplete.MaxHeight = 10;
            this.textbox_ws.ConfigurationManager.CustomLocation = "ScintillaNET.xml";
            this.textbox_ws.ConfigurationManager.Language = "cs";
            this.textbox_ws.Folding.IsEnabled = false;
            this.textbox_ws.Location = new System.Drawing.Point(0, 0);
            this.textbox_ws.Margins.Margin2.IsClickable = false;
            this.textbox_ws.Margins.Margin2.IsFoldMargin = false;
            this.textbox_ws.Name = "textbox_ws";
            this.textbox_ws.Scrolling.HorizontalScrollTracking = false;
            this.textbox_ws.Scrolling.HorizontalScrollWidth = 2000;
            this.textbox_ws.Size = new System.Drawing.Size(542, 508);
            this.textbox_ws.Styles.Bits = 5;
            this.textbox_ws.Styles.BraceBad.FontName = "\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_ws.Styles.BraceLight.FontName = "\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_ws.Styles.CallTip.FontName = "\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_ws.Styles.ControlChar.FontName = "\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_ws.Styles.Default.BackColor = System.Drawing.SystemColors.Window;
            this.textbox_ws.Styles.Default.FontName = "\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_ws.Styles.IndentGuide.FontName = "\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_ws.Styles.LastPredefined.FontName = "\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_ws.Styles.LineNumber.FontName = "\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_ws.Styles.Max.FontName = "\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_ws.TabIndex = 0;
            this.textbox_ws.CharAdded += new System.EventHandler<ScintillaNET.CharAddedEventArgs>(this.textbox_ws_CharAdded);
            // 
            // textbox_html
            // 
            this.textbox_html.ConfigurationManager.Language = "html";
            this.textbox_html.Location = new System.Drawing.Point(0, 0);
            this.textbox_html.Name = "textbox_html";
            this.textbox_html.Size = new System.Drawing.Size(542, 508);
            this.textbox_html.Styles.BraceBad.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_html.Styles.BraceLight.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_html.Styles.CallTip.FontName = "Segoe UI\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_html.Styles.ControlChar.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_html.Styles.Default.BackColor = System.Drawing.SystemColors.Window;
            this.textbox_html.Styles.Default.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_html.Styles.IndentGuide.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_html.Styles.LastPredefined.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_html.Styles.LineNumber.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_html.Styles.Max.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_html.TabIndex = 1;
            this.textbox_html.CharAdded += new System.EventHandler<ScintillaNET.CharAddedEventArgs>(this.textbox_html_CharAdded);
            // 
            // button_compile
            // 
            this.button_compile.Location = new System.Drawing.Point(1035, 547);
            this.button_compile.Name = "button_compile";
            this.button_compile.Size = new System.Drawing.Size(75, 23);
            this.button_compile.TabIndex = 2;
            this.button_compile.Text = "Compile";
            this.button_compile.UseVisualStyleBackColor = true;
            this.button_compile.Click += new System.EventHandler(this.button_compile_Click);
            // 
            // checkBox_autoOpen
            // 
            this.checkBox_autoOpen.AutoSize = true;
            this.checkBox_autoOpen.Location = new System.Drawing.Point(174, 552);
            this.checkBox_autoOpen.Name = "checkBox_autoOpen";
            this.checkBox_autoOpen.Size = new System.Drawing.Size(75, 17);
            this.checkBox_autoOpen.TabIndex = 3;
            this.checkBox_autoOpen.Text = "Auto open";
            this.checkBox_autoOpen.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab1HTML);
            this.tabControl.Controls.Add(this.tab1CSS);
            this.tabControl.Controls.Add(this.tab1Web);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(550, 534);
            this.tabControl.TabIndex = 4;
            this.tabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabHTML_Selecting);
            // 
            // tab1HTML
            // 
            this.tab1HTML.Controls.Add(this.textbox_html);
            this.tab1HTML.Location = new System.Drawing.Point(4, 22);
            this.tab1HTML.Name = "tab1HTML";
            this.tab1HTML.Padding = new System.Windows.Forms.Padding(3);
            this.tab1HTML.Size = new System.Drawing.Size(542, 508);
            this.tab1HTML.TabIndex = 0;
            this.tab1HTML.Text = "HTML";
            this.tab1HTML.UseVisualStyleBackColor = true;
            // 
            // tab1CSS
            // 
            this.tab1CSS.Controls.Add(this.textbox_css);
            this.tab1CSS.Location = new System.Drawing.Point(4, 22);
            this.tab1CSS.Name = "tab1CSS";
            this.tab1CSS.Padding = new System.Windows.Forms.Padding(3);
            this.tab1CSS.Size = new System.Drawing.Size(542, 508);
            this.tab1CSS.TabIndex = 2;
            this.tab1CSS.Text = "CSS";
            this.tab1CSS.UseVisualStyleBackColor = true;
            // 
            // textbox_css
            // 
            this.textbox_css.ConfigurationManager.Language = "css";
            this.textbox_css.Location = new System.Drawing.Point(0, 0);
            this.textbox_css.Name = "textbox_css";
            this.textbox_css.Size = new System.Drawing.Size(542, 508);
            this.textbox_css.Styles.BraceBad.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_css.Styles.BraceLight.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_css.Styles.CallTip.FontName = "Segoe UI\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_css.Styles.ControlChar.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_css.Styles.Default.BackColor = System.Drawing.SystemColors.Window;
            this.textbox_css.Styles.Default.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_css.Styles.IndentGuide.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_css.Styles.LastPredefined.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_css.Styles.LineNumber.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_css.Styles.Max.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_css.TabIndex = 2;
            // 
            // tab1Web
            // 
            this.tab1Web.Controls.Add(this.webBrowserHTML);
            this.tab1Web.Location = new System.Drawing.Point(4, 22);
            this.tab1Web.Name = "tab1Web";
            this.tab1Web.Padding = new System.Windows.Forms.Padding(3);
            this.tab1Web.Size = new System.Drawing.Size(542, 508);
            this.tab1Web.TabIndex = 1;
            this.tab1Web.Text = "Preview";
            this.tab1Web.UseVisualStyleBackColor = true;
            // 
            // webBrowserHTML
            // 
            this.webBrowserHTML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserHTML.Location = new System.Drawing.Point(3, 3);
            this.webBrowserHTML.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserHTML.Name = "webBrowserHTML";
            this.webBrowserHTML.Size = new System.Drawing.Size(536, 502);
            this.webBrowserHTML.TabIndex = 0;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(12, 547);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 5;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_openFolder
            // 
            this.button_openFolder.Location = new System.Drawing.Point(93, 547);
            this.button_openFolder.Name = "button_openFolder";
            this.button_openFolder.Size = new System.Drawing.Size(75, 23);
            this.button_openFolder.TabIndex = 6;
            this.button_openFolder.Text = "Open";
            this.button_openFolder.UseVisualStyleBackColor = true;
            this.button_openFolder.Click += new System.EventHandler(this.button_openFolder_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab2WSharp);
            this.tabControl1.Controls.Add(this.tab2Java);
            this.tabControl1.Controls.Add(this.tab2PHP);
            this.tabControl1.Location = new System.Drawing.Point(564, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(550, 534);
            this.tabControl1.TabIndex = 7;
            // 
            // tab2WSharp
            // 
            this.tab2WSharp.Controls.Add(this.textbox_ws);
            this.tab2WSharp.Location = new System.Drawing.Point(4, 22);
            this.tab2WSharp.Name = "tab2WSharp";
            this.tab2WSharp.Padding = new System.Windows.Forms.Padding(3);
            this.tab2WSharp.Size = new System.Drawing.Size(542, 508);
            this.tab2WSharp.TabIndex = 0;
            this.tab2WSharp.Text = "W#";
            this.tab2WSharp.UseVisualStyleBackColor = true;
            // 
            // tab2Java
            // 
            this.tab2Java.Controls.Add(this.textbox_java);
            this.tab2Java.Location = new System.Drawing.Point(4, 22);
            this.tab2Java.Name = "tab2Java";
            this.tab2Java.Padding = new System.Windows.Forms.Padding(3);
            this.tab2Java.Size = new System.Drawing.Size(542, 508);
            this.tab2Java.TabIndex = 1;
            this.tab2Java.Text = "Java";
            this.tab2Java.UseVisualStyleBackColor = true;
            // 
            // tab2PHP
            // 
            this.tab2PHP.Location = new System.Drawing.Point(4, 22);
            this.tab2PHP.Name = "tab2PHP";
            this.tab2PHP.Size = new System.Drawing.Size(542, 508);
            this.tab2PHP.TabIndex = 2;
            this.tab2PHP.Text = "PHP";
            this.tab2PHP.UseVisualStyleBackColor = true;
            // 
            // textbox_java
            // 
            this.textbox_java.AutoComplete.ListString = "";
            this.textbox_java.AutoComplete.MaxHeight = 10;
            this.textbox_java.ConfigurationManager.Language = "js";
            this.textbox_java.Folding.IsEnabled = false;
            this.textbox_java.Location = new System.Drawing.Point(0, 0);
            this.textbox_java.Margins.Margin2.IsClickable = false;
            this.textbox_java.Margins.Margin2.IsFoldMargin = false;
            this.textbox_java.Name = "textbox_java";
            this.textbox_java.Scrolling.HorizontalScrollTracking = false;
            this.textbox_java.Scrolling.HorizontalScrollWidth = 2000;
            this.textbox_java.Size = new System.Drawing.Size(542, 508);
            this.textbox_java.Styles.Bits = 5;
            this.textbox_java.Styles.BraceBad.FontName = "\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_java.Styles.BraceLight.FontName = "\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_java.Styles.CallTip.FontName = "\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_java.Styles.ControlChar.FontName = "\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_java.Styles.Default.BackColor = System.Drawing.SystemColors.Window;
            this.textbox_java.Styles.Default.FontName = "\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_java.Styles.IndentGuide.FontName = "\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_java.Styles.LastPredefined.FontName = "\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_java.Styles.LineNumber.FontName = "\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_java.Styles.Max.FontName = "\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.textbox_java.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 582);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button_openFolder);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.checkBox_autoOpen);
            this.Controls.Add(this.button_compile);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.textbox_ws)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textbox_html)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tab1HTML.ResumeLayout(false);
            this.tab1CSS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textbox_css)).EndInit();
            this.tab1Web.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tab2WSharp.ResumeLayout(false);
            this.tab2Java.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textbox_java)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScintillaNET.Scintilla textbox_ws;
        private ScintillaNET.Scintilla textbox_html;
        private System.Windows.Forms.Button button_compile;
        private System.Windows.Forms.CheckBox checkBox_autoOpen;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab1HTML;
        private System.Windows.Forms.TabPage tab1Web;
        private System.Windows.Forms.WebBrowser webBrowserHTML;
        private System.Windows.Forms.TabPage tab1CSS;
        private ScintillaNET.Scintilla textbox_css;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_openFolder;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab2WSharp;
        private System.Windows.Forms.TabPage tab2Java;
        private ScintillaNET.Scintilla textbox_java;
        private System.Windows.Forms.TabPage tab2PHP;
    }
}

