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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        // This is SignUp Button
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NODKF4Q;Initial Catalog=CollegeManagmentSystem;Integrated Security=True");

            String query = "SELECT userName FROM tbl_registrationForm WHERE userName = '" + this.bunifuMetroTextbox1.Text.Trim() + "'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count == 0)
            {
                try
                {

                    String sql = "INSERT INTO tbl_registrationForm(firstName,lastName,userName,email,password) VALUES (@firstName,@lastName,@userName,@email,@password)";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@firstName", this.bunifuMetroTextbox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@lastName", this.bunifuMetroTextbox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@userName", this.bunifuMetroTextbox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", this.bunifuMetroTextbox5.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", this.bunifuMetroTextbox4.Text.Trim());

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    //if query runs successfully than row value will be greater than 0 else data is not entered   successffully.
                    if (rows > 0)
                    {

                        MessageBox.Show("User Registered Successfully");
                    }
                    else
                    {

                        MessageBox.Show("Error while storing data");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception Caught", ex);
                }
                finally
                {
                    conn.Close();
                    this.Hide();
                    loginForm form = new loginForm();
                    form.Show();

                }

            }
            else
            {
                MessageBox.Show("This User Name is already in use");
            }
              
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
