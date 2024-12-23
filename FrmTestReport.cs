using DataAccess;
using DomainModel.Models;
using DomainModel.ViewModels;
using FarsiLibrary.Win.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory
{
    public partial class FrmTestReport : Form
    {
        DataAccess.PatientTestHeaderRepository ptRepo = new DataAccess.PatientTestHeaderRepository();
        DataAccess.PatientRepository pRepo = new DataAccess.PatientRepository();

        List<PatientHeaderList> reportList;
        DateTime? SearchingFromDate;
        DateTime? SearchingToDate;
        int? registeredTestID;
        int? patientID;

        #region DataBinders
        private void BindGrid()
        {
            grdTestReport.AutoGenerateColumns = false;
            grdTestReport.DataSource = null;
            grdTestReport.DataSource = reportList;
        }
        private void BindGridDateToPersian()
        {
            FrameWork.DateTimeUtility utility = new FrameWork.DateTimeUtility();
            if (reportList != null)
            {
                foreach (DataGridViewRow row in grdTestReport.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex == 4)
                        {
                            cell.Value = utility.GetPersianDate(Convert.ToDateTime(cell.Value));
                        }
                    }
                }
            }
        }
        #endregion
        #region Utility
        private void ClearForm()
        {
            ClearControls(this.Controls);
            foreach (var groupBox in this.Controls.OfType<GroupBox>())
            {
                ClearControls(groupBox.Controls);
            }
            grdTestReport.DataSource=null;  
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
                    case FADatePicker datePicker:
                        datePicker.Text = "[هیج مقداری انتخاب نشده]";
                        datePicker.SelectedDateTime = null;
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
        public FrmTestReport()
        {
            InitializeComponent();
        }
        private void grdTestReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int RegisteredTestID = Convert.ToInt32(grdTestReport.Rows[e.RowIndex].Cells[0].Value);

            if (e.ColumnIndex == 8)
            {
                var hasAnyDetails = ptRepo.GetRegisteredTestItemsByID(RegisteredTestID);
                if (hasAnyDetails.Count>0)
                {
                    Form formToCheck = Application.OpenForms["FrmTestReportDetails"];

                    if (formToCheck != null)
                    {
                        formToCheck.Close();
                    }
                    FrmTestReportDetails frm = new FrmTestReportDetails(RegisteredTestID);
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("این سربرگ فاقد جزییات است");
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            err.Clear();
            if(SearchingFromDate.HasValue || SearchingToDate.HasValue || registeredTestID.HasValue || patientID.HasValue)
            {
                RegisteredTestSearchModel sm = new RegisteredTestSearchModel
                {
                    FromDate = SearchingFromDate,
                    ToDate = SearchingToDate,
                    RegisteredTestID = registeredTestID,
                    PatientID = patientID
                };
                reportList = ptRepo.SearchRegisteredTest(sm);  
            }
            else
            {
                MessageBox.Show("هیچ آیتمی برای مورد جستجو انتخاب نشده است!!!");
            }
            BindGrid();
            BindGridDateToPersian();
        }
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            err.Clear();
            reportList = ptRepo.GetAllRegisteredTests();
            BindGrid();
            BindGridDateToPersian();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void faDateFromDate_SelectedDateTimeChanged(object sender, EventArgs e)
        {
            SearchingFromDate = (DateTime?)faDateFromDate.SelectedDateTime;
            if (!SearchingFromDate.HasValue)
            {
                reportList.Clear();
            }
        }
        private void faDateToDate_SelectedDateTimeChanged(object sender, EventArgs e)
        {
            SearchingToDate = (DateTime?)faDateToDate.SelectedDateTime;
            if (!SearchingToDate.HasValue)
            {
                reportList.Clear();
            }
        }
        private void txtRegistedTestID_TextChanged(object sender, EventArgs e)
        {
            string RGID = txtRegistedTestID.Text;
            
            if(RGID.Length>0)
            {
                if (!CheckIsNumeric(RGID))
                {
                    err.SetError(txtRegistedTestID, "شماره سربرگ را به عدد وارد کنید");
                    return;
                }
                registeredTestID = Convert.ToInt32(RGID);
            }
            else
            {
                registeredTestID = null;
                reportList.Clear();
            }
        }
        private void txtSearchPatient_TextChanged(object sender, EventArgs e)
        {
            if (lstPatient.Items.Count > 0)
            {
                lstPatient.DataSource = null;
            }
            if (!string.IsNullOrEmpty(txtSearchPatient.Text) && txtSearchPatient.Text.Length >= 1)
            {
                List<PatientList> list = pRepo.Search(txtSearchPatient.Text);
                lstPatient.DisplayMember = "Information";
                lstPatient.ValueMember = "PatientID";
                lstPatient.DataSource = list;
                lstPatient.Visible = true;
            }
            else
            {
                patientID = null;
                reportList.Clear();
                BindGrid();
            }
        }
        private void lstPatient_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            patientID = Convert.ToInt32(lstPatient.SelectedValue);
            var patient = pRepo.GetById(Convert.ToInt32(lstPatient.SelectedValue));
            txtSearchPatient.Text = patient.FirstName + " " + patient.LastName;
            lstPatient.Visible = false;
        }

    }
}
