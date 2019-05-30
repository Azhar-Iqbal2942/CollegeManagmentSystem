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
    public partial class SearchStudent : UserControl
    {
        public SearchStudent()
        {
            InitializeComponent();
        }

        public void loadData() {
            DataUtil.dataUtil d = new DataUtil.dataUtil();
            DataTable dt = d.Select();

            dgvSearchStudent.DataSource = dt;

        }

        public void SearchStudent_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgvSearchStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            // Get value from textbox
            String Keyword = this.bunifuMetroTextbox1.Text;


            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NODKF4Q;Initial Catalog=CollegeManagmentSystem;Integrated Security=True");
            String query =
                "SELECT * FROM tbl_admissionForm WHERE fullName LIKE '%" + Keyword+ "%' OR fatherName LIKE '%" + Keyword + "%' ";
            SqlDataAdapter adapter = new SqlDataAdapter(query,conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvSearchStudent.DataSource = dt;
        }
    }
}
