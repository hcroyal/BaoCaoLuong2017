﻿namespace BaoCaoLuong2017
{
    internal class Global
    {
        public static DataEntryBPODataContext db_BPO = new DataEntryBPODataContext();
        public static DataBaoCaoLuongDataContext db_BCL = new DataBaoCaoLuongDataContext();
        public static string StrMachine = "";
        public static string StrUserWindow = "";
        public static string StrIpAddress = "";
        public static string StrUsername = "";
        public static string StrBatch = "";
        public static string StrRole = "";
        public static string Strtoken = "";
        public static string StrIdimage = "";
        public static string StrCheck = "";
        public static string StrPath = @"\\10.10.10.248\BaoCaoLuong2017_CityS$";
        public static string Webservice = "http://10.10.10.248:8888/BaoCaoLuong2017_CityS/";
        public static string TenHinhThu2 = "";
        public static string GiaTriTruongSo4 = "";
        public static string StrIdProject = "BaoCaoLuong2017_CityS";
        public static int FreeTime = 0;
    }
}