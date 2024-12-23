using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory
{
    public partial class FrmTestCategory : Form
    {
        DataAccess.TestCategoryRepository ctRepo= new DataAccess.TestCategoryRepository();

        int catID;
        public FrmTestCategory()
        {
            InitializeComponent();
        }

        #region DataBinders
        private void BindGrid()
        {
            grdCategory.AutoGenerateColumns = false;
            grdCategory.DataSource = null;
            grdCategory.DataSource = ctRepo.GetAll();
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
        #endregion

        private void FrmTestCategory_Load(object sender, EventArgs e)
        {
            GoToAddMode();
            BindGrid();
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCategoryName.Text))
            {
                TestCategory cat = new TestCategory { CategoryName = txtCategoryName.Text };
                ctRepo.Add(cat);
                ClearForm();
                BindGrid();
                GoToAddMode();
            }
            else
            {
                MessageBox.Show("لطفا نام رده را وارد نمایید");
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCategoryName.Text))
            {
                TestCategory newCat = new TestCategory { CategoryID = catID, CategoryName = txtCategoryName.Text };
                ctRepo.Update(newCat);
                ClearForm();
                BindGrid();
                GoToAddMode();
            }
            else
            {
                MessageBox.Show("لطفا نام رده را وارد نمایید");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            GoToAddMode();
            ClearForm();
        }
        private void grdUnit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            catID = Convert.ToInt32(grdCategory.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == 3)
            {
                if (MessageBox.Show("آیا می خواهید این مورد را حذف کنید؟", "هشدار!!!!!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (ctRepo.Delete(catID))
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
            }
            if (e.ColumnIndex == 2)
            {
                var c = ctRepo.GetById(catID);
                txtCategoryName.Text = c.CategoryName;
                GoToEditMode();
            }
        }
    }
}
