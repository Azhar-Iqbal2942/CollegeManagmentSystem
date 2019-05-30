using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace College_Managment_System.UserControls
{
    public partial class FeeForm : UserControl
    {
        // Global Variables
        int id;
        String name;
        String degree;


        public FeeForm()
        {
            InitializeComponent();
        }

        private void Fee_Search_Click(object sender, EventArgs e)
        {

        }

        public void clearData()
        {
            lblName.Text = "";
            lblDegree.Text = "";
            txtFee.Text = "";
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NODKF4Q;Initial Catalog=CollegeManagmentSystem;Integrated Security=True");
            // Check for data integrity
            String checkQuery = "SELECT fullName FROM tbl_feeForm WHERE fullName = '" + name + "'";

            SqlDataAdapter adapter = new SqlDataAdapter(checkQuery, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count == 0)
            {
                try
                {

                    String sql = "INSERT INTO tbl_feeForm(fullName,degree,fee) VALUES (@fullName,@degree,@fee)";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@fullName", name);
                    cmd.Parameters.AddWithValue("@degree", degree);
                    cmd.Parameters.AddWithValue("@fee", txtFee.Text.ToString());


                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    //if query runs successfully than row value will be greater than 0 else data is not entered   successffully.
                    if (rows > 0)
                    {

                        MessageBox.Show("Data Entered  Successfully");
                        clearData();
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

                }
            }
            else
            {
                MessageBox.Show("Fee Already paid");
            }

        }

        // This is textbox for getting id
        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            String value = bunifuMetroTextbox1.Text;
            id = Convert.ToInt32(value); 

        }

        // Search Button
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            DataUtil.dataUtil dataUtil = new DataUtil.dataUtil();
            DataTable data   =dataUtil.searchById(id);
            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                name = row["fullName"].ToString();
                degree = row["degree"].ToString();
                lblName.Text = name;
                lblDegree.Text = degree;
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.FeeDetails feeDetails = new Forms.FeeDetails();
            feeDetails.Show();
                
        }
    }
}
