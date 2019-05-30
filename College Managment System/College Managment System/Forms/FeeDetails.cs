using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_Managment_System.Forms
{
    public partial class FeeDetails : Form
    {
        public FeeDetails()
        {
            InitializeComponent();
        }

        public void displayData()
        {
            DataUtil.dataUtil dataUtil = new DataUtil.dataUtil();
            DataTable table = dataUtil.GetFeeData();
            dgvFeeDetails.DataSource = table;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FeeDetails_Load(object sender, EventArgs e)
        {
            displayData();
        }
    }
}
