using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using CefSharp.Internals;

namespace JC3MP_Package_UI_Sandbox
{
    public class JCMPServerClient
    {
        public JCMPServerClient(Form1 mainForm)
        {
            this.mainWindow = mainForm;
            this.control = mainForm.control;
        }

        Form1 mainWindow;
        Form2 control;
        public Dictionary<string, IJavascriptCallback> events = new Dictionary<string, IJavascriptCallback>();
        public Dictionary<string, IJavascriptCallback> fastCallButtons = new Dictionary<string, IJavascriptCallback>();

        delegate void AddFastCallButtonDelegated(string name, IJavascriptCallback callback);

        public void AddEvent(string eventName, IJavascriptCallback callback)
        {
            this.events.Add(eventName, callback);
        }

        public void CallEvent(string eventName, params Object[] args)
        {
            if (!mainWindow.jcmp.events.ContainsKey(eventName))
            {
                return;
            }
            IJavascriptCallback callback;
            mainWindow.jcmp.events.TryGetValue(eventName, out callback);
            callback.ExecuteAsync(args);
        }

        public void Execute(string code)
        {
            mainWindow.ui.ExecuteScriptAsync(code);
        }

        public void AddFastCallButton(string name, IJavascriptCallback callback)
        {
            if (this.control.fastcallbuttons.InvokeRequired)
            {
                AddFastCallButtonDelegated d = new AddFastCallButtonDelegated(AddFastCallButton);
                this.control.Invoke(d, new object[] { name, callback });
                return;
            }

            if (this.fastCallButtons.ContainsKey(name))
            {
                mainWindow.as_.browser.ExecuteScriptAsync("console.error('Fast Call button with name '" + name.Replace("'", "\\'") + "' already exists.');");
                return;
            }

            mainWindow.control.nofastcallbuttons.Visible = false;
            mainWindow.control.fastcallbuttons.Visible = true;
            this.fastCallButtons.Add(name, callback);
            mainWindow.control.fastcallbuttons.Items.Add(name);
        }
    }
}
