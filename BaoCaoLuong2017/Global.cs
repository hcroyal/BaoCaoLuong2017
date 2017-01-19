using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaoCaoLuong2017
{
    internal class Global
    {
        public static DataEntryBPODataContext db_BPO = new DataEntryBPODataContext();
        public static DataBaoCaoLuongDataContext db_BCL = new DataBaoCaoLuongDataContext();
        public static  string StrMachine= "";
        public static string StrUserWindow ="";
        public static string StrIpAddress = "";
        public static string StrUsername ="";
        public static string StrBatch ="";
        public static string StrRole ="";
        public static string Strtoken ="";
    }
}
