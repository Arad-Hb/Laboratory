namespace Laboratory
{
    partial class FrmTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.grdTest = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.txtMethod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chbGender = new System.Windows.Forms.CheckBox();
            this.chbAge = new System.Windows.Forms.CheckBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.clmnTestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnUnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnAge = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnGender = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmnTestRanges = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(699, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام آزمایش";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(740, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "قیمت";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(350, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "دسته بندی";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(391, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "واحد";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(484, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(205, 26);
            this.txtName.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.Location = new System.Drawing.Point(484, 87);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(205, 26);
            this.txtPrice.TabIndex = 7;
            // 
            // cmbCategory
            // 
            this.cmbCategory.ForeColor = System.Drawing.Color.Black;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(174, 41);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(170, 28);
            this.cmbCategory.TabIndex = 10;
            // 
            // cmbUnit
            // 
            this.cmbUnit.ForeColor = System.Drawing.Color.Black;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(174, 111);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(170, 28);
            this.cmbUnit.TabIndex = 11;
            // 
            // grdTest
            // 
            this.grdTest.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.grdTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnTestID,
            this.clmnTestName,
            this.clmnPrice,
            this.clmnUnitName,
            this.clmnCategoryName,
            this.clmnMethod,
            this.clmnAge,
            this.clmnGender,
            this.clmnUpdate,
            this.clmnDelete,
            this.clmnTestRanges});
            this.grdTest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdTest.GridColor = System.Drawing.SystemColors.Control;
            this.grdTest.Location = new System.Drawing.Point(0, 313);
            this.grdTest.Name = "grdTest";
            this.grdTest.RowHeadersWidth = 51;
            this.grdTest.RowTemplate.Height = 24;
            this.grdTest.Size = new System.Drawing.Size(982, 240);
            this.grdTest.TabIndex = 12;
            this.grdTest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTest_CellContentClick);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Teal;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Location = new System.Drawing.Point(151, 251);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(198, 42);
            this.btnCancel.TabIndex = 77;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Teal;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEdit.Location = new System.Drawing.Point(375, 251);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(198, 42);
            this.btnEdit.TabIndex = 76;
            this.btnEdit.Text = "ثبت ویرایش";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Teal;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddNew.Location = new System.Drawing.Point(596, 251);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(198, 42);
            this.btnAddNew.TabIndex = 75;
            this.btnAddNew.Text = "ثبت";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // txtMethod
            // 
            this.txtMethod.BackColor = System.Drawing.SystemColors.Window;
            this.txtMethod.ForeColor = System.Drawing.Color.Black;
            this.txtMethod.Location = new System.Drawing.Point(484, 130);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.Size = new System.Drawing.Size(205, 26);
            this.txtMethod.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(736, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 78;
            this.label5.Text = "تکنیک";
            // 
            // chbGender
            // 
            this.chbGender.AutoSize = true;
            this.chbGender.BackColor = System.Drawing.Color.Transparent;
            this.chbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbGender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chbGender.Location = new System.Drawing.Point(497, 185);
            this.chbGender.Name = "chbGender";
            this.chbGender.Size = new System.Drawing.Size(192, 29);
            this.chbGender.TabIndex = 80;
            this.chbGender.Text = "جنسیت موثر می باشد";
            this.chbGender.UseVisualStyleBackColor = false;
            // 
            // chbAge
            // 
            this.chbAge.AutoSize = true;
            this.chbAge.BackColor = System.Drawing.Color.Transparent;
            this.chbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAge.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chbAge.Location = new System.Drawing.Point(173, 185);
            this.chbAge.Name = "chbAge";
            this.chbAge.Size = new System.Drawing.Size(171, 29);
            this.chbAge.TabIndex = 81;
            this.chbAge.Text = " سن موثر می باشد";
            this.chbAge.UseVisualStyleBackColor = false;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // clmnTestID
            // 
            this.clmnTestID.DataPropertyName = "TestID";
            this.clmnTestID.HeaderText = "شناسه آزمایش";
            this.clmnTestID.MinimumWidth = 6;
            this.clmnTestID.Name = "clmnTestID";
            this.clmnTestID.ToolTipText = "شناسه آزمایش";
            this.clmnTestID.Visible = false;
            this.clmnTestID.Width = 125;
            // 
            // clmnTestName
            // 
            this.clmnTestName.DataPropertyName = "TestName";
            this.clmnTestName.HeaderText = "نام آزمایش";
            this.clmnTestName.MinimumWidth = 6;
            this.clmnTestName.Name = "clmnTestName";
            this.clmnTestName.ToolTipText = "نام آزمایش";
            this.clmnTestName.Width = 125;
            // 
            // clmnPrice
            // 
            this.clmnPrice.DataPropertyName = "Price";
            this.clmnPrice.HeaderText = "قیمت";
            this.clmnPrice.MinimumWidth = 6;
            this.clmnPrice.Name = "clmnPrice";
            this.clmnPrice.ToolTipText = "قیمت";
            // 
            // clmnUnitName
            // 
            this.clmnUnitName.DataPropertyName = "UnitName";
            this.clmnUnitName.FillWeight = 90F;
            this.clmnUnitName.HeaderText = "واحد";
            this.clmnUnitName.MinimumWidth = 6;
            this.clmnUnitName.Name = "clmnUnitName";
            this.clmnUnitName.ToolTipText = "واحد";
            this.clmnUnitName.Width = 90;
            // 
            // clmnCategoryName
            // 
            this.clmnCategoryName.DataPropertyName = "CategoryName";
            this.clmnCategoryName.HeaderText = "دسته بندی";
            this.clmnCategoryName.MinimumWidth = 6;
            this.clmnCategoryName.Name = "clmnCategoryName";
            this.clmnCategoryName.ToolTipText = "دسته بندی";
            this.clmnCategoryName.Width = 110;
            // 
            // clmnMethod
            // 
            this.clmnMethod.DataPropertyName = "Method";
            this.clmnMethod.HeaderText = "تکنیک";
            this.clmnMethod.MinimumWidth = 6;
            this.clmnMethod.Name = "clmnMethod";
            this.clmnMethod.ToolTipText = "تکنیک";
            this.clmnMethod.Width = 90;
            // 
            // clmnAge
            // 
            this.clmnAge.DataPropertyName = "AgeHasEffect";
            this.clmnAge.HeaderText = "تاثیرسن";
            this.clmnAge.MinimumWidth = 6;
            this.clmnAge.Name = "clmnAge";
            this.clmnAge.ReadOnly = true;
            this.clmnAge.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnAge.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmnAge.Width = 75;
            // 
            // clmnGender
            // 
            this.clmnGender.DataPropertyName = "JensiatHasEffect";
            this.clmnGender.HeaderText = "تاثیرجنسیت";
            this.clmnGender.MinimumWidth = 6;
            this.clmnGender.Name = "clmnGender";
            this.clmnGender.ReadOnly = true;
            this.clmnGender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnGender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmnGender.Width = 85;
            // 
            // clmnUpdate
            // 
            this.clmnUpdate.HeaderText = "ویرایش";
            this.clmnUpdate.MinimumWidth = 6;
            this.clmnUpdate.Name = "clmnUpdate";
            this.clmnUpdate.Text = "ویرایش";
            this.clmnUpdate.UseColumnTextForButtonValue = true;
            this.clmnUpdate.Width = 80;
            // 
            // clmnDelete
            // 
            this.clmnDelete.HeaderText = "حذف";
            this.clmnDelete.MinimumWidth = 6;
            this.clmnDelete.Name = "clmnDelete";
            this.clmnDelete.Text = "حذف";
            this.clmnDelete.UseColumnTextForButtonValue = true;
            this.clmnDelete.Width = 80;
            // 
            // clmnTestRanges
            // 
            this.clmnTestRanges.HeaderText = "جزییات";
            this.clmnTestRanges.MinimumWidth = 6;
            this.clmnTestRanges.Name = "clmnTestRanges";
            this.clmnTestRanges.Text = "جزییات";
            this.clmnTestRanges.UseColumnTextForButtonValue = true;
            this.clmnTestRanges.Width = 80;
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Laboratory.Properties.Resources.the_science_biology_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.chbAge);
            this.Controls.Add(this.chbGender);
            this.Controls.Add(this.txtMethod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.grdTest);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTest";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.Text = "مدیریت آزمایش";
            this.Load += new System.EventHandler(this.FrmTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.DataGridView grdTest;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox txtMethod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbGender;
        private System.Windows.Forms.CheckBox chbAge;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnUnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnMethod;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnAge;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnGender;
        private System.Windows.Forms.DataGridViewButtonColumn clmnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn clmnDelete;
        private System.Windows.Forms.DataGridViewButtonColumn clmnTestRanges;
    }
}