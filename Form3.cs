using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using CefSharp;
using CefSharp.Internals;

namespace JC3MP_Package_UI_Sandbox
{
    public partial class Form3 : Form
    {
        public Form3(Form1 mainForm, string eventName)
        {
            InitializeComponent();
            this.mainWindow = mainForm;
            this.Text = "Call event \"" + eventName + "\"";
            this.eventName = eventName;
        }

        public Form1 mainWindow;
        private List<List<object>> events = new List<List<object>>();
        private string eventName;

        private void addButton_Click(object sender, EventArgs e)
        {
            Label newLabel = new System.Windows.Forms.Label();
            newLabel.AutoSize = true;
            newLabel.Location = new System.Drawing.Point(12, 50 + this.events.Count * 64);
            newLabel.Name = "eventLabel" + (this.events.Count + 1);
            newLabel.Size = new System.Drawing.Size(20, 13);
            newLabel.Text = "#" + (this.events.Count + 1);
            panel1.Controls.Add(newLabel);

            TextBox newTextBox = new System.Windows.Forms.TextBox();
            newTextBox.Location = new System.Drawing.Point(13, 66 + this.events.Count * 64);
            newTextBox.Name = "eventTextBox" + (this.events.Count + 1);
            newTextBox.Size = new System.Drawing.Size(77, 20);
            newTextBox.TabIndex = 2;
            newTextBox.Leave += tb_check;
            newTextBox.KeyDown += window_KeyDown;
            panel1.Controls.Add(newTextBox);

            ComboBox newComboBox = new System.Windows.Forms.ComboBox();
            newComboBox.FormattingEnabled = true;
            newComboBox.Items.AddRange(new object[] {
            "string",
            "int",
            "double",
            "boolean"});
            newComboBox.Location = new System.Drawing.Point(96, 65 + this.events.Count * 64);
            newComboBox.Name = "eventComboBox" + (this.events.Count + 1);
            newComboBox.Size = new System.Drawing.Size(121, 21);
            newComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            newComboBox.TextChanged += tb_check;
            newComboBox.SelectedIndex = 0;
            panel1.Controls.Add(newComboBox);

            remove.Location = new System.Drawing.Point(225, 68 + this.events.Count * 64);
            remove.Visible = true;

            List<object> el = new List<object>();
            el.Add(newLabel);
            el.Add(newTextBox);
            el.Add(newComboBox);
            this.events.Add(el);
        }

        public string GetEventName()
        {
            return this.eventName;
        }

        private void tb_check(object sender, EventArgs e)
        {
            this.tb_check();
        }

        private void tb_check()
        {
            List<object> el;
            TextBox tb;
            ComboBox cb;
            int _int;
            double _double;
            for (int i = 0; i < this.events.Count; i++)
            {
                el = this.events[i];
                tb = (TextBox)el[1];
                cb = (ComboBox)el[2];

                if (cb.Text == "int")
                {
                    try
                    {
                        _int = Convert.ToInt32(tb.Text);
                    }
                    catch (FormatException ex)
                    {
                        _int = 0;
                    }
                    tb.Text = Convert.ToString(_int);
                }
                else if (cb.Text == "double")
                {
                    try
                    {
                        _double = Convert.ToDouble(tb.Text);
                    }
                    catch (FormatException ex)
                    {
                        _double = 0.00;
                    }
                    tb.Text = Convert.ToString(_double);
                }
                else if (cb.Text == "boolean")
                {
                    if (tb.Text != "true" && tb.Text != "false")
                    {
                        tb.Text = "true";
                    }
                }
            }
        }

        private void callEventButton_Click(object sender, EventArgs e)
        {
            if (mainWindow.jcmp.events.ContainsKey(this.eventName))
            {
                this.callEvent();
            }
        }

        private void callEvent()
        {
            IJavascriptCallback callback;
            mainWindow.jcmp.events.TryGetValue(this.eventName, out callback);
            List<object> args = new List<object>();
            Label lb;
            TextBox tb;
            ComboBox cb;
            string _string;
            int _int;
            double _double;
            bool _bool;
            for (int i = 0; i < this.events.Count; i++)
            {
                lb = (Label)this.events[i][0];
                tb = (TextBox)this.events[i][1];
                cb = (ComboBox)this.events[i][2];
                if (cb.Text == "int")
                {
                    try
                    {
                        _int = Convert.ToInt32(tb.Text);
                    }
                    catch (FormatException ex)
                    {
                        _int = 0;
                    }
                    args.Add(_int);
                }
                else if (cb.Text == "double")
                {
                    try
                    {
                        _double = Convert.ToDouble(tb.Text);
                    }
                    catch (FormatException ex)
                    {
                        _double = 0;
                    }
                    args.Add(_double);
                }
                else if (cb.Text == "boolean")
                {
                    if (tb.Text != "true" && tb.Text != "false")
                    {
                        tb.Text = "true";
                    }
                    _bool = tb.Text == "true";
                    args.Add(_bool);
                }
                else
                {
                    _string = tb.Text;
                    args.Add(_string);
                }
            }
            callback.ExecuteAsync(args.ToArray());
            if (checkBox1.Checked)
            {
                this.Close();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            remove.Visible = false;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainWindow.isCallEventWindowOpened = false;
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (this.events.Count == 0)
            {
                return;
            }
            int last = 0;

            for (int i = 0; i < this.events.Count; i++)
            {
                last = i;
            }

            panel1.Controls.Remove((Label)this.events[last][0]);
            panel1.Controls.Remove((TextBox)this.events[last][1]);
            panel1.Controls.Remove((ComboBox)this.events[last][2]);

            this.events.Remove(this.events[last]);
            remove.Location = new System.Drawing.Point(225, 68 + (this.events.Count - 1) * 64);
            remove.Visible = this.events.Count > 0;
        }

        private void Form3_Click(object sender, EventArgs e)
        {
            this.tb_check();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.tb_check();
        }

        private void window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.callEvent();
            }
        }
    }
}
