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

namespace Laboratory
{
    public partial class FrmLogin : Form
    {
        #region Checking
        private bool CheckUsernameAndPasswordCharacters(string input)
        {
            string pattern = @"^[a-zA-Z0-9@$_\-.]+$";
            return !string.IsNullOrEmpty(input) && Regex.IsMatch(input, pattern);
        }
        #endregion
        public FrmLogin()
        {
            InitializeComponent();
        }
        
        private void btnEnter_Click(object sender, EventArgs e)
        {
            err.Clear();
            DataAccess.EmployeeRepository empRepo = new DataAccess.EmployeeRepository();

            if (empRepo.Login(txtUserName.Text, txtPassword.Text))
            {
                FrmMain frm = new FrmMain(empRepo.GetByUserName(txtUserName.Text));
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("اطلاعات وارد شده صحیح نمی باشد!!!!");
            }
        }
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (!CheckUsernameAndPasswordCharacters(txtUserName.Text)) 
                err.SetError(txtUserName, "(اعدادوحروف انگلیسی و $ و @ و . و - و _ مجاز هستند)");
            else err.Clear();
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!CheckUsernameAndPasswordCharacters(txtPassword.Text)) 
                err.SetError(txtPassword, "(اعدادوحروف انگلیسی و $ و @ و . و - و _ مجاز هستند)");
            else err.Clear();
        }
       
    }
}
