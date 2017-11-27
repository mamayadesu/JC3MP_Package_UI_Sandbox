using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using CefSharp;
using CefSharp.Internals;

namespace JC3MP_Package_UI_Sandbox
{
    public class JCMPNamespace
    {
        public Dictionary<string, IJavascriptCallback> events = new Dictionary<string, IJavascriptCallback>();
        public JCMPNamespace(Form1 mainForm, Form2 form2)
        {
            this.mainWindow = mainForm;
            this.control = form2;
        }

        Form1 mainWindow;
        Form2 control;

        delegate void AddEventDelegated(string eventName, IJavascriptCallback callback);

        public void CallEvent(string eventName, params Object[] args)
        {
            if (!mainWindow.jcmpsc.events.ContainsKey(eventName))
            {
                return;
            }
            IJavascriptCallback callback;
            mainWindow.jcmpsc.events.TryGetValue(eventName, out callback);
            callback.ExecuteAsync(args);
        }

        public void AddEvent(string eventName, IJavascriptCallback callback)
        {
            if (this.control.eventsList.InvokeRequired)
            {
                AddEventDelegated d = new AddEventDelegated(AddEvent);
                this.control.Invoke(d, new object[] { eventName, callback });
                return;
            }
            this.events.Add(eventName, callback);
            this.control.eventsList.Items.Add(eventName);
        }

        public void HideCursor()
        {
            mainWindow.HideCursor();
        }

        public void ShowCursor()
        {
            mainWindow.ShowCursor();
        }
    }
}
