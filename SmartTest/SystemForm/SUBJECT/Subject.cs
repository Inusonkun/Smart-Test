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
using System.Data.SqlClient;
using SmartTest.SystemForm.STAFF;
using SmartTest.SystemForm.CLASS;

namespace SmartTest.SystemForm.SUBJECT
{
    public partial class Subject : Form
    {
        DataAccess da;
        string ButtonClick = "";
        DataSet dt = new DataSet();

        public string MaSo { set; get; }
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
                    txtKhoa.Text = "";                    
                    grbDetail.Enabled = true;
                    this.Height = 395;
                    break;
                case "Sửa":
                    grbDetail.Enabled = true;
                    this.Height = 395;
                    txtSubjectID.Text = dtgrvSubject.CurrentRow.Cells[0].Value.ToString();
                    txtSubjectName.Text = dtgrvSubject.CurrentRow.Cells[1].Value.ToString();
                    txtKhoa.Text = dtgrvSubject.CurrentRow.Cells[2].Value.ToString();
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
            ViewMode();
            LoadData();
        }

        private void LoadData(string str = "")
        {
            string vMaSo = MaSo;
            string sql = "SELECT MaMon, TenMon FROM [DANHSACHMONTHI]" + str + "WHERE Khoa ='" + vMaSo + "'";
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
            dtgrvSubject.DataSource = bsource;
        }

        private void AddNew()
        {
            try
            {
                string vMaKhoa = MaSo;
                Class_Subject sj = new Class_Subject
                {
                    MaMon = txtSubjectID.Text.Trim(),
                    TenMon = txtSubjectName.Text.Trim(),
                    Khoa = txtKhoa.Text.Trim()
                };

                int result = da.ExecuteData(sj.ToInsertQuery(), sj.ToParameters());
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
                    Khoa = txtKhoa.Text
                };
                int result = da.ExecuteData(sj.ToUpdateQuery(), sj.ToParameters());
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
                    String vFilter = " Where (1=1)";
                    if (txtSubjectID.Text != "")
                    {
                        vFilter = vFilter + " and MaMon like'%" + txtSubjectID.Text + "%'";
                    }
                    if (txtSubjectName.Text != "")
                    {
                        vFilter = vFilter + " and TenMon like'%" + txtSubjectName.Text + "%'";
                    }
                    LoadData(vFilter);
                    ButtonClick = "";
                    ViewMode();
                    btAdd.Enabled = true;
                    btDelete.Enabled = true;
                    btEdit.Enabled = true;
                    btFind.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            new frmReportViewer(new ReportListSubject()).ShowDialog();
        }


        private void btFind_Click(object sender, EventArgs e)
        {
            grbDetail.Visible = true;
            btAdd.Enabled = false;
            btDelete.Enabled = false;
            btEdit.Enabled = false;
            btFind.Enabled = false;
            btPrint.Enabled = true;
            ButtonClick = "Tìm";
            ViewMode();
        }

        private void btStaff_Click(object sender, EventArgs e)
        {
            FormCBCT cb = new FormCBCT();
            cb.MaSo = dtgrvSubject.CurrentRow.Cells[0].Value.ToString();
            cb.ShowDialog();
        }
    }
}