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
    public partial class FrmTestUnit : Form
    {
        DataAccess.UnitRepository unRepo = new DataAccess.UnitRepository();

        int unitID;

        public FrmTestUnit()
        {
            InitializeComponent();
        }
       

        #region DataBinders
        private void BindGrid()
        {

            grdUnit.AutoGenerateColumns = false;
            grdUnit.DataSource = null;
            grdUnit.DataSource = unRepo.GetAll();

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

        private void FrmTestUnit_Load(object sender, EventArgs e)
        {
            GoToAddMode();
            BindGrid();
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUnitName.Text))
            {
                Unit unit = new Unit { UnitName = txtUnitName.Text };
                unRepo.Add(unit);
                ClearForm();
                BindGrid();
            }
            else
            {
                MessageBox.Show("لطفا نام واحد را وارد نمایید");
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUnitName.Text))
            {
                Unit oldUnit = new Unit { UnitID = unitID, UnitName = txtUnitName.Text };
                unRepo.Update(oldUnit);
                ClearForm();
                BindGrid();
                GoToAddMode();
            }
            else
            {
                MessageBox.Show("لطفا نام واحد را وارد نمایید");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            GoToAddMode();
            ClearForm();
        }
        private void grdUnit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            unitID = Convert.ToInt32(grdUnit.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == 3)
            {
                if (MessageBox.Show("آیا می خواهید این مورد را حذف کنید؟", "هشدار!!!!!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (unRepo.Delete(unitID))
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
                var un = unRepo.GetById(unitID);
                txtUnitName.Text = un.UnitName;
                GoToEditMode();
            }
        }

    }
}
