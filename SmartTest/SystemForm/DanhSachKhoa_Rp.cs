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
    public partial class DanhSachKhoa_Rp : Form
    {
        public DanhSachKhoa_Rp()
        {
            InitializeComponent();
        }

        private void crtrpDanhSachKhoa_Load(object sender, EventArgs e)
        {
            RpDanhSachKhoa rpt = new RpDanhSachKhoa();
            crtrpDanhSachKhoa.ReportSource = rpt;
        }
    }
}
