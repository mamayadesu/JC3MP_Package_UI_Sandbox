namespace JC3MP_Package_UI_Sandbox
{
    public partial class Form2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reloadpackage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.debug = new System.Windows.Forms.Button();
            this.selectFile = new System.Windows.Forms.Button();
            this.closeSandbox = new System.Windows.Forms.Button();
            this.opacityInactive = new System.Windows.Forms.CheckBox();
            this.overMainWindow = new System.Windows.Forms.CheckBox();
            this.fullScreen = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.eventsList = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.selectascript = new System.Windows.Forms.Button();
            this.openascript = new System.Windows.Forms.Button();
            this.unsetascript = new System.Windows.Forms.Button();
            this.ascriptpath = new System.Windows.Forms.TextBox();
            this.noauxiliaryscript = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.fastcallbuttons = new System.Windows.Forms.ListBox();
            this.nofastcallbuttons = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(284, 262);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reloadpackage);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.debug);
            this.tabPage1.Controls.Add(this.selectFile);
            this.tabPage1.Controls.Add(this.closeSandbox);
            this.tabPage1.Controls.Add(this.opacityInactive);
            this.tabPage1.Controls.Add(this.overMainWindow);
            this.tabPage1.Controls.Add(this.fullScreen);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(276, 236);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reloadpackage
            // 
            this.reloadpackage.Location = new System.Drawing.Point(9, 176);
            this.reloadpackage.Name = "reloadpackage";
            this.reloadpackage.Size = new System.Drawing.Size(125, 23);
            this.reloadpackage.TabIndex = 8;
            this.reloadpackage.Text = "Reload package";
            this.reloadpackage.UseVisualStyleBackColor = true;
            this.reloadpackage.Click += new System.EventHandler(this.reloadpackage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "debugging menu";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(5, 46);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(113, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://localhost:13173";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // debug
            // 
            this.debug.Location = new System.Drawing.Point(140, 36);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(128, 23);
            this.debug.TabIndex = 5;
            this.debug.Text = "isn\'t used anymore";
            this.debug.UseVisualStyleBackColor = true;
            this.debug.Visible = false;
            this.debug.Click += new System.EventHandler(this.debug_Click);
            // 
            // selectFile
            // 
            this.selectFile.Location = new System.Drawing.Point(160, 7);
            this.selectFile.Name = "selectFile";
            this.selectFile.Size = new System.Drawing.Size(108, 23);
            this.selectFile.TabIndex = 4;
            this.selectFile.Text = "Select package";
            this.selectFile.UseVisualStyleBackColor = true;
            this.selectFile.Click += new System.EventHandler(this.selectFile_Click);
            // 
            // closeSandbox
            // 
            this.closeSandbox.Location = new System.Drawing.Point(7, 205);
            this.closeSandbox.Name = "closeSandbox";
            this.closeSandbox.Size = new System.Drawing.Size(127, 23);
            this.closeSandbox.TabIndex = 3;
            this.closeSandbox.Text = "Close Sandbox";
            this.closeSandbox.UseVisualStyleBackColor = true;
            this.closeSandbox.Click += new System.EventHandler(this.closeSandbox_Click);
            // 
            // opacityInactive
            // 
            this.opacityInactive.AutoSize = true;
            this.opacityInactive.Checked = true;
            this.opacityInactive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.opacityInactive.Location = new System.Drawing.Point(8, 88);
            this.opacityInactive.Name = "opacityInactive";
            this.opacityInactive.Size = new System.Drawing.Size(184, 17);
            this.opacityInactive.TabIndex = 2;
            this.opacityInactive.Text = "Change opacity when it\'s inactive";
            this.opacityInactive.UseVisualStyleBackColor = true;
            this.opacityInactive.CheckedChanged += new System.EventHandler(this.opacityInactive_CheckedChanged);
            // 
            // overMainWindow
            // 
            this.overMainWindow.AutoSize = true;
            this.overMainWindow.Checked = true;
            this.overMainWindow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.overMainWindow.Location = new System.Drawing.Point(8, 65);
            this.overMainWindow.Name = "overMainWindow";
            this.overMainWindow.Size = new System.Drawing.Size(113, 17);
            this.overMainWindow.TabIndex = 1;
            this.overMainWindow.Text = "Over main window";
            this.overMainWindow.UseVisualStyleBackColor = true;
            this.overMainWindow.CheckedChanged += new System.EventHandler(this.overMainWindow_CheckedChanged);
            // 
            // fullScreen
            // 
            this.fullScreen.Location = new System.Drawing.Point(7, 7);
            this.fullScreen.Name = "fullScreen";
            this.fullScreen.Size = new System.Drawing.Size(127, 23);
            this.fullScreen.TabIndex = 0;
            this.fullScreen.Text = "Go to fullscreen";
            this.fullScreen.UseVisualStyleBackColor = true;
            this.fullScreen.Click += new System.EventHandler(this.fullScreen_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.eventsList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(276, 236);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Events";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // eventsList
            // 
            this.eventsList.FormattingEnabled = true;
            this.eventsList.Location = new System.Drawing.Point(0, 0);
            this.eventsList.Name = "eventsList";
            this.eventsList.Size = new System.Drawing.Size(276, 238);
            this.eventsList.TabIndex = 0;
            this.eventsList.Tag = "";
            this.eventsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.eventsList_MouseDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.selectascript);
            this.tabPage3.Controls.Add(this.openascript);
            this.tabPage3.Controls.Add(this.unsetascript);
            this.tabPage3.Controls.Add(this.ascriptpath);
            this.tabPage3.Controls.Add(this.noauxiliaryscript);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(276, 236);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Auxiliary Script";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // selectascript
            // 
            this.selectascript.Location = new System.Drawing.Point(12, 35);
            this.selectascript.Name = "selectascript";
            this.selectascript.Size = new System.Drawing.Size(117, 23);
            this.selectascript.TabIndex = 5;
            this.selectascript.Text = "Select auxiliary script";
            this.selectascript.UseVisualStyleBackColor = true;
            this.selectascript.Click += new System.EventHandler(this.selectascript_Click);
            // 
            // openascript
            // 
            this.openascript.Location = new System.Drawing.Point(12, 118);
            this.openascript.Name = "openascript";
            this.openascript.Size = new System.Drawing.Size(117, 23);
            this.openascript.TabIndex = 4;
            this.openascript.Text = "Open file";
            this.openascript.UseVisualStyleBackColor = true;
            this.openascript.Click += new System.EventHandler(this.openascript_Click);
            // 
            // unsetascript
            // 
            this.unsetascript.Location = new System.Drawing.Point(12, 75);
            this.unsetascript.Name = "unsetascript";
            this.unsetascript.Size = new System.Drawing.Size(117, 23);
            this.unsetascript.TabIndex = 3;
            this.unsetascript.Text = "Unset";
            this.unsetascript.UseVisualStyleBackColor = true;
            this.unsetascript.Click += new System.EventHandler(this.unsetascript_Click);
            // 
            // ascriptpath
            // 
            this.ascriptpath.BackColor = System.Drawing.Color.White;
            this.ascriptpath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ascriptpath.Location = new System.Drawing.Point(9, 7);
            this.ascriptpath.Name = "ascriptpath";
            this.ascriptpath.ReadOnly = true;
            this.ascriptpath.Size = new System.Drawing.Size(259, 13);
            this.ascriptpath.TabIndex = 2;
            // 
            // noauxiliaryscript
            // 
            this.noauxiliaryscript.AutoSize = true;
            this.noauxiliaryscript.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noauxiliaryscript.Location = new System.Drawing.Point(9, 7);
            this.noauxiliaryscript.Name = "noauxiliaryscript";
            this.noauxiliaryscript.Size = new System.Drawing.Size(42, 13);
            this.noauxiliaryscript.TabIndex = 0;
            this.noauxiliaryscript.Text = "isn\'t set";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.fastcallbuttons);
            this.tabPage4.Controls.Add(this.nofastcallbuttons);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(276, 236);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Fast Call";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // fastcallbuttons
            // 
            this.fastcallbuttons.FormattingEnabled = true;
            this.fastcallbuttons.Location = new System.Drawing.Point(0, 0);
            this.fastcallbuttons.Name = "fastcallbuttons";
            this.fastcallbuttons.Size = new System.Drawing.Size(276, 238);
            this.fastcallbuttons.TabIndex = 1;
            this.fastcallbuttons.Tag = "";
            this.fastcallbuttons.Visible = false;
            this.fastcallbuttons.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.fastcallbuttons_MouseDoubleClick);
            // 
            // nofastcallbuttons
            // 
            this.nofastcallbuttons.AutoSize = true;
            this.nofastcallbuttons.Location = new System.Drawing.Point(9, 7);
            this.nofastcallbuttons.Name = "nofastcallbuttons";
            this.nofastcallbuttons.Size = new System.Drawing.Size(236, 13);
            this.nofastcallbuttons.TabIndex = 0;
            this.nofastcallbuttons.Text = "This auxiliary script doesn\'t have fast call buttons";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.linkLabel5);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.linkLabel4);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.linkLabel3);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.linkLabel2);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(276, 236);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "About";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(253, 26);
            this.label12.TabIndex = 15;
            this.label12.Text = "help you in development of packages. Now there is\r\nno need to start JC3-MP. Testi" +
    "ngs can be held here.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(185, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "is tool which will";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(9, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "JC3MP Package UI Sandbox";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(146, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "1.0.0 (25.11.2017)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Version";
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(83, 184);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(157, 13);
            this.linkLabel5.TabIndex = 10;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "http://github.com/mamayadesu";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Github";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(100, 156);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(140, 13);
            this.linkLabel4.TabIndex = 8;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "http://vk.com/id155272407";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "VK";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(83, 128);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(157, 13);
            this.linkLabel3.TabIndex = 5;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "/profiles/76561198134749699/";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Steam";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(113, 100);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(127, 13);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "mamayadesu@gmail.com";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "E-Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "MamayAdesu/xRef";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Author";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "index.html";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control";
            this.Activated += new System.EventHandler(this.Form2_Activated);
            this.Deactivate += new System.EventHandler(this.Form2_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button fullScreen;
        private System.Windows.Forms.CheckBox overMainWindow;
        private System.Windows.Forms.CheckBox opacityInactive;
        private System.Windows.Forms.Button closeSandbox;
        public System.Windows.Forms.ListBox eventsList;
        private System.Windows.Forms.Button selectFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.Button debug;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        public System.Windows.Forms.Button selectascript;
        public System.Windows.Forms.Button openascript;
        public System.Windows.Forms.Button unsetascript;
        public System.Windows.Forms.TextBox ascriptpath;
        public System.Windows.Forms.Label noauxiliaryscript;
        private System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.Button reloadpackage;
        public System.Windows.Forms.Label nofastcallbuttons;
        public System.Windows.Forms.ListBox fastcallbuttons;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;

    }
}