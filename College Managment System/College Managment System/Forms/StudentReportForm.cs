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
    public partial class StudentReportForm : Form
    {
        

        public StudentReportForm()
        {
            InitializeComponent();
        }

        private void StudentReportForm_Load(object sender, EventArgs e)
        {
            showReport();
        }

        private void showReport()
        {
            String appPath = Application.StartupPath;
            String reportPath = @"Reports\Report.rpt";
            String reportFullPath = Path.Combine(appPath,reportPath);

            ReportDocument rdoc = new ReportDocument();
            rdoc.Load(reportFullPath);

            crystalReportViewer1.ReportSource = rdoc;
        }
    }
}
