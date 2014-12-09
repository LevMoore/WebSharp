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
            this.tabHTML = new System.Windows.Forms.TabPage();
            this.tabCSS = new System.Windows.Forms.TabPage();
            this.textbox_css = new ScintillaNET.Scintilla();
            this.tabWeb = new System.Windows.Forms.TabPage();
            this.webBrowserHTML = new System.Windows.Forms.WebBrowser();
            this.button_save = new System.Windows.Forms.Button();
            this.button_openFolder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.textbox_ws)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textbox_html)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabHTML.SuspendLayout();
            this.tabCSS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textbox_css)).BeginInit();
            this.tabWeb.SuspendLayout();
            this.SuspendLayout();
            // 
            // textbox_ws
            // 
            this.textbox_ws.AutoComplete.ListString = "";
            this.textbox_ws.AutoComplete.MaxHeight = 10;
            this.textbox_ws.ConfigurationManager.CustomLocation = "ScintillaNET.xml";
            this.textbox_ws.ConfigurationManager.Language = "cs";
            this.textbox_ws.Folding.IsEnabled = false;
            this.textbox_ws.Location = new System.Drawing.Point(568, 32);
            this.textbox_ws.Margins.Margin2.IsClickable = false;
            this.textbox_ws.Margins.Margin2.IsFoldMargin = false;
            this.textbox_ws.Name = "textbox_ws";
            this.textbox_ws.Scrolling.HorizontalScrollTracking = false;
            this.textbox_ws.Scrolling.HorizontalScrollWidth = 2000;
            this.textbox_ws.Size = new System.Drawing.Size(542, 512);
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
            this.tabControl.Controls.Add(this.tabHTML);
            this.tabControl.Controls.Add(this.tabCSS);
            this.tabControl.Controls.Add(this.tabWeb);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(550, 534);
            this.tabControl.TabIndex = 4;
            this.tabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabHTML_Selecting);
            // 
            // tabHTML
            // 
            this.tabHTML.Controls.Add(this.textbox_html);
            this.tabHTML.Location = new System.Drawing.Point(4, 22);
            this.tabHTML.Name = "tabHTML";
            this.tabHTML.Padding = new System.Windows.Forms.Padding(3);
            this.tabHTML.Size = new System.Drawing.Size(542, 508);
            this.tabHTML.TabIndex = 0;
            this.tabHTML.Text = "HTML";
            this.tabHTML.UseVisualStyleBackColor = true;
            // 
            // tabCSS
            // 
            this.tabCSS.Controls.Add(this.textbox_css);
            this.tabCSS.Location = new System.Drawing.Point(4, 22);
            this.tabCSS.Name = "tabCSS";
            this.tabCSS.Padding = new System.Windows.Forms.Padding(3);
            this.tabCSS.Size = new System.Drawing.Size(542, 508);
            this.tabCSS.TabIndex = 2;
            this.tabCSS.Text = "CSS";
            this.tabCSS.UseVisualStyleBackColor = true;
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
            // tabWeb
            // 
            this.tabWeb.Controls.Add(this.webBrowserHTML);
            this.tabWeb.Location = new System.Drawing.Point(4, 22);
            this.tabWeb.Name = "tabWeb";
            this.tabWeb.Padding = new System.Windows.Forms.Padding(3);
            this.tabWeb.Size = new System.Drawing.Size(542, 508);
            this.tabWeb.TabIndex = 1;
            this.tabWeb.Text = "Preview";
            this.tabWeb.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 582);
            this.Controls.Add(this.button_openFolder);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.checkBox_autoOpen);
            this.Controls.Add(this.button_compile);
            this.Controls.Add(this.textbox_ws);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.textbox_ws)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textbox_html)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabHTML.ResumeLayout(false);
            this.tabCSS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textbox_css)).EndInit();
            this.tabWeb.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScintillaNET.Scintilla textbox_ws;
        private ScintillaNET.Scintilla textbox_html;
        private System.Windows.Forms.Button button_compile;
        private System.Windows.Forms.CheckBox checkBox_autoOpen;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabHTML;
        private System.Windows.Forms.TabPage tabWeb;
        private System.Windows.Forms.WebBrowser webBrowserHTML;
        private System.Windows.Forms.TabPage tabCSS;
        private ScintillaNET.Scintilla textbox_css;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_openFolder;
    }
}

