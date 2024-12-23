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
    public partial class FrmTestReportDetails : Form
    {
        DataAccess.PatientTestHeaderRepository ptRepo = new DataAccess.PatientTestHeaderRepository();
        int registeredTestID;

        private void BindGrid()
        {
            grdTestDetailReport.AutoGenerateColumns = false;
            grdTestDetailReport.DataSource = null;
            grdTestDetailReport.DataSource = ptRepo.GetRegisteredTestItemsByID(registeredTestID);
        }
        public FrmTestReportDetails(int ID)
        {
            registeredTestID = ID;    
            InitializeComponent();
        }

        private void FrmTestReportDetails_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

    }
}
