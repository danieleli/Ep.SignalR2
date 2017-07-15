namespace SignalRChat
{
    partial class BatchUpdateServer
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
            this._buttonStartHub = new System.Windows.Forms.Button();
            this._buttonStartProcessor = new System.Windows.Forms.Button();
            this._textboxConsole = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // _buttonStartHub
            // 
            this._buttonStartHub.Location = new System.Drawing.Point(627, 12);
            this._buttonStartHub.Name = "_buttonStartHub";
            this._buttonStartHub.Size = new System.Drawing.Size(239, 54);
            this._buttonStartHub.TabIndex = 0;
            this._buttonStartHub.Text = "Start Hub";
            this._buttonStartHub.UseVisualStyleBackColor = true;
            this._buttonStartHub.Click += new System.EventHandler(this._buttonStartHub_Click);
            // 
            // _buttonStartProcessor
            // 
            this._buttonStartProcessor.Location = new System.Drawing.Point(627, 100);
            this._buttonStartProcessor.Name = "_buttonStartProcessor";
            this._buttonStartProcessor.Size = new System.Drawing.Size(239, 54);
            this._buttonStartProcessor.TabIndex = 1;
            this._buttonStartProcessor.Text = "Process Batches";
            this._buttonStartProcessor.UseVisualStyleBackColor = true;
            // 
            // _textboxConsole
            // 
            this._textboxConsole.Dock = System.Windows.Forms.DockStyle.Left;
            this._textboxConsole.Location = new System.Drawing.Point(0, 0);
            this._textboxConsole.Name = "_textboxConsole";
            this._textboxConsole.Size = new System.Drawing.Size(600, 623);
            this._textboxConsole.TabIndex = 2;
            this._textboxConsole.Text = "";
            // 
            // BatchUpdateServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 623);
            this.Controls.Add(this._textboxConsole);
            this.Controls.Add(this._buttonStartProcessor);
            this.Controls.Add(this._buttonStartHub);
            this.Name = "BatchUpdateServer";
            this.Text = "BatchUpdateServer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _buttonStartHub;
        private System.Windows.Forms.Button _buttonStartProcessor;
        private System.Windows.Forms.RichTextBox _textboxConsole;
    }
}