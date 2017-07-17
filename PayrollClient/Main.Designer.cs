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
            this.components = new System.ComponentModel.Container();
            this.ButtonGetBatches = new System.Windows.Forms.Button();
            this.ButtonSubmitBatch = new System.Windows.Forms.Button();
            this.DataGridPayrollBatches = new System.Windows.Forms.DataGridView();
            this.payrollBatchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payrollBatchIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPayrollBatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBatchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonGetBatches
            // 
            this.ButtonGetBatches.Location = new System.Drawing.Point(34, 26);
            this.ButtonGetBatches.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonGetBatches.Name = "ButtonGetBatches";
            this.ButtonGetBatches.Size = new System.Drawing.Size(149, 40);
            this.ButtonGetBatches.TabIndex = 0;
            this.ButtonGetBatches.Text = "Get Batches";
            this.ButtonGetBatches.UseVisualStyleBackColor = true;
            this.ButtonGetBatches.Click += new System.EventHandler(this.ButtonGetBatches_Click);
            // 
            // ButtonSubmitBatch
            // 
            this.ButtonSubmitBatch.Location = new System.Drawing.Point(209, 26);
            this.ButtonSubmitBatch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonSubmitBatch.Name = "ButtonSubmitBatch";
            this.ButtonSubmitBatch.Size = new System.Drawing.Size(149, 40);
            this.ButtonSubmitBatch.TabIndex = 2;
            this.ButtonSubmitBatch.Text = "Submit Batch";
            this.ButtonSubmitBatch.UseVisualStyleBackColor = true;
            this.ButtonSubmitBatch.Click += new System.EventHandler(this.ButtonSubmitBatch_Click);
            // 
            // DataGridPayrollBatches
            // 
            this.DataGridPayrollBatches.AllowUserToAddRows = false;
            this.DataGridPayrollBatches.AllowUserToDeleteRows = false;
            this.DataGridPayrollBatches.AutoGenerateColumns = false;
            this.DataGridPayrollBatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridPayrollBatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.payrollBatchIdDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.batchDescDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.DataGridPayrollBatches.DataSource = this.payrollBatchBindingSource;
            this.DataGridPayrollBatches.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataGridPayrollBatches.Location = new System.Drawing.Point(0, 105);
            this.DataGridPayrollBatches.Name = "DataGridPayrollBatches";
            this.DataGridPayrollBatches.ReadOnly = true;
            this.DataGridPayrollBatches.RowTemplate.Height = 24;
            this.DataGridPayrollBatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridPayrollBatches.Size = new System.Drawing.Size(522, 182);
            this.DataGridPayrollBatches.TabIndex = 3;
            // 
            // payrollBatchBindingSource
            // 
            this.payrollBatchBindingSource.DataSource = typeof(PayrollClient.Models.PayrollBatch);
            // 
            // payrollBatchIdDataGridViewTextBoxColumn
            // 
            this.payrollBatchIdDataGridViewTextBoxColumn.DataPropertyName = "PayrollBatchId";
            this.payrollBatchIdDataGridViewTextBoxColumn.HeaderText = "PayrollBatchId";
            this.payrollBatchIdDataGridViewTextBoxColumn.Name = "payrollBatchIdDataGridViewTextBoxColumn";
            this.payrollBatchIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // batchDescDataGridViewTextBoxColumn
            // 
            this.batchDescDataGridViewTextBoxColumn.DataPropertyName = "BatchDesc";
            this.batchDescDataGridViewTextBoxColumn.HeaderText = "BatchDesc";
            this.batchDescDataGridViewTextBoxColumn.Name = "batchDescDataGridViewTextBoxColumn";
            this.batchDescDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 287);
            this.Controls.Add(this.DataGridPayrollBatches);
            this.Controls.Add(this.ButtonSubmitBatch);
            this.Controls.Add(this.ButtonGetBatches);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPayrollBatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBatchBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonGetBatches;
        private System.Windows.Forms.Button ButtonSubmitBatch;
        private System.Windows.Forms.DataGridView DataGridPayrollBatches;
        private System.Windows.Forms.BindingSource payrollBatchBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn payrollBatchIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}

