using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laboratory
{
    public partial class FrmEmployee : Form
    {
        DataAccess.EmployeeRepository employeeRepo = new DataAccess.EmployeeRepository();

        int employeeID;

        public FrmEmployee()
        {
            InitializeComponent();
        }

        #region DataBinders
        private void BindGrid()
        {

            grdEmployee.AutoGenerateColumns = false;
            grdEmployee.DataSource = null;
            grdEmployee.DataSource = employeeRepo.GetAll();
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
            foreach (System.Windows.Forms.Control ctrl in this.Controls)
            {
                if (ctrl is System.Windows.Forms.TextBox)
                {
                    var txt = (System.Windows.Forms.TextBox)ctrl;
                    txt.Text = "";
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
                if (ctrl is System.Windows.Forms.TextBox txt)
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

                        case "txtMobile":
                            if (!CheckIsNumericWithLength(txt.Text, 11))
                            {
                                err.SetError(txtMobile, "شماره موبایل را به درستی وارد نمایید");
                                result = false;
                            }
                            break;

                        case "txtUserName":
                            if (!CheckUsernameAndPasswordCharacters(txt.Text))
                            {
                                err.SetError(txtUserName, "(اعدادوحروف انگلیسی و $ و @ و . و - و _ مجاز هستند)");
                                result = false;
                            }
                            break;

                        case "txtPassword":
                            if (!CheckUsernameAndPasswordCharacters(txt.Text))
                            {
                                err.SetError(txtPassword, "(اعدادوحروف انگلیسی و $ و @ و . و - و _ مجاز هستند)");
                                result = false;
                            }
                            break;
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
        private bool CheckUsernameAndPasswordCharacters(string input)
        {
            string pattern = @"^[a-zA-Z0-9@$_\-.]+$";
            return !string.IsNullOrEmpty(input) && Regex.IsMatch(input, pattern);
        }
        #endregion
        
        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            BindGrid();
            GoToAddMode();
        }
        private void grdEmployee_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            employeeID = Convert.ToInt32(grdEmployee.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == 7)
            {
                if (MessageBox.Show("آیا می خواهید این مورد را حذف کنید؟", "هشدار!!!!!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (!employeeRepo.HasRecords(employeeID))
                    {
                        if (employeeRepo.Delete(employeeID))
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
            if (e.ColumnIndex == 6)
            {
                err.Clear();
                var emp = employeeRepo.GetById(employeeID);
                txtFirstName.Text = emp.FirstName;
                txtLastName.Text = emp.LastName;
                txtPassword.Text = emp.Password;
                txtUserName.Text = emp.UserName;
                txtMobile.Text = emp.Mobile;
                GoToEditMode();
            } 
        }
        private void btnAddNew_Click_1(object sender, EventArgs e)
        {
            err.Clear();
            if (CheckInputs())
            {
                Employee employee = new Employee 
                { FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Mobile = txtMobile.Text,
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text 
                };
                employeeRepo.Add(employee);
                ClearForm();
                BindGrid();
            }
            else
            {
                MessageBox.Show("لطفا موارد اشتباه را تصحیح کنید!!");
            }
        }
        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (CheckInputs())
            {
                Employee employee = new Employee 
                { FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Mobile = txtMobile.Text,
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text,
                    EmployeeID = employeeID 
                };
                employeeRepo.Update(employee);
                BindGrid();
                ClearForm();
                GoToAddMode();
            }
            else
            {
                MessageBox.Show("لطفا موارد اشتباه را تصحیح کنید!!");
            }
        }
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            err.Clear();
            GoToAddMode();
            ClearForm();
            BindGrid();
        }
    }
}
