namespace PayrollClient.UserControls
{
    partial class BatchDetailControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FinalizeButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.timecardIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payrollBatchIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMinutesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timecardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timecardBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FinalizeButton
            // 
            this.FinalizeButton.Location = new System.Drawing.Point(699, 51);
            this.FinalizeButton.Name = "FinalizeButton";
            this.FinalizeButton.Size = new System.Drawing.Size(75, 23);
            this.FinalizeButton.TabIndex = 5;
            this.FinalizeButton.Text = "Finalize";
            this.FinalizeButton.UseVisualStyleBackColor = true;
            this.FinalizeButton.Click += new System.EventHandler(this.FinalizeButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(699, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timecardIdDataGridViewTextBoxColumn,
            this.payrollBatchIdDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.totalMinutesDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.timecardBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(642, 261);
            this.dataGridView2.TabIndex = 3;
            // 
            // timecardIdDataGridViewTextBoxColumn
            // 
            this.timecardIdDataGridViewTextBoxColumn.DataPropertyName = "TimecardId";
            this.timecardIdDataGridViewTextBoxColumn.HeaderText = "TimecardId";
            this.timecardIdDataGridViewTextBoxColumn.Name = "timecardIdDataGridViewTextBoxColumn";
            // 
            // payrollBatchIdDataGridViewTextBoxColumn
            // 
            this.payrollBatchIdDataGridViewTextBoxColumn.DataPropertyName = "PayrollBatchId";
            this.payrollBatchIdDataGridViewTextBoxColumn.HeaderText = "PayrollBatchId";
            this.payrollBatchIdDataGridViewTextBoxColumn.Name = "payrollBatchIdDataGridViewTextBoxColumn";
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            // 
            // totalMinutesDataGridViewTextBoxColumn
            // 
            this.totalMinutesDataGridViewTextBoxColumn.DataPropertyName = "TotalMinutes";
            this.totalMinutesDataGridViewTextBoxColumn.HeaderText = "TotalMinutes";
            this.totalMinutesDataGridViewTextBoxColumn.Name = "totalMinutesDataGridViewTextBoxColumn";
            // 
            // timecardBindingSource
            // 
            this.timecardBindingSource.DataSource = typeof(PayrollClient.Models.Timecard);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(273, 70);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(386, 41);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Visible = false;
            // 
            // BatchDetailControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.FinalizeButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.dataGridView2);
            this.Name = "BatchDetailControl";
            this.Size = new System.Drawing.Size(852, 261);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timecardBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FinalizeButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn timecardIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payrollBatchIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMinutesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource timecardBindingSource;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
