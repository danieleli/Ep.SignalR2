namespace PayrollClient
{
    partial class BatchesForm
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
            this.BatchesGrid = new System.Windows.Forms.DataGridView();
            this.payrollBatchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.batchDetailTabs = new System.Windows.Forms.TabControl();
            this.payrollBatchIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BatchesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBatchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BatchesGrid
            // 
            this.BatchesGrid.AllowUserToAddRows = false;
            this.BatchesGrid.AllowUserToDeleteRows = false;
            this.BatchesGrid.AutoGenerateColumns = false;
            this.BatchesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BatchesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.payrollBatchIdDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.batchDescDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.BatchesGrid.DataSource = this.payrollBatchBindingSource;
            this.BatchesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BatchesGrid.Location = new System.Drawing.Point(0, 0);
            this.BatchesGrid.Margin = new System.Windows.Forms.Padding(2);
            this.BatchesGrid.Name = "BatchesGrid";
            this.BatchesGrid.ReadOnly = true;
            this.BatchesGrid.RowTemplate.Height = 33;
            this.BatchesGrid.Size = new System.Drawing.Size(1000, 277);
            this.BatchesGrid.TabIndex = 1;
            this.BatchesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BatchesGrid_CellContentClick);
            // 
            // payrollBatchBindingSource
            // 
            this.payrollBatchBindingSource.DataSource = typeof(PayrollClient.Models.PayrollBatch);
            // 
            // batchDetailTabs
            // 
            this.batchDetailTabs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.batchDetailTabs.Location = new System.Drawing.Point(0, 277);
            this.batchDetailTabs.Margin = new System.Windows.Forms.Padding(2);
            this.batchDetailTabs.Name = "batchDetailTabs";
            this.batchDetailTabs.SelectedIndex = 0;
            this.batchDetailTabs.Size = new System.Drawing.Size(1000, 457);
            this.batchDetailTabs.TabIndex = 0;
            // 
            // payrollBatchIdDataGridViewTextBoxColumn
            // 
            this.payrollBatchIdDataGridViewTextBoxColumn.DataPropertyName = "PayrollBatchId";
            this.payrollBatchIdDataGridViewTextBoxColumn.HeaderText = "PayrollBatchId";
            this.payrollBatchIdDataGridViewTextBoxColumn.Name = "payrollBatchIdDataGridViewTextBoxColumn";
            this.payrollBatchIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.payrollBatchIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // batchDescDataGridViewTextBoxColumn
            // 
            this.batchDescDataGridViewTextBoxColumn.DataPropertyName = "BatchDesc";
            this.batchDescDataGridViewTextBoxColumn.HeaderText = "BatchDesc";
            this.batchDescDataGridViewTextBoxColumn.Name = "batchDescDataGridViewTextBoxColumn";
            this.batchDescDataGridViewTextBoxColumn.ReadOnly = true;
            this.batchDescDataGridViewTextBoxColumn.Width = 300;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BatchesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 734);
            this.Controls.Add(this.BatchesGrid);
            this.Controls.Add(this.batchDetailTabs);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BatchesForm";
            this.Text = "BatchesForm";
            this.Load += new System.EventHandler(this.BatchesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BatchesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBatchBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView BatchesGrid;
        private System.Windows.Forms.BindingSource payrollBatchBindingSource;
        private System.Windows.Forms.TabControl batchDetailTabs;
        private System.Windows.Forms.DataGridViewTextBoxColumn payrollBatchIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}