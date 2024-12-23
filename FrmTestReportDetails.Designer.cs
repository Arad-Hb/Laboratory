namespace Laboratory
{
    partial class FrmTestReportDetails
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
            this.grdTestDetailReport = new System.Windows.Forms.DataGridView();
            this.clmnDrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTestCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPatientTestHeaderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnHasStar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdTestDetailReport)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTestDetailReport
            // 
            this.grdTestDetailReport.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.grdTestDetailReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTestDetailReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnDrName,
            this.clmnAge,
            this.clmnTestCategoryID,
            this.clmnPatientTestHeaderID,
            this.clmnEmployeeName,
            this.clmnTotalPrice,
            this.clmnResult,
            this.clmnHasStar});
            this.grdTestDetailReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdTestDetailReport.Location = new System.Drawing.Point(0, 0);
            this.grdTestDetailReport.Name = "grdTestDetailReport";
            this.grdTestDetailReport.RowHeadersWidth = 51;
            this.grdTestDetailReport.RowTemplate.Height = 24;
            this.grdTestDetailReport.Size = new System.Drawing.Size(982, 553);
            this.grdTestDetailReport.TabIndex = 1;
            // 
            // clmnDrName
            // 
            this.clmnDrName.DataPropertyName = "PatientTestHeaderID";
            this.clmnDrName.HeaderText = "شماره سربرگ";
            this.clmnDrName.MinimumWidth = 6;
            this.clmnDrName.Name = "clmnDrName";
            this.clmnDrName.ToolTipText = "شماره سربرگ";
            this.clmnDrName.Width = 120;
            // 
            // clmnAge
            // 
            this.clmnAge.DataPropertyName = "PatientTestDetailsID";
            this.clmnAge.HeaderText = "ردیف پذیرش";
            this.clmnAge.MinimumWidth = 6;
            this.clmnAge.Name = "clmnAge";
            this.clmnAge.ToolTipText = "ردیف پذیرش";
            this.clmnAge.Width = 120;
            // 
            // clmnTestCategoryID
            // 
            this.clmnTestCategoryID.DataPropertyName = "TestCategoryID";
            this.clmnTestCategoryID.HeaderText = "کد رده ";
            this.clmnTestCategoryID.MinimumWidth = 6;
            this.clmnTestCategoryID.Name = "clmnTestCategoryID";
            this.clmnTestCategoryID.ToolTipText = "کد رده ";
            this.clmnTestCategoryID.Width = 80;
            // 
            // clmnPatientTestHeaderID
            // 
            this.clmnPatientTestHeaderID.DataPropertyName = "TestID";
            this.clmnPatientTestHeaderID.HeaderText = "کد آزمایش";
            this.clmnPatientTestHeaderID.MinimumWidth = 6;
            this.clmnPatientTestHeaderID.Name = "clmnPatientTestHeaderID";
            this.clmnPatientTestHeaderID.ToolTipText = "کد آزمایش";
            // 
            // clmnEmployeeName
            // 
            this.clmnEmployeeName.DataPropertyName = "TestName";
            this.clmnEmployeeName.HeaderText = "نام آزمایش";
            this.clmnEmployeeName.MinimumWidth = 6;
            this.clmnEmployeeName.Name = "clmnEmployeeName";
            this.clmnEmployeeName.ToolTipText = "نام آزمایش";
            this.clmnEmployeeName.Width = 150;
            // 
            // clmnTotalPrice
            // 
            this.clmnTotalPrice.DataPropertyName = "Price";
            this.clmnTotalPrice.HeaderText = "قیمت";
            this.clmnTotalPrice.MinimumWidth = 6;
            this.clmnTotalPrice.Name = "clmnTotalPrice";
            this.clmnTotalPrice.ToolTipText = "قیمت";
            this.clmnTotalPrice.Width = 150;
            // 
            // clmnResult
            // 
            this.clmnResult.DataPropertyName = "Result";
            this.clmnResult.HeaderText = "نتیجه آزمایش";
            this.clmnResult.MinimumWidth = 6;
            this.clmnResult.Name = "clmnResult";
            this.clmnResult.Width = 125;
            // 
            // clmnHasStar
            // 
            this.clmnHasStar.DataPropertyName = "HasStar";
            this.clmnHasStar.HeaderText = "اضطرار";
            this.clmnHasStar.MinimumWidth = 6;
            this.clmnHasStar.Name = "clmnHasStar";
            this.clmnHasStar.Width = 80;
            // 
            // FrmTestReportDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.grdTestDetailReport);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTestReportDetails";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.Text = "فرم جزییات آزمایش";
            this.Load += new System.EventHandler(this.FrmTestReportDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTestDetailReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdTestDetailReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTestCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPatientTestHeaderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnResult;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnHasStar;
    }
}