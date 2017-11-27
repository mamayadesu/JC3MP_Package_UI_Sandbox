using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JC3MP_Package_UI_Sandbox
{
    public class AuxiliaryScripts
    {
        public AuxiliaryScripts(Form1 mainForm)
        {
            this.mainWindow = mainForm;
        }

        Form1 mainWindow;
        private Dictionary<string, string> paths = new Dictionary<string, string>();

        public void Load()
        {
            string path = this.mainWindow.GetAppDataPath() + "auxiliaryscripts";
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "");
            }
            string content = File.ReadAllText(path);
            content = content.Replace("\r", "");
            if (content == "")
            {
                return;
            }
            string[] arr = content.Split('\n');
            string[] keyValue;
            int c = 0;
            foreach (string line in arr)
            {
                c++;
                if (line.StartsWith("#") || line == "")
                {
                    continue;
                }
                keyValue = line.Split('|');
                if (keyValue.Length != 2)
                {
                    mainWindow.ERR("Failed to parse " + c + " line in scripts-injectors list!");
                    continue;
                }
                this.paths.Add(keyValue[0], keyValue[1]);
            }
        }

        public void SetPathToAuxiliaryScript(string mainScript, string auxiliaryScript)
        {
            if (this.paths.ContainsKey(mainScript))
            {
                this.paths[mainScript] = auxiliaryScript;
            }
            else
            {
                this.paths.Add(mainScript, auxiliaryScript);
            }
            mainWindow.control.noauxiliaryscript.Visible = false;
            mainWindow.control.unsetascript.Enabled = mainWindow.control.openascript.Enabled = mainWindow.control.ascriptpath.Visible = true;
            mainWindow.control.ascriptpath.Text = auxiliaryScript;
        }

        public void UnsetPathToAuxiliaryScript(string mainScript)
        {
            if (this.paths.ContainsKey(mainScript))
            {
                this.paths.Remove(mainScript);
            }
            mainWindow.control.noauxiliaryscript.Visible = true;
            mainWindow.control.unsetascript.Enabled = mainWindow.control.openascript.Enabled = mainWindow.control.ascriptpath.Visible = false;
            mainWindow.control.ascriptpath.Text = "";
        }

        public Dictionary<string, string> GetAuxiliaryScripts()
        {
            return this.paths;
        }

        public bool HasAuxiliaryScript(string mainScript)
        {
            return this.paths.ContainsKey(mainScript);
        }

        public string GetAuxiliaryScriptPath(string mainScript)
        {
            string auxiliary = "";
            if (!this.paths.ContainsKey(mainScript))
            {
                return auxiliary;
            }
            
            this.paths.TryGetValue(mainScript, out auxiliary);
            return auxiliary;
        }

        public void Save()
        {
            string output = "";
            bool isFirstLine = true;
            foreach (KeyValuePair<string, string> item in this.paths)
            {
                if (!isFirstLine)
                {
                    output += Environment.NewLine + item.Key + "|" + item.Value;
                }
                else
                {
                    output += item.Key + "|" + item.Value;
                    isFirstLine = false;
                }
            }
            File.WriteAllText(this.mainWindow.GetAppDataPath() + "auxiliaryscripts", output);
        }
    }
}
