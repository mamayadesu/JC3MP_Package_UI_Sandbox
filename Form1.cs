using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

// CefSharp
using CefSharp;
using CefSharp.WinForms;
using CefSharp.Internals;

namespace JC3MP_Package_UI_Sandbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private string uri;
        public ChromiumWebBrowser ui;
        FormBorderStyle DefaultFormBorderStyle;
        FormWindowState DefaultWindowState;
        public bool inFullScreen = false;
        public bool isFirstTime = true;
        public bool isCallEventWindowOpened = false;
        public bool isDebuggingMenuOpened = false;
        public Form4 as_;
        public Form3 callEventWindow;
        public Form2 control;
        public string pathToHomepage;
        public string pathToTempIAS;
        public string pathToTempAS;
        public JCMPNamespace jcmp;
        public JCMPServerClient jcmpsc;
        public Color defaultColor = System.Drawing.Color.LightGray;
        public AuxiliaryScripts aScripts;
        public bool asfleFirstTime = true;
        public string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\";

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(String sClassName, String sAppName);

        public string GetURI()
        {
            return this.uri;
        }

        public void SetURI(string value)
        {
            this.uri = value;
            if (!File.Exists(value))
            {
                ERR("File '" + value + "' could not be found.", "Failed to open package");
                return;
            }
            if (value == this.pathToHomepage)
            {
                this.Text = "JC3-MP Package UI Sandbox";
                this.control.reloadpackage.Enabled = false;
            }
            else
            {
                this.Text = "\"" + value + "\" | JC3-MP Package UI Sandbox";
                this.control.reloadpackage.Enabled = true;
            }
            if (this.isCallEventWindowOpened == true)
            {
                this.callEventWindow.Close();
            }
            this.control.selectascript.Enabled = value != this.pathToHomepage;
            bool hasAscript = this.aScripts.HasAuxiliaryScript(value);
            this.control.noauxiliaryscript.Visible = !hasAscript;
            this.control.unsetascript.Enabled = this.control.openascript.Enabled = this.control.ascriptpath.Visible = hasAscript;
            if (hasAscript)
            {
                this.control.ascriptpath.Text = this.aScripts.GetAuxiliaryScriptPath(value);
            }
            else
            {
                this.control.ascriptpath.Text = "";
            }
            if (this.isFirstTime)
            {
                this.isFirstTime = false;
                return;
            }
            control.eventsList.Items.Clear();
            this.jcmp.events.Clear();
            this.jcmpsc.events.Clear();
            jcmpsc.fastCallButtons = new Dictionary<string, IJavascriptCallback>();
            control.fastcallbuttons.Items.Clear();
            control.fastcallbuttons.Visible = false;
            control.nofastcallbuttons.Visible = true;
            if (hasAscript)
            {
                this.as_.L(value);
                return;
            }
            ui.Load(value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(exePath + "debug.log"))
            {
                try
                {
                    File.Delete(exePath + "debug.log");
                }
                catch
                {

                }
            }
            this.control = new Form2(this);
            this.control.Show();
        }

        public void Form2_Load()
        {
            // When Form2 is loaded
            string tmp1 = Path.GetTempFileName();
            File.Delete(tmp1);
            string[] tmp2 = tmp1.Split('\\');
            tmp2[tmp2.Length - 1] = "";
            string tmp = String.Join("\\", tmp2);
            tmp += "jc3mpuipackagesandbox\\";
            string appData = this.GetAppDataPath();
            if (!Directory.Exists(appData))
            {
                Directory.CreateDirectory(appData);
            }
            if (!Directory.Exists(tmp))
            {
                Directory.CreateDirectory(tmp);
            }
            this.pathToHomepage = appData + "homepage.html";
            this.pathToTempIAS = tmp + "index.html";
            this.pathToTempAS = tmp + "as.js";
            if (!File.Exists(this.pathToHomepage))
            {
                File.WriteAllText(this.pathToHomepage, Properties.Resources.home);
            }
            if (!File.Exists(this.pathToTempIAS) || File.ReadAllText(this.pathToTempIAS) != Properties.Resources.ias)
            {
                File.WriteAllText(this.pathToTempIAS, Properties.Resources.ias);
            }
            if (!File.Exists(this.pathToTempAS) || File.ReadAllText(this.pathToTempAS) != Properties.Resources._as)
            {
                File.WriteAllText(this.pathToTempAS, Properties.Resources._as);
            }
            this.aScripts = new AuxiliaryScripts(this);
            this.aScripts.Load();
            panel1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
            
            this.SetURI(this.pathToHomepage);
            this.DefaultFormBorderStyle = this.FormBorderStyle;
            this.DefaultWindowState = this.WindowState;
            
            CefSettings uiSettings = new CefSettings();
            uiSettings.RemoteDebuggingPort = 13173;
            BrowserSettings browserSettings = new BrowserSettings();
            browserSettings.BackgroundColor = ColorToUint(defaultColor);
            Cef.Initialize(uiSettings);

            ui = new ChromiumWebBrowser(this.uri);
            ui.BrowserSettings = browserSettings;
            panel1.Controls.Add(ui);
            ui.Dock = DockStyle.Fill;
            
            BindingOptions options = new BindingOptions();
            options.CamelCaseJavascriptNames = false;
            this.jcmp = new JCMPNamespace(this, this.control);
            this.jcmpsc = new JCMPServerClient(this);
            ui.RegisterJsObject("jcmp", this.jcmp, options);

            this.as_ = new Form4(this);
            this.as_.Show();
        }

        public string GetAppDataPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\JC3MP_Package_UI_Sandbox\\";
        }

        public uint ColorToUint(System.Drawing.Color c)
        {
            return (uint)(((c.A << 24) | (c.R << 16) | (c.G << 8) | c.B) & 0xffffffffL);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            panel1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
        }

        public void jsEval(string code)
        {
            ui.ExecuteScriptAsync(code);
        }

        public void SetFullScreen(bool set)
        {
            if (set)
            {
                //this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                //this.TopMost = false;
                this.FormBorderStyle = this.DefaultFormBorderStyle;
                this.WindowState = this.DefaultWindowState;
            }
            this.inFullScreen = set;
        }

        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            //MessageBox.Show(Convert.ToString(e.KeyCode));
            if (e.KeyCode == Keys.F11)
            {
                this.SetFullScreen(!this.inFullScreen);
            }
        }

        public void HideCursor()
        {
            Cursor.Hide();
        }

        public void ShowCursor()
        {
            Cursor.Show();
        }

        public void MB(string text, string title = "")
        {
            MessageBox.Show(text, title);
        }

        public void ERR(string text, string title = "Error")
        {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (File.Exists(exePath + "debug.log"))
            {
                try
                {
                    File.Delete(exePath + "debug.log");
                }
                catch
                {

                }
            }
        }
    }
}
