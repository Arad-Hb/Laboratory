using DomainModel.Models;
using DomainModel.ViewModels;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;
using FarsiLibrary.Win.Controls;

namespace Laboratory
{
    public partial class FrmPatientTestHeader : Form
    {
        DataAccess.PatientTestHeaderRepository ptHeaderRepo = new DataAccess.PatientTestHeaderRepository();
        DataAccess.PatientRepository ptRepo = new DataAccess.PatientRepository();
        DataAccess.TestsRepository tstRepo = new DataAccess.TestsRepository();

        int patientTestHeaderID;
        int patientTestDetailsID;
        int patientID;
        int testID;
        int testCategoryID;
        Patient patient;
        InsuranceType insurance;
        PatientHeaderList currentTestHeader;
        double totalPrice = 0;
        public Employee ActiveEmployee { get; set; }

        public FrmPatientTestHeader()
        {
            InitializeComponent();
        }

        #region DataBinders
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
        private void BindGrpPatientTestDetails()
        {
            grpPatientTestDetails.Enabled = true;
            BindTestCategoryCmb();
            BindTestNameCmb();
        }
        private void BindRegisteredPtientTestHeaderInfo(int ID)
        {
            PatientHeaderList p = ptHeaderRepo.GetPatientTestHeaderItemByID(ID);
            lblPatientTestHeaderID.Text = p.PatientTestHeaderID.ToString();
            lblPatientName.Text = p.PatientName;
            lblEmployeeName.Text = p.EmployeeName;
            lblDrName.Text = p.DrName;
            lblNationalCode.Text = p.NationalCode;
            lblInsurance.Text = p.InsuranceName;
            lblMobile.Text = p.Mobile;
            lblAge.Text = p.Age.ToString();
        }
        #endregion

        #region Utility
        private void GoToAddMode()
        {
            btnAddTestDetails.Enabled = true;
            btnCancel.Enabled = false;
            btnEdit.Enabled = false;
            btnAddNew.Enabled = false;
            cmbInsurance.SelectedValue = -1;

            btnAddNew.BackColor = Color.DarkGray;
            btnAddTestDetails.BackColor = Color.Teal;
            btnCancel.BackColor = Color.DarkGray;
            btnEdit.BackColor = Color.DarkGray;
        }
        private void GoToEditMode()
        {
            btnAddTestDetails.Enabled = false;
            btnCancel.Enabled = true;
            btnEdit.Enabled = true;

            btnAddTestDetails.BackColor = Color.DarkGray;
            btnCancel.BackColor = Color.Teal;
            btnEdit.BackColor = Color.Teal;
        }
        private void SetTotalPrice()
        {
            totalPrice = ptHeaderRepo.CalculateTotalPrice(patientTestHeaderID);
            if (totalPrice == 0)
            {
                PatientTestHeader item = ptHeaderRepo.GetById(patientTestHeaderID);
                item.TotalPrice = totalPrice;
                ptHeaderRepo.UpdateRegisteredHeader(item);
            }
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
        private void ClearForm()
        {
            ClearControls(this.Controls);
            foreach (var groupBox in this.Controls.OfType<GroupBox>())
            {
                ClearControls(groupBox.Controls);
            }
            lblPrice.Text = "";
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
                        comboBox.Text = "انتخاب کنید";
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
        private bool CheckHeaderInputs()
        {
            bool result = true;
            
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

        private void FrmPatientTestHeader_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            BindInsuranceCmb();
            grpPatientTestDetails.Enabled = false;
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            err.Clear();
            if (!CheckHeaderInputs())
            {
                try
                {
                    PatientTestHeader p = new PatientTestHeader();
                    p.PatientID = patientID;
                    p.EmployeeID = ActiveEmployee.EmployeeID;
                    p.HeaderDate = DateTime.Now;
                    p.Age = Convert.ToInt32(txtAge.Text);
                    p.DrName = txtDrName.Text;
                    p.InsuranceTypeID = Convert.ToInt32(cmbInsurance.SelectedValue);
                    p.TotalPrice = totalPrice;

                    patientTestHeaderID = ptHeaderRepo.RegisterTest(p);

                    MessageBox.Show("سر برگ آزمایش با موفقیت ثبت شد. شماره ی آزمایش:" + patientTestHeaderID);

                    BindRegisteredPtientTestHeaderInfo(patientTestHeaderID);
                    BindGrpPatientTestDetails();
                    GoToAddMode();
                    ClearForm();
                }
                catch
                {
                    MessageBox.Show("در ثبت آزمایش خطایی رخ داده است!!! لطفا اطلاعات صحیح وارد نمایید.");
                }
                ClearForm();
            }
            else
            {
                MessageBox.Show("لطفا مقادیر را به درستی وارد نمایید");
            }
        }
        private void btnAddTestDetails_Click(object sender, EventArgs e)
        {
            if (!CheckDetailInputs())
            {
                testID = Convert.ToInt32(cmbTestName.SelectedValue);
                bool isReapeted = ptHeaderRepo.TestExists(patientTestHeaderID, testID);
                if (!isReapeted)
                {
                    try
                    {
                        PatientTestDetail ptDetail = new PatientTestDetail();
                        ptDetail.PatientTestHeaderID = patientTestHeaderID;
                        ptDetail.TestID = testID;
                        ptDetail.Result = txtResult.Text.Length < 1 ? 0 : Convert.ToDouble(txtResult.Text);
                        ptDetail.HasStar = chbHasStar.Checked;

                        patientTestDetailsID = ptHeaderRepo.RegisterTestItems(ptDetail);
                        ptHeaderRepo.SetHasStarByResult(patientTestDetailsID);

                        SetTotalPrice();
                        BindGrid();
                        SetHazardRange();

                    }
                    catch { MessageBox.Show("خطا در ثبت آزمایش"); }
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("این آزمایش تکراریست!!!");
                }
            }
            else
            {
                MessageBox.Show("لطفا مقادیر را به درستی وارد نمایید");
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
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
            ClearForm();
            GoToAddMode();


        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            err.Clear();
            GoToAddMode();
            ClearForm();
        }
        private void grdPatientTestDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            err.Clear();
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
                var currentPatientTestItem = ptHeaderRepo.GetRegisteredTestItem(patientTestDetailsID);
                cmbTestCategory.SelectedValue = currentPatientTestItem.TestCategoryID;
                cmbTestName.SelectedValue = currentPatientTestItem.TestID;
                chbHasStar.Checked = currentPatientTestItem.HasStar;
                lblPrice.Text = currentPatientTestItem.Price.ToString();
                txtResult.Text = currentPatientTestItem.Result.ToString();

                GoToEditMode();
            }
        }
        private void txtSearchPatient_TextChanged(object sender, EventArgs e)
        {
            //private bool IsPersianCharacter(char c)
            //{
            //   return (c >= 0x0600 && c <= 0x06FF) ||
            //           (c >= 0xFB50 && c <= 0xFDFF) ||
            //           (c >= 0xFE70 && c <= 0xFeFF) ||
            //           c == ' ' || c == '\b';
            //}

            if (lstPatient.Items.Count > 0)
            {
                lstPatient.DataSource = null;
            }
            if (!string.IsNullOrEmpty(txtSearchPatient.Text) && txtSearchPatient.Text.Length >= 1)
            {
                List<PatientList> list = ptRepo.Search(txtSearchPatient.Text);
                lstPatient.DisplayMember = "Information";
                lstPatient.ValueMember = "PatientID";
                lstPatient.DataSource = list;
                lstPatient.Visible = true;
            }
        }
        private void lstPatient_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            patientID = Convert.ToInt32(lstPatient.SelectedValue);
            patient = ptRepo.GetById(patientID);
            txtSearchPatient.Text = patient.FirstName + " " + patient.LastName;
            lstPatient.Visible = false;
        }
        private void cmbInsurance_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAccess.InsuranceTypeRepository insRepo = new DataAccess.InsuranceTypeRepository();
            insurance = insRepo.GetById(cmbInsurance.SelectedIndex);
        }
        private void cmbTestCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            testCategoryID = Convert.ToInt32(cmbTestCategory.SelectedValue);
            BindTestNameCmb();
        }
        private void cmbTestName_SelectedValueChanged(object sender, EventArgs e)
        {
            testID = Convert.ToInt32(cmbTestName.SelectedValue);
            if (testID >= 1)
            {
                lblPrice.Text = tstRepo.GetById(testID).Price.ToString();
            }
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            FrameWork.DateTimeUtility utility = new FrameWork.DateTimeUtility();
            lblDate.Text = utility.GetPersianDate(DateTime.Now);
        }
    }
}
