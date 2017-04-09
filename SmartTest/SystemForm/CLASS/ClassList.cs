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

namespace SmartTest.SystemForm.CLASS
{
    public partial class ClassList : Form
    {
        DataAccess da;
        DataSet dt = new DataSet();
        string ButtonClick = "";
        public ClassList()
        {
            InitializeComponent();
            da = new DataAccess();
        }

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

        private void LoadData(string str = "")
        {
            string sql = "SELECT * FROM [DANHSACHLOP]" + str;
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
            dtgrvClass.DataSource = bsource;
        }

        private void ViewMode()
        {
            switch (ButtonClick)
            {
                case "Tìm":
                case "Thêm":
                    txtClassID.Text = "";
                    txtClassName.Text = "";
                    txtSubject.Text = "";
                    txtNote.Text = "";
                    gbDetail.Enabled = true;
                    this.Height = 360;
                    break;
                case "Sửa":
                    gbDetail.Enabled = true;
                    this.Height = 360;
                    txtClassID.Text = dtgrvClass.CurrentRow.Cells[0].Value.ToString();
                    txtClassName.Text = dtgrvClass.CurrentRow.Cells[1].Value.ToString();
                    txtSubject.Text = dtgrvClass.CurrentRow.Cells[2].Value.ToString();
                    txtNote.Text = dtgrvClass.CurrentRow.Cells[3].Value.ToString();
                    break;
                case "":
                    gbDetail.Enabled = false;
                    this.Height = 261;
                    break;
                default:
                    break;
            }
        }

        private void gbDetail_Enter(object sender, EventArgs e)
        {

        }

        private void ClassList_Load(object sender, EventArgs e)
        {
            this.Height = 360;
            ViewMode();
            LoadData();
        }

        private void AddNew()
        {
            try
            {
                ClassClass cl = new ClassClass
                {
                    MaLop = txtClassID.Text.Trim(),
                    TenLop = txtClassName.Text.Trim(),
                    MonHoc = txtSubject.Text.Trim(),
                    GhiChu = txtNote.Text.Trim()
                };

                int result = da.ExecuteData(cl.ToInsertQuery(), cl.ToParameters());
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
                ClassClass cl = new ClassClass
                {
                    MaLop = txtClassID.Text,
                    TenLop = txtClassName.Text,
                    MonHoc = txtSubject.Text,
                    GhiChu = txtNote.Text
                };
                int result = da.ExecuteData(cl.ToUpdateQuery(), cl.ToParameters());
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

        private void btAdd_Click(object sender, EventArgs e)
        {
            gbDetail.Visible = true;
            btAdd.Enabled = false;
            btDelete.Enabled = false;
            btEdit.Enabled = false;
            btFind.Enabled = false;
            btPrint.Enabled = true;
            ButtonClick = "Thêm";
            ViewMode();
            AlignCenterToScreen();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            gbDetail.Visible = true;
            btAdd.Enabled = false;
            btDelete.Enabled = false;
            btEdit.Enabled = false;
            btFind.Enabled = false;
            btPrint.Enabled = true;
            ButtonClick = "Sửa";
            ViewMode();
            AlignCenterToScreen();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Height = 268;
            ButtonClick = "";
            ViewMode();
            AlignCenterToScreen();
        }

        private void btCommit_Click(object sender, EventArgs e)
        {
            switch (ButtonClick)
            {
                case "Thêm":
                    AddNew();
                    gbDetail.Enabled = true;
                    this.Height = 360;
                    btAdd.Enabled = true;
                    btDelete.Enabled = true;
                    btEdit.Enabled = true;
                    btFind.Enabled = true;
                    break;
                case "Sửa":
                    EditData();
                    gbDetail.Enabled = true;
                    this.Height = 360;
                    btAdd.Enabled = true;
                    btDelete.Enabled = true;
                    btEdit.Enabled = true;
                    btFind.Enabled = true;
                    break;
                case "Tìm":
                    String vFilter = " Where (1=1)";
                    if (txtClassID.Text != ""){
                        vFilter = vFilter + " and MaLop like'%" + txtClassID.Text + "%'";
                    }
                    if (txtClassName.Text != "")
                    {
                        vFilter = vFilter + " and TenLop like'%" + txtClassName.Text + "%'";
                    }
                    if (txtSubject.Text != "")
                    {
                        vFilter = vFilter + " and MonHoc like'%" + txtSubject.Text + "%'";
                    }
                    //
                    LoadData(vFilter);
                    ButtonClick = "";
                    ViewMode();
                    break;
                default:
                    break;
            }
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            ButtonClick = "Tìm";
            ViewMode();
            AlignCenterToScreen();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (dt.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK);
            }
            else
                foreach (System.Windows.Forms.DataGridViewRow dgvDANHSACHLOProws in dtgrvClass.SelectedRows)
                {
                    string _MaLop = dgvDANHSACHLOProws.Cells[0].Value.ToString().Trim();
                    string _TenLop = dgvDANHSACHLOProws.Cells[1].Value.ToString().Trim();

                    if (MessageBox.Show("Có chắc chắn xóa '" + _MaLop + " - " + _TenLop + "' không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            int _rowIdx = dgvDANHSACHLOProws.Index;
                            //MessageBox.Show(dgvUsersrows.Index.ToString(), "TB");
                            dt.Tables[0].Rows.RemoveAt(dgvDANHSACHLOProws.Index);
                            dtgrvClass.Refresh();

                            var result = dtgrvClass.DataSource;
                            //result.RemoveAt(_rowIdx);
                            //dataGridView1.DataSource = result;

                            DataAccess dbA = new DataAccess();
                            string sql = "DELETE FROM [DANHSACHLOP] " +
                                         "WHERE MaLop ='" + _MaLop + "'";
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

        private void btPrint_Click(object sender, EventArgs e)
        {
            new frmReportViewer(new RpClassList()).ShowDialog();
        }
    }
}
