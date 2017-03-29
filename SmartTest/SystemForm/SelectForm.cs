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
    public partial class SelectForm : Form
    {
        DataSet ds = new DataSet();

        public SelectForm()
        {
            InitializeComponent();
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        public string Selected
        {
            get { return dtgrSelect.CurrentRow.Cells[0].Value.ToString(); }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    e.SuppressKeyPress = true;
                    if (btSelect.Enabled) { btSelect_Click(sender, e); }
                    break;
                case Keys.Escape:
                    btClose_Click(sender, e);
                    break;
                default:
                    break;
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
