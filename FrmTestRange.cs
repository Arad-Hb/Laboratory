using DomainModel.Models;
using DomainModel.ViewModels;
using FarsiLibrary.Win.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Laboratory
{
    public partial class FrmTestRange : Form
    {
        DataAccess.TestRangeRepository testRangeRepo = new DataAccess.TestRangeRepository();
        DataAccess.TestsRepository testRepo = new DataAccess.TestsRepository();
        public int thisTestID { get; set; }
        int testRangeID;
        double fromValue;
        double toValue;
        int gender = 3;
        int fromAge = 1;
        int toAge = 200;

        public FrmTestRange()
        {
            InitializeComponent();
        }

        #region DataBinders
        private void BindGrid()
        {
            grdTestRange.AutoGenerateColumns = false;
            grdTestRange.DataSource = null;
            grdTestRange.DataSource = testRangeRepo.GetAll(thisTestID);
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
        private void GetGender()
        {
            if (rdbMan.Checked) gender = 1;
            if(rdbWoman.Checked) gender = 2;
            if (!rdbWoman.Checked && !rdbMan.Checked) gender = 3;
        }
        private void GetAge()
        {
            if (CheckIsNumeric(txtFromAge.Text)) fromAge = Convert.ToInt32(txtFromAge.Text);
            else fromAge = 1;
            if (CheckIsNumeric(txtToAge.Text)) toAge = Convert.ToInt32(txtToAge.Text);
            else toAge = 200;
        }
        private void GetValue()
        {
            if (CheckIsNumeric(txtFromValue.Text)) fromValue = Convert.ToDouble(txtFromValue.Text);
            else err.SetError(txtFromValue, "عدد وارد نمایید");
            if (CheckIsNumeric(txtToValue.Text)) toValue = Convert.ToDouble(txtToValue.Text);
            else err.SetError(txtToValue, "عدد وارد نمایید");
        }
        private void SetTestName()
        {
            var test = testRepo.GetById(thisTestID);
            lblTestName.Text = test.TestName;
            if (!test.AgeHasEffect)
            {
                grpAge.Enabled = false;
            }
            if (!test.JensiatHasEffect)
            {
                grpGender.Enabled = false;
            }
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

        private bool CheckIsNumeric(string input)
        {
            return !string.IsNullOrEmpty(input) &&
                   long.TryParse(input, out _);
        }
        #endregion

        private void FrmTestRange_Load(object sender, EventArgs e)
        {
            SetTestName();
            BindGrid();
            GoToAddMode();
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            err.Clear();
            GetGender();
            GetAge();
            GetValue();

                TestRange range = new TestRange
                {
                    TestID = thisTestID,
                    FromValue = fromValue,
                    ToValue = toValue,
                    FromAge = fromAge,
                    ToAge = toAge,
                    Jensiat = gender,
                    Description = txtDescription.Text,
                    Differential = 1,
                    Hazard = chbHazard.Checked
                };
                testRangeRepo.Add(range);
                BindGrid();
                ClearForm();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            err.Clear();
            GetGender();
            GetValue();
            GetAge();

                TestRange range = new TestRange
                {
                    RangeID = testRangeID,
                    TestID = thisTestID,
                    FromValue = fromValue,
                    ToValue = toValue,
                    FromAge = fromAge,
                    ToAge = toAge,
                    Jensiat = gender,
                    Description = txtDescription.Text,
                    Differential = 1,
                    Hazard = chbHazard.Checked
                };
                testRangeRepo.Update(range);

                BindGrid();
                ClearForm();
                GoToAddMode();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            err.Clear();
            GoToAddMode();
            ClearForm();
        }
        private void grdTestRange_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            err.Clear();
            testRangeID = Convert.ToInt32(grdTestRange.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == 9)
            {
                if (MessageBox.Show("آیا می خواهید این مورد را حذف کنید؟", "هشدار!!!!!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    bool s = testRangeRepo.Delete(testRangeID);
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
            }
            if (e.ColumnIndex == 8)
            {
                var range = testRangeRepo.GetById(testRangeID);

                txtFromValue.Text = range.FromValue.ToString();
                txtToValue.Text = range.ToValue.ToString();
                txtFromAge.Text = range.FromAge.ToString();
                txtToAge.Text = range.ToAge.ToString();
                txtDescription.Text = range.Description;
                rdbWoman.Checked = range.Jensiat == 2 ? true : false;
                rdbMan.Checked = range.Jensiat == 1 ? true : false;
                chbHazard.Checked = range.Hazard;
                GoToEditMode();
            }
        }
    }
}