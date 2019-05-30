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
    public partial class AdmissionFormUC : UserControl
    {
        public AdmissionFormUC()
        {
            InitializeComponent();
        }

        public void clearFields()
        {
            bunifuMetroTextbox1.Text = "";
            bunifuMetroTextbox2.Text = "";
            bunifuMetroTextbox3.Text = "";
            bunifuMetroTextbox4.Text = "";
            bunifuMetroTextbox5.Text = "";
            bunifuMetroTextbox6.Text = "";
            bunifuMetroTextbox7.Text = "";
            bunifuMetroTextbox8.Text = "";
            bunifuDatepicker1.ResetText();
            bunifuDropdown1.selectedIndex = -1;

        }

       
       

        private void Button_Register(object sender, EventArgs e)
        {
           
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NODKF4Q;Initial Catalog=CollegeManagmentSystem;Integrated Security=True");
            String checkQuery = "SELECT fullName FROM tbl_admissionForm WHERE fullName = '" + this.bunifuMetroTextbox1.Text.Trim() + "'";

            SqlDataAdapter adapter = new SqlDataAdapter(checkQuery, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count == 0)
            {

                try
                {
                    String query = "INSERT INTO tbl_admissionForm(fullName,fatherName,gender,mobileNo,email,degree,previousSchoolName,address,year,dateOfBirth) VALUES (@fullName,@fatherName,@gender,@mobileNo,@email,@degree,@previousSchoolName,@address,@year,@dateOfBirth)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@fullName", this.bunifuMetroTextbox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@fatherName", this.bunifuMetroTextbox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@gender", this.bunifuDropdown1.selectedValue.ToString());
                    cmd.Parameters.AddWithValue("@mobileNo", this.bunifuMetroTextbox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", this.bunifuMetroTextbox4.Text.Trim());
                    cmd.Parameters.AddWithValue("@degree", this.bunifuMetroTextbox5.Text.Trim());
                    cmd.Parameters.AddWithValue("@previousSchoolName", this.bunifuMetroTextbox6.Text.Trim());
                    cmd.Parameters.AddWithValue("@address", this.bunifuMetroTextbox8.Text.Trim());
                    cmd.Parameters.AddWithValue("@year", this.bunifuMetroTextbox7.Text.Trim());
                    cmd.Parameters.Add("@dateOfBirth", SqlDbType.Date).Value = this.bunifuDatepicker1.Value.Date;


                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    //if query runs successfully than row value will be greater than 0 else data is not entered   successffully.
                    if (rows > 0)
                    {
                        MessageBox.Show("Student Record Enter Successfully.");
                        clearFields();
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
                MessageBox.Show("This user is Already Register");

            }

        }
    }
}
