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
                int h = 2;
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    for (int i = 0; i <= 15; i++)
                    {
                        if (i == 2)
                        {
                            if (string.IsNullOrEmpty(dr.Cells[i].Value.ToString()))
                            {
                                wrksheet.Cells[h, i + 1] = "0";
                            }
                            else if (dr.Cells[i].Value.ToString() == "1")
                            {
                                wrksheet.Cells[h, i + 1] = "0";
                            }
                            else if (dr.Cells[i].Value.ToString() == "2")
                            {
                                wrksheet.Cells[h, i + 1] = "1";
                            }
                            else if (dr.Cells[i].Value.ToString() == "3")
                            {
                                wrksheet.Cells[h, i + 1] = "2";
                            }
                            else
                            {
                                wrksheet.Cells[h, i + 1] = dr.Cells[i].Value.ToString();
                            }

                        }
                        else if (i == 4)
                        {
                            if (string.IsNullOrEmpty(dr.Cells[i].Value.ToString()))
                            {
                                wrksheet.Cells[h, i + 1] = "0";
                            }
                            else
                            {
                                wrksheet.Cells[h, i + 1] = dr.Cells[i].Value.ToString();
                            }
                        }
                        else if (i == 5)
                        {
                            if (string.IsNullOrEmpty(dr.Cells[i].Value.ToString()))
                            {
                                wrksheet.Cells[h, i + 1] = "0";
                            }
                            else
                            {
                                wrksheet.Cells[h, i + 1] = dr.Cells[i].Value.ToString();
                            }
                        }
                        else if (i == 6)
                        {
                            if (string.IsNullOrEmpty(dr.Cells[i].Value.ToString()))
                            {
                                wrksheet.Cells[h, i + 1] = "0";
                            }
                            else
                            {
                                wrksheet.Cells[h, i + 1] = dr.Cells[i].Value.ToString();
                            }
                        }
                        else if (i == 7)
                        {
                            if (string.IsNullOrEmpty(dr.Cells[i].Value.ToString()))
                            {
                                wrksheet.Cells[h, i + 1] = "0";
                            }
                            else if (dr.Cells[i].Value.ToString() == "1")
                            {
                                wrksheet.Cells[h, i + 1] = "0";
                            }
                            else if (dr.Cells[i].Value.ToString() == "2")
                            {
                                wrksheet.Cells[h, i + 1] = "1";
                            }
                            else
                            {
                                wrksheet.Cells[h, i + 1] = dr.Cells[i].Value.ToString();
                            }
                        }
                        else if (i == 14 || i == 15)
                        {
                            if (dr.Cells[i].Value.ToString() == "1")
                            {
                                wrksheet.Cells[h, 15] = "X";
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            wrksheet.Cells[h, i + 1] = dr.Cells[i].Value.ToString();
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
    }
}