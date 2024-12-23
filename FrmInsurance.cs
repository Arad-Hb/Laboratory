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
    public partial class FrmInsurance : Form
    {
        DataAccess.InsuranceTypeRepository insRepo=new DataAccess.InsuranceTypeRepository();
        int insuranceTypeID;
        public FrmInsurance()
        {
            InitializeComponent();
        }
        #region DataBinders
        private void BindGrid()
        {
            grdInsurance.AutoGenerateColumns = false;
            grdInsurance.DataSource = null;
            grdInsurance.DataSource = insRepo.GetAll();
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
                if (ctrl is TextBox)
                {
                    var txt = (TextBox)ctrl;
                    txt.Text = "";
                }
            }
        }
        private bool CheckInputs() 
        {
            bool result = true;
            foreach (System.Windows.Forms.Control ctrl in this.Controls)
            {
                if (ctrl is System.Windows.Forms.TextBox txt)
                {
                    switch (txt.Name)
                    {
                        case "txtInsuranceTypeName":
                            if (!CheckIsPersianLetters(txt.Text))
                            {
                                result = false;
                                return result;
                            }
                            break;
                    }
                }
            }
            return result;
        }
        private bool CheckIsPersianLetters(string input)
        {
            string pattern = @"^[\u0600-\u06FF\s]+$";
            return !string.IsNullOrEmpty(input) && Regex.IsMatch(input, pattern);
        }
        #endregion

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (CheckInputs())
            {
                InsuranceType insurance = new InsuranceType 
                { 
                    InsuranceTypeName = txtInsuranceTypeName.Text,
                    Description = txtDescription.Text 
                };
                insRepo.Add(insurance);
                ClearForm();
                BindGrid();
            }
            else
            {
                MessageBox.Show("لطفا از حروف فارسی استفاده کنید!!");
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (CheckInputs()) 
            {
                InsuranceType ins = new InsuranceType 
                { 
                    InsuranceTypeID = insuranceTypeID,
                    InsuranceTypeName = txtInsuranceTypeName.Text,
                    Description = txtDescription.Text 
                };
                insRepo.Update(ins);
                ClearForm();
                BindGrid();
                GoToAddMode();
            }
            else
            {
                MessageBox.Show("لطفا از حروف فارسی استفاده کنید!!");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            GoToAddMode();
            ClearForm();
            BindGrid();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            insuranceTypeID = Convert.ToInt32(grdInsurance.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == 4)
            {
                if (MessageBox.Show("آیا می خواهید این مورد را حذف کنید؟", "هشدار!!!!!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (!insRepo.HasRecords(insuranceTypeID))
                    {
                        bool s = insRepo.Delete(insuranceTypeID);
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
            if (e.ColumnIndex == 3)
            {
                var insurance = insRepo.GetById(insuranceTypeID);
                txtInsuranceTypeName.Text = insurance.InsuranceTypeName;
                txtDescription.Text = insurance.Description;
                GoToEditMode();
            }
        }
        private void FrmInsurance_Load(object sender, EventArgs e)
        {
            BindGrid();
            GoToAddMode();
        }
    }
}
