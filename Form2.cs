using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using CefSharp;
using CefSharp.Internals;

namespace JC3MP_Package_UI_Sandbox
{
    public partial class Form2 : Form
    {
        public Form2(Form1 mainForm)
        {
            InitializeComponent();
            this.mainWindow = mainForm;
        }

        Form1 mainWindow;
        const double INACTIVE_OPACITY = 0.25;
        double inactiveOpacity = INACTIVE_OPACITY;
        bool isActive = false;

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.MaximizeBox = false;
            mainWindow.Form2_Load();
        }

        private void fullScreen_Click(object sender, EventArgs e)
        {
            if (mainWindow.inFullScreen)
            {
                fullScreen.Text = "Go to fullscreen";
            }
            else
            {
                fullScreen.Text = "Out from fullscreen";
            }
            mainWindow.SetFullScreen(!mainWindow.inFullScreen);
                
        }

        private void overMainWindow_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = overMainWindow.Checked;
        }

        private void opacityInactive_CheckedChanged(object sender, EventArgs e)
        {
            if (opacityInactive.Checked)
            {
                this.inactiveOpacity = INACTIVE_OPACITY;
            }
            else
            {
                this.inactiveOpacity = 1;
            }
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            this.isActive = true;
            this.Opacity = 1;
        }

        private void Form2_Deactivate(object sender, EventArgs e)
        {
            this.isActive = false;
            this.Opacity = this.inactiveOpacity;
        }

        private void closeSandbox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void selectFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                string text;
                try
                {
                    text = File.ReadAllText(file);
                    mainWindow.SetURI(file);
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Failed to open file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void eventsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string item;

            try
            {
                item = eventsList.Items[eventsList.IndexFromPoint(e.Location)].ToString();
            }
            catch
            {
                return;
            }
            
            if (mainWindow.isCallEventWindowOpened == true)
            {
                mainWindow.callEventWindow.Close();
            }
            mainWindow.callEventWindow = new Form3(mainWindow, item);
            mainWindow.callEventWindow.Show();
            mainWindow.isCallEventWindowOpened = true;
        }

        private void debug_Click(object sender, EventArgs e)
        {
            /*if (mainWindow.isDebuggingMenuOpened)
            {
                debug.Enabled = false;
                return;
            }
            mainWindow.debuggingMenu = new Form4(mainWindow);
            mainWindow.debuggingMenu.Show();
            mainWindow.isDebuggingMenuOpened = true;
            debug.Enabled = false;*/
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost:13173");
        }
        private void selectascript_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "Javascript|*.js|All Files|*.*";
            DialogResult result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog2.FileName;
                mainWindow.aScripts.SetPathToAuxiliaryScript(mainWindow.GetURI(), file);
                mainWindow.aScripts.Save();
                MessageBox.Show("Reload a package that changes have come into force.", "All OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void unsetascript_Click(object sender, EventArgs e)
        {
            mainWindow.aScripts.UnsetPathToAuxiliaryScript(mainWindow.GetURI());
            mainWindow.aScripts.Save();
            MessageBox.Show("Reload a package that changes have come into force.", "All OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void openascript_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(mainWindow.aScripts.GetAuxiliaryScriptPath(mainWindow.GetURI()));
        }

        private void reloadpackage_Click(object sender, EventArgs e)
        {
            mainWindow.SetURI(mainWindow.GetURI());
        }

        private void fastcallbuttons_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string item;
            try
            {
                item = fastcallbuttons.Items[fastcallbuttons.IndexFromPoint(e.Location)].ToString();
            }
            catch
            {
                return;
            }
            if (!mainWindow.jcmpsc.fastCallButtons.ContainsKey(item))
            {
                return;
            }
            
            IJavascriptCallback callback;

            mainWindow.jcmpsc.fastCallButtons.TryGetValue(item, out callback);

            callback.ExecuteAsync();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:mamayadesu@gmail.com");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://steamcommunity.com/profiles/76561198134749699/");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://vk.com/id155272407");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/mamayadesu");
        }
    }
}
