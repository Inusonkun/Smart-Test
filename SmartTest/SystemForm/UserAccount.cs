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
        string ButtonClick = "";

        protected void AlignCenterToScreen()
        {
            Screen screen = Screen.FromControl(this);
            Rectangle workingArea = screen.WorkingArea;
            this.Location = new Point()
            {
                X = Math.Max(workingArea.X, workingArea.X + (workingArea.Width - this.Width) / 2),
                Y = Math.Max(workingArea.Y, workingArea.Y + (workingArea.Height - this.Height) / 2)
            };
        }
        public UserAccount()
        {
            InitializeComponent();
        }

        private void ViewMode()
        {
            switch (ButtonClick)
            {
                case "Find":
                case "Add":
                    txtbUserID.Text = "";
                    txtbName.Text = "";
                    txtStaffID.Text = "";
                    //dExpiredDate.Text = DateTime.Now;
                    cbChangePass.Checked = false;
                    ckbMacCheck.Checked = false;
                    groupBox1.Enabled = true;
                    dataGridView1.Enabled = false;
                    this.Height = 360;
                    break;
                case "Edit":
                    groupBox1.Enabled = true;
                    dataGridView1.Enabled = false;
                    this.Height = 360;
                    //
                    txtbUserID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    txtbName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txtStaffID.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    cbChangePass.Checked = dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Y" ? true : false;
                    ckbMacCheck.Checked = dataGridView1.CurrentRow.Cells[5].Value.ToString() == "1" ? true : false;
                    txtTransaction.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    //
                    break;
                case "":
                    groupBox1.Enabled = true;
                    dataGridView1.Enabled = true;
                    this.Height = 230;
                    break;
                default:
                    break;
            }
        }

        private void loadData(string _Filter = "")
        {
            DataAccess dbA = new DataAccess();
            string sql = "SELECT Code, Name, Staff_ID, TransactionCode, Open_Date, Expiry_Date, ChangePass, MAC_Check FROM [DANHSACHUSERS]" + _Filter;
            try
            {
                dt = dbA.ExecuteAsDataSetSql(sql);
            }
            catch (Exception es)
            {
                MessageBox.Show("Có lỗi" + es.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt.Tables[0];
            dataGridView1.DataSource = bSource;
            //dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }

        private void addNew()
        {
            try
            {
                DataAccess dbA = new DataAccess();
                Char vChangeAtLogon = cbChangePass.Checked ? 'Y' : 'N';
                Int32 vMacCheck = ckbMacCheck.Checked ? 1 : 0;
                string sql = "INSERT INTO Users(Code,Name,Staff_ID,TransactionCode,Open_Date, Expiry_Date,ChangePass,MAC_Check) " +
                    "VALUES('" + txtbUserID.Text + "','" + txtbName.Text + "','','" + txtTransaction.Text + "','" + txtTransaction.Text.Substring(0, 1) + "','" + vChangeAtLogon + "','" + dateTimePicker1.Text + "','" + txtStaffID.Text + "'," + vMacCheck + ", '" + DateTime.Today.ToString("yyyy-MM-dd") + "') ";
                int i = dbA.ExecuteData(sql);
                if (i > 0)
                {
                    //MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                    loadData();
                    ButtonClick = "";
                    ViewMode();
                }
                else
                {
                    MessageBox.Show("Có lỗi! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi! " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editData()
        {
            try
            {
                DataAccess dbA = new DataAccess();
                String vCode = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Char vChangeAtLogon = cbChangePass.Checked ? 'Y' : 'N';
                Int32 vMacCheck = ckbMacCheck.Checked ? 1 : 0;

                string sql = "UPDATE [Users] SET Name ='" + txtbName.Text + "'," +
                             "TransCodes ='" + txtTransaction.Text + "'," +
                             "TranRef ='" + txtTransaction.Text.Substring(0, 1) + "'," +
                             "PWDCHGNextLogon ='" + vChangeAtLogon + "'," +
                             "PWDExpiry_Date ='" + dateTimePicker1.Text + "'," +
                             "Staff_ID ='" + txtStaffID.Text + "'," +
                             "MAC_Check = " + vMacCheck + " " +
                             "WHERE code ='" + vCode + "'";
                int i = dbA.ExecuteData(sql);
                if (i > 0)
                {
                    //MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    ButtonClick = "";
                    ViewMode();
                }
                else
                {
                    MessageBox.Show("Có lỗi! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi! " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            ButtonClick = "Add";
            ViewMode();
            AlignCenterToScreen();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            ButtonClick = "Edit";
            ViewMode();
            AlignCenterToScreen();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            ButtonClick = "Cancel";
            ViewMode();
            AlignCenterToScreen();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            ButtonClick = "Find";
            ViewMode();
            AlignCenterToScreen();
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

        private void btCommit_Click(object sender, EventArgs e)
        {
            switch (ButtonClick)
            {
                case "Add":
                    addNew();
                    break;
                case "Edit":
                    editData();
                    //
                    break;
                case "Find":
                    String vFilter = " Where (1=1)";
                    if (txtbUserID.Text != "")
                    {
                        vFilter = vFilter + " and code like'%" + txtbUserID.Text + "%'";
                    }
                    if (txtbName.Text != "")
                    {
                        vFilter = vFilter + " and name like'%" + txtbName.Text + "%'";
                    }
                    if (txtStaffID.Text != "")
                    {
                        vFilter = vFilter + " and Staff_ID like'%" + txtStaffID.Text + "%'";
                    }
                    //
                    loadData(vFilter);
                    ButtonClick = "";
                    ViewMode();
                    //
                    break;
                default:
                    // Do Something
                    break;
            }
        }
    }
      
}
