namespace PayrollClient
{
    partial class Main
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
            this.ButtonGetBatches = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ButtonSubmitBatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonGetBatches
            // 
            this.ButtonGetBatches.Location = new System.Drawing.Point(51, 41);
            this.ButtonGetBatches.Name = "ButtonGetBatches";
            this.ButtonGetBatches.Size = new System.Drawing.Size(223, 62);
            this.ButtonGetBatches.TabIndex = 0;
            this.ButtonGetBatches.Text = "Get Batches";
            this.ButtonGetBatches.UseVisualStyleBackColor = true;
            this.ButtonGetBatches.Click += new System.EventHandler(this.ButtonGetBatches_Click);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.Location = new System.Drawing.Point(0, 144);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(783, 305);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ButtonSubmitBatch
            // 
            this.ButtonSubmitBatch.Location = new System.Drawing.Point(313, 41);
            this.ButtonSubmitBatch.Name = "ButtonSubmitBatch";
            this.ButtonSubmitBatch.Size = new System.Drawing.Size(223, 62);
            this.ButtonSubmitBatch.TabIndex = 2;
            this.ButtonSubmitBatch.Text = "Submit Batch";
            this.ButtonSubmitBatch.UseVisualStyleBackColor = true;
            this.ButtonSubmitBatch.Click += new System.EventHandler(this.ButtonSubmitBatch_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 449);
            this.Controls.Add(this.ButtonSubmitBatch);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ButtonGetBatches);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonGetBatches;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button ButtonSubmitBatch;
    }
}

