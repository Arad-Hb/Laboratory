using DomainModel.Models;
using DomainModel.ViewModels;
using FarsiLibrary.Win.Controls;
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
    public partial class FrmPatientTestResult : Form
    {
        DataAccess.PatientTestHeaderRepository ptHeaderRepo = new DataAccess.PatientTestHeaderRepository();
        DataAccess.PatientRepository ptRepo = new DataAccess.PatientRepository();
        DataAccess.TestsRepository tstRepo = new DataAccess.TestsRepository();

        int patientTestHeaderID;
        int patientTestDetailsID;
        int patientID;
        int testCategoryID;
        int testID;
        double totalPrice = 0;
        PatientHeaderList currentTestHeader;

        public FrmPatientTestResult()
        {
            InitializeComponent();
        }
        #region Data Binder
        private void BindGrid()
        {
            grdPatientTestDetail.AutoGenerateColumns = false;
            grdPatientTestDetail.DataSource = null;
            grdPatientTestDetail.DataSource = ptHeaderRepo.GetRegisteredTestItemsByID(patientTestHeaderID);
        }
        private void BindInsuranceCmb()
        {
            DataAccess.InsuranceTypeRepository insRepo = new DataAccess.InsuranceTypeRepository();
            List<InsuranceType> insurances = insRepo.GetAll();
            insurances.Insert(0, new InsuranceType { InsuranceTypeID = -1, InsuranceTypeName = "انتخاب بیمه" });
            cmbInsurance.DisplayMember = "InsuranceTypeName";
            cmbInsurance.ValueMember = "InsuranceTypeID";
            cmbInsurance.DataSource = insurances;
        }
        private void BindTestHeaderCmb()
        {
            RegisteredTestSearchModel sm = new RegisteredTestSearchModel();
            sm.PatientID = patientID;
            var testHeaderList = ptHeaderRepo.SearchRegisteredTest(sm);
            testHeaderList.Insert(0, new PatientHeaderList { PatientTestHeaderID = -1, Information = "مشخصات آزمایش" });
            cmbTestHeader.DisplayMember = "Information";
            cmbTestHeader.ValueMember = "PatientTestHeaderID";
            cmbTestHeader.DataSource = testHeaderList;
        }
        private void BindTestCategoryCmb()
        {
            DataAccess.TestCategoryRepository tstCatRepo = new DataAccess.TestCategoryRepository();
            List<TestCategory> testCat = tstCatRepo.GetAll();
            testCat.Insert(0, new TestCategory { CategoryID = -1, CategoryName = "نوع آزمایش" });
            cmbTestCategory.DisplayMember = "CategoryName";
            cmbTestCategory.ValueMember = "CategoryID";
            cmbTestCategory.DataSource = testCat;
        }
        private void BindTestNameCmb()
        {
            List<TestList> tests = tstRepo.GetByParentID(testCategoryID);
            tests.Insert(0, new TestList { TestID = -1, TestName = "نام آزمایش" });
            cmbTestName.DisplayMember = "TestName";
            cmbTestName.ValueMember = "TestID";
            cmbTestName.DataSource = tests;
        }
        private void BindRegisteredPtientTestHeaderInfo()
        {
            
            lblPatientTestHeaderID.Text = currentTestHeader.PatientTestHeaderID.ToString();
            lblPatientName.Text = currentTestHeader.PatientName;
            txtDrName.Text = currentTestHeader.DrName;
            cmbInsurance.SelectedValue = currentTestHeader.InsuranceID;
            lblMobile.Text = currentTestHeader.Mobile;
            lblNationalCode.Text = currentTestHeader.NationalCode;
            txtAge.Text = currentTestHeader.Age.ToString();
            lblTotalPrice.Text = currentTestHeader.TotalPrice.ToString();
            faDateHeader.SelectedDateTime = currentTestHeader.HeaderDate;
        }
        #endregion
        #region Utility
        private void GoToSearchModeHeader()
        {
            btnSearchTestHeader.Enabled = true;
            btnSearchTestHeader.BackColor = Color.Teal;
            btnUpdateHeader.Enabled = false;
            btnUpdateHeader.BackColor = Color.DarkGray;
            btnDeleteHeader.Enabled = false;
            btnDeleteHeader.BackColor = Color.DarkGray;
            btnCancelHeader.Enabled = false;
            btnCancelHeader.BackColor = Color.DarkGray;

            btnAddDetails.Enabled = false;
            btnCancelDetail.Enabled = false;
            btnEditDetail.Enabled = false;
            btnAddDetails.BackColor = Color.DarkGray;
            btnCancelDetail.BackColor = Color.DarkGray;
            btnEditDetail.BackColor = Color.DarkGray;
            grpPatientTestDetails.Enabled = false;
            grpTestHeader.Enabled = true;
        }
        private void GoToManageModeHeader()
        {
            btnSearchTestHeader.Enabled = false;
            btnSearchTestHeader.BackColor = Color.DarkGray;
            btnUpdateHeader.Enabled = true;
            btnUpdateHeader.BackColor = Color.MidnightBlue;
            btnDeleteHeader.Enabled = true;
            btnDeleteHeader.BackColor = Color.MidnightBlue;
            btnCancelHeader.Enabled = true;
            btnCancelHeader.BackColor = Color.MidnightBlue;
            grpPatientTestDetails.Enabled = true;
            grpTestHeader.Enabled = false;
        }
        private void GoToAddModeTest()
        {
            btnAddDetails.Enabled = true;
            btnCancelDetail.Enabled = false;
            btnEditDetail.Enabled = false;

            btnAddDetails.BackColor = Color.Teal;
            btnCancelDetail.BackColor = Color.DarkGray;
            btnEditDetail.BackColor = Color.DarkGray;
        }
        private void GoToEditModeTest()
        {
            btnAddDetails.Enabled = false;
            btnCancelDetail.Enabled = true;
            btnEditDetail.Enabled = true;

            btnAddDetails.BackColor = Color.DarkGray;
            btnCancelDetail.BackColor = Color.Teal;
            btnEditDetail.BackColor = Color.Teal;
        }
        private void SetTotalPrice()
        {
            totalPrice = ptHeaderRepo.CalculateTotalPrice(patientTestHeaderID);
            lblTotalPrice.Text = totalPrice.ToString();
        }
        private void SetHazardRange()
        {
            foreach (DataGridViewRow row in grdPatientTestDetail.Rows)
            {
                if (row.Cells[7].Value != null)
                {
                    bool hasStar = Convert.ToBoolean(row.Cells[7].Value);
                    if (hasStar)
                    {
                        row.Cells[6].Style.ForeColor = Color.AntiqueWhite;
                        row.Cells[6].Style.BackColor = Color.Red;
                    }
                }
                else
                {
                    row.Cells[6].Style.ForeColor = Color.Black;
                    row.Cells[6].Style.BackColor = Color.White;
                }
            }
        }
        private void CheckTextBoxHeaderID()
        {
            string id = txtTestHeaderID.Text;
            if (!string.IsNullOrEmpty(id) && int.TryParse(id, out _))
            {
                if (ptHeaderRepo.TestHeaderExists(Convert.ToInt32(id)))
                {
                    patientTestHeaderID = Convert.ToInt32(id);
                    currentTestHeader = ptHeaderRepo.GetPatientTestHeaderItemByID(patientTestHeaderID);
                    patientID = currentTestHeader.PatientID;
                }
                else
                {
                    MessageBox.Show("این سربرگ وجود ندارد!!!");
                }
            }
        }
        private void ClearForm()
        {
            ClearControls(this.Controls);
            foreach (var groupBox in this.Controls.OfType<GroupBox>())
            {
                ClearControls(groupBox.Controls);
            }
            ClearInfoPanel();
            ClearDetailsPanel();
            grdPatientTestDetail.DataSource = null;
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
                    case DateTimePicker dateTimePicker:
                        dateTimePicker.Text = "[هیج مقداری انتخاب نشده]";
                        break;
                    case FADatePicker datePicker:
                        datePicker.Text = "[هیج مقداری انتخاب نشده]";
                        break;
                }
            }
        }
        private void ClearInfoPanel()
        {
            lblPatientTestHeaderID.Text = string.Empty;
            lblPatientName.Text = string.Empty;
            lblMobile.Text = string.Empty;
            lblNationalCode.Text = string.Empty;
            lblTotalPrice.Text = string.Empty;
        }
        private void ClearDetailsPanel()
        {
            cmbTestCategory.SelectedIndex = 0;
            cmbTestName.SelectedIndex = 0;
            txtResult.Text = string.Empty;
            chbHasStar.Checked = false;
            lblPrice.Text = string.Empty;
        }
        #endregion
        #region Checking
       
        private bool CheckHeaderInputs()
        {
            bool result = true;
            //this method is for groupbox controls
            foreach (GroupBox groupBox in this.Controls.OfType<GroupBox>())
            {
                foreach (Control ctrl in groupBox.Controls)
                {
                    if (ctrl is System.Windows.Forms.TextBox txt)
                    {
                        switch (txt.Name)
                        {
                            case "txtSearchPatient":
                                if (string.IsNullOrEmpty(txt.Text))
                                {
                                    err.SetError(txtSearchPatient, "نام مراجع را انتخاب کنید");
                                    result = false;
                                }
                                break;

                            case "txtDrName":
                                if (!CheckIsPersianLetters(txt.Text))
                                {
                                    err.SetError(txtDrName, "نام پزشک را وارد نمایید");
                                    result = false;
                                }
                                break;

                            case "txtAge":
                                if (!CheckIsNumeric(txt.Text))
                                {
                                    err.SetError(txtAge, "سن را به عدد وارد نمایید");
                                    result = false;
                                }
                                break;
                        }
                    }
                    if (ctrl is ComboBox cmb)
                    {
                        if (cmb.SelectedIndex == 0 || cmb.SelectedIndex == -1)
                        {
                            err.SetError(cmbInsurance, "نوع بیمه را انتخاب نمایید");
                            result = false;
                        }
                    }
                }
            }

            return result;
        }
        private bool CheckDetailInputs()
        {
            bool result = true;
            //this method is for groupbox controls
            foreach (GroupBox groupBox in this.Controls.OfType<GroupBox>())
            {
                foreach (Control ctrl in groupBox.Controls)
                {
                    if (ctrl is ComboBox cmb)
                    {
                        if (cmb.SelectedIndex == 0 || cmb.SelectedIndex == -1)
                        {
                            err.SetError(cmbTestCategory, "آزمایش را انتخاب نمایید");
                            result = false;
                        }
                    }
                }
            }

            return result;
        }
        private bool CheckIsNumeric(string input)
        {
            return !string.IsNullOrEmpty(input) && long.TryParse(input, out _);
        }
        private bool CheckIsPersianLetters(string input)
        {
            string pattern = @"^[\u0600-\u06FF\s]+$";
            return !string.IsNullOrEmpty(input) && Regex.IsMatch(input, pattern);
        }
        #endregion

        private void btnSearchTestHeader_Click(object sender, EventArgs e)
        {
            CheckTextBoxHeaderID();
            if (patientTestHeaderID != 0)
            {
                BindRegisteredPtientTestHeaderInfo();
                BindGrid();
                SetHazardRange();
                BindTestHeaderCmb();
                BindTestCategoryCmb();
                GoToManageModeHeader();
                GoToAddModeTest();
                txtSearchPatient.Text = "";
            }
            else
            {
                MessageBox.Show("لطفا شماره سربرگ را انتخاب نمایید!!!");
            }
        }

        private void btnUpdateHeader_Click(object sender, EventArgs e)
        {
            try
            {
                PatientTestHeader newTestHeader = new PatientTestHeader
                {
                    PatientTestHeaderID = patientTestHeaderID,
                    PatientID = patientID,
                    EmployeeID = currentTestHeader.EmployeeID,
                    DrName = txtDrName.Text,
                    TotalPrice = totalPrice,
                    Age = Convert.ToInt32(txtAge.Text),
                    InsuranceTypeID = Convert.ToInt32(cmbInsurance.SelectedValue),
                    HeaderDate = Convert.ToDateTime(faDateHeader.SelectedDateTime)
                };
                ptHeaderRepo.UpdateRegisteredHeader(newTestHeader);
                MessageBox.Show($"به روز رسانی سربرگ شماره {patientTestHeaderID} با موفقیت انجام شد!!");
                GoToSearchModeHeader();
                ClearForm();
            }
            catch
            {
                MessageBox.Show("به روز رسانی این مورد امکان پذیر نمی باشد!!");
            }
        }

        private void btnDeleteHeader_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا می خواهید این مورد را حذف کنید؟", "هشدار!!!!!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                bool result = ptHeaderRepo.DeleteRegisteredTest(patientTestHeaderID);
                if (result)
                {
                    MessageBox.Show($"حذف سربرگ شماره {patientTestHeaderID} با موفقیت انجام شد!!");
                    
                    ClearForm();
                    GoToSearchModeHeader();
                }
                else
                {
                    MessageBox.Show("عملیات حذف انجام پذیر نمی باشد!!!!!!");
                }
            }
        }

        private void btnCancelHeader_Click(object sender, EventArgs e)
        {
            ClearForm();
            GoToSearchModeHeader();
        }

        private void btnAddDetails_Click(object sender, EventArgs e)
        {
            testID = Convert.ToInt32(cmbTestName.SelectedValue);
            bool isReapeted = ptHeaderRepo.TestExists(patientTestHeaderID, testID);
            if (!isReapeted)
            {
                PatientTestDetail ptDetail = new PatientTestDetail();
                try
                {
                    ptDetail.PatientTestHeaderID = patientTestHeaderID;
                    ptDetail.TestID = testID;
                    ptDetail.Result = txtResult.Text.Length < 1 ? 0 : Convert.ToDouble(txtResult.Text);
                    ptDetail.HasStar = chbHasStar.Checked;

                    patientTestDetailsID = ptHeaderRepo.RegisterTestItems(ptDetail);
                    //ptHeaderRepo.IsResultInHazardZone(patientTestDetailsID);
                    ptHeaderRepo.SetHasStarByResult(patientTestDetailsID);

                    SetTotalPrice();
                    BindGrid();
                    SetHazardRange();
                    ClearDetailsPanel();
                }
                catch { MessageBox.Show("خطا در ثبت آزمایش"); }
            }
            else
            {
                MessageBox.Show("این آزمایش تکراریست!!!");
            }
        }

        private void btnEditDetail_Click(object sender, EventArgs e)
        {
            PatientTestDetail pt = new PatientTestDetail
            {
                PatientTestDetailsID = patientTestDetailsID,
                PatientTestHeaderID = patientTestHeaderID,
                TestID = testID,
                Result = txtResult.Text.Length < 1 ? 0 : Convert.ToDouble(txtResult.Text),
                HasStar = chbHasStar.Checked
            };
            ptHeaderRepo.UpdateRegisteredDetails(pt);
            //ptHeaderRepo.IsResultInHazardZone(patientTestDetailsID);
            ptHeaderRepo.SetHasStarByResult(patientTestDetailsID);

            SetTotalPrice();
            BindGrid();
            SetHazardRange();
            ClearDetailsPanel();
            GoToAddModeTest();
        }

        private void btnCancelDetail_Click(object sender, EventArgs e)
        {
            ClearDetailsPanel();
            GoToAddModeTest();
        }

        private void grdPatientTestDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            patientTestDetailsID = Convert.ToInt32(grdPatientTestDetail.Rows[e.RowIndex].Cells[1].Value);
            if (e.ColumnIndex == 9)
            {
                if (MessageBox.Show("آیا می خواهید این مورد را حذف کنید؟", "هشدار!!!!!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    bool s = ptHeaderRepo.DeleteRegisteredTestItems(patientTestDetailsID);
                    if (s)
                    {
                        SetTotalPrice();
                        BindGrid();
                        SetHazardRange();
                        ClearDetailsPanel();
                        GoToAddModeTest();
                        
                    }
                    else
                    {
                        MessageBox.Show("عملیات حذف انجام پذیر نمی باشد!!!!!!");
                    }
                }
            }
            if (e.ColumnIndex == 8)
            {
                var currentPatientTestItem = ptHeaderRepo.GetRegisteredTestItem(patientTestDetailsID);
                cmbTestCategory.SelectedValue = currentPatientTestItem.TestCategoryID;
                cmbTestName.SelectedValue = currentPatientTestItem.TestID;
                chbHasStar.Checked = currentPatientTestItem.HasStar;
                lblPrice.Text = currentPatientTestItem.Price.ToString();
                txtResult.Text = currentPatientTestItem.Result.ToString();

                GoToEditModeTest();
            }
        }

        private void FrmPatientTestResult_Load(object sender, EventArgs e)
        {
            BindTestCategoryCmb();
            BindInsuranceCmb();
        }

        private void lstSearchPatient_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            patientID = Convert.ToInt32(lstSearchPatient.SelectedValue);
            var patient = ptRepo.GetById(patientID);
            txtSearchPatient.Text = patient.FirstName + " " + patient.LastName;
            lstSearchPatient.Visible = false;
            BindTestHeaderCmb();
        }

        private void txtSearchPatient_TextChanged(object sender, EventArgs e)
        {
            if (lstSearchPatient.Items.Count > 0)
            {
                lstSearchPatient.DataSource = null;
            }
            if (!string.IsNullOrEmpty(txtSearchPatient.Text) && txtSearchPatient.Text.Length >= 1)
            {
                List<PatientList> patientList = ptRepo.Search(txtSearchPatient.Text);
                lstSearchPatient.DisplayMember = "Information";
                lstSearchPatient.ValueMember = "PatientID";
                lstSearchPatient.DataSource = patientList;
                lstSearchPatient.Visible = true;
            }
        }

        private void cmbTestHeader_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbTestHeader.SelectedValue) > 0)
            {
                patientTestHeaderID = Convert.ToInt32(cmbTestHeader.SelectedValue);
                currentTestHeader = ptHeaderRepo.GetPatientTestHeaderItemByID(patientTestHeaderID);
                txtTestHeaderID.Text = patientTestHeaderID.ToString();
            }
        }

        private void cmbTestCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            testCategoryID = cmbTestCategory.SelectedIndex;
            BindTestNameCmb();
        }

        private void cmbTestName_SelectedIndexChanged(object sender, EventArgs e)
        {
            testID = Convert.ToInt32(cmbTestName.SelectedValue);
            if (testID >= 1)
            {
                lblPrice.Text = tstRepo.GetById(testID).Price.ToString();
            }
        }
    }
}
