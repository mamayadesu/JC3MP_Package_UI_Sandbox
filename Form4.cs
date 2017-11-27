using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using CefSharp.Internals;
using System.IO;

namespace JC3MP_Package_UI_Sandbox
{
    public partial class Form4 : Form
    {
        public Form4(Form1 mainForm)
        {
            InitializeComponent();
            this.mainWindow = mainForm;
        }

        public ChromiumWebBrowser browser;
        Form1 mainWindow;
        public bool fle = true;
        public bool ac = true;
        public string lastUrl = "";

        private void Form4_Load(object sender, EventArgs e)
        {
            panel1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
            
            this.browser = new ChromiumWebBrowser(mainWindow.pathToTempIAS);
            panel1.Controls.Add(this.browser);
            this.browser.Dock = DockStyle.Fill;
            this.browser.FrameLoadEnd += browser_FrameLoadEnd;
            this.WindowState = FormWindowState.Minimized;

            BindingOptions options = new BindingOptions();
            options.CamelCaseJavascriptNames = false;
            this.browser.RegisterJsObject("jcmp", mainWindow.jcmpsc, options);
        }

        public void L(string mainScript)
        {
            if (!mainWindow.aScripts.HasAuxiliaryScript(mainScript))
            {
                return;
            }
            string ascriptpath = mainWindow.aScripts.GetAuxiliaryScriptPath(mainScript);
            if (!File.Exists(ascriptpath))
            {
                mainWindow.ERR("Auxiliary file " + ascriptpath + " not found!");
                mainWindow.ui.Load(mainWindow.GetURI());
                this.lastUrl = ascriptpath;
                return;
            }
            string ascript = File.ReadAllText(ascriptpath);
            File.WriteAllText(mainWindow.pathToTempAS, Properties.Resources._as + ascript);
            this.lastUrl = ascriptpath;
            this.browser.Load(mainWindow.pathToTempIAS);
        }

        void browser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            if (this.fle)
            {
                this.fle = false;
                return;
            }
            string uri = mainWindow.GetURI();
            if (this.lastUrl == mainWindow.aScripts.GetAuxiliaryScriptPath(uri))
            {
                mainWindow.ui.Load(uri);
            }
        }

        private void Form4_SizeChanged(object sender, EventArgs e)
        {
            panel1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
