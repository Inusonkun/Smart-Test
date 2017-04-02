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

namespace SmartTest.SystemForm.Subject
{
    public partial class Subject : Form
    {
        DataAccess da;
        string ButtonClick = "";
        public Subject()
        {
            InitializeComponent();
            da = new DataAccess();
        }

        private void ViewMode()
        {
            switch (ButtonClick)
            {
                case "Tìm":
                case "Thêm":
                    txtSubjectID.Text = "";
                    txtSubjectName.Text = "";
                    txtNote.Text = "";
                    grbDetail.Enabled = true;
                    this.Height = 395;
                    break;
                case "Sửa":
                    grbDetail.Enabled = true;
                    this.Height = 395;
                    txtSubjectID.Text = dtgrvSubject.CurrentRow.Cells[0].Value.ToString();
                    txtSubjectName.Text = dtgrvSubject.CurrentRow.Cells[1].Value.ToString();
                    txtNote.Text = dtgrvSubject.CurrentRow.Cells[2].Value.ToString();
                    break;
                case "":
                    grbDetail.Enabled = false;
                    this.Height = 265;
                    break;
                default:
                    break;
            }
        }

        private void Subject_Load(object sender, EventArgs e)
        {
            this.Height = 266;
            var data = da.ExecuteAsDataReaderSql("SELECT MaMon, TenMon, GhiChu FROM DANHSACHMONTHI", null);

            try
            {
                if (data != null && data.HasRows)
                {
                    List<Class_Subject> sj = new List<Class_Subject>();
                    while (data.Read())
                    {
                        sj.Add(new Class_Subject
                        {
                            MaMon = data["MaMon"] + string.Empty,
                            TenMon = data["TenMon"] + string.Empty,
                            GhiChu = data["GhiChu"] + string.Empty,
                        });
                    }
                    dtgrvSubject.DataBindings.Clear();
                    dtgrvSubject.AutoGenerateColumns = false;
                    dtgrvSubject.DataSource = sj;
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("Có lỗi" + es.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddNew()
        {
            try
            {
                Class_Subject sj = new Class_Subject
                {
                    MaMon = txtSubjectID.Text.Trim(),
                    TenMon = txtSubjectName.Text.Trim(),
                    GhiChu = txtNote.Text.Trim()
                };

                int result = da.ExecuteData(sj.ToInsertQuery(), sj.ToParameters());
                if (result > 0)
                {
                    MessageBox.Show("Success");
                    ButtonClick = "";
                    ViewMode();
                }
                else MessageBox.Show("Failed");

                Subject_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void EditData()
        {
            try
            {
                Class_Subject sj = new Class_Subject
                {
                    MaMon = txtSubjectID.Text,
                    TenMon = txtSubjectName.Text,
                    GhiChu = txtNote.Text
                };
                int result = da.ExecuteData(sj.ToUpdateQuery(), sj.ToParameters());
                if (result > 0)
                {
                    MessageBox.Show("Success");
                    ButtonClick = "";
                    ViewMode();
                }
                else MessageBox.Show("Failed");

                Subject_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi! " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            txtSubjectID.ReadOnly = true;
            grbDetail.Visible = true;
            btAdd.Enabled = false;
            btDelete.Enabled = false;
            btEdit.Enabled = false;
            btFind.Enabled = false;
            btPrint.Enabled = true;
            ButtonClick = "Sửa";
            ViewMode();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Height = 265;
            btAdd.Enabled = true;
            btDelete.Enabled = true;
            btEdit.Enabled = true;
            btFind.Enabled = true;
            btPrint.Enabled = true;
        }

        private void btCommit_Click(object sender, EventArgs e)
        {
            switch (ButtonClick)
            {
                case "Thêm":
                    AddNew();
                    grbDetail.Enabled = true;
                    this.Height = 395;
                    btAdd.Enabled = true;
                    btDelete.Enabled = true;
                    btEdit.Enabled = true;
                    btFind.Enabled = true;
                    break;
                case "Sửa":
                    EditData();
                    grbDetail.Enabled = true;
                    this.Height = 395;
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

        private void btPrint_Click(object sender, EventArgs e)
        {
            SmartTest.SystemForm.SUBJECT.ReportSubject rpsj = new SUBJECT.ReportSubject();
            rpsj.ShowDialog();

        }
    }
}