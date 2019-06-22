using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_Managment_System.Forms
{
    public partial class StudentFeeReport : Form
    {
        public StudentFeeReport()
        {
            InitializeComponent();
        }

        private void ShowReport()
        {
            String appPath = Application.StartupPath;
            String reportPath = @"Reports\FeeReport.rpt";
            String reportFullPath = Path.Combine(appPath, reportPath);

            ReportDocument rdoc = new ReportDocument();
            rdoc.Load(reportFullPath);

            crystalReportViewer1.ReportSource = rdoc;

        }

        private void StudentFeeReport_Load(object sender, EventArgs e)
        {
            ShowReport();
        }
    }
}
