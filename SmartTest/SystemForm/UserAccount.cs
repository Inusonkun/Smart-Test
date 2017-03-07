using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartTest.SystemForm
{
    public partial class UserAccount : Form
    {
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
    }
}
