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
using SmartTest.DAL;

namespace SmartTest.SystemForm
{
    public partial class UserAccount : Form
    {
        DataSet dt = new DataSet();
        public UserAccount()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            this.Height = 360;
            btAdd.Enabled = false;
            btDelete.Enabled = false;
            btEdit.Enabled = false;
            btFind.Enabled = false;
            btPrint.Enabled = false;
            //dataGridView1.Rows.Add(txtbName.Text, txtbUserID.Text, txtStaffID.Text, txtTransaction.Text);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            this.Height = 230;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            this.Height = 360;
        }

        private void UserAccount_Load(object sender, EventArgs e)
        {
            this.Height = 230;
            
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (dt.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK);
            }
            else
                foreach (System.Windows.Forms.DataGridViewRow dgvUsersrows in dataGridView1.SelectedRows)
                {
                    string _code = dgvUsersrows.Cells[0].Value.ToString().Trim();
                    string _name = dgvUsersrows.Cells[1].Value.ToString().Trim();

                    if (MessageBox.Show("Có chắc chắn xóa '" + _code + " - " + _name + "' không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            int _rowIdx = dgvUsersrows.Index;
                            //MessageBox.Show(dgvUsersrows.Index.ToString(), "TB");
                            dt.Tables[0].Rows.RemoveAt(dgvUsersrows.Index);
                            dataGridView1.Refresh();

                            var result = dataGridView1.DataSource;
                            //result.RemoveAt(_rowIdx);
                            //dataGridView1.DataSource = result;

                           DataAccess dbA = new DataAccess();
                            string sql = "DELETE FROM [Users] " +
                                         "WHERE code ='" + _code + "'";
                            int _ok = dbA.ExecuteData(sql);
                            if (_ok > 0)
                            {
                                //MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Có lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Có lỗi" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    i++;
                }
        }
    }
}
