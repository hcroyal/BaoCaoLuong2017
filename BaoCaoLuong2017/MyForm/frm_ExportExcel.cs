using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BaoCaoLuong2017.MyForm
{
    public partial class frm_ExportExcel : DevExpress.XtraEditors.XtraForm
    {
        public frm_ExportExcel()
        {
            InitializeComponent();
        }

        private void frm_ExportExcel_Load(object sender, EventArgs e)
        {
            cbb_Batch.DataSource = Global.db_BCL.GetBatch();
            cbb_Batch.DisplayMember = "fBatchName";
            cbb_Batch.ValueMember = "fbatchname";
            cbb_Batch.Text = Global.StrBatch;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var nhap = (from w in Global.db_BCL.tbl_Images
                        where w.fbatchname == Global.StrBatch && w.ReadImageDESo == 2
                        select w.idimage).Count();
            var sohinh = (from w in Global.db_BCL.tbl_Images
                          where w.fbatchname == Global.StrBatch
                          select w.idimage).Count();
            var check = (from w in Global.db_BCL.tbl_MissImage_DESOs
                         where w.fBatchName == Global.StrBatch && w.Submit == 0
                         select w.IdImage).Count();
            if (sohinh > nhap)
            {
                MessageBox.Show("Chưa nhập xong DeSo!");
                return;
            }
            if (check > 0)
            {
                var list_user = (from w in Global.db_BCL.tbl_MissImage_DESOs
                                 where w.fBatchName == cbb_Batch.Text && w.Submit == 0
                                 select w.UserName).ToList();
                string sss = "";
                foreach (var item in list_user)
                {
                    sss += item + "\r\n";
                }

                if (list_user.Count > 0)
                {
                    MessageBox.Show("Những user lấy hình về nhưng không nhập: \r\n" + sss);
                    return;
                }
            }
            nhap = (from w in Global.db_BCL.tbl_Images
                    where w.fbatchname == cbb_Batch.Text && w.ReadImageDEJP == 2
                    select w.idimage).Count();
            check = (from w in Global.db_BCL.tbl_MissImage_DEJPs
                     where w.fBatchName == cbb_Batch.Text && w.Submit == 0
                     select w.IdImage).Count();
            if (sohinh > nhap)
            {
                MessageBox.Show("Chưa nhập xong DeJP!");
                return;
            }
            if (check > 0)
            {
                var list_user = (from w in Global.db_BCL.tbl_MissImage_DEJPs
                                 where w.fBatchName == cbb_Batch.Text && w.Submit == 0
                                 select w.UserName).ToList();
                string sss = "";
                foreach (var item in list_user)
                {
                    sss += item + "\r\n";
                }

                if (list_user.Count > 0)
                {
                    MessageBox.Show("Những user lấy hình về nhưng không nhập: \r\n" + sss);
                    return;
                }
            }
            var soloi = ((from w in Global.db_BCL.tbl_DESOs
                          where w.fBatchName == cbb_Batch.Text && w.Dem == 1
                          select w.IdImage).Count() / 2);

            check = (from w in Global.db_BCL.tbl_MissCheck_DESOs
                     where w.fBatchName == cbb_Batch.Text && w.Submit == 0
                     select w.IdImage).Count();
            if (check > 0 || soloi > 0)
            {
                MessageBox.Show("Chưa check xong DeSo!");
                return;
            }
            soloi = ((from w in Global.db_BCL.tbl_DEJPs
                      where w.fBatchName == cbb_Batch.Text && w.Dem == 1
                      select w.IdImage).Count() / 2);

            check = (from w in Global.db_BCL.tbl_MissCheck_DEJPs
                     where w.fBatchName == cbb_Batch.Text && w.Submit == 0 
                     select w.IdImage).Count();
            if (check > 0 || soloi > 0)
            {
                MessageBox.Show("Chưa check xong DeJP!");
                return;
            }
            if (System.IO.File.Exists(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\\ExportExcel.xls"))
            {
                System.IO.File.Delete(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\\ExportExcel.xls");
                System.IO.File.WriteAllBytes((System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "/ExportExcel.xls"), Properties.Resources.ExportExcel);
            }
            else
            {
                System.IO.File.WriteAllBytes((System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "/ExportExcel.xls"), Properties.Resources.ExportExcel);
            }
            TableToExcel(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\\ExportExcel.xls");
        }
        public bool TableToExcel(String strfilename)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Global.db_BCL.ExportExcel(cbb_Batch.Text);
                Microsoft.Office.Interop.Excel.Application App = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook book = App.Workbooks.Open(strfilename, 0, true, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                Microsoft.Office.Interop.Excel.Sheets _sheet = (Microsoft.Office.Interop.Excel.Sheets)book.Sheets;
                Microsoft.Office.Interop.Excel.Worksheet wrksheet = (Microsoft.Office.Interop.Excel.Worksheet)book.ActiveSheet;
                
                string truongso1_tobia = "";
                string dulieu_truong2_loai1 = "";
                string loaiphieu = "";
                bool truong3_loai2_trong = false;
                string dulieu_truong3_loai2 = "";
                string dulieu_truong4_loai2 = "";
                int hangloai2 = 0;
                int hangloai2_truong4 = 0;
                int h = 2;
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    
                    for (int i = 0; i <= 217; i++)
                    {
                        if (i==0)
                        {
                            wrksheet.Cells[h, i + 1] = dr.Cells[i].Value.ToString();
                        }
                        else if (i == 1)
                        {
                            if (dr.Cells[i].ToString() == "Loai1")
                            {
                                loaiphieu = "1";
                            }
                            else if (dr.Cells[i].ToString() == "Loai2")
                            {
                                loaiphieu = "2";
                            }
                            else if (dr.Cells[i].ToString() == "Loai3")
                            {
                                loaiphieu = "3";
                            }
                            else
                            {
                                loaiphieu = "4";
                            }
                            wrksheet.Cells[h, i + 1] = dr.Cells[i].Value.ToString();
                        }
                        else if (i == 2)
                        {
                            switch (loaiphieu)
                            {
                                case "1":
                                    wrksheet.Cells[h, i + 1] = dr.Cells[i].Value.ToString();
                                    truongso1_tobia = dr.Cells[i].Value.ToString();
                                    break;
                                case "2":
                                    wrksheet.Cells[h, i + 1] = truongso1_tobia;
                                    break;
                                case "3":
                                    wrksheet.Cells[h, i + 1] = truongso1_tobia;
                                    break;
                                case "4":
                                    if (!string.IsNullOrEmpty(dr.Cells[i].Value.ToString()))
                                    {
                                        if (dr.Cells[i].Value.ToString() == "?")
                                        {
                                            wrksheet.Cells[h, i + 1] = "?";
                                        }
                                        else
                                        {
                                            wrksheet.Cells[h, i + 1] = dr.Cells[i].Value.ToString();
                                        }
                                    }
                                    else
                                    {
                                        wrksheet.Cells[h, i + 1] = "";
                                    }
                                    break;
                            }
                        }
                        else if (i == 3)
                        {
                            switch (loaiphieu)
                            {
                                case "1":
                                    wrksheet.Cells[h, i + 1] = !string.IsNullOrEmpty(dr.Cells[i].Value.ToString()) ? dr.Cells[i].Value.ToString() : "";
                                    if (!string.IsNullOrEmpty(dr.Cells[i].Value.ToString()))
                                    {
                                        wrksheet.Cells[h, i + 1] = dr.Cells[i].Value.ToString();
                                        dulieu_truong2_loai1 = dr.Cells[i].Value.ToString();
                                    }
                                    else
                                    {
                                        wrksheet.Cells[h, i + 1] = "";
                                        dulieu_truong2_loai1 = "";
                                    }
                                    break;
                                case "2":
                                    if (!string.IsNullOrEmpty(dr.Cells[i].Value.ToString()))
                                    {
                                        if (dr.Cells[i].Value.ToString()=="?")
                                        {
                                            wrksheet.Cells[h, i + 1] = "?";
                                        }
                                        else
                                        {
                                            wrksheet.Cells[h, i + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[i].Value.ToString(), 12, "0");
                                        }
                                    }
                                    else
                                    {
                                        wrksheet.Cells[h, i + 1] = "";
                                    }
                                    break;
                                case "3":
                                    if (!string.IsNullOrEmpty(dr.Cells[i].Value.ToString()))
                                    {
                                        if (dr.Cells[i].Value.ToString() == "?")
                                        {
                                            wrksheet.Cells[h, i + 1] = "?";
                                        }
                                        else
                                        {
                                            wrksheet.Cells[h, i + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[i].Value.ToString(), 12, "0");
                                        }
                                    }
                                    else
                                    {
                                        wrksheet.Cells[h, i + 1] = "";
                                    }
                                    break;
                                case "4":
                                    wrksheet.Cells[h, i + 1] = dr.Cells[i].Value?.ToString();
                                    break;
                            }
                            
                        }
                        else if (i == 4)
                        {
                            switch (loaiphieu)
                            {
                                case "1":
                                    wrksheet.Cells[h, i + 1] = "";
                                    break;
                                case "2":
                                    if (!string.IsNullOrEmpty(dr.Cells[i].Value.ToString()))
                                    {
                                        if (dr.Cells[i].Value.ToString() == "?")
                                        {
                                            wrksheet.Cells[h, i + 1] = "?";
                                            dulieu_truong3_loai2 = "?";
                                        }
                                        else
                                        {
                                            wrksheet.Cells[h, i + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[i].Value.ToString(), 12, "0");
                                            dulieu_truong3_loai2 = ThemKyTubatKyPhiatruoc(dr.Cells[i].Value.ToString(), 12, "0");
                                        }
                                        truong3_loai2_trong = false;
                                    }
                                    else
                                    {
                                        wrksheet.Cells[h, i + 1] = "";
                                        dulieu_truong3_loai2 = "";
                                        truong3_loai2_trong = true;
                                    }
                                    hangloai2 = h;
                                    break;
                                case "3":
                                    if (!string.IsNullOrEmpty(dr.Cells[i].Value.ToString()))
                                    {
                                        if (dr.Cells[i].Value.ToString() == "?")
                                        {
                                            wrksheet.Cells[h, i + 1] = "?";
                                            if (truong3_loai2_trong)
                                            {
                                                wrksheet.Cells[hangloai2, i + 2] = "?";
                                            }
                                        }
                                        else
                                        {
                                            wrksheet.Cells[h, i + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[i].Value.ToString(), 12, "0");
                                            if (truong3_loai2_trong)
                                            {
                                                wrksheet.Cells[hangloai2, i + 2] = ThemKyTubatKyPhiatruoc(dr.Cells[i].Value.ToString(), 12, "0");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        wrksheet.Cells[h, i + 1] = "333333333333";
                                        if (truong3_loai2_trong)
                                        {
                                            wrksheet.Cells[hangloai2, i + 1] = "333333333333";
                                        }
                                    }
                                    break;
                                case "4":
                                    if (!string.IsNullOrEmpty(dr.Cells[i].Value.ToString()))
                                    {
                                        if (dr.Cells[i].Value.ToString() == "?")
                                        {
                                            wrksheet.Cells[h, i + 1] = "?";
                                        }
                                        else
                                        {
                                            wrksheet.Cells[h, i + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[i].Value.ToString(), 12, "0");
                                        }
                                    }
                                    else
                                    {
                                        wrksheet.Cells[h, i + 1] = "";
                                    }
                                    break;
                            }
                        }
                        else if (i == 5)
                        {
                            switch (loaiphieu)
                            {
                                case "1":
                                    wrksheet.Cells[h, i + 1] = "";
                                    break;
                                case "2":
                                    if (!string.IsNullOrEmpty(dr.Cells[i].Value.ToString()))
                                    {
                                        if (dr.Cells[i].Value.ToString() == "?")
                                        {
                                            wrksheet.Cells[h, i + 1] = "?";
                                            dulieu_truong4_loai2 = "?";
                                        }
                                        else
                                        {
                                            wrksheet.Cells[h, i + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[i].Value.ToString(), 12, "0");
                                            dulieu_truong4_loai2 = ThemKyTubatKyPhiatruoc(dr.Cells[i].Value.ToString(), 12, "0");
                                        }
                                    }
                                    else
                                    {
                                        wrksheet.Cells[h, i + 1] = "";
                                        dulieu_truong4_loai2 = "";
                                    }
                                    hangloai2_truong4 = h;
                                    break;
                                case "3":
                                    wrksheet.Cells[h, i + 1] = "";
                                    break;
                                case "4":
                                    wrksheet.Cells[h, i + 1] = !string.IsNullOrEmpty(dr.Cells[i].Value.ToString()) ? dr.Cells[i].Value?.ToString() : "";
                                    break;
                            }
                        }
                        else if (i == 6)
                        {
                            if (loaiphieu=="4")
                            {
                                if (!string.IsNullOrEmpty(dr.Cells[i].Value.ToString()))
                                {
                                    if (dulieu_truong4_loai2 != dr.Cells[i].Value.ToString())
                                    {
                                        wrksheet.Cells[h, i + 1] = "9999999999999";
                                        wrksheet.Cells[hangloai2_truong4, i + 1] = "9999999999999";
                                    }
                                    else
                                    {
                                        wrksheet.Cells[h, i + 1] = dr.Cells[i].Value.ToString();
                                    }
                                }
                                else
                                {
                                    if (!string.IsNullOrEmpty(dulieu_truong4_loai2))
                                    {
                                        wrksheet.Cells[h, i + 1] = "9999999999999";
                                        wrksheet.Cells[hangloai2_truong4, i + 1] = "9999999999999";
                                    }
                                    else
                                    {
                                        wrksheet.Cells[h, i + 1] = "";
                                    }
                                }
                            }
                            else
                            {
                                wrksheet.Cells[h, i + 1] = !string.IsNullOrEmpty(dr.Cells[i].Value.ToString()) ? dr.Cells[i].Value?.ToString(): "";
                            }
                        }
                        else if (i == 7)
                        {
                            if (loaiphieu=="4")
                            {
                                if (truongso1_tobia=="06" || truongso1_tobia == "07")
                                {
                                    wrksheet.Cells[h, i + 1] = "4091953036";
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(dr.Cells[i].Value.ToString()))
                                    {
                                        if (dulieu_truong3_loai2 !="")
                                        {
                                            wrksheet.Cells[h, i + 1] = dulieu_truong3_loai2;
                                        }
                                        else
                                        {
                                            wrksheet.Cells[h, i + 1] = "3333333333333";
                                        }
                                    }
                                    else
                                    {
                                        wrksheet.Cells[h, i + 1] = dr.Cells[i].Value.ToString();
                                    }
                                }
                            }
                            else
                            {
                                wrksheet.Cells[h, i + 1] = !string.IsNullOrEmpty(dr.Cells[i].Value.ToString()) ? dr.Cells[i].Value.ToString() : "";
                            }
                        }
                        else if (i == 13)
                        {
                            if (loaiphieu == "4")
                            {
                                if (truongso1_tobia!="06"||truongso1_tobia !="07")
                                {
                                    wrksheet.Cells[h, i + 1] = !string.IsNullOrEmpty(dr.Cells[i].Value.ToString()) ? dr.Cells[i].Value.ToString() : "";
                                }
                                else
                                {
                                    wrksheet.Cells[h, i + 1] = "";
                                }
                            }
                            else
                            {
                                wrksheet.Cells[h, i + 1] = !string.IsNullOrEmpty(dr.Cells[i].Value.ToString()) ? dr.Cells[i].Value.ToString() : "";
                            }
                        }
                        else if (i == 14)
                        {
                            if (loaiphieu == "4")
                            {
                                if (dulieu_truong2_loai1 != "")
                                {
                                    wrksheet.Cells[h, i + 1] = !string.IsNullOrEmpty(dr.Cells[i].Value.ToString()) ? dr.Cells[i].Value.ToString() : "";
                                }
                                else
                                {
                                    wrksheet.Cells[h, i + 1] = "";
                                }
                            }
                            else
                            {
                                wrksheet.Cells[h, i + 1] = !string.IsNullOrEmpty(dr.Cells[i].Value.ToString()) ? dr.Cells[i].Value.ToString() : "";
                            }
                        }
                        else if (i == 38||i==39|| i == 40|| i == 41|| i == 42|| i == 43|| i == 44|| i == 45|| i == 46|| i == 47|| i == 48|| i == 49|| i == 51|| i == 52|| i == 53|| i == 54|| i == 58|| i == 59|| i == 64|| i == 65|| i == 66|| i == 67)
                        {
                            if (loaiphieu == "4")
                            {
                                if (!string.IsNullOrEmpty(dr.Cells[i].Value.ToString()))
                                {
                                    if (dr.Cells[i].Value.ToString()=="?")
                                    {
                                        wrksheet.Cells[h, i + 1] = "?";
                                    }
                                    else if (dr.Cells[i].Value.ToString()!="0")
                                    {
                                        wrksheet.Cells[h, i + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[i].Value.ToString().Replace(",",""),8,"0");
                                    }
                                    else
                                    {
                                        wrksheet.Cells[h, i + 1] = "";
                                    }
                                }
                                else
                                {
                                    wrksheet.Cells[h, i + 1] = "";
                                }
                            }
                            else
                            {
                                wrksheet.Cells[h, i + 1] = !string.IsNullOrEmpty(dr.Cells[i].Value.ToString()) ? dr.Cells[i].Value.ToString() : "";
                            }
                        }
                        else if (i==79)
                        {
                            if (loaiphieu == "4")
                            {
                                if (!string.IsNullOrEmpty(dr.Cells[i].Value.ToString()))
                                {
                                    wrksheet.Cells[h, i + 1] = dr.Cells[i].Value.ToString();
                                    wrksheet.Cells[h, i] = "";
                                    
                                }
                                else
                                {
                                    wrksheet.Cells[h, i + 1] = "";
                                }
                            }
                            else
                            {
                                wrksheet.Cells[h, i + 1] = !string.IsNullOrEmpty(dr.Cells[i].Value.ToString()) ? dr.Cells[i].Value.ToString() : "";
                            }
                        }
                        else if (i == 80 || i == 81 || i == 82 || i == 83 || i == 84 || i == 85 || i == 86 || i == 87)
                        {
                            if (loaiphieu == "4")
                            {
                                if (!string.IsNullOrEmpty(dr.Cells[i].Value.ToString()))
                                {
                                    if (dr.Cells[i].Value.ToString() == "?")
                                    {
                                        wrksheet.Cells[h, i + 1] = "?";
                                    }
                                    else if (dr.Cells[i].Value.ToString() != "0")
                                    {
                                        wrksheet.Cells[h, i + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[i].Value.ToString().Replace(",", ""), 2, "0");
                                    }
                                    else
                                    {
                                        wrksheet.Cells[h, i + 1] = "";
                                    }
                                }
                                else
                                {
                                    wrksheet.Cells[h, i + 1] = "";
                                }
                            }
                            else
                            {
                                wrksheet.Cells[h, i + 1] = !string.IsNullOrEmpty(dr.Cells[i].Value.ToString()) ? dr.Cells[i].Value.ToString() : "";
                            }
                        }
                        else if (i==93)
                        {
                            if (loaiphieu == "4")
                            {
                                if (!string.IsNullOrEmpty(dr.Cells[107].Value.ToString()))
                                {
                                    if (dr.Cells[107].Value.ToString() != "?")
                                    {
                                        int temp = int.Parse(dr.Cells[107].Value.ToString());
                                        if (temp>260401)
                                        {
                                            wrksheet.Cells[h, i + 1] = "1";
                                        }
                                        else
                                        {
                                            wrksheet.Cells[h, i + 1] = "";
                                        }
                                    }
                                }
                                if (!string.IsNullOrEmpty(dr.Cells[108].Value.ToString()))
                                {
                                    if (dr.Cells[108].Value.ToString() != "?")
                                    {
                                        int temp = int.Parse(dr.Cells[108].Value.ToString());
                                        if (temp > 260401)
                                        {
                                            wrksheet.Cells[h, i + 1] = "1";
                                        }
                                        else
                                        {
                                            wrksheet.Cells[h, i + 1] = "";
                                        }
                                    }
                                }
                            }
                            else
                            {
                                wrksheet.Cells[h, i + 1] = !string.IsNullOrEmpty(dr.Cells[i].Value.ToString()) ? dr.Cells[i].Value.ToString() : "";
                            }
                        }
                        else if (i == 101)
                        {
                            if (loaiphieu == "4")
                            {
                                if (!string.IsNullOrEmpty(dr.Cells[102].Value.ToString()))
                                {
                                    wrksheet.Cells[h, i + 1] = "";
                                }
                                else
                                {
                                    wrksheet.Cells[h, i + 1] = !string.IsNullOrEmpty(dr.Cells[i].Value.ToString()) ? dr.Cells[i].Value.ToString() : "";
                                }
                            }
                            else
                            {
                                wrksheet.Cells[h, i + 1] = !string.IsNullOrEmpty(dr.Cells[i].Value.ToString()) ? dr.Cells[i].Value.ToString() : "";
                            }
                        }
                        else if (i == 103 || i == 107 || i == 108)
                        {
                            if (loaiphieu == "4")
                            {
                                if (!string.IsNullOrEmpty(dr.Cells[i].Value.ToString()))
                                {
                                    if (dr.Cells[i].Value.ToString() == "?")
                                    {
                                        wrksheet.Cells[h, i + 1] = "?";
                                    }
                                    else 
                                    {
                                        wrksheet.Cells[h, i + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[i].Value.ToString().Replace(",", ""), 8, "0");
                                    }
                                    
                                }
                                else
                                {
                                    wrksheet.Cells[h, i + 1] = "";
                                }
                            }
                            else
                            {
                                wrksheet.Cells[h, i + 1] = !string.IsNullOrEmpty(dr.Cells[i].Value.ToString()) ? dr.Cells[i].Value.ToString() : "";
                            }
                        }
                        else if (i == 111)
                        {
                            if (loaiphieu == "4")
                            {
                                if (!string.IsNullOrEmpty(dr.Cells[i].Value.ToString()))
                                {
                                    if (dr.Cells[i].Value.ToString() == "?")
                                    {
                                        wrksheet.Cells[h, i + 1] = "?";
                                    }
                                    else
                                    {
                                        wrksheet.Cells[h, i + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[i].Value.ToString().Replace(",", ""), 2, "0");
                                    }

                                }
                                else
                                {
                                    wrksheet.Cells[h, i + 1] = "";
                                }
                            }
                            else
                            {
                                wrksheet.Cells[h, i + 1] = !string.IsNullOrEmpty(dr.Cells[i].Value.ToString()) ? dr.Cells[i].Value.ToString() : "";
                            }
                        }
                        else if (i == 159)
                        {
                            if (loaiphieu == "4")
                            {
                                if (!string.IsNullOrEmpty(dr.Cells[i].Value.ToString()))
                                {
                                    if (dr.Cells[i].Value.ToString() == "?")
                                    {
                                        wrksheet.Cells[h, i + 1] = "?";
                                    }
                                    else
                                    {
                                        wrksheet.Cells[h, i + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[i].Value.ToString().Replace(",", ""), 12, "0");
                                    }

                                }
                                else
                                {
                                    wrksheet.Cells[h, i + 1] = "";
                                }
                            }
                            else
                            {
                                wrksheet.Cells[h, i + 1] = !string.IsNullOrEmpty(dr.Cells[i].Value.ToString()) ? dr.Cells[i].Value.ToString() : "";
                            }
                        }
                        else if (i == 160||i==161||i==162)
                        {
                            if (loaiphieu == "4")
                            {
                                if (!string.IsNullOrEmpty(dr.Cells[i].Value.ToString()))
                                {
                                    if (dr.Cells[i].Value.ToString() == "?")
                                    {
                                        wrksheet.Cells[h, i + 1] = "?";
                                    }
                                    else
                                    {
                                        wrksheet.Cells[h, i + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[i].Value.ToString().Replace(",", ""), 12, "0");
                                    }
                                }
                                else
                                {
                                    wrksheet.Cells[h, i + 1] = "";
                                }
                            }
                            else
                            {
                                wrksheet.Cells[h, i + 1] = !string.IsNullOrEmpty(dr.Cells[i].Value.ToString()) ? dr.Cells[i].Value.ToString() : "";
                            }
                        }
                        else if (i == 163)
                        {
                            if (loaiphieu == "4")
                            {
                                if (!string.IsNullOrEmpty(dr.Cells[i].Value.ToString()))
                                {
                                    if (dr.Cells[i].Value.ToString() == "?")
                                    {
                                        wrksheet.Cells[h, i + 1] = "?";
                                    }
                                    else
                                    {
                                        if (dr.Cells[160].Value.ToString()=="")
                                        {
                                            if (dr.Cells[161].Value.ToString() == "")
                                            {
                                                if (dr.Cells[162].Value.ToString() == "")
                                                {
                                                    wrksheet.Cells[h, 160 + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[i].Value.ToString().Replace(",", ""), 12, "0");
                                                    wrksheet.Cells[h, i + 1] = "";
                                                }
                                                else
                                                {
                                                    if (dr.Cells[160].Value.ToString() == "")
                                                    {
                                                        if (dr.Cells[161].Value.ToString()=="")
                                                        {
                                                            wrksheet.Cells[h, 160 + 1] =ThemKyTubatKyPhiatruoc(dr.Cells[162].Value.ToString().Replace(",", ""), 12,"0");
                                                            wrksheet.Cells[h, 161 + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[i].Value.ToString().Replace(",", ""), 12, "0");
                                                            wrksheet.Cells[h, 162 + 1] = "";
                                                            wrksheet.Cells[h, i + 1] = "";
                                                        }
                                                        else
                                                        {
                                                            wrksheet.Cells[h, 160 + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[161].Value.ToString().Replace(",", ""), 12, "0");
                                                            wrksheet.Cells[h, 161 + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[162].Value.ToString().Replace(",", ""), 12, "0");
                                                            wrksheet.Cells[h, 162 + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[163].Value.ToString().Replace(",", ""), 12, "0");
                                                            wrksheet.Cells[h, i + 1] = "";
                                                        }
                                                    }
                                                    else
                                                    {
                                                        wrksheet.Cells[h, 163 + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[163].Value.ToString().Replace(",", ""), 12, "0");
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if (dr.Cells[160].Value.ToString() == "")
                                                {
                                                    wrksheet.Cells[h, 160 + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[161].Value.ToString().Replace(",", ""), 12, "0");
                                                    wrksheet.Cells[h, 161 + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[162].Value.ToString().Replace(",", ""), 12, "0");
                                                    wrksheet.Cells[h, 162 + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[163].Value.ToString().Replace(",", ""), 12, "0");
                                                    wrksheet.Cells[h, i + 1] = "";
                                                }
                                                else
                                                {
                                                    wrksheet.Cells[h, 163 + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[163].Value.ToString().Replace(",", ""), 12, "0");

                                                }
                                            }
                                        }
                                        else
                                        {
                                            wrksheet.Cells[h, 163 + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[163].Value.ToString().Replace(",", ""), 12, "0");
                                        }

                                    }
                                }
                                else
                                {
                                    wrksheet.Cells[h, i + 1] = "";
                                }
                            }
                            else
                            {
                                wrksheet.Cells[h, i + 1] = !string.IsNullOrEmpty(dr.Cells[i].Value.ToString()) ? dr.Cells[i].Value.ToString() : "";
                            }
                        }
                        else if (i == 169)
                        {
                            if (loaiphieu == "4")
                            {
                                if (!string.IsNullOrEmpty(dr.Cells[i].Value.ToString()))
                                {
                                    if (dr.Cells[i].Value.ToString() == "?")
                                    {
                                        wrksheet.Cells[h, i + 1] = "?";
                                    }
                                    else
                                    {
                                        if (dr.Cells[166].Value.ToString() == "")
                                        {
                                            if (dr.Cells[167].Value.ToString() == "")
                                            {
                                                if (dr.Cells[168].Value.ToString() == "")
                                                {
                                                    wrksheet.Cells[h, 166 + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[i].Value.ToString().Replace(",", ""), 12, "0");
                                                    wrksheet.Cells[h, i + 1] = "";
                                                }
                                                else
                                                {
                                                    if (dr.Cells[166].Value.ToString() == "")
                                                    {
                                                        if (dr.Cells[167].Value.ToString() == "")
                                                        {
                                                            wrksheet.Cells[h, 166 + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[167].Value.ToString().Replace(",", ""), 12, "0");
                                                            wrksheet.Cells[h, 167 + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[i].Value.ToString().Replace(",", ""), 12, "0");
                                                            wrksheet.Cells[h, 168 + 1] = "";
                                                            wrksheet.Cells[h, i + 1] = "";
                                                        }
                                                        else
                                                        {
                                                            wrksheet.Cells[h, 166 + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[167].Value.ToString().Replace(",", ""), 12, "0");
                                                            wrksheet.Cells[h, 167 + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[168].Value.ToString().Replace(",", ""), 12, "0");
                                                            wrksheet.Cells[h, 168 + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[169].Value.ToString().Replace(",", ""), 12, "0");
                                                            wrksheet.Cells[h, i + 1] = "";
                                                        }
                                                    }
                                                    else
                                                    {
                                                        wrksheet.Cells[h, 169 + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[169].Value.ToString().Replace(",", ""), 12, "0");
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if (dr.Cells[166].Value.ToString() == "")
                                                {
                                                    wrksheet.Cells[h, 166 + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[166].Value.ToString().Replace(",", ""), 12, "0");
                                                    wrksheet.Cells[h, 167 + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[167].Value.ToString().Replace(",", ""), 12, "0");
                                                    wrksheet.Cells[h, 168 + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[168].Value.ToString().Replace(",", ""), 12, "0");
                                                    wrksheet.Cells[h, i + 1] = "";
                                                }
                                                else
                                                {
                                                    wrksheet.Cells[h, 169 + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[169].Value.ToString().Replace(",", ""), 12, "0");

                                                }
                                            }
                                        }
                                        else
                                        {
                                            wrksheet.Cells[h, 169 + 1] = ThemKyTubatKyPhiatruoc(dr.Cells[169].Value.ToString().Replace(",", ""), 12, "0");
                                        }

                                    }
                                }
                                else
                                {
                                    wrksheet.Cells[h, i + 1] = "";
                                }
                            }
                            else
                            {
                                wrksheet.Cells[h, i + 1] = !string.IsNullOrEmpty(dr.Cells[i].Value.ToString()) ? dr.Cells[i].Value.ToString() : "";
                            }
                        }
                        else
                        {
                            wrksheet.Cells[h, i + 1] = !string.IsNullOrEmpty(dr.Cells[i].Value.ToString()) ? dr.Cells[i].Value.ToString(): "";
                        }
                    }
                    h++;
                }
                string savePath = "";
                saveFileDialog1.Title = "Save Excel Files";
                saveFileDialog1.Filter = "Excel files (*.xls)|*.xls";
                saveFileDialog1.FileName = cbb_Batch.Text;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //Tô màu

                    book.SaveCopyAs(saveFileDialog1.FileName);
                    book.Saved = true;
                    savePath = Path.GetDirectoryName(saveFileDialog1.FileName);
                    App.Quit();
                }
                else
                {
                    MessageBox.Show("Lỗi khi xuất excel!");
                    return false;
                }
                Process.Start(savePath);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        private String getcharacter(int n, String str)
        {
            String kq = "";
            for (int i = 1; i <= n; i++)
            {
                kq = kq.Insert(kq.Length, str);
            }

            return kq;
        }
        private String ThemKyTubatKyPhiatruoc(String input, int iByte, string str)
        {
            if (input.Length >= iByte)
                return input.Substring(input.Length - iByte, iByte);

            return input.Insert(0, getcharacter(iByte - input.Length, str));
        }
    }
}