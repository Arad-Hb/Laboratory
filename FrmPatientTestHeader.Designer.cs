namespace Laboratory
{
    partial class FrmPatientTestHeader
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
            this.grdPatientTestDetail = new System.Windows.Forms.DataGridView();
            this.clmnDrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTestCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPatientTestHeaderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnHasStar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmbInsurance = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstPatient = new System.Windows.Forms.ListBox();
            this.txtSearchPatient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDrName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpTestHeader = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblNationalCode = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblInsurance = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblDrName = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPatientTestHeaderID = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.grpPatientTestHeader = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.grpPatientTestDetails = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnAddTestDetails = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.chbHasStar = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTestName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTestCategory = new System.Windows.Forms.ComboBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdPatientTestDetail)).BeginInit();
            this.grpTestHeader.SuspendLayout();
            this.grpPatientTestHeader.SuspendLayout();
            this.grpPatientTestDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPatientTestDetail
            // 
            this.grdPatientTestDetail.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.grdPatientTestDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPatientTestDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnDrName,
            this.clmnAge,
            this.clmnTestCategoryID,
            this.clmnPatientTestHeaderID,
            this.clmnEmployeeName,
            this.clmnTotalPrice,
            this.clmnResult,
            this.clmnHasStar,
            this.clmnEdit,
            this.clmnDelete});
            this.grdPatientTestDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdPatientTestDetail.Location = new System.Drawing.Point(0, 482);
            this.grdPatientTestDetail.Name = "grdPatientTestDetail";
            this.grdPatientTestDetail.RowHeadersWidth = 51;
            this.grdPatientTestDetail.RowTemplate.Height = 24;
            this.grdPatientTestDetail.Size = new System.Drawing.Size(1482, 171);
            this.grdPatientTestDetail.TabIndex = 0;
            this.grdPatientTestDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPatientTestDetail_CellContentClick);
            // 
            // clmnDrName
            // 
            this.clmnDrName.DataPropertyName = "PatientTestHeaderID";
            this.clmnDrName.HeaderText = "شماره سربرگ";
            this.clmnDrName.MinimumWidth = 6;
            this.clmnDrName.Name = "clmnDrName";
            this.clmnDrName.ToolTipText = "شماره سربرگ";
            this.clmnDrName.Visible = false;
            this.clmnDrName.Width = 80;
            // 
            // clmnAge
            // 
            this.clmnAge.DataPropertyName = "PatientTestDetailsID";
            this.clmnAge.HeaderText = "ردیف پذیرش";
            this.clmnAge.MinimumWidth = 6;
            this.clmnAge.Name = "clmnAge";
            this.clmnAge.ToolTipText = "ردیف پذیرش";
            this.clmnAge.Width = 200;
            // 
            // clmnTestCategoryID
            // 
            this.clmnTestCategoryID.DataPropertyName = "TestCategoryID";
            this.clmnTestCategoryID.HeaderText = "کد رده";
            this.clmnTestCategoryID.MinimumWidth = 6;
            this.clmnTestCategoryID.Name = "clmnTestCategoryID";
            this.clmnTestCategoryID.ToolTipText = "کد رده";
            this.clmnTestCategoryID.Width = 125;
            // 
            // clmnPatientTestHeaderID
            // 
            this.clmnPatientTestHeaderID.DataPropertyName = "TestID";
            this.clmnPatientTestHeaderID.HeaderText = "کد آزمایش";
            this.clmnPatientTestHeaderID.MinimumWidth = 6;
            this.clmnPatientTestHeaderID.Name = "clmnPatientTestHeaderID";
            this.clmnPatientTestHeaderID.ToolTipText = "کد آزمایش";
            this.clmnPatientTestHeaderID.Width = 125;
            // 
            // clmnEmployeeName
            // 
            this.clmnEmployeeName.DataPropertyName = "TestName";
            this.clmnEmployeeName.HeaderText = "نام آزمایش";
            this.clmnEmployeeName.MinimumWidth = 6;
            this.clmnEmployeeName.Name = "clmnEmployeeName";
            this.clmnEmployeeName.ToolTipText = "نام آزمایش";
            this.clmnEmployeeName.Width = 260;
            // 
            // clmnTotalPrice
            // 
            this.clmnTotalPrice.DataPropertyName = "Price";
            this.clmnTotalPrice.HeaderText = "قیمت";
            this.clmnTotalPrice.MinimumWidth = 6;
            this.clmnTotalPrice.Name = "clmnTotalPrice";
            this.clmnTotalPrice.ToolTipText = "قیمت";
            this.clmnTotalPrice.Width = 140;
            // 
            // clmnResult
            // 
            this.clmnResult.DataPropertyName = "Result";
            this.clmnResult.HeaderText = "نتیجه آزمایش";
            this.clmnResult.MinimumWidth = 6;
            this.clmnResult.Name = "clmnResult";
            this.clmnResult.Width = 160;
            // 
            // clmnHasStar
            // 
            this.clmnHasStar.DataPropertyName = "HasStar";
            this.clmnHasStar.HeaderText = "وضعیت اضطراری";
            this.clmnHasStar.MinimumWidth = 6;
            this.clmnHasStar.Name = "clmnHasStar";
            this.clmnHasStar.Width = 160;
            // 
            // clmnEdit
            // 
            this.clmnEdit.HeaderText = "ویرایش";
            this.clmnEdit.MinimumWidth = 6;
            this.clmnEdit.Name = "clmnEdit";
            this.clmnEdit.Text = "ویرایش";
            this.clmnEdit.UseColumnTextForButtonValue = true;
            this.clmnEdit.Width = 130;
            // 
            // clmnDelete
            // 
            this.clmnDelete.HeaderText = "حذف";
            this.clmnDelete.MinimumWidth = 6;
            this.clmnDelete.Name = "clmnDelete";
            this.clmnDelete.Text = "حذف";
            this.clmnDelete.UseColumnTextForButtonValue = true;
            this.clmnDelete.Width = 130;
            // 
            // cmbInsurance
            // 
            this.cmbInsurance.FormattingEnabled = true;
            this.cmbInsurance.Location = new System.Drawing.Point(246, 253);
            this.cmbInsurance.Name = "cmbInsurance";
            this.cmbInsurance.Size = new System.Drawing.Size(121, 33);
            this.cmbInsurance.TabIndex = 1;
            this.cmbInsurance.SelectedIndexChanged += new System.EventHandler(this.cmbInsurance_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(425, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "بیمه";
            // 
            // lstPatient
            // 
            this.lstPatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPatient.FormattingEnabled = true;
            this.lstPatient.ItemHeight = 25;
            this.lstPatient.Location = new System.Drawing.Point(24, 62);
            this.lstPatient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstPatient.Name = "lstPatient";
            this.lstPatient.Size = new System.Drawing.Size(377, 125);
            this.lstPatient.TabIndex = 4;
            this.lstPatient.Visible = false;
            this.lstPatient.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstPatient_MouseDoubleClick);
            // 
            // txtSearchPatient
            // 
            this.txtSearchPatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchPatient.Location = new System.Drawing.Point(24, 40);
            this.txtSearchPatient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchPatient.Name = "txtSearchPatient";
            this.txtSearchPatient.Size = new System.Drawing.Size(377, 23);
            this.txtSearchPatient.TabIndex = 3;
            this.txtSearchPatient.TextChanged += new System.EventHandler(this.txtSearchPatient_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(408, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "مراجع";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(373, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "پزشک معالج";
            // 
            // txtDrName
            // 
            this.txtDrName.Location = new System.Drawing.Point(246, 190);
            this.txtDrName.Name = "txtDrName";
            this.txtDrName.Size = new System.Drawing.Size(121, 30);
            this.txtDrName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(662, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "تاریخ :";
            // 
            // grpTestHeader
            // 
            this.grpTestHeader.BackColor = System.Drawing.Color.Teal;
            this.grpTestHeader.Controls.Add(this.label13);
            this.grpTestHeader.Controls.Add(this.lblNationalCode);
            this.grpTestHeader.Controls.Add(this.label12);
            this.grpTestHeader.Controls.Add(this.lblAge);
            this.grpTestHeader.Controls.Add(this.label17);
            this.grpTestHeader.Controls.Add(this.label16);
            this.grpTestHeader.Controls.Add(this.lblInsurance);
            this.grpTestHeader.Controls.Add(this.label15);
            this.grpTestHeader.Controls.Add(this.lblDrName);
            this.grpTestHeader.Controls.Add(this.label14);
            this.grpTestHeader.Controls.Add(this.labelEmployee);
            this.grpTestHeader.Controls.Add(this.lblTotalPrice);
            this.grpTestHeader.Controls.Add(this.label11);
            this.grpTestHeader.Controls.Add(this.label6);
            this.grpTestHeader.Controls.Add(this.lblDate);
            this.grpTestHeader.Controls.Add(this.lblPatientTestHeaderID);
            this.grpTestHeader.Controls.Add(this.lblMobile);
            this.grpTestHeader.Controls.Add(this.lblEmployeeName);
            this.grpTestHeader.Controls.Add(this.lblPatientName);
            this.grpTestHeader.Controls.Add(this.label4);
            this.grpTestHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTestHeader.ForeColor = System.Drawing.SystemColors.Window;
            this.grpTestHeader.Location = new System.Drawing.Point(62, 12);
            this.grpTestHeader.Name = "grpTestHeader";
            this.grpTestHeader.Size = new System.Drawing.Size(812, 307);
            this.grpTestHeader.TabIndex = 10;
            this.grpTestHeader.TabStop = false;
            this.grpTestHeader.Text = "سر برگ آزمایش";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(662, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 25);
            this.label13.TabIndex = 29;
            this.label13.Text = "کد ملی :";
            // 
            // lblNationalCode
            // 
            this.lblNationalCode.AutoSize = true;
            this.lblNationalCode.Location = new System.Drawing.Point(520, 183);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.Size = new System.Drawing.Size(0, 25);
            this.lblNationalCode.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(639, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 25);
            this.label12.TabIndex = 27;
            this.label12.Text = "نام مراجع :";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(381, 145);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(0, 25);
            this.lblAge.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(442, 145);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 25);
            this.label17.TabIndex = 25;
            this.label17.Text = "سن :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(386, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 25);
            this.label16.TabIndex = 24;
            this.label16.Text = "شماره موبایل :";
            // 
            // lblInsurance
            // 
            this.lblInsurance.AutoSize = true;
            this.lblInsurance.Location = new System.Drawing.Point(326, 253);
            this.lblInsurance.Name = "lblInsurance";
            this.lblInsurance.Size = new System.Drawing.Size(0, 25);
            this.lblInsurance.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(442, 253);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 25);
            this.label15.TabIndex = 22;
            this.label15.Text = "بیمه :";
            // 
            // lblDrName
            // 
            this.lblDrName.AutoSize = true;
            this.lblDrName.Location = new System.Drawing.Point(520, 253);
            this.lblDrName.Name = "lblDrName";
            this.lblDrName.Size = new System.Drawing.Size(0, 25);
            this.lblDrName.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(639, 256);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 25);
            this.label14.TabIndex = 20;
            this.label14.Text = "پزشک معالج :";
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Location = new System.Drawing.Point(153, 145);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(80, 25);
            this.labelEmployee.TabIndex = 19;
            this.labelEmployee.Text = "متصدی :";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(47, 256);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(24, 25);
            this.lblTotalPrice.TabIndex = 17;
            this.lblTotalPrice.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(132, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "مبلغ نهایی :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "شماره پذیرش :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDate.Location = new System.Drawing.Point(525, 45);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 25);
            this.lblDate.TabIndex = 14;
            // 
            // lblPatientTestHeaderID
            // 
            this.lblPatientTestHeaderID.AutoSize = true;
            this.lblPatientTestHeaderID.Location = new System.Drawing.Point(47, 45);
            this.lblPatientTestHeaderID.Name = "lblPatientTestHeaderID";
            this.lblPatientTestHeaderID.Size = new System.Drawing.Size(0, 25);
            this.lblPatientTestHeaderID.TabIndex = 6;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(245, 45);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(0, 25);
            this.lblMobile.TabIndex = 4;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(15, 145);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(0, 25);
            this.lblEmployeeName.TabIndex = 2;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(525, 111);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(0, 25);
            this.lblPatientName.TabIndex = 1;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Teal;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddNew.Location = new System.Drawing.Point(24, 245);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(157, 41);
            this.btnAddNew.TabIndex = 11;
            this.btnAddNew.Text = "ثبت";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Teal;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(15, 103);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(163, 41);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Teal;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.Location = new System.Drawing.Point(205, 103);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(163, 41);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "ثبت ویرایش";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(1169, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "قیمت";
            // 
            // grpPatientTestHeader
            // 
            this.grpPatientTestHeader.BackColor = System.Drawing.Color.Transparent;
            this.grpPatientTestHeader.Controls.Add(this.label9);
            this.grpPatientTestHeader.Controls.Add(this.txtAge);
            this.grpPatientTestHeader.Controls.Add(this.label2);
            this.grpPatientTestHeader.Controls.Add(this.btnAddNew);
            this.grpPatientTestHeader.Controls.Add(this.txtSearchPatient);
            this.grpPatientTestHeader.Controls.Add(this.lstPatient);
            this.grpPatientTestHeader.Controls.Add(this.txtDrName);
            this.grpPatientTestHeader.Controls.Add(this.label1);
            this.grpPatientTestHeader.Controls.Add(this.label3);
            this.grpPatientTestHeader.Controls.Add(this.cmbInsurance);
            this.grpPatientTestHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPatientTestHeader.ForeColor = System.Drawing.SystemColors.Window;
            this.grpPatientTestHeader.Location = new System.Drawing.Point(907, 12);
            this.grpPatientTestHeader.Name = "grpPatientTestHeader";
            this.grpPatientTestHeader.Size = new System.Drawing.Size(500, 307);
            this.grpPatientTestHeader.TabIndex = 16;
            this.grpPatientTestHeader.TabStop = false;
            this.grpPatientTestHeader.Text = "اطلاعات مراجعه کننده";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Info;
            this.label9.Location = new System.Drawing.Point(150, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "سن";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(24, 190);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(121, 30);
            this.txtAge.TabIndex = 17;
            // 
            // grpPatientTestDetails
            // 
            this.grpPatientTestDetails.BackColor = System.Drawing.Color.Transparent;
            this.grpPatientTestDetails.Controls.Add(this.lblPrice);
            this.grpPatientTestDetails.Controls.Add(this.btnAddTestDetails);
            this.grpPatientTestDetails.Controls.Add(this.label10);
            this.grpPatientTestDetails.Controls.Add(this.txtResult);
            this.grpPatientTestDetails.Controls.Add(this.chbHasStar);
            this.grpPatientTestDetails.Controls.Add(this.label8);
            this.grpPatientTestDetails.Controls.Add(this.label5);
            this.grpPatientTestDetails.Controls.Add(this.cmbTestName);
            this.grpPatientTestDetails.Controls.Add(this.btnEdit);
            this.grpPatientTestDetails.Controls.Add(this.btnCancel);
            this.grpPatientTestDetails.Controls.Add(this.label7);
            this.grpPatientTestDetails.Controls.Add(this.cmbTestCategory);
            this.grpPatientTestDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPatientTestDetails.ForeColor = System.Drawing.SystemColors.Window;
            this.grpPatientTestDetails.Location = new System.Drawing.Point(62, 325);
            this.grpPatientTestDetails.Name = "grpPatientTestDetails";
            this.grpPatientTestDetails.Size = new System.Drawing.Size(1345, 151);
            this.grpPatientTestDetails.TabIndex = 17;
            this.grpPatientTestDetails.TabStop = false;
            this.grpPatientTestDetails.Text = "اطلاعات آزمایش";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.Info;
            this.lblPrice.Location = new System.Drawing.Point(1075, 111);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(24, 25);
            this.lblPrice.TabIndex = 20;
            this.lblPrice.Text = "0";
            // 
            // btnAddTestDetails
            // 
            this.btnAddTestDetails.BackColor = System.Drawing.Color.Teal;
            this.btnAddTestDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTestDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddTestDetails.Location = new System.Drawing.Point(395, 103);
            this.btnAddTestDetails.Name = "btnAddTestDetails";
            this.btnAddTestDetails.Size = new System.Drawing.Size(163, 41);
            this.btnAddTestDetails.TabIndex = 19;
            this.btnAddTestDetails.Text = "افزودن آزمایش";
            this.btnAddTestDetails.UseVisualStyleBackColor = false;
            this.btnAddTestDetails.Click += new System.EventHandler(this.btnAddTestDetails_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Info;
            this.label10.Location = new System.Drawing.Point(650, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "نتیجه";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(523, 49);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(121, 30);
            this.txtResult.TabIndex = 18;
            // 
            // chbHasStar
            // 
            this.chbHasStar.AutoSize = true;
            this.chbHasStar.Location = new System.Drawing.Point(236, 50);
            this.chbHasStar.Name = "chbHasStar";
            this.chbHasStar.Size = new System.Drawing.Size(174, 29);
            this.chbHasStar.TabIndex = 16;
            this.chbHasStar.Text = "وضعیت اضطراری";
            this.chbHasStar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(873, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "نام آزمایش";
            // 
            // cmbTestName
            // 
            this.cmbTestName.FormattingEnabled = true;
            this.cmbTestName.Location = new System.Drawing.Point(746, 49);
            this.cmbTestName.Name = "cmbTestName";
            this.cmbTestName.Size = new System.Drawing.Size(121, 33);
            this.cmbTestName.TabIndex = 5;
            this.cmbTestName.SelectedValueChanged += new System.EventHandler(this.cmbTestName_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(1122, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "رده آزمایش";
            // 
            // cmbTestCategory
            // 
            this.cmbTestCategory.FormattingEnabled = true;
            this.cmbTestCategory.Location = new System.Drawing.Point(995, 49);
            this.cmbTestCategory.Name = "cmbTestCategory";
            this.cmbTestCategory.Size = new System.Drawing.Size(121, 33);
            this.cmbTestCategory.TabIndex = 3;
            this.cmbTestCategory.SelectedIndexChanged += new System.EventHandler(this.cmbTestCategory_SelectedIndexChanged);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // FrmPatientTestHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Laboratory.Properties.Resources.the_science_biology_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1482, 653);
            this.Controls.Add(this.grpPatientTestDetails);
            this.Controls.Add(this.grpPatientTestHeader);
            this.Controls.Add(this.grpTestHeader);
            this.Controls.Add(this.grdPatientTestDetail);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPatientTestHeader";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.Text = "فرم سربرگ پذیرش";
            this.Load += new System.EventHandler(this.FrmPatientTestHeader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPatientTestDetail)).EndInit();
            this.grpTestHeader.ResumeLayout(false);
            this.grpTestHeader.PerformLayout();
            this.grpPatientTestHeader.ResumeLayout(false);
            this.grpPatientTestHeader.PerformLayout();
            this.grpPatientTestDetails.ResumeLayout(false);
            this.grpPatientTestDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPatientTestDetail;
        private System.Windows.Forms.ComboBox cmbInsurance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstPatient;
        private System.Windows.Forms.TextBox txtSearchPatient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDrName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpTestHeader;
        private System.Windows.Forms.Label lblPatientTestHeaderID;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpPatientTestHeader;
        private System.Windows.Forms.GroupBox grpPatientTestDetails;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTestName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTestCategory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.CheckBox chbHasStar;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAddTestDetails;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblInsurance;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblDrName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblNationalCode;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTestCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPatientTestHeaderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnResult;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnHasStar;
        private System.Windows.Forms.DataGridViewButtonColumn clmnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn clmnDelete;
    }
}