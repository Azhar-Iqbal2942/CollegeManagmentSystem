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
    public partial class RemoveStudent : UserControl
    {
        // Global Variable
        int idToDelete;

        public RemoveStudent()
        {
            InitializeComponent();
        }

        public void loadDataDelete()
        {
            DataUtil.dataUtil d = new DataUtil.dataUtil();
            DataTable dt = d.Select();

            dgvDelete.DataSource = dt;
        }

        private void RowClicked(object sender, DataGridViewCellMouseEventArgs e)
        {
            // This is row that was clicked......
            int rowIndex = e.RowIndex;
            idToDelete = Convert.ToInt32(dgvDelete.Rows[rowIndex].Cells[0].Value);


        }

        private void Button_Delete(object sender, EventArgs e)
        {
            DataUtil.dataUtil data = new DataUtil.dataUtil();
            bool check = data.Delete(idToDelete);

            if (check)
            {
                MessageBox.Show("Data Deleted Successfully");
                loadDataDelete();
            }
            else {
                MessageBox.Show("Error Occured");
            }

        }

        private void searchDelete_OnValueChanged(object sender, EventArgs e)
        {
            String Keyword = this.searchDelete.Text;


            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NODKF4Q;Initial Catalog=CollegeManagmentSystem;Integrated Security=True");
            String query =
                "SELECT * FROM tbl_admissionForm WHERE fullName LIKE '%" + Keyword + "%' OR fatherName LIKE '%" + Keyword + "%' ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvDelete.DataSource = dt;
        }
    }
}
