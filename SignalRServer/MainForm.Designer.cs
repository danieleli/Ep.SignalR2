﻿namespace SignalRServer
{
    partial class MainForm
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
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.RichTextBoxConsole = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(17, 16);
            this.ButtonStart.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(147, 28);
            this.ButtonStart.TabIndex = 0;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.Enabled = false;
            this.ButtonStop.Location = new System.Drawing.Point(273, 16);
            this.ButtonStop.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(147, 28);
            this.ButtonStop.TabIndex = 0;
            this.ButtonStop.Text = "Stop";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // RichTextBoxConsole
            // 
            this.RichTextBoxConsole.Location = new System.Drawing.Point(17, 52);
            this.RichTextBoxConsole.Margin = new System.Windows.Forms.Padding(4);
            this.RichTextBoxConsole.Name = "RichTextBoxConsole";
            this.RichTextBoxConsole.ReadOnly = true;
            this.RichTextBoxConsole.Size = new System.Drawing.Size(401, 277);
            this.RichTextBoxConsole.TabIndex = 1;
            this.RichTextBoxConsole.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 345);
            this.Controls.Add(this.RichTextBoxConsole);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ButtonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "SignalR Server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.RichTextBox RichTextBoxConsole;
    }
}

