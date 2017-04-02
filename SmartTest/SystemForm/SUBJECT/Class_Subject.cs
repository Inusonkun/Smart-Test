using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTest.SystemForm.Subject
{
    public class Class_Subject
    {
        public string MaMon { get; set; }

        public string TenMon { get; set; }
        public string GhiChu { get; set; }
    }

    public static class SubjectExtension
    {
        public static List<KeyValuePair<string, object>> ToParameters(this Class_Subject sj)
        {
            var parameters = new List<KeyValuePair<string, object>>();
            parameters.Add(new KeyValuePair<string, object>("MaMon", sj.MaMon));
            parameters.Add(new KeyValuePair<string, object>("TenMon", sj.TenMon));
            parameters.Add(new KeyValuePair<string, object>("Ghichu", sj.GhiChu));

            return parameters;
        }

        public static string ToInsertQuery(this Class_Subject sj)
        {
            return @"INSERT INTO DANHSACHMONTHI(MaMon, TenMon, GhiChu) VALUES (@MaMon, @TenMon, @GhiChu)";
        }

        public static string ToUpdateQuery(this Class_Subject sj)
        {
            return @"UPDATE DANHSACHMONTHI
                    SET TenMon = @TenMon, GhiChu = @GhiChu WHERE MaMon = @MaMon";
        }

        public static string ToDeleteQuery(this Class_Subject sj)
        {
            return @"DELETE FROM DANHSACHMONTHI WHERE MaMon= @MaMon";
        }
    }
}
