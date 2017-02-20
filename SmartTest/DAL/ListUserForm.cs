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

namespace SmartTest.DAL
{
    public partial class ListUserForm : Form
    {
        public ListUserForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        SqlConnection cnt = new SqlConnection(@"Data Source=DESKTOP-QD51D97\SQLEXPRESS;Initial Catalog=THI_TRAC_NGHIEM;Integrated Security=True");
        private void KetNoiCSDL()
        {
            try
            {
                cnt.Open();
                string sql = "select * from DANHSACHNGUOIDUNG";
                SqlCommand cm = new SqlCommand(sql, cnt);
                cm.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgvListUser.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối! Hãy kiểm tra lại!");
            }

            cnt.Close();
           
        }

        private void ListUserForm_Load(object sender, EventArgs e)
        {
            KetNoiCSDL();
        }
    }
}
