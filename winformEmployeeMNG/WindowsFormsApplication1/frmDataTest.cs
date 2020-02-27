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

namespace WindowsFormsApplication1
{
    public partial class frmDataTest : Form
    {
        public frmDataTest()
        {
            InitializeComponent();
        }

        private void frmDataTest_Load(object sender, EventArgs e)
        {

        }
        private DataTable GetAllNhanVien()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-7R3NGKH;Initial Catalog=DataTest;Integrated Security=True";
            SqlCommand comman = new SqlCommand();
            comman.Connection = conn;
            comman.CommandText = "GetAllEmployee";
            comman.CommandType = CommandType.StoredProcedure;
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(comman);
            adapter.Fill(data);
            return data;
        }

        private void grdTestList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDataEvent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
