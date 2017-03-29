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
                    this.Height = 303;
                    break;
                case "Sửa":
                    grbDetail.Enabled = true;
                    this.Height = 303;
                    txtMaKhoa.Text = dtgrDSKhoa.CurrentRow.Cells[0].Value.ToString();
                    txtTenKhoa.Text = dtgrDSKhoa.CurrentRow.Cells[1].Value.ToString();
                    txtGhiChu.Text = dtgrDSKhoa.CurrentRow.Cells[2].Value.ToString();
                    break;
                case "":
                    grbDetail.Enabled = false;
                    this.Height = 214;
                    break;
                default:
                    break;
            }
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
                }                   
                else MessageBox.Show("Failed");

                DSKhoaForm_Load(null, null);
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
                    MaKhoa = txtMaKhoa.Text.Trim(),
                    TenKhoa = txtTenKhoa.Text.Trim(),
                    GhiChu = txtGhiChu.Text.Trim()
                };
                int result = da.ExecuteData(DSK.ToUpdateQuery(), DSK.ToParameters());
                if (result > 0)
                {
                    MessageBox.Show("Success");
                    ButtonClick = "";
                    ViewMode();
                }
                else MessageBox.Show("Failed");

                DSKhoaForm_Load(null, null);
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
            this.Height = 214;
            var data = da.ExecuteAsDataReaderSql("SELECT MaKhoa, TenKhoa, GhiChu FROM DANHSACHKHOA", null);

            try
            {
                if (data != null && data.HasRows)
                {
                    List<Class_DSKhoa> DSK = new List<Class_DSKhoa>();
                    while (data.Read())
                    {
                        DSK.Add(new Class_DSKhoa
                        {
                            MaKhoa = data["MaKhoa"] + string.Empty,
                            TenKhoa = data["TenKhoa"] + string.Empty,
                            GhiChu = data["GhiChu"] + string.Empty,
                        });
                    }
                    dtgrDSKhoa.DataBindings.Clear();
                    dtgrDSKhoa.AutoGenerateColumns = false;
                    dtgrDSKhoa.DataSource = DSK;
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("Có lỗi" + es.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    this.Height = 303;
                    break;
                case "Sửa":
                case "Tìm":
                    break;
                default:
                    break;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            grbDetail.Visible = false;
            this.Height = 214;
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

    }
}
