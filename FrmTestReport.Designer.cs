namespace Laboratory
{
    partial class FrmTestReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdTestReport = new System.Windows.Forms.DataGridView();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchPatient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.faDateToDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.lstPatient = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.faDateFromDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtRegistedTestID = new System.Windows.Forms.TextBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.clmnPatientTestHeaderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnInsuranceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnHeaderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdTestReport)).BeginInit();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTestReport
            // 
            this.grdTestReport.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grdTestReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTestReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnPatientTestHeaderID,
            this.clmnPatientName,
            this.clmnDrName,
            this.clmnInsuranceName,
            this.clmnHeaderDate,
            this.clmnMobile,
            this.clmnAge,
            this.clmnTotalPrice,
            this.clmnDetails});
            this.grdTestReport.Dock = System.Windows.Forms.DockStyle.Left;
            this.grdTestReport.Location = new System.Drawing.Point(0, 0);
            this.grdTestReport.Name = "grdTestReport";
            this.grdTestReport.RowHeadersWidth = 51;
            this.grdTestReport.RowTemplate.Height = 24;
            this.grdTestReport.Size = new System.Drawing.Size(1133, 653);
            this.grdTestReport.TabIndex = 0;
            this.grdTestReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTestReport_CellContentClick);
            // 
            // grpSearch
            // 
            this.grpSearch.BackColor = System.Drawing.Color.Transparent;
            this.grpSearch.Controls.Add(this.btnReset);
            this.grpSearch.Controls.Add(this.label4);
            this.grpSearch.Controls.Add(this.txtSearchPatient);
            this.grpSearch.Controls.Add(this.label1);
            this.grpSearch.Controls.Add(this.faDateToDate);
            this.grpSearch.Controls.Add(this.lstPatient);
            this.grpSearch.Controls.Add(this.label2);
            this.grpSearch.Controls.Add(this.faDateFromDate);
            this.grpSearch.Controls.Add(this.label5);
            this.grpSearch.Controls.Add(this.btnShowAll);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.txtRegistedTestID);
            this.grpSearch.ForeColor = System.Drawing.SystemColors.Info;
            this.grpSearch.Location = new System.Drawing.Point(1139, 26);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(331, 600);
            this.grpSearch.TabIndex = 1;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "جستجو بر اساس";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Teal;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReset.Location = new System.Drawing.Point(41, 537);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(254, 49);
            this.btnReset.TabIndex = 29;
            this.btnReset.Text = "پاک کردن";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(113, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "جستجوی مراجع";
            // 
            // txtSearchPatient
            // 
            this.txtSearchPatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchPatient.Location = new System.Drawing.Point(41, 172);
            this.txtSearchPatient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchPatient.Name = "txtSearchPatient";
            this.txtSearchPatient.Size = new System.Drawing.Size(254, 23);
            this.txtSearchPatient.TabIndex = 26;
            this.txtSearchPatient.TextChanged += new System.EventHandler(this.txtSearchPatient_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(213, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "تاریخ شروع";
            // 
            // faDateToDate
            // 
            this.faDateToDate.Location = new System.Drawing.Point(41, 379);
            this.faDateToDate.Name = "faDateToDate";
            this.faDateToDate.Size = new System.Drawing.Size(166, 25);
            this.faDateToDate.TabIndex = 25;
            this.faDateToDate.SelectedDateTimeChanged += new System.EventHandler(this.faDateToDate_SelectedDateTimeChanged);
            // 
            // lstPatient
            // 
            this.lstPatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPatient.FormattingEnabled = true;
            this.lstPatient.ItemHeight = 25;
            this.lstPatient.Location = new System.Drawing.Point(41, 195);
            this.lstPatient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstPatient.Name = "lstPatient";
            this.lstPatient.Size = new System.Drawing.Size(254, 100);
            this.lstPatient.TabIndex = 27;
            this.lstPatient.Visible = false;
            this.lstPatient.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstPatient_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(220, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "تاریخ پایان";
            // 
            // faDateFromDate
            // 
            this.faDateFromDate.Location = new System.Drawing.Point(41, 318);
            this.faDateFromDate.Name = "faDateFromDate";
            this.faDateFromDate.Size = new System.Drawing.Size(166, 25);
            this.faDateFromDate.TabIndex = 24;
            this.faDateFromDate.SelectedDateTimeChanged += new System.EventHandler(this.faDateFromDate_SelectedDateTimeChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(113, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "سربرگ پذیرش";
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.Teal;
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShowAll.Location = new System.Drawing.Point(41, 482);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(254, 49);
            this.btnShowAll.TabIndex = 19;
            this.btnShowAll.Text = "گزارش کلی";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(41, 427);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(254, 49);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "گزارش موارد مورد جستجو";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtRegistedTestID
            // 
            this.txtRegistedTestID.Location = new System.Drawing.Point(126, 84);
            this.txtRegistedTestID.Name = "txtRegistedTestID";
            this.txtRegistedTestID.Size = new System.Drawing.Size(83, 30);
            this.txtRegistedTestID.TabIndex = 16;
            this.txtRegistedTestID.TextChanged += new System.EventHandler(this.txtRegistedTestID_TextChanged);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // clmnPatientTestHeaderID
            // 
            this.clmnPatientTestHeaderID.DataPropertyName = "PatientTestHeaderID";
            this.clmnPatientTestHeaderID.HeaderText = "سربرگ";
            this.clmnPatientTestHeaderID.MinimumWidth = 6;
            this.clmnPatientTestHeaderID.Name = "clmnPatientTestHeaderID";
            this.clmnPatientTestHeaderID.ToolTipText = "سربرگ";
            this.clmnPatientTestHeaderID.Width = 80;
            // 
            // clmnPatientName
            // 
            this.clmnPatientName.DataPropertyName = "PatientName";
            this.clmnPatientName.HeaderText = "نام مراجع";
            this.clmnPatientName.MinimumWidth = 6;
            this.clmnPatientName.Name = "clmnPatientName";
            this.clmnPatientName.ToolTipText = "نام مراجع";
            this.clmnPatientName.Width = 150;
            // 
            // clmnDrName
            // 
            this.clmnDrName.DataPropertyName = "DrName";
            this.clmnDrName.HeaderText = "نام پزشک";
            this.clmnDrName.MinimumWidth = 6;
            this.clmnDrName.Name = "clmnDrName";
            this.clmnDrName.ToolTipText = "نام پزشک";
            this.clmnDrName.Width = 125;
            // 
            // clmnInsuranceName
            // 
            this.clmnInsuranceName.DataPropertyName = "InsuranceName";
            this.clmnInsuranceName.HeaderText = "بیمه";
            this.clmnInsuranceName.MinimumWidth = 6;
            this.clmnInsuranceName.Name = "clmnInsuranceName";
            this.clmnInsuranceName.ToolTipText = "بیمه";
            this.clmnInsuranceName.Width = 125;
            // 
            // clmnHeaderDate
            // 
            this.clmnHeaderDate.DataPropertyName = "HeaderDate";
            dataGridViewCellStyle1.NullValue = null;
            this.clmnHeaderDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmnHeaderDate.HeaderText = "تاریخ ثبت";
            this.clmnHeaderDate.MinimumWidth = 6;
            this.clmnHeaderDate.Name = "clmnHeaderDate";
            this.clmnHeaderDate.ToolTipText = "تاریخ ثبت";
            this.clmnHeaderDate.Width = 125;
            // 
            // clmnMobile
            // 
            this.clmnMobile.DataPropertyName = "Mobile";
            this.clmnMobile.HeaderText = "موبایل";
            this.clmnMobile.MinimumWidth = 6;
            this.clmnMobile.Name = "clmnMobile";
            this.clmnMobile.ToolTipText = "موبایل";
            this.clmnMobile.Width = 125;
            // 
            // clmnAge
            // 
            this.clmnAge.DataPropertyName = "Age";
            this.clmnAge.HeaderText = "سن";
            this.clmnAge.MinimumWidth = 6;
            this.clmnAge.Name = "clmnAge";
            this.clmnAge.ToolTipText = "سن";
            this.clmnAge.Width = 110;
            // 
            // clmnTotalPrice
            // 
            this.clmnTotalPrice.DataPropertyName = "TotalPrice";
            this.clmnTotalPrice.HeaderText = "مبلغ کل";
            this.clmnTotalPrice.MinimumWidth = 6;
            this.clmnTotalPrice.Name = "clmnTotalPrice";
            this.clmnTotalPrice.ToolTipText = "مبلغ کل";
            this.clmnTotalPrice.Width = 125;
            // 
            // clmnDetails
            // 
            this.clmnDetails.HeaderText = "جزییات";
            this.clmnDetails.MinimumWidth = 6;
            this.clmnDetails.Name = "clmnDetails";
            this.clmnDetails.Text = "جزییات";
            this.clmnDetails.UseColumnTextForButtonValue = true;
            this.clmnDetails.Width = 120;
            // 
            // FrmTestReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Laboratory.Properties.Resources.the_science_biology_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1482, 653);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grdTestReport);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmTestReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.Text = "گزارش جامع";
            ((System.ComponentModel.ISupportInitialize)(this.grdTestReport)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdTestReport;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtRegistedTestID;
        private System.Windows.Forms.Label label1;
        private FarsiLibrary.Win.Controls.FADatePicker faDateToDate;
        private FarsiLibrary.Win.Controls.FADatePicker faDateFromDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearchPatient;
        private System.Windows.Forms.ListBox lstPatient;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPatientTestHeaderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnInsuranceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnHeaderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTotalPrice;
        private System.Windows.Forms.DataGridViewButtonColumn clmnDetails;
    }
}