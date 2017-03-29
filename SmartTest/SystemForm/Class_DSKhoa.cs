using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTest.SystemForm
{
    public class Class_DSKhoa
    {
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public string GhiChu { get; set; }
    }

    public static class DSKhoaExtension
    {
        public static List<KeyValuePair<string, object>> ToParameters(this Class_DSKhoa DSK)
        {
            var parameters = new List<KeyValuePair<string, object>>();
            parameters.Add(new KeyValuePair<string, object>("MaKhoa", DSK.MaKhoa));
            parameters.Add(new KeyValuePair<string, object>("TenKhoa", DSK.TenKhoa));
            parameters.Add(new KeyValuePair<string, object>("GhiChu", DSK.GhiChu));

            return parameters;
        }

        public static string ToInsertQuery(this Class_DSKhoa DSK)
        {
            return @"INSERT INTO DANHSACHKHOA(MaKhoa, TenKhoa, GhiChu) VALUES (@MaKhoa, @TenKhoa, @GhiChu)";
        }

        public static string ToUpdateQuery(this Class_DSKhoa DSK)
        {
            return @"UPDATE DANHSACHKHOA
                    SET TenKhoa = @TenKhoa, GhiChu = @GhiChu WHERE MaKhoa = @MaKhoa";
        }
    }
}
