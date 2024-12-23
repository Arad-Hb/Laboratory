using DomainModel.Models;
using FarsiLibrary.Win.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory
{
    public partial class FrmPatient : Form
    {
        DataAccess.PatientRepository pntRepo = new DataAccess.PatientRepository();
        int patientID;



        public FrmPatient()
        {
            InitializeComponent();
        }
        #region DataBinders
        private void BindGrid()
        {

            grdPatient.AutoGenerateColumns = false;
            grdPatient.DataSource = null;
            grdPatient.DataSource = pntRepo.GetAll();

        }

        #endregion
        #region Utility
        private void GoToAddMode()
        {
            btnAddNew.Enabled = true;
            btnCancel.Enabled = false;
            btnEdit.Enabled = false;

            btnAddNew.BackColor = Color.Teal;
            btnCancel.BackColor = Color.DarkGray;
            btnEdit.BackColor = Color.DarkGray;
        }
        private void GoToEditMode()
        {
            btnAddNew.Enabled = false;
            btnCancel.Enabled = true;
            btnEdit.Enabled = true;

            btnAddNew.BackColor = Color.DarkGray;
            btnCancel.BackColor = Color.Teal;
            btnEdit.BackColor = Color.Teal;
        }
        private void ClearForm()
        {
            ClearControls(this.Controls);
            foreach (var groupBox in this.Controls.OfType<GroupBox>())
            {
                ClearControls(groupBox.Controls);
            }
        }
        private void ClearControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                switch (ctrl)
                {
                    case TextBox textBox:
                        textBox.Clear();
                        break;
                    case ComboBox comboBox:
                        comboBox.SelectedIndex = 0;
                        break;
                    case CheckBox checkBox:
                        checkBox.Checked = false;
                        break;
                    case RadioButton radioButton:
                        radioButton.Checked = false;
                        break;
                    case DateTimePicker dateTimePicker:
                        dateTimePicker.Text = "[هیج مقداری انتخاب نشده]";
                        break;
                    case FADatePicker datePicker:
                        datePicker.Text = "[هیج مقداری انتخاب نشده]";
                        break;
                }
            }
        }

        #endregion
        #region Checking
        private bool CheckInputs()
        {
            bool result = true;
            foreach (System.Windows.Forms.Control ctrl in this.Controls)
            {
                if (ctrl is TextBox txt)
                {
                    switch (txt.Name)
                    {
                        case "txtFirstName":
                            if (!CheckIsPersianLetters(txt.Text))
                            {
                                err.SetError(txtFirstName, "نام را به درستی وارد نمایید");
                                result = false;
                            }
                            break;

                        case "txtLastName":
                            if (!CheckIsPersianLetters(txt.Text))
                            {
                                err.SetError(txtLastName, "نام خانوادگی را به درستی وارد نمایید");
                                result = false;
                            }
                            break;

                        case "txtAddress":
                            if (!CheckAddress(txt.Text))
                            {
                                err.SetError(txtAddress, "آدرس را به درستی وارد نمایید");
                                result = false;
                            }
                            break;

                        case "txtMobile":
                            if (!CheckIsNumericWithLength(txt.Text, 11))
                            {
                                err.SetError(txtMobile, "شماره موبایل را به درستی وارد نمایید");
                                result = false;
                            }
                            break;

                        case "txtNationalCode":
                            if (!CheckIsNumericWithLength(txt.Text, 10))
                            {
                                err.SetError(txtNationalCode, "کد ملی را به درستی وارد نمایید");
                                result = false;
                            }
                            break;
                    }
                }
                
            }
            foreach (GroupBox groupBox in this.Controls.OfType<GroupBox>())
            {
                foreach (Control ctrl in groupBox.Controls)
                {
                    if (ctrl is RadioButton rdb)
                    {
                        if (!rdbMan.Checked && !rdbWoman.Checked)
                        {
                            err.SetError(grpGender, "لطفا جنسیت را انتخاب کنید!!");
                            result = false;
                        }
                    }
                }
            }
            return result;
        }
        private bool CheckIsNumericWithLength(string input, int length)
        {
            return !string.IsNullOrEmpty(input) &&
                   input.Length == length &&
                   long.TryParse(input, out _);
        }
        private bool CheckIsPersianLetters(string input)
        {
            string pattern = @"^[\u0600-\u06FF\s]+$";
            return !string.IsNullOrEmpty(input) && Regex.IsMatch(input, pattern);
        }
        private bool CheckAddress(string input)
        {
            string pattern = @"^[\u0600-\u06FF0-9,.\-_ ]*$";
            return Regex.IsMatch(input, pattern);
        }
        #endregion
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            err.Clear();
            if (CheckInputs())
            {
                var oldPatient = pntRepo.HasPastFile(txtNationalCode.Text);
                if (oldPatient == null)
                {
                    Patient patient = new Patient
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Mobile = txtMobile.Text,
                        NationalCode = txtNationalCode.Text,
                        Address = txtAddress.Text,
                        Jensiat = rdbMan.Checked
                    };
                    pntRepo.Add(patient);
                    ClearForm();
                    BindGrid();
                }
                else
                {
                    MessageBox.Show("مراجع مورد نظر قبلا پرونده سازی کرده است . شماره ی پرونده:" + "   " + oldPatient.PatientID);
                    txtNationalCode.Focus();
                }
            }
            else
            {
                MessageBox.Show("لطفا موارد اشتباه را تصحیح نمایید!!");
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (CheckInputs())
            {
                   Patient patient = new Patient
               {
                   PatientID = patientID,
                   FirstName = txtFirstName.Text,
                   LastName = txtLastName.Text,
                   Mobile = txtMobile.Text,
                   Address = txtAddress.Text,
                   NationalCode = txtNationalCode.Text,
                   Jensiat = rdbMan.Checked
               };
               pntRepo.Update(patient);
               ClearForm();
               BindGrid();
               GoToAddMode();
            }
            else
            {
                MessageBox.Show("لطفا موارد اشتباه را تصحیح نمایید!!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            err.Clear();
            GoToAddMode();
            ClearForm();
            BindGrid();
        }

        private void FrmPatient_Load(object sender, EventArgs e)
        {
            BindGrid();
            GoToAddMode();
        }

        private void grdPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            err.Clear();
            patientID = Convert.ToInt32(grdPatient.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == 8)
            {
                if (MessageBox.Show("آیا می خواهید این مورد را حذف کنید؟", "هشدار!!!!!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (!pntRepo.HasRecords(patientID))
                    {
                        bool s = pntRepo.Delete(patientID);
                        if (s)
                        {
                            BindGrid();
                            GoToAddMode();
                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show("عملیات حذف انجام پذیر نمی باشد!!!!!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("این مورد دارای سوابق ثبتی می باشد و حذف آن ممکن نیست!!!!!");
                    }
                }
            }
            if (e.ColumnIndex == 7)
            {
                err.Clear();
                var pnt = pntRepo.GetById(patientID);

                if (pnt.Jensiat)
                {
                    rdbMan.Checked = true;
                }
                else
                {
                    rdbWoman.Checked = true;
                }
                txtFirstName.Text = pnt.FirstName;
                txtLastName.Text = pnt.LastName;
                txtMobile.Text = pnt.Mobile;
                txtAddress.Text = pnt.Address;
                txtNationalCode.Text = pnt.NationalCode;
                GoToEditMode();
            }

        }
 
    }
}
