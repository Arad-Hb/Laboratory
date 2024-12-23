namespace Laboratory
{
    partial class FrmPatientTestResult
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
            this.grpPatientTestDetails = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnAddDetails = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.chbHasStar = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTestName = new System.Windows.Forms.ComboBox();
            this.btnEditDetail = new System.Windows.Forms.Button();
            this.btnCancelDetail = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTestCategory = new System.Windows.Forms.ComboBox();
            this.grpTestHeader = new System.Windows.Forms.GroupBox();
            this.btnSearchTestHeader = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTestHeader = new System.Windows.Forms.ComboBox();
            this.txtTestHeaderID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchPatient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSearchPatient = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelHeader = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblNationalCode = new System.Windows.Forms.Label();
            this.faDateHeader = new FarsiLibrary.Win.Controls.FADatePicker();
            this.btnDeleteHeader = new System.Windows.Forms.Button();
            this.btnUpdateHeader = new System.Windows.Forms.Button();
            this.cmbInsurance = new System.Windows.Forms.ComboBox();
            this.txtDrName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPatientTestHeaderID = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.grdPatientTestDetail)).BeginInit();
            this.grpPatientTestDetails.SuspendLayout();
            this.grpTestHeader.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.grdPatientTestDetail.Location = new System.Drawing.Point(0, 469);
            this.grdPatientTestDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdPatientTestDetail.Name = "grdPatientTestDetail";
            this.grdPatientTestDetail.RowHeadersWidth = 51;
            this.grdPatientTestDetail.RowTemplate.Height = 24;
            this.grdPatientTestDetail.Size = new System.Drawing.Size(1482, 184);
            this.grdPatientTestDetail.TabIndex = 1;
            this.grdPatientTestDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPatientTestDetail_CellContentClick);
            // 
            // grpPatientTestDetails
            // 
            this.grpPatientTestDetails.BackColor = System.Drawing.Color.Transparent;
            this.grpPatientTestDetails.Controls.Add(this.lblPrice);
            this.grpPatientTestDetails.Controls.Add(this.btnAddDetails);
            this.grpPatientTestDetails.Controls.Add(this.label10);
            this.grpPatientTestDetails.Controls.Add(this.txtResult);
            this.grpPatientTestDetails.Controls.Add(this.chbHasStar);
            this.grpPatientTestDetails.Controls.Add(this.label8);
            this.grpPatientTestDetails.Controls.Add(this.label5);
            this.grpPatientTestDetails.Controls.Add(this.cmbTestName);
            this.grpPatientTestDetails.Controls.Add(this.btnEditDetail);
            this.grpPatientTestDetails.Controls.Add(this.btnCancelDetail);
            this.grpPatientTestDetails.Controls.Add(this.label7);
            this.grpPatientTestDetails.Controls.Add(this.cmbTestCategory);
            this.grpPatientTestDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPatientTestDetails.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpPatientTestDetails.Location = new System.Drawing.Point(29, 313);
            this.grpPatientTestDetails.Name = "grpPatientTestDetails";
            this.grpPatientTestDetails.Size = new System.Drawing.Size(1407, 148);
            this.grpPatientTestDetails.TabIndex = 20;
            this.grpPatientTestDetails.TabStop = false;
            this.grpPatientTestDetails.Text = "اطلاعات آزمایش";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.Info;
            this.lblPrice.Location = new System.Drawing.Point(24, 53);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(24, 25);
            this.lblPrice.TabIndex = 20;
            this.lblPrice.Text = "0";
            // 
            // btnAddDetails
            // 
            this.btnAddDetails.BackColor = System.Drawing.Color.Teal;
            this.btnAddDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddDetails.Location = new System.Drawing.Point(315, 101);
            this.btnAddDetails.Name = "btnAddDetails";
            this.btnAddDetails.Size = new System.Drawing.Size(145, 41);
            this.btnAddDetails.TabIndex = 19;
            this.btnAddDetails.Text = "افزودن آزمایش";
            this.btnAddDetails.UseVisualStyleBackColor = false;
            this.btnAddDetails.Click += new System.EventHandler(this.btnAddDetails_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Info;
            this.label10.Location = new System.Drawing.Point(679, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "نتیجه";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(552, 55);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(121, 30);
            this.txtResult.TabIndex = 18;
            // 
            // chbHasStar
            // 
            this.chbHasStar.AutoSize = true;
            this.chbHasStar.ForeColor = System.Drawing.SystemColors.Info;
            this.chbHasStar.Location = new System.Drawing.Point(317, 57);
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
            this.label8.Location = new System.Drawing.Point(934, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "نام آزمایش";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(164, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "قیمت";
            // 
            // cmbTestName
            // 
            this.cmbTestName.FormattingEnabled = true;
            this.cmbTestName.Location = new System.Drawing.Point(807, 50);
            this.cmbTestName.Name = "cmbTestName";
            this.cmbTestName.Size = new System.Drawing.Size(121, 33);
            this.cmbTestName.TabIndex = 5;
            this.cmbTestName.SelectedIndexChanged += new System.EventHandler(this.cmbTestName_SelectedIndexChanged);
            // 
            // btnEditDetail
            // 
            this.btnEditDetail.BackColor = System.Drawing.Color.Teal;
            this.btnEditDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDetail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditDetail.Location = new System.Drawing.Point(164, 101);
            this.btnEditDetail.Name = "btnEditDetail";
            this.btnEditDetail.Size = new System.Drawing.Size(145, 41);
            this.btnEditDetail.TabIndex = 13;
            this.btnEditDetail.Text = "ثبت ویرایش";
            this.btnEditDetail.UseVisualStyleBackColor = false;
            this.btnEditDetail.Click += new System.EventHandler(this.btnEditDetail_Click);
            // 
            // btnCancelDetail
            // 
            this.btnCancelDetail.BackColor = System.Drawing.Color.Teal;
            this.btnCancelDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelDetail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelDetail.Location = new System.Drawing.Point(15, 101);
            this.btnCancelDetail.Name = "btnCancelDetail";
            this.btnCancelDetail.Size = new System.Drawing.Size(145, 41);
            this.btnCancelDetail.TabIndex = 12;
            this.btnCancelDetail.Text = "انصراف";
            this.btnCancelDetail.UseVisualStyleBackColor = false;
            this.btnCancelDetail.Click += new System.EventHandler(this.btnCancelDetail_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(1200, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "نوع آزمایش";
            // 
            // cmbTestCategory
            // 
            this.cmbTestCategory.FormattingEnabled = true;
            this.cmbTestCategory.Location = new System.Drawing.Point(1073, 50);
            this.cmbTestCategory.Name = "cmbTestCategory";
            this.cmbTestCategory.Size = new System.Drawing.Size(121, 33);
            this.cmbTestCategory.TabIndex = 3;
            this.cmbTestCategory.SelectedIndexChanged += new System.EventHandler(this.cmbTestCategory_SelectedIndexChanged);
            // 
            // grpTestHeader
            // 
            this.grpTestHeader.BackColor = System.Drawing.Color.Transparent;
            this.grpTestHeader.Controls.Add(this.btnSearchTestHeader);
            this.grpTestHeader.Controls.Add(this.label3);
            this.grpTestHeader.Controls.Add(this.cmbTestHeader);
            this.grpTestHeader.Controls.Add(this.txtTestHeaderID);
            this.grpTestHeader.Controls.Add(this.label2);
            this.grpTestHeader.Controls.Add(this.txtSearchPatient);
            this.grpTestHeader.Controls.Add(this.label1);
            this.grpTestHeader.Controls.Add(this.lstSearchPatient);
            this.grpTestHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpTestHeader.Location = new System.Drawing.Point(775, 12);
            this.grpTestHeader.Name = "grpTestHeader";
            this.grpTestHeader.Size = new System.Drawing.Size(661, 295);
            this.grpTestHeader.TabIndex = 21;
            this.grpTestHeader.TabStop = false;
            this.grpTestHeader.Text = "جستجوی سربرگ پذیرش";
            // 
            // btnSearchTestHeader
            // 
            this.btnSearchTestHeader.BackColor = System.Drawing.Color.Teal;
            this.btnSearchTestHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTestHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearchTestHeader.Location = new System.Drawing.Point(6, 248);
            this.btnSearchTestHeader.Name = "btnSearchTestHeader";
            this.btnSearchTestHeader.Size = new System.Drawing.Size(145, 41);
            this.btnSearchTestHeader.TabIndex = 19;
            this.btnSearchTestHeader.Text = " جستجو";
            this.btnSearchTestHeader.UseVisualStyleBackColor = false;
            this.btnSearchTestHeader.Click += new System.EventHandler(this.btnSearchTestHeader_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(478, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "انتخاب سربرگ :";
            // 
            // cmbTestHeader
            // 
            this.cmbTestHeader.FormattingEnabled = true;
            this.cmbTestHeader.Location = new System.Drawing.Point(6, 208);
            this.cmbTestHeader.Name = "cmbTestHeader";
            this.cmbTestHeader.Size = new System.Drawing.Size(466, 33);
            this.cmbTestHeader.TabIndex = 13;
            this.cmbTestHeader.SelectedIndexChanged += new System.EventHandler(this.cmbTestHeader_SelectedIndexChanged);
            // 
            // txtTestHeaderID
            // 
            this.txtTestHeaderID.Location = new System.Drawing.Point(402, 256);
            this.txtTestHeaderID.Name = "txtTestHeaderID";
            this.txtTestHeaderID.Size = new System.Drawing.Size(70, 30);
            this.txtTestHeaderID.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(478, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "جستجومراجع : ";
            // 
            // txtSearchPatient
            // 
            this.txtSearchPatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchPatient.Location = new System.Drawing.Point(6, 44);
            this.txtSearchPatient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchPatient.Name = "txtSearchPatient";
            this.txtSearchPatient.Size = new System.Drawing.Size(466, 23);
            this.txtSearchPatient.TabIndex = 6;
            this.txtSearchPatient.TextChanged += new System.EventHandler(this.txtSearchPatient_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(478, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "شماره پذیرش :";
            // 
            // lstSearchPatient
            // 
            this.lstSearchPatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstSearchPatient.FormattingEnabled = true;
            this.lstSearchPatient.ItemHeight = 25;
            this.lstSearchPatient.Location = new System.Drawing.Point(6, 67);
            this.lstSearchPatient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstSearchPatient.Name = "lstSearchPatient";
            this.lstSearchPatient.Size = new System.Drawing.Size(466, 125);
            this.lstSearchPatient.TabIndex = 7;
            this.lstSearchPatient.Visible = false;
            this.lstSearchPatient.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstSearchPatient_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.btnCancelHeader);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblNationalCode);
            this.groupBox1.Controls.Add(this.faDateHeader);
            this.groupBox1.Controls.Add(this.btnDeleteHeader);
            this.groupBox1.Controls.Add(this.btnUpdateHeader);
            this.groupBox1.Controls.Add(this.cmbInsurance);
            this.groupBox1.Controls.Add(this.txtDrName);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lblTotalPrice);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblPatientTestHeaderID);
            this.groupBox1.Controls.Add(this.lblMobile);
            this.groupBox1.Controls.Add(this.lblPatientName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 295);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "سربرگ پذیرش";
            // 
            // btnCancelHeader
            // 
            this.btnCancelHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelHeader.Location = new System.Drawing.Point(15, 248);
            this.btnCancelHeader.Name = "btnCancelHeader";
            this.btnCancelHeader.Size = new System.Drawing.Size(145, 41);
            this.btnCancelHeader.TabIndex = 23;
            this.btnCancelHeader.Text = "انصراف";
            this.btnCancelHeader.UseVisualStyleBackColor = false;
            this.btnCancelHeader.Click += new System.EventHandler(this.btnCancelHeader_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(23, 83);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(163, 30);
            this.txtAge.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Info;
            this.label13.Location = new System.Drawing.Point(609, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 25);
            this.label13.TabIndex = 32;
            this.label13.Text = "کد ملی :";
            // 
            // lblNationalCode
            // 
            this.lblNationalCode.AutoSize = true;
            this.lblNationalCode.ForeColor = System.Drawing.SystemColors.Info;
            this.lblNationalCode.Location = new System.Drawing.Point(423, 140);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.Size = new System.Drawing.Size(0, 25);
            this.lblNationalCode.TabIndex = 31;
            // 
            // faDateHeader
            // 
            this.faDateHeader.Location = new System.Drawing.Point(23, 39);
            this.faDateHeader.Name = "faDateHeader";
            this.faDateHeader.Size = new System.Drawing.Size(163, 24);
            this.faDateHeader.TabIndex = 30;
            // 
            // btnDeleteHeader
            // 
            this.btnDeleteHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteHeader.Location = new System.Drawing.Point(164, 248);
            this.btnDeleteHeader.Name = "btnDeleteHeader";
            this.btnDeleteHeader.Size = new System.Drawing.Size(145, 41);
            this.btnDeleteHeader.TabIndex = 21;
            this.btnDeleteHeader.Text = "حذف";
            this.btnDeleteHeader.UseVisualStyleBackColor = false;
            this.btnDeleteHeader.Click += new System.EventHandler(this.btnDeleteHeader_Click);
            // 
            // btnUpdateHeader
            // 
            this.btnUpdateHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdateHeader.Location = new System.Drawing.Point(315, 248);
            this.btnUpdateHeader.Name = "btnUpdateHeader";
            this.btnUpdateHeader.Size = new System.Drawing.Size(145, 41);
            this.btnUpdateHeader.TabIndex = 22;
            this.btnUpdateHeader.Text = "ثبت ویرایش";
            this.btnUpdateHeader.UseVisualStyleBackColor = false;
            this.btnUpdateHeader.Click += new System.EventHandler(this.btnUpdateHeader_Click);
            // 
            // cmbInsurance
            // 
            this.cmbInsurance.FormattingEnabled = true;
            this.cmbInsurance.Location = new System.Drawing.Point(21, 193);
            this.cmbInsurance.Name = "cmbInsurance";
            this.cmbInsurance.Size = new System.Drawing.Size(164, 33);
            this.cmbInsurance.TabIndex = 29;
            // 
            // txtDrName
            // 
            this.txtDrName.Location = new System.Drawing.Point(23, 135);
            this.txtDrName.Name = "txtDrName";
            this.txtDrName.Size = new System.Drawing.Size(163, 30);
            this.txtDrName.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Info;
            this.label12.Location = new System.Drawing.Point(536, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 25);
            this.label12.TabIndex = 27;
            this.label12.Text = "نام مراجعه کننده :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.Info;
            this.label17.Location = new System.Drawing.Point(251, 86);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 25);
            this.label17.TabIndex = 25;
            this.label17.Text = "سن :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.Info;
            this.label16.Location = new System.Drawing.Point(561, 196);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 25);
            this.label16.TabIndex = 24;
            this.label16.Text = "شماره موبایل :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.Info;
            this.label15.Location = new System.Drawing.Point(234, 196);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 25);
            this.label15.TabIndex = 22;
            this.label15.Text = "بیمه :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.Info;
            this.label14.Location = new System.Drawing.Point(186, 138);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 25);
            this.label14.TabIndex = 20;
            this.label14.Text = "پزشک معالج :";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.ForeColor = System.Drawing.SystemColors.Info;
            this.lblTotalPrice.Location = new System.Drawing.Point(511, 256);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(24, 25);
            this.lblTotalPrice.TabIndex = 17;
            this.lblTotalPrice.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Info;
            this.label11.Location = new System.Drawing.Point(583, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "مبلغ نهایی :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(560, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "شماره پذیرش :";
            // 
            // lblPatientTestHeaderID
            // 
            this.lblPatientTestHeaderID.AutoSize = true;
            this.lblPatientTestHeaderID.ForeColor = System.Drawing.SystemColors.Info;
            this.lblPatientTestHeaderID.Location = new System.Drawing.Point(423, 39);
            this.lblPatientTestHeaderID.Name = "lblPatientTestHeaderID";
            this.lblPatientTestHeaderID.Size = new System.Drawing.Size(0, 25);
            this.lblPatientTestHeaderID.TabIndex = 6;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.ForeColor = System.Drawing.SystemColors.Info;
            this.lblMobile.Location = new System.Drawing.Point(423, 196);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(0, 25);
            this.lblMobile.TabIndex = 4;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.ForeColor = System.Drawing.SystemColors.Info;
            this.lblPatientName.Location = new System.Drawing.Point(423, 86);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(0, 25);
            this.lblPatientName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(234, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "تاریخ :";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // clmnDrName
            // 
            this.clmnDrName.DataPropertyName = "PatientTestHeaderID";
            this.clmnDrName.HeaderText = "شماره پذیرش";
            this.clmnDrName.MinimumWidth = 6;
            this.clmnDrName.Name = "clmnDrName";
            this.clmnDrName.ToolTipText = "شماره پذیرش";
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
            this.clmnTestCategoryID.HeaderText = "کد گروه";
            this.clmnTestCategoryID.MinimumWidth = 6;
            this.clmnTestCategoryID.Name = "clmnTestCategoryID";
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
            // FrmPatientTestResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Laboratory.Properties.Resources.the_science_biology_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1482, 653);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpTestHeader);
            this.Controls.Add(this.grpPatientTestDetails);
            this.Controls.Add(this.grdPatientTestDetail);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPatientTestResult";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.Text = "مدیریت سربرگ پذیرش";
            this.Load += new System.EventHandler(this.FrmPatientTestResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPatientTestDetail)).EndInit();
            this.grpPatientTestDetails.ResumeLayout(false);
            this.grpPatientTestDetails.PerformLayout();
            this.grpTestHeader.ResumeLayout(false);
            this.grpTestHeader.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPatientTestDetail;
        private System.Windows.Forms.GroupBox grpPatientTestDetails;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAddDetails;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.CheckBox chbHasStar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTestName;
        private System.Windows.Forms.Button btnEditDetail;
        private System.Windows.Forms.Button btnCancelDetail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTestCategory;
        private System.Windows.Forms.GroupBox grpTestHeader;
        private System.Windows.Forms.Button btnSearchTestHeader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTestHeader;
        private System.Windows.Forms.TextBox txtTestHeaderID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSearchPatient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelHeader;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblNationalCode;
        private FarsiLibrary.Win.Controls.FADatePicker faDateHeader;
        private System.Windows.Forms.Button btnDeleteHeader;
        private System.Windows.Forms.Button btnUpdateHeader;
        private System.Windows.Forms.ComboBox cmbInsurance;
        private System.Windows.Forms.TextBox txtDrName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPatientTestHeaderID;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label label4;
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