using DomainModel.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Laboratory
{
    public partial class FrmMain : Form
    {
        public Employee CurrentEmployee { get; set; }
        public FrmMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            mainpb.Dock = DockStyle.Fill;
        }

        #region Methods

        public void OpenSelectedForm<T>() where T : Form, new()
        {
            foreach (Form openedForm in this.MdiChildren)
            {
                if (openedForm is T existingForm)
                {
                    existingForm.Activate();
                    return;
                }
            }

            Form newForm = new T();
            newForm.MdiParent = this;

            switch (newForm)
            {
                case FrmPatientTestHeader frmPt:
                    frmPt.ActiveEmployee = CurrentEmployee;
                    break;
            }
            newForm.Show();
        }
        public void SetMainVisiblity()
        {
            foreach (Form OpenedForm in this.MdiChildren)
            {
                if (this.MdiChildren.Length > 0)
                {
                    mainpb.Visible = false;
                    lblEmployee.Visible = false;
                    lblDate.Visible = false;
                    lbldt.Visible = false;
                    lblemp.Visible = false;
                }
                else
                {
                    mainpb.Visible = true;
                    lblEmployee.Visible = true;
                    lblDate.Visible = true;
                    lbldt.Visible = true;
                    lblemp.Visible = true;
                }
            }
        }
        #endregion

        private void کارمندانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSelectedForm<FrmEmployee>();
            SetMainVisiblity();
        }
        private void مراجعینToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSelectedForm<FrmPatient>();
            SetMainVisiblity();
        }
        private void آزمایشاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSelectedForm<FrmTest>();
            SetMainVisiblity();
        }
        private void پروندهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSelectedForm<FrmTestReport>();
            SetMainVisiblity();
        }
        private void مدیریتنتایجآزمایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSelectedForm<FrmPatientTestHeader>();
            SetMainVisiblity();
        }
        private void مدیریتسربرگآزمایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSelectedForm<FrmPatientTestResult>();
            SetMainVisiblity();
        }
        private void بیمهToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenSelectedForm<FrmInsurance>();
            SetMainVisiblity();
        }
        private void واحدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSelectedForm<FrmTestUnit>();
            SetMainVisiblity();
        }
        private void ردهبندیآزمایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSelectedForm<FrmTestCategory>();
            SetMainVisiblity();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblEmployee.Text = CurrentEmployee.FirstName + "  " + CurrentEmployee.LastName;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            FrameWork.DateTimeUtility utility = new FrameWork.DateTimeUtility();
            lblDate.Text = utility.GetPersianDateTime(DateTime.Now);
        } 
    }
}
