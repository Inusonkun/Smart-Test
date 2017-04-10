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
using SmartTest.SystemForm;

namespace SmartTest.SystemForm.SUBJECT
{
    public delegate void SendData(string str);
    public partial class frmSelect : Form
    {
        DataAccess da;
        DataSet dt = new DataSet();
        public string MaSo { set; get; }
        public frmSelect()
        {
            InitializeComponent();
            da = new DataAccess();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public string Selected
        {
            get { return dtgrvSelect.CurrentRow.Cells[0].Value.ToString(); }
        }

        private void dtgrvSelect_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    e.SuppressKeyPress = true;
                    if (btSelect.Enabled)
                    {
                        btSelect_Click(sender, e);
                    }
                    break;
                case Keys.Escape:
                    btClose_Click(sender, e);
                    break;
                default:
                    break;
            }
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
            dtgrvSelect.DataSource = bsource;
            dtgrvSelect.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }

        private void frmSelect_Load(object sender, EventArgs e)
        {
            Subject sj = new Subject();
            //SendData ld = new SendData(sj.LoadData())
            //this.send(LoadData);
            //LoadData();
        }

    }
}
