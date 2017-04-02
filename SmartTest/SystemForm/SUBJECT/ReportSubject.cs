using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartTest.SystemForm.SUBJECT
{
    public partial class ReportSubject : Form
    {
        public ReportSubject()
        {
            InitializeComponent();
        }

        private void crtrpSubject_Load(object sender, EventArgs e)
        {
            ReportListSubject rp = new ReportListSubject();
            crtrpSubject.ReportSource = rp;
        }
    }
}
