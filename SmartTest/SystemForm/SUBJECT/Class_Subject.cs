using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTest.SystemForm.SUBJECT
{
    public class Class_Subject
    {
        public string MaMon { get; set; }

        public string TenMon { get; set; }
        public string Khoa { get; set; }
      
        //public string NhanVienCoiThi { get; set; }
    }

    public static class SubjectExtension
    {
        public static List<KeyValuePair<string, object>> ToParameters(this Class_Subject sj)
        {
            var parameters = new List<KeyValuePair<string, object>>();
            parameters.Add(new KeyValuePair<string, object>("MaMon", sj.MaMon));
            parameters.Add(new KeyValuePair<string, object>("TenMon", sj.TenMon));
            parameters.Add(new KeyValuePair<string, object>("Khoa", sj.Khoa));
            //parameters.Add(new KeyValuePair<string, object>("NhanVienCoiThi", sj.NhanVienCoiThi));

            return parameters;
        }

        public static string ToInsertQuery(this Class_Subject sj)
        {
            return @"INSERT INTO DANHSACHMONTHI(MaMon, TenMon, Khoa) VALUES (@MaMon, @TenMon, @Khoa)";
        }

        public static string ToUpdateQuery(this Class_Subject sj)
        {
            return @"UPDATE DANHSACHMONTHI
                    SET TenMon = @TenMon, Khoa = @Khoa WHERE MaMon = @MaMon";
        }

  
    }
}
