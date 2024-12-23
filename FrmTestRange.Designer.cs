namespace Laboratory
{
    partial class FrmTestRange
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
            this.grdTestRange = new System.Windows.Forms.DataGridView();
            this.clmnRangeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnFromValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnToValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnJensiat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnHazard = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTestName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chbHazard = new System.Windows.Forms.CheckBox();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rdbWoman = new System.Windows.Forms.RadioButton();
            this.rdbMan = new System.Windows.Forms.RadioButton();
            this.grpAge = new System.Windows.Forms.GroupBox();
            this.txtToAge = new System.Windows.Forms.TextBox();
            this.txtFromAge = new System.Windows.Forms.TextBox();
            this.grpValue = new System.Windows.Forms.GroupBox();
            this.txtToValue = new System.Windows.Forms.TextBox();
            this.txtFromValue = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdTestRange)).BeginInit();
            this.grpGender.SuspendLayout();
            this.grpAge.SuspendLayout();
            this.grpValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTestRange
            // 
            this.grdTestRange.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.grdTestRange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTestRange.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnRangeID,
            this.clmnTestName,
            this.clmnFromValue,
            this.clmnUnit,
            this.clmnToValue,
            this.clmnJensiat,
            this.clmnDescription,
            this.clmnHazard,
            this.clmnEdit,
            this.clmnDelete});
            this.grdTestRange.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdTestRange.Location = new System.Drawing.Point(0, 409);
            this.grdTestRange.Name = "grdTestRange";
            this.grdTestRange.RowHeadersWidth = 51;
            this.grdTestRange.RowTemplate.Height = 24;
            this.grdTestRange.Size = new System.Drawing.Size(982, 244);
            this.grdTestRange.TabIndex = 0;
            this.grdTestRange.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTestRange_CellContentClick);
            // 
            // clmnRangeID
            // 
            this.clmnRangeID.DataPropertyName = "RangeID";
            this.clmnRangeID.HeaderText = "شناسه بازه آزمایش";
            this.clmnRangeID.MinimumWidth = 6;
            this.clmnRangeID.Name = "clmnRangeID";
            this.clmnRangeID.Visible = false;
            this.clmnRangeID.Width = 80;
            // 
            // clmnTestName
            // 
            this.clmnTestName.DataPropertyName = "TestName";
            this.clmnTestName.HeaderText = "نام آزمایش";
            this.clmnTestName.MinimumWidth = 6;
            this.clmnTestName.Name = "clmnTestName";
            this.clmnTestName.ToolTipText = "نام آزمایش";
            this.clmnTestName.Width = 150;
            // 
            // clmnFromValue
            // 
            this.clmnFromValue.DataPropertyName = "Value";
            this.clmnFromValue.HeaderText = "مقدار";
            this.clmnFromValue.MinimumWidth = 6;
            this.clmnFromValue.Name = "clmnFromValue";
            this.clmnFromValue.ToolTipText = "مقدار";
            this.clmnFromValue.Width = 125;
            // 
            // clmnUnit
            // 
            this.clmnUnit.DataPropertyName = "Unit";
            this.clmnUnit.HeaderText = "واحد";
            this.clmnUnit.MinimumWidth = 6;
            this.clmnUnit.Name = "clmnUnit";
            this.clmnUnit.ToolTipText = "واحد";
            this.clmnUnit.Width = 80;
            // 
            // clmnToValue
            // 
            this.clmnToValue.DataPropertyName = "Age";
            this.clmnToValue.HeaderText = "سن";
            this.clmnToValue.MinimumWidth = 6;
            this.clmnToValue.Name = "clmnToValue";
            this.clmnToValue.ToolTipText = "سن";
            this.clmnToValue.Width = 80;
            // 
            // clmnJensiat
            // 
            this.clmnJensiat.DataPropertyName = "Jensiat";
            this.clmnJensiat.HeaderText = "جنسیت";
            this.clmnJensiat.MinimumWidth = 6;
            this.clmnJensiat.Name = "clmnJensiat";
            this.clmnJensiat.ToolTipText = "جنسیت";
            this.clmnJensiat.Width = 80;
            // 
            // clmnDescription
            // 
            this.clmnDescription.DataPropertyName = "Description";
            this.clmnDescription.HeaderText = "توضیحات";
            this.clmnDescription.MinimumWidth = 6;
            this.clmnDescription.Name = "clmnDescription";
            this.clmnDescription.ToolTipText = "توضیحات";
            this.clmnDescription.Width = 170;
            // 
            // clmnHazard
            // 
            this.clmnHazard.DataPropertyName = "Hazard";
            this.clmnHazard.HeaderText = "اضطرار";
            this.clmnHazard.MinimumWidth = 6;
            this.clmnHazard.Name = "clmnHazard";
            this.clmnHazard.Width = 60;
            // 
            // clmnEdit
            // 
            this.clmnEdit.HeaderText = "ویرایش";
            this.clmnEdit.MinimumWidth = 6;
            this.clmnEdit.Name = "clmnEdit";
            this.clmnEdit.Text = "ویرایش";
            this.clmnEdit.UseColumnTextForButtonValue = true;
            this.clmnEdit.Width = 125;
            // 
            // clmnDelete
            // 
            this.clmnDelete.HeaderText = "حذف";
            this.clmnDelete.MinimumWidth = 6;
            this.clmnDelete.Name = "clmnDelete";
            this.clmnDelete.Text = "حذف";
            this.clmnDelete.UseColumnTextForButtonValue = true;
            this.clmnDelete.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(475, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "تنظیمات برای آزمایش:";
            // 
            // lblTestName
            // 
            this.lblTestName.AutoSize = true;
            this.lblTestName.BackColor = System.Drawing.Color.Transparent;
            this.lblTestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTestName.Location = new System.Drawing.Point(233, 21);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(130, 36);
            this.lblTestName.TabIndex = 4;
            this.lblTestName.Text = "نام آزمایش";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(194, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "از";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(88, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "به";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(386, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "توضیحات";
            // 
            // chbHazard
            // 
            this.chbHazard.AutoSize = true;
            this.chbHazard.BackColor = System.Drawing.Color.Transparent;
            this.chbHazard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbHazard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chbHazard.Location = new System.Drawing.Point(105, 222);
            this.chbHazard.Name = "chbHazard";
            this.chbHazard.Size = new System.Drawing.Size(360, 29);
            this.chbHazard.TabIndex = 15;
            this.chbHazard.Text = "این محدوده یک وضعیت اضطراری می باشد!";
            this.chbHazard.UseVisualStyleBackColor = false;
            // 
            // grpGender
            // 
            this.grpGender.BackColor = System.Drawing.Color.Transparent;
            this.grpGender.Controls.Add(this.rdbWoman);
            this.grpGender.Controls.Add(this.rdbMan);
            this.grpGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpGender.Location = new System.Drawing.Point(503, 283);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(399, 100);
            this.grpGender.TabIndex = 16;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "جنسیت را تعیین کنید";
            // 
            // rdbWoman
            // 
            this.rdbWoman.AutoSize = true;
            this.rdbWoman.Location = new System.Drawing.Point(24, 45);
            this.rdbWoman.Name = "rdbWoman";
            this.rdbWoman.Size = new System.Drawing.Size(56, 29);
            this.rdbWoman.TabIndex = 1;
            this.rdbWoman.TabStop = true;
            this.rdbWoman.Text = "زن";
            this.rdbWoman.UseVisualStyleBackColor = true;
            // 
            // rdbMan
            // 
            this.rdbMan.AutoSize = true;
            this.rdbMan.Location = new System.Drawing.Point(130, 45);
            this.rdbMan.Name = "rdbMan";
            this.rdbMan.Size = new System.Drawing.Size(61, 29);
            this.rdbMan.TabIndex = 0;
            this.rdbMan.TabStop = true;
            this.rdbMan.Text = "مرد";
            this.rdbMan.UseVisualStyleBackColor = true;
            // 
            // grpAge
            // 
            this.grpAge.BackColor = System.Drawing.Color.Transparent;
            this.grpAge.Controls.Add(this.txtToAge);
            this.grpAge.Controls.Add(this.txtFromAge);
            this.grpAge.Controls.Add(this.label3);
            this.grpAge.Controls.Add(this.label4);
            this.grpAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAge.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpAge.Location = new System.Drawing.Point(503, 177);
            this.grpAge.Name = "grpAge";
            this.grpAge.Size = new System.Drawing.Size(399, 100);
            this.grpAge.TabIndex = 17;
            this.grpAge.TabStop = false;
            this.grpAge.Text = "بازه ی سنی را تعیین کنید";
            // 
            // txtToAge
            // 
            this.txtToAge.Location = new System.Drawing.Point(23, 41);
            this.txtToAge.Name = "txtToAge";
            this.txtToAge.Size = new System.Drawing.Size(62, 30);
            this.txtToAge.TabIndex = 10;
            // 
            // txtFromAge
            // 
            this.txtFromAge.Location = new System.Drawing.Point(129, 42);
            this.txtFromAge.Name = "txtFromAge";
            this.txtFromAge.Size = new System.Drawing.Size(62, 30);
            this.txtFromAge.TabIndex = 9;
            // 
            // grpValue
            // 
            this.grpValue.BackColor = System.Drawing.Color.Transparent;
            this.grpValue.Controls.Add(this.txtToValue);
            this.grpValue.Controls.Add(this.txtFromValue);
            this.grpValue.Controls.Add(this.label11);
            this.grpValue.Controls.Add(this.label12);
            this.grpValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpValue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpValue.Location = new System.Drawing.Point(503, 71);
            this.grpValue.Name = "grpValue";
            this.grpValue.Size = new System.Drawing.Size(399, 100);
            this.grpValue.TabIndex = 18;
            this.grpValue.TabStop = false;
            this.grpValue.Text = "بازه ی مقداری را تعیین کنید";
            // 
            // txtToValue
            // 
            this.txtToValue.Location = new System.Drawing.Point(20, 41);
            this.txtToValue.Name = "txtToValue";
            this.txtToValue.Size = new System.Drawing.Size(62, 30);
            this.txtToValue.TabIndex = 10;
            // 
            // txtFromValue
            // 
            this.txtFromValue.Location = new System.Drawing.Point(125, 41);
            this.txtFromValue.Name = "txtFromValue";
            this.txtFromValue.Size = new System.Drawing.Size(62, 30);
            this.txtFromValue.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(194, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 25);
            this.label11.TabIndex = 6;
            this.label11.Text = "از";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(88, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 25);
            this.label12.TabIndex = 8;
            this.label12.Text = "به";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(111, 85);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(269, 101);
            this.txtDescription.TabIndex = 19;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Teal;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Location = new System.Drawing.Point(105, 314);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 42);
            this.btnCancel.TabIndex = 80;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Teal;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEdit.Location = new System.Drawing.Point(234, 314);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(123, 42);
            this.btnEdit.TabIndex = 79;
            this.btnEdit.Text = "ثبت ویرایش";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Teal;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddNew.Location = new System.Drawing.Point(363, 314);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(123, 42);
            this.btnAddNew.TabIndex = 78;
            this.btnAddNew.Text = "ثبت";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // FrmTestRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Laboratory.Properties.Resources.the_science_biology_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.grpValue);
            this.Controls.Add(this.grpAge);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.chbHazard);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTestName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdTestRange);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmTestRange";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.Text = "مدیریت بازه ی آزمایش";
            this.Load += new System.EventHandler(this.FrmTestRange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTestRange)).EndInit();
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.grpAge.ResumeLayout(false);
            this.grpAge.PerformLayout();
            this.grpValue.ResumeLayout(false);
            this.grpValue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdTestRange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTestName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbHazard;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.GroupBox grpAge;
        private System.Windows.Forms.TextBox txtToAge;
        private System.Windows.Forms.TextBox txtFromAge;
        private System.Windows.Forms.GroupBox grpValue;
        private System.Windows.Forms.TextBox txtToValue;
        private System.Windows.Forms.TextBox txtFromValue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.RadioButton rdbWoman;
        private System.Windows.Forms.RadioButton rdbMan;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnRangeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnFromValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnToValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnJensiat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDescription;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnHazard;
        private System.Windows.Forms.DataGridViewButtonColumn clmnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn clmnDelete;
    }
}