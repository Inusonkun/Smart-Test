using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartTest.SystemForm;
using SmartTest.SO;

namespace SmartTest
{
    public partial class Main : Form
    {

        public static Main Current;
        public Main()
        {
            InitializeComponent();
            Current = this;
        }
        public string ItemMnuSystemLoginChange
        {
            get { return ItemDangNhap.Text; }
            set { ItemDangNhap.Text = value; }
        }
        

            private void DangNhap_Click(object sender, EventArgs e)
            {

                if (!MyApp.gConnected)
                {
                    LoginForm frm = new LoginForm();
                    frm.ShowDialog();
                }
                else
                {
                    if (MessageBox.Show("Có chắc chắn bỏ kết nối?", "Đăng xuất",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        MyApp.gConnected = false;
                        Main.Current.ItemMnuSystemLoginChange = "Đăng nhập";
                        SmartTest.SO.PhanQuyen.HideAll(); //ẩn tất cả các menu
                        LoginForm frm = new LoginForm();
                        frm.ShowDialog();
                    }
                }
            }

            private void FrmLogin_Load(object sender, EventArgs e)
            {
                foreach (Control ctrl in this.Controls)
                {

                    if (ctrl is MdiClient)
                    {
                        ctrl.BackColor = Color.White;
                    }
                }
            }

            private void Main_Load(object sender, EventArgs e)
            {
                MyApp.gConnected = false;
                //truyền đối tượng This (frmMain) cho class PhanQuyen
                SmartTest.SO.PhanQuyen.frmmain = this;
                //gọi HideAll để ẩn menu trong class PhanQUyen
                SmartTest.SO.PhanQuyen.HideAll();
                //
                //gọi form kết nối

                if (!MyApp.gConnected)
                {
                    LoginForm digForm = new LoginForm();
                    digForm.ShowDialog();
                }
            }

            private void DSLop_Click(object sender, EventArgs e)
            {
                ListClassForm frm = new ListClassForm();
                frm.Show();
                this.Hide();
            }

            private void Exit_Click(object sender, EventArgs e)
            {
                ExitForm frm = new ExitForm();
                frm.Show();
            }
        }
    
}
