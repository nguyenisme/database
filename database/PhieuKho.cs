using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace database
{
    public partial class PhieuKho : Form
    {
        string connectionString = @"Server=DESKTOP-555IDLF\NGUYEN;Database=Nghia;Trusted_Connection=True;";
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataTable dt;
        public PhieuKho()
        {
            InitializeComponent();
        }

        private void Sach_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            string connectionString = @"Server=DESKTOP-555IDLF\NGUYEN;Database=Nghia;Trusted_Connection=True;";
            conn = new SqlConnection(connectionString);

            string query = "SELECT * FROM PhieuKho";
            adapter = new SqlDataAdapter(query, conn);

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                adapter.Update(dt);
                MessageBox.Show("Đã lưu thay đổi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
        }
    }
}
