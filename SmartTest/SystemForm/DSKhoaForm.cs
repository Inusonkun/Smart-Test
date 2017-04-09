using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartTest.DAL;


namespace SmartTest.SystemForm
{
    public partial class DSKhoaForm : Form
    {
        private DataAccess da;
        DataSet dt = new DataSet();
        public DSKhoaForm()
        {
            InitializeComponent();
            da = new DataAccess();
        }

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

        private void ViewMode()
        {
            switch(ButtonClick)
            {
                case "Tìm":
                case "Thêm":
                    txtMaKhoa.Text = "";
                    txtTenKhoa.Text = "";
                    txtGhiChu.Text = "";
                    grbDetail.Enabled = true;
                    this.Height = 374;
                    break;
                case "Sửa":
                    grbDetail.Enabled = true;
                    this.Height = 374;
                    txtMaKhoa.Text = dtgrDSKhoa.CurrentRow.Cells[0].Value.ToString();
                    txtTenKhoa.Text = dtgrDSKhoa.CurrentRow.Cells[1].Value.ToString();
                    txtGhiChu.Text = dtgrDSKhoa.CurrentRow.Cells[2].Value.ToString();
                    break;
                case "":
                    grbDetail.Enabled = false;
                    this.Height = 268;
                    break;
                default:
                    break;
            }
        }


        private void LoadData(string str = "")
        {
            string sql = "SELECT * FROM [DANHSACHKHOA]" + str;
            try
            {
                dt = da.ExecuteAsDataSetSql(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BindingSource bsource = new BindingSource();
            bsource.DataSource = dt.Tables[0];
            dtgrDSKhoa.DataSource = bsource;
        }

        private void AddNew()
        {
            try
            {
                Class_DSKhoa DSK = new Class_DSKhoa
                {
                    MaKhoa = txtMaKhoa.Text.Trim(),
                    TenKhoa = txtTenKhoa.Text.Trim(),
                    GhiChu = txtGhiChu.Text.Trim()
                };

                int result = da.ExecuteData(DSK.ToInsertQuery(), DSK.ToParameters());
                if (result > 0)
                {
                    MessageBox.Show("Success");
                    ButtonClick = "";
                    ViewMode();
                    LoadData();
                }                   
                else MessageBox.Show("Failed");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditData()
        {
            try
            {
                Class_DSKhoa DSK = new Class_DSKhoa
                {
                    MaKhoa = txtMaKhoa.Text,
                    TenKhoa = txtTenKhoa.Text,
                    GhiChu = txtGhiChu.Text
                };
                int result = da.ExecuteData(DSK.ToUpdateQuery(), DSK.ToParameters());
                if (result > 0)
                {
                    MessageBox.Show("Success");
                    ButtonClick = "";
                    ViewMode();
                    LoadData();
                }
                else MessageBox.Show("Failed");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi! " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgrDSKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grbDetail_Enter(object sender, EventArgs e)
        {
            
        }

        private void DSKhoaForm_Load(object sender, EventArgs e)
        {
            this.Height = 268;
            ViewMode();
            LoadData();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            grbDetail.Visible = true;
            btAdd.Enabled = false;
            btDelete.Enabled = false;
            btEdit.Enabled = false;
            btFind.Enabled = false;
            btPrint.Enabled = true;
            ButtonClick = "Thêm";
            ViewMode();
            AlignCenterToScreen();
        }

        private void btCommit_Click(object sender, EventArgs e)
        {
            switch(ButtonClick)
            {
                case "Thêm":
                    AddNew();
                    grbDetail.Enabled = true;
                    this.Height = 374;                 
                    btAdd.Enabled = true;
                    btDelete.Enabled = true;
                    btEdit.Enabled = true;
                    btFind.Enabled = true;
                    break;
                case "Sửa":
                    EditData();
                    grbDetail.Enabled = true;
                    this.Height = 374;
                    btAdd.Enabled = true;
                    btDelete.Enabled = true;
                    btEdit.Enabled = true;
                    btFind.Enabled = true;
                    break;
                case "Tìm":
                    break;
                default:
                    break;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            grbDetail.Visible = false;
            this.Height = 268;
            btAdd.Enabled = true;
            btDelete.Enabled = true;
            btEdit.Enabled = true;
            btFind.Enabled = true;
            btPrint.Enabled = true;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            txtMaKhoa.ReadOnly = true;
            grbDetail.Visible = true;
            btAdd.Enabled = false;
            btDelete.Enabled = false;
            btEdit.Enabled = false;
            btFind.Enabled = false;
            btPrint.Enabled = true;
            ButtonClick = "Sửa";
            ViewMode();
            AlignCenterToScreen();
        }

        private void dtgrDSKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Height = 374;
            grbDetail.Enabled = true;
            var data = da.ExecuteAsDataReaderSql("SELECT * FROM DANHSACHKHOA", null);
            if (data != null && data.HasRows)
            {
                List<Class_DSKhoa> DSK = new List<Class_DSKhoa>();
                while (data.Read())
                {
                    txtMaKhoa.Text = dtgrDSKhoa.CurrentRow.Cells[0].Value.ToString();
                    txtTenKhoa.Text = dtgrDSKhoa.CurrentRow.Cells[1].Value.ToString();
                    txtGhiChu.Text = dtgrDSKhoa.CurrentRow.Cells[2].Value.ToString();
                }
             
            }
        }


        private void btDelete_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (dt.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK);
            }
            else
                foreach (System.Windows.Forms.DataGridViewRow dgvDANHSACHKHOArows in dtgrDSKhoa.SelectedRows)
                {
                    string _MaKhoa = dgvDANHSACHKHOArows.Cells[0].Value.ToString().Trim();
                    string _TenKhoa = dgvDANHSACHKHOArows.Cells[1].Value.ToString().Trim();

                    if (MessageBox.Show("Có chắc chắn xóa '" + _MaKhoa + " - " + _TenKhoa + "' không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            int _rowIdx = dgvDANHSACHKHOArows.Index;
                            //MessageBox.Show(dgvUsersrows.Index.ToString(), "TB");
                            dt.Tables[0].Rows.RemoveAt(dgvDANHSACHKHOArows.Index);
                            dtgrDSKhoa.Refresh();

                            var result = dtgrDSKhoa.DataSource;
                            //result.RemoveAt(_rowIdx);
                            //dataGridView1.DataSource = result;

                            string sql = "DELETE FROM [DANHSACHKHOA] " +
                                         "WHERE MaKhoa ='" + _MaKhoa + "'";
                            int _ok = da.ExecuteData(sql);
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

        private void btPrint_Click(object sender, EventArgs e)
        {
            DanhSachKhoa_Rp rp = new DanhSachKhoa_Rp();
            rp.ShowDialog();
        }

        private void btSubject_Click(object sender, EventArgs e)
        {
            SUBJECT.Subject sj = new SUBJECT.Subject();
            sj.MaSo = dtgrDSKhoa.CurrentRow.Cells[0].Value.ToString();
            sj.ShowDialog();
        }
    }
}
