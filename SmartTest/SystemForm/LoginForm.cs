using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartTest.SO;
using SmartTest.DAL;

namespace SmartTest.SystemForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            ExitForm frm = new ExitForm();
            frm.ShowDialog();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        #region login method
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Thực hiện đăng nhập vào ứng Demo với thông tin trên
            string loginApp = Login.LoginApp(
                MyApp.gHostDB, MyApp.gPortDB, MyApp.gServiceNameDB, txtUser.Text, txtPass.Text,
                txtUser.Text, txtPass.Text);
            if (loginApp.Equals("true"))
            {
                MyApp.gConnected = true;
                MyApp.gUserDB = txtUser.Text;
                //FrmLogin.Current.ItemMnuSystemLoginChange = "Đăng xuất";
                //Goi phan quyen o day
                SmartTest.SO.PhanQuyen.ShowAll();
                //close form
                this.Close();
            }
            else
            {
                //e.Result = string.Format("Đăng nhập vào {0} không thành công. Bạn hãy kiểm tra lại các thông tin đăng nhập.\r\n{1}", MyApp.gAppCoded, loginApp);
                string mMessage;
                mMessage = string.Format("Đăng nhập vào {0} không thành công. Bạn hãy kiểm tra lại các thông tin đăng nhập.\r\n{1}", MyApp.gHostDB, loginApp);
                MessageBox.Show(mMessage);
            }
        }
        #endregion

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPass.SelectionStart = 0;
            txtPass.SelectionLength = txtPass.Text.Length;
        }
    }
}
