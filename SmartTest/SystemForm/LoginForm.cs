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
using System.Data.SqlClient;

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
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        #region login method
        //private void btnLogin_Click(object sender, EventArgs e)
        //{
        //    //Thực hiện đăng nhập vào ứng Demo với thông tin trên
        //    string loginApp = Login.LoginApp(
        //        MyApp.gHostDB, MyApp.gPortDB, MyApp.gServiceNameDB, txtUser.Text, txtPass.Text,
        //        txtUser.Text, txtPass.Text);
        //    if (loginApp.Equals("true"))
        //    {
        //        MyApp.gConnected = true;
        //        MyApp.gUserDB = txtUser.Text;
        //        //FrmLogin.Current.ItemMnuSystemLoginChange = "Đăng xuất";
        //        //Goi phan quyen o day
        //        SmartTest.SO.PhanQuyen.ShowAll();
        //        //close form
        //        this.Close();
        //    }
        //    else
        //    {
        //        //e.Result = string.Format("Đăng nhập vào {0} không thành công. Bạn hãy kiểm tra lại các thông tin đăng nhập.\r\n{1}", MyApp.gAppCoded, loginApp);
        //        string mMessage;
        //        mMessage = string.Format("Đăng nhập vào {0} không thành công. Bạn hãy kiểm tra lại các thông tin đăng nhập.\r\n{1}", MyApp.gHostDB, loginApp);
        //        MessageBox.Show(mMessage);
        //    }
        //}
        #endregion

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPass.SelectionStart = 0;
            txtPass.SelectionLength = txtPass.Text.Length;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
           
            string ketqua;
            ketqua = Login.DangNhap(txtUser.Text, txtPass.Text);
            if (ketqua == "Tốt")
            {
                //PhanQuyen.ShowAll();
                DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(ketqua, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btLogin_Click(sender, e);
            }
        }
    }
}
