﻿namespace PayrollClient
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
            this.components = new System.ComponentModel.Container();
            this.ButtonGetBatches = new System.Windows.Forms.Button();
            this.ButtonSubmitBatch = new System.Windows.Forms.Button();
            this.DataGridPayrollBatches = new System.Windows.Forms.DataGridView();
            this.payrollBatchIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payrollBatchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPayrollBatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBatchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonGetBatches
            // 
            this.ButtonGetBatches.Location = new System.Drawing.Point(51, 41);
            this.ButtonGetBatches.Name = "ButtonGetBatches";
            this.ButtonGetBatches.Size = new System.Drawing.Size(224, 62);
            this.ButtonGetBatches.TabIndex = 0;
            this.ButtonGetBatches.Text = "Get Batches";
            this.ButtonGetBatches.UseVisualStyleBackColor = true;
            this.ButtonGetBatches.Click += new System.EventHandler(this.ButtonGetBatches_Click);
            // 
            // ButtonSubmitBatch
            // 
            this.ButtonSubmitBatch.Location = new System.Drawing.Point(314, 41);
            this.ButtonSubmitBatch.Name = "ButtonSubmitBatch";
            this.ButtonSubmitBatch.Size = new System.Drawing.Size(224, 62);
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
            this.DataGridPayrollBatches.Location = new System.Drawing.Point(0, 526);
            this.DataGridPayrollBatches.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridPayrollBatches.Name = "DataGridPayrollBatches";
            this.DataGridPayrollBatches.ReadOnly = true;
            this.DataGridPayrollBatches.RowTemplate.Height = 24;
            this.DataGridPayrollBatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridPayrollBatches.Size = new System.Drawing.Size(1239, 284);
            this.DataGridPayrollBatches.TabIndex = 3;
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
            // payrollBatchBindingSource
            // 
            this.payrollBatchBindingSource.DataSource = typeof(PayrollClient.Models.PayrollBatch);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 810);
            this.Controls.Add(this.DataGridPayrollBatches);
            this.Controls.Add(this.ButtonSubmitBatch);
            this.Controls.Add(this.ButtonGetBatches);
            this.Name = "MainForm";
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

