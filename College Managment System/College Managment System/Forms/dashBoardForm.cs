using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_Managment_System.Forms
{
    public partial class dashBoardForm : Form
    {
        public dashBoardForm()
        {
            InitializeComponent();
            dashBoardUC1.BringToFront();
            panelLabel.Height = button6.Height;
            panelLabel.Top = button6.Top;
            lblTitle.Text = "Dashboard";
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        

        private void buttonDashBoard_Click(object sender, EventArgs e)
        {
            dashBoardUC1.BringToFront();
            panelLabel.Height = button6.Height;
            panelLabel.Top = button6.Top;
            lblTitle.Text = "Dashboard";

        }

        private void buttonAdmission_click(object sender, EventArgs e)
        {
            admissionFormUC1.BringToFront();
            panelLabel.Height = button1.Height;
            panelLabel.Top = button1.Top;
            lblTitle.Text = "Admission Form";

        }

        private void Button_Fee(object sender, EventArgs e)
        {
            feeForm1.BringToFront();
            panelLabel.Height = button2.Height;
            panelLabel.Top = button2.Top;
            lblTitle.Text = "Fee Form";

        }

        private void Button_StDetail(object sender, EventArgs e)
        {
            searchStudent1.BringToFront();
            panelLabel.Height = button3.Height;
            panelLabel.Top = button3.Top;
            lblTitle.Text = "Search Student";

            searchStudent1.loadData();

        }

        private void Button_StRemove(object sender, EventArgs e)
        {
            removeStudent1.BringToFront();
            panelLabel.Height = button4.Height;
            panelLabel.Top = button4.Top;
            lblTitle.Text = "Remove Student";

            removeStudent1.loadDataDelete();
        }

        private void Button_AboutUs(object sender, EventArgs e)
        {
            aboutUs1.BringToFront();
            panelLabel.Height = button5.Height;
            panelLabel.Top = button5.Top;
            lblTitle.Text = "About Us";
        }

        private void admissionFormUC2_Load(object sender, EventArgs e)
        {

        }
 
        // This is logout button
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loginForm form = new loginForm();
            form.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
