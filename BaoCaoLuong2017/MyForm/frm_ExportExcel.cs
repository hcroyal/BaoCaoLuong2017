using Microsoft.Office.Interop.Excel;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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
                        where w.fbatchname == cbb_Batch.Text && w.ReadImageDESo == 2
                        select w.idimage).Count();
            var sohinh = (from w in Global.db_BCL.tbl_Images
                          where w.fbatchname == cbb_Batch.Text
                          select w.idimage).Count();
            var check = (from w in Global.db_BCL.tbl_MissImage_DESOs
                         where w.fBatchName == cbb_Batch.Text && w.Submit == 0
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
                dataGridView1.DataSource = Global.db_BCL.ExportExcel_new(cbb_Batch.Text);
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
                int hLoaiHai = 0;
                int hLoaiBa = 0;
                string TruongSo06Loai2 = "";
                string TruongSo06Loai3 = "";
                string TruongSo06Loai4 = "";

                string TruongSo5Loai2 = "";
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    //i = 0 --> dr.Cells[i] la ten hinh
                    //i = 1 --> dr.Cells[i] la laoi hinh

                    //loại phiếu
                    if (h == 145)
                    {
                        MessageBox.Show("");
                    }
                    switch (dr.Cells[1].Value.ToString())
                    {
                        case "Loai1":
                            //insert loai 1

                            truongso1_tobia = dr.Cells[2].Value != null ? dr.Cells[2].Value.ToString() : "";
                            dulieu_truong2_loai1 = dr.Cells[3].Value != null ? dr.Cells[3].Value.ToString() : "";

                            //bỏ qua nếu rỗng
                            if (string.IsNullOrEmpty(dr.Cells[2].Value != null ? dr.Cells[2].Value.ToString() : "") &&
                                string.IsNullOrEmpty(dr.Cells[3].Value != null ? dr.Cells[3].Value.ToString() : ""))
                            {
                                TruongSo06Loai2 = "";
                                TruongSo06Loai3 = "";
                                TruongSo06Loai4 = "";
                                hLoaiHai = 0;
                                hLoaiBa = 0;
                                break;
                            }

                            wrksheet.Cells[h, 1] = dr.Cells[0].Value != null ? dr.Cells[0].Value.ToString() : "";//tên iamge
                            wrksheet.Cells[h, 2] = dr.Cells[1].Value != null ? dr.Cells[1].Value.ToString() : "";//laoi
                            wrksheet.Cells[h, 3] = dr.Cells[2].Value != null ? dr.Cells[2].Value.ToString() : "";//truong so 1
                            wrksheet.Cells[h, 4] = dr.Cells[3].Value != null ? dr.Cells[3].Value.ToString() : "";// truong so2
                            wrksheet.Cells[h, 217] = dr.Cells[216].Value != null ? dr.Cells[216].Value.ToString() : "";

                            TruongSo06Loai2 = "";
                            TruongSo06Loai3 = "";
                            TruongSo06Loai4 = "";
                            hLoaiHai = 0;
                            hLoaiBa = 0;

                            break;

                        case "Loai2":
                            //insert loai 2
                            TruongSo06Loai3 = "";
                            TruongSo06Loai4 = "";

                            //bo qua neu rong
                            if (string.IsNullOrEmpty(dr.Cells[3].Value != null ? dr.Cells[3].Value.ToString() : "")
                                && string.IsNullOrEmpty(dr.Cells[5].Value != null ? dr.Cells[5].Value.ToString() : "")
                                && string.IsNullOrEmpty(dr.Cells[4].Value != null ? dr.Cells[4].Value.ToString() : "")
                                && string.IsNullOrEmpty(dr.Cells[216].Value != null ? dr.Cells[216].Value.ToString() : "")
                                )
                                break;

                            wrksheet.Cells[h, 1] = dr.Cells[0].Value != null ? dr.Cells[0].Value.ToString() : "";
                            wrksheet.Cells[h, 2] = dr.Cells[1].Value != null ? dr.Cells[1].Value.ToString() : "";
                            wrksheet.Cells[h, 3] = "";
                            wrksheet.Cells[h, 4] = "";
                            wrksheet.Cells[h, 5] = "";
                            wrksheet.Cells[h, 6] = dr.Cells[3].Value != null ? dr.Cells[3].Value.ToString() : ""; //truong so 4 mới/trường số 2 cũ

                            if (string.IsNullOrEmpty(dr.Cells[5].Value != null ? dr.Cells[5].Value.ToString() : ""))
                            {
                                wrksheet.Cells[h, 7] = "9999999999999";
                            }
                            else
                            {
                                wrksheet.Cells[h, 7] = dr.Cells[5].Value != null ? dr.Cells[5].Value.ToString() : "";//truong so 5
                            }

                            // = "4091953036" neu truong so 1 cua laoi 1 = 06 hoac 07
                            if (truongso1_tobia == "06" || truongso1_tobia == "07")
                                wrksheet.Cells[h, 8] = "4091953036";
                            else
                            {
                                wrksheet.Cells[h, 8] = TruongSo06Loai2 = dr.Cells[4].Value != null ? dr.Cells[4].Value.ToString() : ""; //truong so 6 mới / trường số 3 cũ
                            }

                            hLoaiHai = h;
                            wrksheet.Cells[h, 12] = "9";
                            wrksheet.Cells[h, 217] = dr.Cells[216].Value != null ? dr.Cells[216].Value.ToString() : "";
                            break;

                        case "Loai3":
                            //insert loai 3
                            TruongSo06Loai4 = "";
                            if (string.IsNullOrEmpty(dr.Cells[3].Value != null ? dr.Cells[3].Value.ToString() : "")
                                && string.IsNullOrEmpty(dr.Cells[4].Value != null ? dr.Cells[4].Value.ToString() : "")
                                )
                                break;

                            wrksheet.Cells[h, 1] = dr.Cells[0].Value != null ? dr.Cells[0].Value.ToString() : "";
                            wrksheet.Cells[h, 2] = dr.Cells[1].Value != null ? dr.Cells[1].Value.ToString() : "";
                            wrksheet.Cells[h, 3] = "";
                            wrksheet.Cells[h, 4] = "";
                            wrksheet.Cells[h, 5] = "";
                            wrksheet.Cells[h, 6] = dr.Cells[3].Value != null ? dr.Cells[3].Value.ToString() : "";//truong so 4 moi - 2 cu
                            wrksheet.Cells[h, 7] = "";

                            //Bắt đầu trường số 6
                            if (truongso1_tobia == "06" || truongso1_tobia == "07")
                                wrksheet.Cells[h, 8] = "4091953036";
                            else if (string.IsNullOrEmpty(dr.Cells[4].Value != null ? dr.Cells[4].Value.ToString() : ""))
                                wrksheet.Cells[h, 8] = TruongSo06Loai2;
                            else
                                wrksheet.Cells[h, 8] = TruongSo06Loai3 = dr.Cells[4].Value != null ? dr.Cells[4].Value.ToString() : "";//truong so 6 moi -4 cu
                            hLoaiBa = h;

                            wrksheet.Cells[h, 12] = "9";
                            wrksheet.Cells[h, 217] = dr.Cells[216].Value != null ? dr.Cells[216].Value.ToString() : "";

                            break;

                        case "Loai4":
                            //insert loai 4

                            wrksheet.Cells[h, 1] = dr.Cells[0].Value != null ? dr.Cells[0].Value.ToString() : "";//idimage
                            wrksheet.Cells[h, 2] = dr.Cells[1].Value != null ? dr.Cells[1].Value.ToString() : "";//loai phieu
                            wrksheet.Cells[h, 3] = ThemKyTubatKyPhiatruocNeuTrongThiDeTrong(dr.Cells[2].Value != null ? dr.Cells[2].Value.ToString() : "", 8, "0");//truong so 1

                            wrksheet.Cells[h, 4] = dr.Cells[3].Value != null ? dr.Cells[3].Value.ToString() : "";//truong so 2
                            wrksheet.Cells[h, 5] = dr.Cells[4].Value != null ? dr.Cells[4].Value.ToString() : "";//truong so 3
                            wrksheet.Cells[h, 6] = dr.Cells[5].Value != null ? dr.Cells[5].Value.ToString() : "";//truong so 4
                            if (string.IsNullOrEmpty(dr.Cells[6].Value != null ? dr.Cells[6].Value.ToString() : ""))
                            {
                                wrksheet.Cells[h, 7] = "";
                            }
                            else
                            {
                                wrksheet.Cells[h, 7] = dr.Cells[6].Value != null ? dr.Cells[6].Value.ToString() : "";//truong so 5
                            }

                            //Trường số 6
                            if (truongso1_tobia == "06" || truongso1_tobia == "07")
                            {
                                wrksheet.Cells[h, 8] = "4091953036";//thi truong so 6 = "4091953036"
                                //if (hLoaiHai > 0)
                                //    wrksheet.Cells[hLoaiHai, 8] = "4091953036";//truong so 6
                            }
                            else
                                wrksheet.Cells[h, 8] = TruongSo06Loai4 = dr.Cells[7].Value != null ? dr.Cells[7].Value.ToString() : "";

                            if ((string.IsNullOrEmpty(TruongSo06Loai2)
                                && string.IsNullOrEmpty(TruongSo06Loai3)
                                && string.IsNullOrEmpty(TruongSo06Loai4)) && (hLoaiHai > 0 && hLoaiBa > 0))
                            {
                                wrksheet.Cells[hLoaiHai, 8] = "333333333333";
                                wrksheet.Cells[hLoaiBa, 8] = "333333333333";
                                wrksheet.Cells[h, 8] = "333333333333";
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(TruongSo06Loai2) && hLoaiHai > 0)
                                    wrksheet.Cells[hLoaiHai, 8] = TruongSo06Loai3;
                                if (string.IsNullOrEmpty(TruongSo06Loai3) && hLoaiBa > 0)
                                {
                                    wrksheet.Cells[hLoaiBa, 8] = TruongSo06Loai2;
                                }
                            }

                            if (string.IsNullOrEmpty(TruongSo06Loai4) || truongso1_tobia == "12" || truongso1_tobia == "13" || truongso1_tobia == "14" || truongso1_tobia == "15")
                                wrksheet.Cells[h, 8] = TruongSo06Loai2;

                            //else if (string.IsNullOrEmpty(TruongSo06Loai2) && string.IsNullOrEmpty(dr.Cells[7].Value != null ? dr.Cells[7].Value.ToString() : ""))
                            //{
                            //    wrksheet.Cells[h, 8] = "333333333333";
                            //    if (hLoaiHai > 0)
                            //        wrksheet.Cells[hLoaiHai, 8] = "333333333333";
                            //}
                            //else if (!string.IsNullOrEmpty(TruongSo06Loai2) && string.IsNullOrEmpty(dr.Cells[7].Value != null ? dr.Cells[7].Value.ToString() : ""))
                            //{
                            //    wrksheet.Cells[h, 8] = TruongSo06Loai2;
                            //}
                            //else if (string.IsNullOrEmpty(TruongSo06Loai2) && !string.IsNullOrEmpty(dr.Cells[7].Value != null ? dr.Cells[7].Value.ToString() : ""))
                            //{
                            //    if (hLoaiHai > 0)
                            //        wrksheet.Cells[hLoaiHai, 8] = dr.Cells[7].Value != null ? dr.Cells[7].Value.ToString() : "";
                            //}
                            //else
                            //    wrksheet.Cells[h, 8] = dr.Cells[7].Value != null ? dr.Cells[7].Value.ToString() : "";

                            wrksheet.Cells[h, 9] = "";
                            wrksheet.Cells[h, 10] = dr.Cells[9].Value != null ? dr.Cells[9].Value.ToString() : "";
                            wrksheet.Cells[h, 11] = dr.Cells[10].Value != null ? dr.Cells[10].Value.ToString() : "";
                            wrksheet.Cells[h, 12] = "";
                            wrksheet.Cells[h, 13] = "";
                            //trường số 12
                            if (truongso1_tobia == "06" || truongso1_tobia == "07")
                                wrksheet.Cells[h, 14] = "";
                            else if (string.IsNullOrEmpty(dr.Cells[13].Value != null ? dr.Cells[13].Value.ToString() : ""))
                                wrksheet.Cells[h, 14] = "1";
                            else
                                wrksheet.Cells[h, 14] = dr.Cells[13].Value != null ? dr.Cells[13].Value.ToString() : "";

                            //trường số13
                            //if (!string.IsNullOrEmpty(dulieu_truong2_loai1))

                            wrksheet.Cells[h, 15] = dr.Cells[14].Value != null ? dr.Cells[14].Value.ToString() : "";
                            //else
                            //  wrksheet.Cells[h, 15] = "";

                            for (int i = 14; i <= 27; i++)
                            {
                                wrksheet.Cells[h, i + 2] = "";
                            }

                            wrksheet.Cells[h, 30] = dr.Cells[29].Value != null ? dr.Cells[29].Value.ToString() : "";

                            wrksheet.Cells[h, 31] = dr.Cells[30].Value != null ? dr.Cells[30].Value.ToString() : "";
                            wrksheet.Cells[h, 32] = dr.Cells[31].Value != null ? dr.Cells[31].Value.ToString() : "";

                            for (int i = 31; i <= 36; i++)
                            {
                                wrksheet.Cells[h, i + 2] = "";
                            }

                            for (int i = 37; i <= 76; i++)
                            {
                                if (i == 49 || i == 54 || i == 55 || i == 56 || i == 59 || i == 60 || i == 61 || i == 62 || i == 67 || i == 68 || i == 69 || i == 70 || i == 71 || i == 72 || i == 73 || i == 74 || i == 75 || i == 76)
                                {
                                    wrksheet.Cells[h, i + 2] = "";
                                    continue;
                                }

                                if ((dr.Cells[i + 1].Value == null ? "" : dr.Cells[i + 1].Value.ToString()) == "0")
                                    wrksheet.Cells[h, i + 2] = "";
                                else
                                    wrksheet.Cells[h, i + 2] = dr.Cells[i + 1].Value == null ? "" : dr.Cells[i + 1].Value.ToString().Replace(",", "");
                            }

                            //truong so 77
                            if (!string.IsNullOrEmpty(dr.Cells[79].Value == null ? "" : dr.Cells[79].Value.ToString()))
                                wrksheet.Cells[h, 79] = "";
                            else
                                wrksheet.Cells[h, 79] = dr.Cells[78].Value == null ? "" : dr.Cells[78].Value.ToString();

                            //truong số 78
                            wrksheet.Cells[h, 80] = dr.Cells[79].Value == null ? "" : dr.Cells[79].Value.ToString();

                            for (int i = 79; i <= 86; i++)
                            {
                                if ((dr.Cells[i + 1].Value == null ? "" : dr.Cells[i + 1].Value.ToString()) == "0")
                                {
                                    wrksheet.Cells[h, i + 2] = "";
                                }
                                else
                                {
                                    if ((dr.Cells[i + 1].Value == null ? "" : dr.Cells[i + 1].Value.ToString()).IndexOf('?') >= 0)
                                    {
                                        wrksheet.Cells[h, i + 2] = "?";
                                    }
                                    else
                                    {
                                        wrksheet.Cells[h, i + 2] = dr.Cells[i + 1].Value == null ? "" : dr.Cells[i + 1].Value.ToString();
                                    }
                                }
                            }
                            wrksheet.Cells[h, 89] = "";

                            //tuwf truowng 88
                            for (int i = 88; i <= 101; i++)
                            {
                                if (i == 92)
                                {
                                    if ((dr.Cells[i + 1].Value == null ? "" : dr.Cells[i + 1].Value.ToString()).IndexOf('?') < 0 && !string.IsNullOrEmpty(dr.Cells[i + 1].Value == null ? "" : dr.Cells[i + 1].Value.ToString()))
                                    {
                                        if (Convert.ToInt32(dr.Cells[107].Value == null ? "" : dr.Cells[107].Value.ToString()) > 260401 || Convert.ToInt32(dr.Cells[108].Value == null ? "" : dr.Cells[108].Value.ToString()) > 260401)
                                            wrksheet.Cells[h, 94] = "1";
                                        else
                                            wrksheet.Cells[h, 94] = "";

                                        continue;
                                    }
                                }
                                if (i == 100)
                                {
                                    if (!string.IsNullOrEmpty(dr.Cells[102].Value == null ? "" : dr.Cells[102].Value.ToString()))
                                        wrksheet.Cells[h, 101] = "";
                                    else
                                        wrksheet.Cells[h, 102] = dr.Cells[101].Value == null ? "" : dr.Cells[101].Value.ToString();
                                    continue;
                                }
                                wrksheet.Cells[h, i + 2] = dr.Cells[i + 1].Value == null ? "" : dr.Cells[i + 1].Value.ToString();
                            }

                            //truong 102:
                            if (!string.IsNullOrEmpty(dr.Cells[103].Value == null ? "" : dr.Cells[103].Value.ToString()))
                            {
                                if (dr.Cells[103].Value.ToString().IndexOf('?') >= 0)
                                    wrksheet.Cells[h, 104] = "?";
                                else
                                    wrksheet.Cells[h, 104] = ThemKyTubatKyPhiatruoc(dr.Cells[103].Value.ToString(), 8, "0");
                            }
                            wrksheet.Cells[h, 105] = "";//truong 103
                            wrksheet.Cells[h, 106] = dr.Cells[105].Value == null ? "" : dr.Cells[105].Value.ToString();
                            wrksheet.Cells[h, 107] = dr.Cells[106].Value == null ? "" : dr.Cells[106].Value.ToString();

                            if (!string.IsNullOrEmpty(dr.Cells[107].Value == null ? "" : dr.Cells[107].Value.ToString()))//truong so 106
                            {
                                if (dr.Cells[107].Value.ToString().IndexOf('?') >= 0)
                                    wrksheet.Cells[h, 108] = "?";
                                else
                                    wrksheet.Cells[h, 108] = ThemKyTubatKyPhiatruoc(dr.Cells[107].Value.ToString(), 8, "0");
                            }

                            if (!string.IsNullOrEmpty(dr.Cells[108].Value == null ? "" : dr.Cells[108].Value.ToString()))//truong so 107
                            {
                                if (dr.Cells[108].Value.ToString().IndexOf('?') >= 0)
                                    wrksheet.Cells[h, 109] = "?";
                                else
                                    wrksheet.Cells[h, 109] = ThemKyTubatKyPhiatruoc(dr.Cells[108].Value.ToString(), 8, "0");
                            }

                            wrksheet.Cells[h, 110] = dr.Cells[109].Value == null ? "" : dr.Cells[109].Value.ToString();
                            wrksheet.Cells[h, 111] = dr.Cells[110].Value == null ? "" : dr.Cells[110].Value.ToString();
                            wrksheet.Cells[h, 112] = (dr.Cells[111].Value == null ? "" : dr.Cells[111].Value.ToString());

                            for (int i = 126; i <= 139; i++)
                            {
                                if ((dr.Cells[i + 1].Value == null ? "" : dr.Cells[i + 1].Value.ToString()) == "0")
                                    wrksheet.Cells[h, i + 2] = "";
                                else
                                    wrksheet.Cells[h, i + 2] = dr.Cells[i + 1].Value != null ? dr.Cells[i + 1].Value.ToString().Replace(",", "") : "";
                            }

                            wrksheet.Cells[h, 160] = dr.Cells[159].Value == null ? "" : dr.Cells[159].Value.ToString();//truong so 158
                            wrksheet.Cells[h, 165] = "";
                            wrksheet.Cells[h, 166] = "";

                            string Truongso159 = dr.Cells[160].Value == null ? "" : dr.Cells[160].Value.ToString();
                            string Truongso160 = dr.Cells[161].Value == null ? "" : dr.Cells[161].Value.ToString();
                            string Truongso161 = dr.Cells[162].Value == null ? "" : dr.Cells[162].Value.ToString();
                            string Truongso162 = dr.Cells[163].Value == null ? "" : dr.Cells[163].Value.ToString();

                            //if(string.IsNullOrEmpty(Truongso161))
                            //{
                            //    Truongso161 = Truongso162;
                            //}
                            //if (string.IsNullOrEmpty(Truongso160))
                            //{
                            //    Truongso160 = Truongso161;
                            //}

                            //if (string.IsNullOrEmpty(Truongso159))
                            //{
                            //    Truongso159 = Truongso160;
                            //}

                            wrksheet.Cells[h, 161] = Truongso159.IndexOf('?') >= 0 ? "?" : Truongso159; //truongso159
                            wrksheet.Cells[h, 162] = Truongso160.IndexOf('?') >= 0 ? "?" : Truongso160; //truongso160
                            wrksheet.Cells[h, 163] = Truongso161.IndexOf('?') >= 0 ? "?" : Truongso161; //truongso161
                            wrksheet.Cells[h, 164] = Truongso162.IndexOf('?') >= 0 ? "?" : Truongso162; //truongso162

                            string Truongso165 = dr.Cells[166].Value == null ? "" : dr.Cells[166].Value.ToString();//truongso165
                            string Truongso166 = dr.Cells[167].Value == null ? "" : dr.Cells[167].Value.ToString();
                            string Truongso167 = dr.Cells[168].Value == null ? "" : dr.Cells[168].Value.ToString();
                            string Truongso168 = dr.Cells[169].Value == null ? "" : dr.Cells[169].Value.ToString();

                            //if (string.IsNullOrEmpty(Truongso167))
                            //{
                            //    Truongso167 = Truongso168;
                            //}
                            //if (string.IsNullOrEmpty(Truongso166))
                            //{
                            //    Truongso166 = Truongso167;
                            //}

                            //if (string.IsNullOrEmpty(Truongso165))
                            //{
                            //    Truongso165 = Truongso166;
                            //}

                            wrksheet.Cells[h, 165] = Truongso165.IndexOf('?') >= 0 ? "?" : Truongso165; //truongso165
                            wrksheet.Cells[h, 166] = Truongso166.IndexOf('?') >= 0 ? "?" : Truongso166; //truongso166
                            wrksheet.Cells[h, 167] = Truongso167.IndexOf('?') >= 0 ? "?" : Truongso167; //truongso167
                            wrksheet.Cells[h, 168] = Truongso168.IndexOf('?') >= 0 ? "?" : Truongso168; //truongso168
                            wrksheet.Cells[h, 217] = dr.Cells[216].Value != null ? dr.Cells[216].Value.ToString() : "";

                            break;
                    }
                    lb_SoDong_trongExcel.Text = (h - 1).ToString() + "/" + dataGridView1.Rows.Count.ToString();
                    Range rowHead = wrksheet.get_Range("A2", "HH" + h);
                    rowHead.Borders.LineStyle = Constants.xlSolid;
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

    /*

          dr.Cells[i].ToString()
            if (i == 1)
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
            //trường 001
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
            //trường 002
            else if (i == 3)
            {
                switch (loaiphieu)
                {
                    case "1":
                        wrksheet.Cells[h, i + 1] = dr.Cells[i].Value != null ? dr.Cells[i].Value.ToString() : "";

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
                        if (!string.IsNullOrEmpty(dr.Cells[i].Value == null? "" : dr.Cells[i].Value.ToString()))
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
                        wrksheet.Cells[h, i + 1] = !string.IsNullOrEmpty(dr.Cells[i].Value == null ? "" : dr.Cells[i].Value.ToString()) ? dr.Cells[i].Value?.ToString() : "";
                        break;
                }
            }
            else if (i == 6)
            {
                if (loaiphieu=="4")
                {
                    if (!string.IsNullOrEmpty(dr.Cells[i].Value == null ? "": dr.Cells[i].Value.ToString() ))
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
//catch (Exception ex)
//{
//    MessageBox.Show(ex.Message);
//    return false;
//}

     */
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

        private String ThemKyTubatKyPhiatruocNeuTrongThiDeTrong(String input, int iByte, string str)
        {
            if (string.IsNullOrEmpty(input))
                return "";
            if (input.IndexOf('?') > 0)
                return "?";

            if (input.Length >= iByte)
                return input.Substring(input.Length - iByte, iByte);

            return input.Insert(0, getcharacter(iByte - input.Length, str));
        }
    }
}