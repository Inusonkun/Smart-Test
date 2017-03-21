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
    public partial class ReportUAListForm : Form
    {
        public ReportUAListForm()
        {
            InitializeComponent();
        }

        private void crtrp_ReportUAccList_Load(object sender, EventArgs e)
        {
            UserAccountList rpt = new UserAccountList();
            crtrp_ReportUAccList.ReportSource = rpt;
        }
    }
}
