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
    public partial class FrmTest : Form
    {
        DataAccess.TestsRepository testRepo= new DataAccess.TestsRepository();
        int testID;
        double price=0;

        public FrmTest()
        {
            InitializeComponent();
        }
        #region DataBinders
        private void BindGrid()
        {
            grdTest.AutoGenerateColumns = false;
            grdTest.DataSource = null;
            grdTest.DataSource = testRepo.GetAll();
        }
        private void BindCategoryCmb()
        {
            DataAccess.TestCategoryRepository categoryRepo = new DataAccess.TestCategoryRepository();
            List<TestCategory> testCategories = categoryRepo.GetAll();
            testCategories.Insert(0, new TestCategory { CategoryID = -1, CategoryName = "انتخاب رده" });
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.DataSource = testCategories;
        }
        private void BindUnitCmb()
        {
            DataAccess.UnitRepository unitRepo= new DataAccess.UnitRepository();
            List<Unit> units = unitRepo.GetAll();
            units.Insert(0, new Unit { UnitID = -1, UnitName ="انتخاب واحد" });
            cmbUnit.DisplayMember = "UnitName";
            cmbUnit.ValueMember = "UnitID";
            cmbUnit.DataSource = units;
        }
        #endregion
        #region Utility
        private void GoToAddMode()
        {
            btnAddNew.Enabled = true;
            btnCancel.Enabled = false;
            btnEdit.Enabled = false;
            cmbUnit.SelectedValue = -1;
            cmbCategory.SelectedValue = -1;

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
        private void SetPrice()
        {
            if (txtPrice.Text.Length > 1)
            {
                price = Convert.ToDouble(txtPrice.Text);
            }
            else { price = 0; }
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
                if (ctrl is ComboBox)
                {
                    var cmb = (ComboBox)ctrl;
                    cmb.SelectedIndex = -1;
                }
                if(ctrl is CheckBox)
                {
                    var checkBox = (CheckBox)ctrl;
                    checkBox.Checked = false;
                }
                SetPrice();
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
                        case "txtName":
                            if (string.IsNullOrEmpty(txt.Text))
                            {
                                err.SetError(txtName, "نام را به درستی وارد نمایید");
                                result = false;
                            }
                            break;

                        case "txtPrice":
                            if (!CheckIsNumeric(txt.Text))
                            {
                                err.SetError(txtPrice, "قیمت را به درستی وارد نمایید");
                                result = false;
                            }
                            break;
                    }
                }
                if (ctrl is ComboBox cmb)
                {
                    switch (cmb.Name)
                    {
                        case "cmbCategory":
                            if (Convert.ToInt32(cmbCategory.SelectedValue) <=0)
                            {
                                err.SetError(cmbCategory, "نام دسته بندی را انتخاب نمایید");
                                result = false;
                            }
                            break;

                        case "cmbUnit":
                            if (Convert.ToInt32(cmbUnit.SelectedValue) <= 0)
                            {
                                err.SetError(cmbUnit, "واحد اندازه گیری را انتخاب نمایید");
                                result = false;
                            }
                            break;
                    }
                }
            }

            return result;
        }
        private bool CheckIsNumeric(string input)
        {
            return !string.IsNullOrEmpty(input) &&
                   long.TryParse(input, out _);
        }
        private bool CheckIsPersianLetters(string input)
        {
            string pattern = @"^[\u0600-\u06FF\s]+$";
            return !string.IsNullOrEmpty(input) && Regex.IsMatch(input, pattern);
        }
        #endregion
        private void FrmTest_Load(object sender, EventArgs e)
        {
            GoToAddMode();
            BindGrid();
            BindUnitCmb();
            BindCategoryCmb();
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            err.Clear();
            SetPrice();
            if (CheckInputs())
            {
                Test test = new Test
                {
                    TestName = txtName.Text,
                    Price = price,
                    CategoryID = Convert.ToInt32(cmbCategory.SelectedValue),
                    UnitID = Convert.ToInt32(cmbUnit.SelectedValue),
                    Method = txtMethod.Text,
                    AgeHasEffect = chbAge.Checked,
                    JensiatHasEffect = chbGender.Checked
                };
                testRepo.Add(test);
                ClearForm();
                BindGrid();
            }
            else 
            {
                MessageBox.Show("لطفا موارد اشتباه را تصحیح نمایید");
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetPrice();
            if (CheckInputs())
            {
                Test test = new Test
                {
                    TestID = testID,
                    TestName = txtName.Text,
                    Price = price,
                    CategoryID = Convert.ToInt32(cmbCategory.SelectedValue),
                    UnitID = Convert.ToInt32(cmbUnit.SelectedValue),
                    Method = txtMethod.Text,
                    AgeHasEffect = chbAge.Checked,
                    JensiatHasEffect = chbGender.Checked
                };
                testRepo.Update(test);
                ClearForm();
                BindGrid();
                GoToAddMode();
            }
            else
            {
                MessageBox.Show("لطفا موارد اشتباه را تصحیح نمایید");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            err.Clear();
            GoToAddMode();
            ClearForm();
            BindGrid();
        }
        private void grdTest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            err.Clear();
            testID = Convert.ToInt32(grdTest.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == 9)
            {
                if (MessageBox.Show("آیا می خواهید این مورد را حذف کنید؟", "هشدار!!!!!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (!testRepo.HasRecords(testID))
                    {
                        bool s = testRepo.Delete(testID);
                        
                        if (s)
                        {
                            BindGrid();
                            GoToAddMode();
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
            if (e.ColumnIndex == 8)
            {
                err.Clear();
                var tst = testRepo.GetById(testID);
                txtName.Text = tst.TestName;
                txtPrice.Text = tst.Price.ToString();
                txtMethod.Text = tst.Method;
                cmbUnit.SelectedValue = tst.UnitID;
                cmbCategory.SelectedValue = tst.CategoryID;
                chbAge.Checked= tst.AgeHasEffect;
                chbGender.Checked = tst.JensiatHasEffect;
                GoToEditMode();
            }
            if (e.ColumnIndex == 10)
            {
                Form formToCheck = Application.OpenForms["FrmTestRange"];

                if (formToCheck != null)
                {
                    formToCheck.Close();
                }
                FrmTestRange frm = new FrmTestRange();
                frm.thisTestID = testID;
                frm.Show();
            }
        }

    }
}
