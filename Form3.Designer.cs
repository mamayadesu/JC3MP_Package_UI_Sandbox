namespace JC3MP_Package_UI_Sandbox
{
    partial class Form3
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
            this.addButton = new System.Windows.Forms.PictureBox();
            this.remove = new System.Windows.Forms.PictureBox();
            this.callEventButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.addButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remove)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Image = global::JC3MP_Package_UI_Sandbox.Properties.Resources.add;
            this.addButton.Location = new System.Drawing.Point(13, 13);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(18, 18);
            this.addButton.TabIndex = 0;
            this.addButton.TabStop = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // remove
            // 
            this.remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.remove.Image = global::JC3MP_Package_UI_Sandbox.Properties.Resources.remove;
            this.remove.Location = new System.Drawing.Point(225, 68);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(18, 18);
            this.remove.TabIndex = 14;
            this.remove.TabStop = false;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // callEventButton
            // 
            this.callEventButton.Location = new System.Drawing.Point(199, 8);
            this.callEventButton.Name = "callEventButton";
            this.callEventButton.Size = new System.Drawing.Size(75, 23);
            this.callEventButton.TabIndex = 15;
            this.callEventButton.Text = "Call event";
            this.callEventButton.UseVisualStyleBackColor = true;
            this.callEventButton.Click += new System.EventHandler(this.callEventButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.remove);
            this.panel1.Location = new System.Drawing.Point(2, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 276);
            this.panel1.TabIndex = 16;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(47, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(148, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Close window after calling";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 323);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.callEventButton);
            this.Controls.Add(this.addButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "Call event";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Click += new System.EventHandler(this.Form3_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.window_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.addButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remove)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox addButton;
        private System.Windows.Forms.PictureBox remove;
        private System.Windows.Forms.Button callEventButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;

    }
}