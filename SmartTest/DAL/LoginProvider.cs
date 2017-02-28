using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartTest.SO;
using System.Data.Common;
using System.Data;

namespace SmartTest.DAL
{
    public class Login
    {
        #region Login vào ứng dụng
        public static string LoginApp(
            string host, string port, string servicename, string userdb, string pwddb,
            string username, string password)
        {
            string result = "Lỗi đăng nhập.";
            DataAccess dbA = new DataAccess();            
            MyApp.MSSQLConnectionString = MyApp.GetLoginMSSQL(host, servicename, userdb, pwddb);
            dbA.ConnectionString = MyApp.MSSQLConnectionString;
            string sql = "SELECT TenNguoiDung From [DANHSACHNGUOIDUNG] WHERE TenNguoiDung='" + username + "' and MatKhau = '" + password + "'";
            List<KeyValuePair<string, object>> ParaMeterCollection = new List<KeyValuePair<string, object>>();
            try
            {
                DbDataReader reader = dbA.ExecuteAsDataReaderSql(sql,ParaMeterCollection);
                if (reader.Read())
                    result = "true";
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }

            return result;
        }
        #endregion
        public static string DangNhap(string username, string password)
        {
            string ketqua = "";
            DataAccess dbA = new DataAccess();
            string sql = "SELECT TenNguoiDung From [DANHSACHNGUOIDUNG] WHERE TenNguoiDung ='" + username + "' and MatKhau ='" + password + "'";
            DataSet ds = new DataSet();
            ds = dbA.ExecuteAsDataSetSql(sql);
            int count = ds.Tables[0].Rows.Count;
            if (count == 0)
            {
                ketqua = "Không thành công";
            }
            else
            {
                ketqua = "Ngon";
            }
            return ketqua;
        }
    }
}
