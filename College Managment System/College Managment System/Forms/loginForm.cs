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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        // This is Login Button
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NODKF4Q;Initial Catalog=CollegeManagmentSystem;Integrated Security=True");
            String query = "SELECT userName,password FROM tbl_registrationForm WHERE userName = '" + this.bunifuMetroTextbox1.Text.Trim() + "' and password = '" + this.bunifuMetroTextbox2.Text.Trim() + "'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                dashBoardForm dashBoardForm = new dashBoardForm();
                this.Hide();
                dashBoardForm.Show();
                
            }
            else
            {
                MessageBox.Show("Check Your Username and Password");

            }

        }

        // This is Sign up Form
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
