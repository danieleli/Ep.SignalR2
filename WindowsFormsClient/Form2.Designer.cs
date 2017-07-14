namespace WinFormsClient
{
    partial class Form2
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
            this.StatusText = new System.Windows.Forms.Label();
            this.RichTextBoxConsole = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // StatusText
            // 
            this.StatusText.Location = new System.Drawing.Point(15, 9);
            this.StatusText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(954, 45);
            this.StatusText.TabIndex = 6;
            this.StatusText.Text = "Not Connected";
            this.StatusText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RichTextBoxConsole
            // 
            this.RichTextBoxConsole.Location = new System.Drawing.Point(39, 144);
            this.RichTextBoxConsole.Name = "RichTextBoxConsole";
            this.RichTextBoxConsole.Size = new System.Drawing.Size(901, 760);
            this.RichTextBoxConsole.TabIndex = 7;
            this.RichTextBoxConsole.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 987);
            this.Controls.Add(this.RichTextBoxConsole);
            this.Controls.Add(this.StatusText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1008, 996);
            this.Name = "Form2";
            this.Text = "WinForms SignalR Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WinFormsClient_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label StatusText;
        private System.Windows.Forms.RichTextBox RichTextBoxConsole;
    }
}

