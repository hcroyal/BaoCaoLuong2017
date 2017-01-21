using BaoCaoLuong2017.Properties;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
namespace BaoCaoLuong2017.MyForm
{
    public partial class frm_Check : XtraForm
    {
        public frm_Check()
        {
            InitializeComponent();
        }

        private void ResetData()
        {
            if (Global.StrCheck == "CHECKDESO")
            {
                uc_Loai_11.ResetData();
                uc_Loai_12.ResetData();

                uc_Loai_21.ResetData();
                uc_Loai_22.ResetData();

                uc_Loai_31.ResetData();
                uc_Loai_32.ResetData();

                uc_Loai_41.ResetData();
                uc_Loai_42.ResetData();
                
            }
            else if(Global.StrCheck == "CHECKDEJP")
            {
                uc_DEJP1.ResetData();
                uc_DEJP2.ResetData();
            }
            uc_PictureBox1.imageBox1.Image = null;

        }

        private void Compare_TextBox(TextEdit t1, TextEdit t2)
        {
            if (!string.IsNullOrEmpty(t1.Text) || !string.IsNullOrEmpty(t2.Text))
            {
                if (t1.Text != t2.Text)
                {
                    t1.BackColor = Color.PaleVioletRed;
                    t2.BackColor = Color.PaleVioletRed;
                }
            }
            else
            {
                t1.BackColor = Color.White;
                t2.BackColor = Color.White;
            }
        }

        private void Compare_LookUpEdit(LookUpEdit t1, LookUpEdit t2)
        {
            if (t1.ItemIndex != t2.ItemIndex)
            {
                t1.BackColor = Color.PaleVioletRed;
                t2.BackColor = Color.PaleVioletRed;
            }
            else
            {
                t1.BackColor = Color.White;
                t2.BackColor = Color.White;
            }
        }
        private void frm_Check_Load(object sender, EventArgs e)
        {
            try
            {
                lb_fBatchName.Text = Global.StrBatch;
                tp_Loai_1_DeSo1.PageVisible=false;
                tp_Loai_2_DeSo1.PageVisible=false;
                tp_Loai_3_DeSo1.PageVisible=false;
                tp_Loai_4_DeSo1.PageVisible=false;
                tp_Loai_4_1_DeSo1.PageVisible=false;
                tp_DEJP1.PageVisible=false;;

                tp_Loai_1_DeSo2.PageVisible=false;
                tp_Loai_2_DeSo2.PageVisible=false;
                tp_Loai_3_DeSo2.PageVisible=false;
                tp_Loai_4_DeSo2.PageVisible=false;
                tp_Loai_4_1_DeSo2.PageVisible=false;
                tp_DEJP2.PageVisible=false;


                if (Global.StrCheck == "CHECKDESO")
                {
                    var soloi =((from w in Global.db_BCL.tbl_DESOs where w.fBatchName == Global.StrBatch && w.Dem == 1 select w.IdImage).Count() / 2).ToString();
                    lb_Loi.Text = soloi + " Lỗi";

                    tp_Loai_1_DeSo1.PageVisible = true;
                    tp_Loai_2_DeSo1.PageVisible = true;
                    tp_Loai_3_DeSo1.PageVisible = true;
                    tp_Loai_4_DeSo1.PageVisible = true;
                    tp_Loai_4_1_DeSo1.PageVisible = true;

                    tp_Loai_1_DeSo2.PageVisible = true;
                    tp_Loai_2_DeSo2.PageVisible = true;
                    tp_Loai_3_DeSo2.PageVisible = true;
                    tp_Loai_4_DeSo2.PageVisible = true;
                    tp_Loai_4_1_DeSo2.PageVisible = true;

                    btn_Luu_DeSo1.Visible = false;
                    btn_Luu_DeSo2.Visible = false;

                    uc_Loai_11.Changed += Uc_Loai_11_Changed;
                    uc_Loai_21.Changed += Uc_Loai_21_Changed;
                    uc_Loai_31.Changed += Uc_Loai_31_Changed;
                    uc_Loai_41.Changed += Uc_Loai_41_Changed;

                    uc_Loai_12.Changed += Uc_Loai_12_Changed;
                    uc_Loai_22.Changed += Uc_Loai_22_Changed;
                    uc_Loai_32.Changed += Uc_Loai_32_Changed;
                    uc_Loai_42.Changed += Uc_Loai_42_Changed;

                }
                else if (Global.StrCheck == "CHECKDEJP")
                {
                    tp_DEJP1.PageVisible = true;
                    
                    tp_DEJP2.PageVisible = true;

                    btn_Luu_DeSo1.Visible = false;
                    btn_Luu_DeSo2.Visible = false;
                    var soloi =((from w in Global.db_BCL.tbl_DEJPs where w.fBatchName == Global.StrBatch && w.Dem == 1 select w.IdImage).Count() / 2).ToString();
                    lb_Loi.Text = soloi + " Lỗi";
                    uc_DEJP1.Changed += Uc_DEJP1_Changed;
                    uc_DEJP2.Changed += Uc_DEJP2_Changed;
                }
            }
            catch( Exception i)
            {
                MessageBox.Show("Lỗi" + i);
            }
        }

        private void Uc_DEJP2_Changed(object sender, EventArgs e)
        {
            btn_Luu_DeSo2.Visible = false;
            btn_SuaVaLuu_User2.Visible = true;
        }

        private void Uc_DEJP1_Changed(object sender, EventArgs e)
        {
            btn_Luu_DeSo1.Visible = false;
            btn_SuaVaLuu_User1.Visible = true;
        }

        private void Uc_Loai_42_Changed(object sender, EventArgs e)
        {
            btn_Luu_DeSo2.Visible = false;
            btn_SuaVaLuu_User2.Visible = true;
        }

        private void Uc_Loai_41_Changed(object sender, EventArgs e)
        {
            btn_Luu_DeSo1.Visible = false;
            btn_SuaVaLuu_User1.Visible = true;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (Global.StrCheck == "CHECKDESO")
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
                    var listUser = (from w in Global.db_BCL.tbl_MissImage_DESOs
                                     where w.fBatchName == Global.StrBatch && w.Submit == 0
                                     select w.UserName).ToList();
                    string sss = "";
                    foreach (var item in listUser)
                    {
                        sss += item + "\r\n";
                    }

                    if (listUser.Count > 0)
                    {
                        MessageBox.Show("Những user lấy hình về nhưng không nhập: \r\n" + sss);
                        return;
                    }
                }
                string temp = GetImage_DeSo();
                if (temp == "NULL")
                {
                    uc_PictureBox1.imageBox1.Dispose();
                    MessageBox.Show("Hết Hình!");
                    return;
                }
                if (temp == "Error")
                {
                    MessageBox.Show("Lỗi load hình");
                    return;
                }
                Load_DeSo(Global.StrBatch, lb_Image.Text);
                btn_Luu_DeSo1.Visible = true;
                btn_Luu_DeSo2.Visible = true;
                btn_SuaVaLuu_User1.Visible = true;
                btn_SuaVaLuu_User2.Visible = true;
            }
            else if(Global.StrCheck == "CHECKDEJP")
            {
                var nhap = (from w in Global.db_BCL.tbl_Images
                            where w.fbatchname == Global.StrBatch && w.ReadImageDEJP == 2
                            select w.idimage).Count();
                var sohinh = (from w in Global.db_BCL.tbl_Images
                              where w.fbatchname == Global.StrBatch
                              select w.idimage).Count();
                var check = (from w in Global.db_BCL.tbl_MissImage_DEJPs
                             where w.fBatchName == Global.StrBatch && w.Submit == 0
                             select w.IdImage).Count();
                if (sohinh > nhap)
                {
                    MessageBox.Show("Chưa nhập xong DeJP!");
                    return;
                }
                if (check > 0)
                {
                    var listUser = (from w in Global.db_BCL.tbl_MissImage_DEJPs
                                    where w.fBatchName == Global.StrBatch && w.Submit == 0
                                    select w.UserName).ToList();
                    string sss = "";
                    foreach (var item in listUser)
                    {
                        sss += item + "\r\n";
                    }

                    if (listUser.Count > 0)
                    {
                        MessageBox.Show("Những user lấy hình về nhưng không nhập: \r\n" + sss);
                        return;
                    }
                }
                string temp = GetImage_DeJP();
                if (temp == "NULL")
                {
                    uc_PictureBox1.imageBox1.Dispose();
                    MessageBox.Show("Hết Hình!");
                    return;
                }
                if (temp == "Error")
                {
                    MessageBox.Show("Lỗi load hình");
                    return;
                }
                Load_DeJP(Global.StrBatch, lb_Image.Text);
                btn_Luu_DeSo1.Visible = true;
                btn_Luu_DeSo2.Visible = true;
                btn_SuaVaLuu_User1.Visible = true;
                btn_SuaVaLuu_User2.Visible = true;
            }
            btn_Start.Visible = false;
        }

        private void Load_DeJP(string strBatch, string idimage)
        {
           
            var deso = (from w in Global.db_BCL.tbl_DEJPs
                        where w.fBatchName == strBatch && w.IdImage == idimage
                        select new
                        {
                            w.UserName,
                            w.LoaiPhieu,
                            w.Truong_002
                        }).ToList();
            lb_username1.Text = deso[0].UserName;
            lb_username2.Text = deso[1].UserName;
            
                
            uc_DEJP1.txt_Truong_002.Text = deso[0].Truong_002;
            uc_DEJP2.txt_Truong_002.Text = deso[1].Truong_002;
           
           
            Compare_TextBox(uc_DEJP1.txt_Truong_002, uc_DEJP2.txt_Truong_002);
        
            var soloi = ((from w in Global.db_BCL.tbl_DEJPs where w.fBatchName == Global.StrBatch && w.Dem == 1 select w.IdImage).Count() / 2).ToString();
            lb_Loi.Text = soloi + " Lỗi";
        
    }

        private string GetImage_DeJP()
        {
            var temp = (from w in Global.db_BCL.tbl_MissCheck_DEJPs
                        where w.fBatchName == Global.StrBatch && w.UserName == Global.StrUsername && w.Submit == 0
                        select w.IdImage).FirstOrDefault();
            if (string.IsNullOrEmpty(temp))
            {
                var getFilename =
                    (from w in Global.db_BCL.ImageCheck_DeJP(Global.StrBatch, Global.StrUsername)
                     select w.Column1).FirstOrDefault();
                if (string.IsNullOrEmpty(getFilename))
                {
                    return "NULL";
                }
                lb_Image.Text = getFilename;
                uc_PictureBox1.imageBox1.Image = null;
                if (uc_PictureBox1.LoadImage(Global.Webservice + Global.StrBatch + "/" + getFilename, getFilename,
                            Properties.Settings.Default.ZoomImage) == "Error")
                {
                    uc_PictureBox1.imageBox1.Image = Resources.svn_deleted;
                    return "Error";
                }
            }
            else
            {
                lb_Image.Text = temp;
                uc_PictureBox1.imageBox1.Image = null;
                if (uc_PictureBox1.LoadImage(Global.Webservice + Global.StrBatch + "/" + temp, temp,
                            Properties.Settings.Default.ZoomImage) == "Error")
                {
                    uc_PictureBox1.imageBox1.Image = Resources.svn_deleted;
                    return "Error";
                }
            }
            return "ok";
        }

        private void Load_DeSo(string strBatch, string idimage)
        {
            var deso = (from w in Global.db_BCL.tbl_DESOs
                        where w.fBatchName == strBatch && w.IdImage == idimage
                        select new
                        {
                            w.UserName,
                            w.LoaiPhieu,
                            w.Truong_001,
                            w.Truong_002,
                            w.Truong_003,
                            w.Truong_004,
                            w.Truong_005,
                            w.Truong_006,
                            w.Truong_008,
                            w.Truong_009,
                            w.Truong_012,
                            w.Truong_013,
                            w.Truong_028,
                            w.Truong_029,
                            w.Truong_030,
                            w.Truong_037,
                            w.Truong_038,
                            w.Truong_039,
                            w.Truong_040,
                            w.Truong_041,
                            w.Truong_042,
                            w.Truong_043,
                            w.Truong_044,
                            w.Truong_045,
                            w.Truong_046,
                            w.Truong_047,
                            w.Truong_048,
                            w.Truong_049,
                            w.Truong_050,
                            w.Truong_051,
                            w.Truong_052,
                            w.Truong_053,
                            w.Truong_057,
                            w.Truong_058,
                            w.Truong_063,
                            w.Truong_064,
                            w.Truong_065,
                            w.Truong_066,
                            w.Truong_077,
                            w.Truong_078,
                            w.Truong_079,
                            w.Truong_080,
                            w.Truong_081,
                            w.Truong_082,
                            w.Truong_083,
                            w.Truong_084,
                            w.Truong_085,
                            w.Truong_086,
                            w.Truong_088,
                            w.Truong_089,
                            w.Truong_090,
                            w.Truong_091,
                            w.Truong_092,
                            w.Truong_093,
                            w.Truong_094,
                            w.Truong_095,
                            w.Truong_096,
                            w.Truong_097,
                            w.Truong_098,
                            w.Truong_099,
                            w.Truong_100,
                            w.Truong_101,
                            w.Truong_102,
                            w.Truong_103,
                            w.Truong_104,
                            w.Truong_105,
                            w.Truong_106,
                            w.Truong_107,
                            w.Truong_108,
                            w.Truong_109,
                            w.Truong_110,
                            w.Truong_112,
                            w.Truong_158,
                            w.Truong_159,
                            w.Truong_160,
                            w.Truong_161,
                            w.Truong_162,
                            w.Truong_165,
                            w.Truong_166,
                            w.Truong_167,
                            w.Truong_168,
                        }).ToList();
            lb_username1.Text = deso[0].UserName;
            lb_username2.Text = deso[1].UserName;
           
            if(deso[0].LoaiPhieu == "Loai1")
            {
                tabcontrol_DeSo1.SelectedTabPage = tp_Loai_1_DeSo1;

                uc_Loai_11.txt_Truong_001.Text = deso[0].Truong_001;
                uc_Loai_11.txt_Truong_002.Text = deso[0].Truong_002;
            }
            else if (deso[0].LoaiPhieu == "Loai2")
            {
                tabcontrol_DeSo1.SelectedTabPage = tp_Loai_2_DeSo1;

                uc_Loai_21.txt_Truong_002.Text = deso[0].Truong_002;
                uc_Loai_21.txt_Truong_003.Text = deso[0].Truong_003;
                uc_Loai_21.txt_Truong_004.Text = deso[0].Truong_004;
            }
            else if (deso[0].LoaiPhieu == "Loai3")
            {
                tabcontrol_DeSo1.SelectedTabPage = tp_Loai_3_DeSo1;

                tp_DEJP1.PageVisible = false;

                uc_Loai_31.txt_Truong_002.Text = deso[0].Truong_002;
                uc_Loai_31.txt_Truong_003.Text = deso[0].Truong_003;
            }
            else if (deso[0].LoaiPhieu == "Loai4")
            {
                tabcontrol_DeSo1.SelectedTabPage = tp_Loai_4_DeSo1;

                tp_DEJP1.PageVisible = false;

                uc_Loai_41.txt_Truong_001_1.Text = deso[0].Truong_001?.Substring(0,1);
                uc_Loai_41.txt_Truong_001_2.Text = deso[0].Truong_001?.Substring(1,6);
                uc_Loai_41.txt_Truong_003.Text = deso[0].Truong_003;
                uc_Loai_41.txt_Truong_004.Text = deso[0].Truong_004;
                uc_Loai_41.txt_Truong_005.Text = deso[0].Truong_005;
                uc_Loai_41.txt_Truong_006.Text = deso[0].Truong_006;
                uc_Loai_41.txt_Truong_008.Text = deso[0].Truong_008;
                uc_Loai_41.txt_Truong_009.Text = deso[0].Truong_009;
                uc_Loai_41.txt_Truong_012.Text = deso[0].Truong_012;
                uc_Loai_41.txt_Truong_013.Text = deso[0].Truong_013;
                uc_Loai_41.txt_Truong_028.Text = deso[0].Truong_028;
                uc_Loai_41.txt_Truong_029.Text = deso[0].Truong_029;
                uc_Loai_41.txt_Truong_030.Text = deso[0].Truong_030;
                uc_Loai_41.txt_Truong_037.Text = deso[0].Truong_037;
                uc_Loai_41.txt_Truong_038.Text = deso[0].Truong_038;
                uc_Loai_41.txt_Truong_039.Text = deso[0].Truong_039;
                uc_Loai_41.txt_Truong_040.Text = deso[0].Truong_040;
                uc_Loai_41.txt_Truong_041.Text = deso[0].Truong_041;
                uc_Loai_41.txt_Truong_042.Text = deso[0].Truong_042;
                uc_Loai_41.txt_Truong_043.Text = deso[0].Truong_043;
                uc_Loai_41.txt_Truong_044.Text = deso[0].Truong_044;
                uc_Loai_41.txt_Truong_045.Text = deso[0].Truong_045;
                uc_Loai_41.txt_Truong_046.Text = deso[0].Truong_046;
                uc_Loai_41.txt_Truong_047.Text = deso[0].Truong_047;
                uc_Loai_41.txt_Truong_048.Text = deso[0].Truong_048;
                uc_Loai_41.txt_Truong_050.Text = deso[0].Truong_050;
                uc_Loai_41.txt_Truong_051.Text = deso[0].Truong_051;
                uc_Loai_41.txt_Truong_052.Text = deso[0].Truong_052;
                uc_Loai_41.txt_Truong_053.Text = deso[0].Truong_053;
                uc_Loai_41.txt_Truong_057.Text = deso[0].Truong_057;
                uc_Loai_41.txt_Truong_058.Text = deso[0].Truong_058;
                uc_Loai_41.txt_Truong_063.Text = deso[0].Truong_063;
                uc_Loai_41.txt_Truong_064.Text = deso[0].Truong_064;
                uc_Loai_41.txt_Truong_065.Text = deso[0].Truong_065;
                uc_Loai_41.txt_Truong_066.Text = deso[0].Truong_066;
                uc_Loai_41.txt_Truong_077.Text = deso[0].Truong_077;
                uc_Loai_41.txt_Truong_078.Text = deso[0].Truong_078;
                uc_Loai_41.txt_Truong_079.Text = deso[0].Truong_079;
                uc_Loai_41.txt_Truong_080.Text = deso[0].Truong_080;
                uc_Loai_41.txt_Truong_081.Text = deso[0].Truong_081;
                uc_Loai_41.txt_Truong_082.Text = deso[0].Truong_082;
                uc_Loai_41.txt_Truong_083.Text = deso[0].Truong_083;
                uc_Loai_41.txt_Truong_084.Text = deso[0].Truong_084;
                uc_Loai_41.txt_Truong_085.Text = deso[0].Truong_085;
                uc_Loai_41.txt_Truong_086.Text = deso[0].Truong_086;
                uc_Loai_41.txt_Truong_088.Text = deso[0].Truong_088;
                uc_Loai_41.txt_Truong_089.Text = deso[0].Truong_089;
                uc_Loai_41.txt_Truong_090.Text = deso[0].Truong_090;
                uc_Loai_41.txt_Truong_091.Text = deso[0].Truong_091;
                uc_Loai_41.txt_Truong_093.Text = deso[0].Truong_093;
                uc_Loai_41.txt_Truong_094.Text = deso[0].Truong_094;
                uc_Loai_41.txt_Truong_095.Text = deso[0].Truong_095;
                uc_Loai_41.txt_Truong_096.Text = deso[0].Truong_096;
                uc_Loai_41.txt_Truong_097.Text = deso[0].Truong_097;
                uc_Loai_41.txt_Truong_098.Text = deso[0].Truong_098;
                uc_Loai_41.txt_Truong_099.Text = deso[0].Truong_099;
                uc_Loai_41.txt_Truong_100.Text = deso[0].Truong_100;
                uc_Loai_41.txt_Truong_101.Text = deso[0].Truong_101;
                uc_Loai_41.txt_Truong_102_1.Text = deso[0].Truong_102?.Substring(0, 1);
                uc_Loai_41.txt_Truong_102_2.Text = deso[0].Truong_102?.Substring(1, 6);
                uc_Loai_41.txt_Truong_103.Text = deso[0].Truong_103;
                uc_Loai_41.txt_Truong_104.Text = deso[0].Truong_104;
                uc_Loai_41.txt_Truong_105.Text = deso[0].Truong_105;
                uc_Loai_41.txt_Truong_106.Text = deso[0].Truong_106;
                uc_Loai_41.txt_Truong_107.Text = deso[0].Truong_107;
                uc_Loai_41.txt_Truong_108.EditValue = deso[0].Truong_108;
                uc_Loai_41.txt_Truong_109.EditValue = deso[0].Truong_109;
                uc_Loai_41.txt_Truong_110.Text = deso[0].Truong_110;
                uc_Loai_41.txt_Truong_112.Text = deso[0].Truong_112;
                uc_Loai_41.txt_Truong_158.Text = deso[0].Truong_158;
                uc_Loai_41.txt_Truong_159.Text = deso[0].Truong_159;
                uc_Loai_41.txt_Truong_160.Text = deso[0].Truong_160;
                uc_Loai_41.txt_Truong_161.Text = deso[0].Truong_161;
                uc_Loai_41.txt_Truong_162.Text = deso[0].Truong_162;
                uc_Loai_41.txt_Truong_165.Text = deso[0].Truong_165;
                uc_Loai_41.txt_Truong_166.Text = deso[0].Truong_166;
                uc_Loai_41.txt_Truong_167.Text = deso[0].Truong_167;
                uc_Loai_41.txt_Truong_168.Text = deso[0].Truong_168;
                
            }


            if (deso[1].LoaiPhieu == "Loai1")
            {
                tabcontrol_DeSo2.SelectedTabPage = tp_Loai_1_DeSo2;

                uc_Loai_12.txt_Truong_001.Text = deso[1].Truong_001;
                uc_Loai_12.txt_Truong_002.Text = deso[1].Truong_002;
            }
            else if (deso[1].LoaiPhieu == "Loai2")
            {
                tabcontrol_DeSo2.SelectedTabPage = tp_Loai_2_DeSo2;

                uc_Loai_22.txt_Truong_002.Text = deso[1].Truong_002;
                uc_Loai_22.txt_Truong_003.Text = deso[1].Truong_003;
                uc_Loai_22.txt_Truong_004.Text = deso[1].Truong_004;
            }
            else if (deso[1].LoaiPhieu == "Loai3")
            {
                tabcontrol_DeSo2.SelectedTabPage = tp_Loai_3_DeSo2;
                
                uc_Loai_32.txt_Truong_002.Text = deso[1].Truong_002;
                uc_Loai_32.txt_Truong_003.Text = deso[1].Truong_003;

            }
            else if (deso[1].LoaiPhieu == "Loai4")
            {
                tabcontrol_DeSo2.SelectedTabPage = tp_Loai_4_DeSo2;

                uc_Loai_42.txt_Truong_001_1.Text = deso[1].Truong_001?.Substring(0, 1);
                uc_Loai_42.txt_Truong_001_2.Text = deso[1].Truong_001?.Substring(1, 6);
                uc_Loai_42.txt_Truong_003.Text = deso[1].Truong_003;
                uc_Loai_42.txt_Truong_004.Text = deso[1].Truong_004;
                uc_Loai_42.txt_Truong_005.Text = deso[1].Truong_005;
                uc_Loai_42.txt_Truong_006.Text = deso[1].Truong_006;
                uc_Loai_42.txt_Truong_008.Text = deso[1].Truong_008;
                uc_Loai_42.txt_Truong_009.Text = deso[1].Truong_009;
                uc_Loai_42.txt_Truong_012.Text = deso[1].Truong_012;
                uc_Loai_42.txt_Truong_013.Text = deso[1].Truong_013;
                uc_Loai_42.txt_Truong_028.Text = deso[1].Truong_028;
                uc_Loai_42.txt_Truong_029.Text = deso[1].Truong_029;
                uc_Loai_42.txt_Truong_030.Text = deso[1].Truong_030;
                uc_Loai_42.txt_Truong_037.Text = deso[1].Truong_037;
                uc_Loai_42.txt_Truong_038.Text = deso[1].Truong_038;
                uc_Loai_42.txt_Truong_039.Text = deso[1].Truong_039;
                uc_Loai_42.txt_Truong_040.Text = deso[1].Truong_040;
                uc_Loai_42.txt_Truong_041.Text = deso[1].Truong_041;
                uc_Loai_42.txt_Truong_042.Text = deso[1].Truong_042;
                uc_Loai_42.txt_Truong_043.Text = deso[1].Truong_043;
                uc_Loai_42.txt_Truong_044.Text = deso[1].Truong_044;
                uc_Loai_42.txt_Truong_045.Text = deso[1].Truong_045;
                uc_Loai_42.txt_Truong_046.Text = deso[1].Truong_046;
                uc_Loai_42.txt_Truong_047.Text = deso[1].Truong_047;
                uc_Loai_42.txt_Truong_048.Text = deso[1].Truong_048;
                uc_Loai_42.txt_Truong_050.Text = deso[1].Truong_050;
                uc_Loai_42.txt_Truong_051.Text = deso[1].Truong_051;
                uc_Loai_42.txt_Truong_052.Text = deso[1].Truong_052;
                uc_Loai_42.txt_Truong_053.Text = deso[1].Truong_053;
                uc_Loai_42.txt_Truong_057.Text = deso[1].Truong_057;
                uc_Loai_42.txt_Truong_058.Text = deso[1].Truong_058;
                uc_Loai_42.txt_Truong_063.Text = deso[1].Truong_063;
                uc_Loai_42.txt_Truong_064.Text = deso[1].Truong_064;
                uc_Loai_42.txt_Truong_065.Text = deso[1].Truong_065;
                uc_Loai_42.txt_Truong_066.Text = deso[1].Truong_066;
                uc_Loai_42.txt_Truong_077.Text = deso[1].Truong_077;
                uc_Loai_42.txt_Truong_078.Text = deso[1].Truong_078;
                uc_Loai_42.txt_Truong_079.Text = deso[1].Truong_079;
                uc_Loai_42.txt_Truong_080.Text = deso[1].Truong_080;
                uc_Loai_42.txt_Truong_081.Text = deso[1].Truong_081;
                uc_Loai_42.txt_Truong_082.Text = deso[1].Truong_082;
                uc_Loai_42.txt_Truong_083.Text = deso[1].Truong_083;
                uc_Loai_42.txt_Truong_084.Text = deso[1].Truong_084;
                uc_Loai_42.txt_Truong_085.Text = deso[1].Truong_085;
                uc_Loai_42.txt_Truong_086.Text = deso[1].Truong_086;
                uc_Loai_42.txt_Truong_088.Text = deso[1].Truong_088;
                uc_Loai_42.txt_Truong_089.Text = deso[1].Truong_089;
                uc_Loai_42.txt_Truong_090.Text = deso[1].Truong_090;
                uc_Loai_42.txt_Truong_091.Text = deso[1].Truong_091;
                uc_Loai_42.txt_Truong_093.Text = deso[1].Truong_093;
                uc_Loai_42.txt_Truong_094.Text = deso[1].Truong_094;
                uc_Loai_42.txt_Truong_095.Text = deso[1].Truong_095;
                uc_Loai_42.txt_Truong_096.Text = deso[1].Truong_096;
                uc_Loai_42.txt_Truong_097.Text = deso[1].Truong_097;
                uc_Loai_42.txt_Truong_098.Text = deso[1].Truong_098;
                uc_Loai_42.txt_Truong_099.Text = deso[1].Truong_099;
                uc_Loai_42.txt_Truong_100.Text = deso[1].Truong_100;
                uc_Loai_42.txt_Truong_101.Text = deso[1].Truong_101;
                uc_Loai_42.txt_Truong_102_1.Text = deso[1].Truong_102?.Substring(0, 1);
                uc_Loai_42.txt_Truong_102_2.Text = deso[1].Truong_102?.Substring(1, 6);
                uc_Loai_42.txt_Truong_103.Text = deso[1].Truong_103;
                uc_Loai_42.txt_Truong_104.Text = deso[1].Truong_104;
                uc_Loai_42.txt_Truong_105.Text = deso[1].Truong_105;
                uc_Loai_42.txt_Truong_106.Text = deso[1].Truong_106;
                uc_Loai_42.txt_Truong_107.Text = deso[1].Truong_107;
                uc_Loai_42.txt_Truong_108.EditValue = deso[1].Truong_108;
                uc_Loai_42.txt_Truong_109.EditValue = deso[1].Truong_109;
                uc_Loai_42.txt_Truong_110.Text = deso[1].Truong_110;
                uc_Loai_42.txt_Truong_112.Text = deso[1].Truong_112;
                uc_Loai_42.txt_Truong_158.Text = deso[1].Truong_158;
                uc_Loai_42.txt_Truong_159.Text = deso[1].Truong_159;
                uc_Loai_42.txt_Truong_160.Text = deso[1].Truong_160;
                uc_Loai_42.txt_Truong_161.Text = deso[1].Truong_161;
                uc_Loai_42.txt_Truong_162.Text = deso[1].Truong_162;
                uc_Loai_42.txt_Truong_165.Text = deso[1].Truong_165;
                uc_Loai_42.txt_Truong_166.Text = deso[1].Truong_166;
                uc_Loai_42.txt_Truong_167.Text = deso[1].Truong_167;
                uc_Loai_42.txt_Truong_168.Text = deso[1].Truong_168;

            }

            Compare_TextBox(uc_Loai_11.txt_Truong_001, uc_Loai_12.txt_Truong_001);
            Compare_TextBox(uc_Loai_11.txt_Truong_002, uc_Loai_12.txt_Truong_002);

            Compare_TextBox(uc_Loai_21.txt_Truong_002, uc_Loai_22.txt_Truong_002);
            Compare_TextBox(uc_Loai_21.txt_Truong_002, uc_Loai_22.txt_Truong_002);
            Compare_TextBox(uc_Loai_21.txt_Truong_002, uc_Loai_22.txt_Truong_002);

            Compare_TextBox(uc_Loai_31.txt_Truong_002, uc_Loai_32.txt_Truong_002);
            Compare_TextBox(uc_Loai_31.txt_Truong_002, uc_Loai_32.txt_Truong_002);

            Compare_TextBox(uc_Loai_41.txt_Truong_001_1, uc_Loai_42.txt_Truong_001_1);
            Compare_TextBox(uc_Loai_41.txt_Truong_001_2, uc_Loai_42.txt_Truong_001_2);
            Compare_TextBox(uc_Loai_41.txt_Truong_003, uc_Loai_42.txt_Truong_003);
            Compare_TextBox(uc_Loai_41.txt_Truong_004, uc_Loai_42.txt_Truong_004);
            Compare_TextBox(uc_Loai_41.txt_Truong_005, uc_Loai_42.txt_Truong_005);
            Compare_TextBox(uc_Loai_41.txt_Truong_006, uc_Loai_42.txt_Truong_006);
            Compare_TextBox(uc_Loai_41.txt_Truong_008, uc_Loai_42.txt_Truong_008);
            Compare_TextBox(uc_Loai_41.txt_Truong_009, uc_Loai_42.txt_Truong_009);
            Compare_TextBox(uc_Loai_41.txt_Truong_012, uc_Loai_42.txt_Truong_012);
            Compare_TextBox(uc_Loai_41.txt_Truong_013, uc_Loai_42.txt_Truong_013);
            Compare_TextBox(uc_Loai_41.txt_Truong_028, uc_Loai_42.txt_Truong_028);
            Compare_TextBox(uc_Loai_41.txt_Truong_029, uc_Loai_42.txt_Truong_029);
            Compare_TextBox(uc_Loai_41.txt_Truong_030, uc_Loai_42.txt_Truong_030);
            Compare_TextBox(uc_Loai_41.txt_Truong_037, uc_Loai_42.txt_Truong_037);
            Compare_TextBox(uc_Loai_41.txt_Truong_038, uc_Loai_42.txt_Truong_038);
            Compare_TextBox(uc_Loai_41.txt_Truong_039, uc_Loai_42.txt_Truong_039);
            Compare_TextBox(uc_Loai_41.txt_Truong_040, uc_Loai_42.txt_Truong_040);
            Compare_TextBox(uc_Loai_41.txt_Truong_041, uc_Loai_42.txt_Truong_041);
            Compare_TextBox(uc_Loai_41.txt_Truong_042, uc_Loai_42.txt_Truong_042);
            Compare_TextBox(uc_Loai_41.txt_Truong_043, uc_Loai_42.txt_Truong_043);
            Compare_TextBox(uc_Loai_41.txt_Truong_044, uc_Loai_42.txt_Truong_044);
            Compare_TextBox(uc_Loai_41.txt_Truong_045, uc_Loai_42.txt_Truong_045);
            Compare_TextBox(uc_Loai_41.txt_Truong_046, uc_Loai_42.txt_Truong_046);
            Compare_TextBox(uc_Loai_41.txt_Truong_047, uc_Loai_42.txt_Truong_047);
            Compare_TextBox(uc_Loai_41.txt_Truong_048, uc_Loai_42.txt_Truong_048);
            Compare_TextBox(uc_Loai_41.txt_Truong_050, uc_Loai_42.txt_Truong_050);
            Compare_TextBox(uc_Loai_41.txt_Truong_051, uc_Loai_42.txt_Truong_051);
            Compare_TextBox(uc_Loai_41.txt_Truong_052, uc_Loai_42.txt_Truong_052);
            Compare_TextBox(uc_Loai_41.txt_Truong_053, uc_Loai_42.txt_Truong_053);
            Compare_TextBox(uc_Loai_41.txt_Truong_057, uc_Loai_42.txt_Truong_057);
            Compare_TextBox(uc_Loai_41.txt_Truong_058, uc_Loai_42.txt_Truong_058);
            Compare_TextBox(uc_Loai_41.txt_Truong_063, uc_Loai_42.txt_Truong_063);
            Compare_TextBox(uc_Loai_41.txt_Truong_064, uc_Loai_42.txt_Truong_064);
            Compare_TextBox(uc_Loai_41.txt_Truong_065, uc_Loai_42.txt_Truong_065);
            Compare_TextBox(uc_Loai_41.txt_Truong_066, uc_Loai_42.txt_Truong_066);
            Compare_TextBox(uc_Loai_41.txt_Truong_077, uc_Loai_42.txt_Truong_077);
            Compare_TextBox(uc_Loai_41.txt_Truong_078, uc_Loai_42.txt_Truong_078);
            Compare_TextBox(uc_Loai_41.txt_Truong_079, uc_Loai_42.txt_Truong_079);
            Compare_TextBox(uc_Loai_41.txt_Truong_080, uc_Loai_42.txt_Truong_080);
            Compare_TextBox(uc_Loai_41.txt_Truong_081, uc_Loai_42.txt_Truong_081);
            Compare_TextBox(uc_Loai_41.txt_Truong_082, uc_Loai_42.txt_Truong_082);
            Compare_TextBox(uc_Loai_41.txt_Truong_083, uc_Loai_42.txt_Truong_083);
            Compare_TextBox(uc_Loai_41.txt_Truong_084, uc_Loai_42.txt_Truong_084);
            Compare_TextBox(uc_Loai_41.txt_Truong_085, uc_Loai_42.txt_Truong_085);
            Compare_TextBox(uc_Loai_41.txt_Truong_086, uc_Loai_42.txt_Truong_086);
            Compare_TextBox(uc_Loai_41.txt_Truong_088, uc_Loai_42.txt_Truong_088);
            Compare_TextBox(uc_Loai_41.txt_Truong_089, uc_Loai_42.txt_Truong_089);
            Compare_TextBox(uc_Loai_41.txt_Truong_090, uc_Loai_42.txt_Truong_090);
            Compare_TextBox(uc_Loai_41.txt_Truong_091, uc_Loai_42.txt_Truong_091);
            Compare_TextBox(uc_Loai_41.txt_Truong_093, uc_Loai_42.txt_Truong_093);
            Compare_TextBox(uc_Loai_41.txt_Truong_094, uc_Loai_42.txt_Truong_094);
            Compare_TextBox(uc_Loai_41.txt_Truong_095, uc_Loai_42.txt_Truong_095);
            Compare_TextBox(uc_Loai_41.txt_Truong_096, uc_Loai_42.txt_Truong_096);
            Compare_TextBox(uc_Loai_41.txt_Truong_097, uc_Loai_42.txt_Truong_097);
            Compare_TextBox(uc_Loai_41.txt_Truong_098, uc_Loai_42.txt_Truong_098);
            Compare_TextBox(uc_Loai_41.txt_Truong_099, uc_Loai_42.txt_Truong_099);
            Compare_TextBox(uc_Loai_41.txt_Truong_100, uc_Loai_42.txt_Truong_100);
            Compare_TextBox(uc_Loai_41.txt_Truong_101, uc_Loai_42.txt_Truong_101);
            Compare_TextBox(uc_Loai_41.txt_Truong_102_1, uc_Loai_42.txt_Truong_102_1);
            Compare_TextBox(uc_Loai_41.txt_Truong_102_2, uc_Loai_42.txt_Truong_102_2);
            Compare_TextBox(uc_Loai_41.txt_Truong_103, uc_Loai_42.txt_Truong_103);
            Compare_TextBox(uc_Loai_41.txt_Truong_104, uc_Loai_42.txt_Truong_104);
            Compare_TextBox(uc_Loai_41.txt_Truong_105, uc_Loai_42.txt_Truong_105);
            Compare_TextBox(uc_Loai_41.txt_Truong_106, uc_Loai_42.txt_Truong_106);
            Compare_TextBox(uc_Loai_41.txt_Truong_107, uc_Loai_42.txt_Truong_107);
            Compare_LookUpEdit(uc_Loai_41.txt_Truong_108, uc_Loai_42.txt_Truong_108);
            Compare_LookUpEdit(uc_Loai_41.txt_Truong_109, uc_Loai_42.txt_Truong_109);
            Compare_TextBox(uc_Loai_41.txt_Truong_110, uc_Loai_42.txt_Truong_110);
            Compare_TextBox(uc_Loai_41.txt_Truong_112, uc_Loai_42.txt_Truong_112);
            Compare_TextBox(uc_Loai_41.txt_Truong_158, uc_Loai_42.txt_Truong_158);
            Compare_TextBox(uc_Loai_41.txt_Truong_159, uc_Loai_42.txt_Truong_159);
            Compare_TextBox(uc_Loai_41.txt_Truong_160, uc_Loai_42.txt_Truong_160);
            Compare_TextBox(uc_Loai_41.txt_Truong_161, uc_Loai_42.txt_Truong_161);
            Compare_TextBox(uc_Loai_41.txt_Truong_162, uc_Loai_42.txt_Truong_162);
            Compare_TextBox(uc_Loai_41.txt_Truong_165, uc_Loai_42.txt_Truong_165);
            Compare_TextBox(uc_Loai_41.txt_Truong_166, uc_Loai_42.txt_Truong_166);
            Compare_TextBox(uc_Loai_41.txt_Truong_167, uc_Loai_42.txt_Truong_167);
            Compare_TextBox(uc_Loai_41.txt_Truong_168, uc_Loai_42.txt_Truong_168);


            var soloi = ((from w in Global.db_BCL.tbl_DESOs where w.fBatchName == Global.StrBatch && w.Dem == 1 select w.IdImage).Count() / 2).ToString();
            lb_Loi.Text = soloi + " Lỗi";
        }

        private string GetImage_DeSo()
        {
            var temp = (from w in Global.db_BCL.tbl_MissCheck_DESOs
                        where w.fBatchName == Global.StrBatch && w.UserName == Global.StrUsername &&  w.Submit == 0
                        select w.IdImage).FirstOrDefault();
            if (string.IsNullOrEmpty(temp))
            {
                var getFilename =
                    (from w in Global.db_BCL.ImageCheck_DeSo(Global.StrBatch, Global.StrUsername)
                     select w.Column1).FirstOrDefault();
                if (string.IsNullOrEmpty(getFilename))
                {
                    return "NULL";
                }
                lb_Image.Text = getFilename;
                uc_PictureBox1.imageBox1.Image = null;
                if (uc_PictureBox1.LoadImage(Global.Webservice + Global.StrBatch + "/" + getFilename, getFilename,
                            Properties.Settings.Default.ZoomImage) == "Error")
                {
                    uc_PictureBox1.imageBox1.Image = Resources.svn_deleted;
                    return "Error";
                }
            }
            else
            {
                lb_Image.Text = temp;
                uc_PictureBox1.imageBox1.Image = null;
                if (uc_PictureBox1.LoadImage(Global.Webservice + Global.StrBatch + "/" + temp, temp,
                            Properties.Settings.Default.ZoomImage) == "Error")
                {
                    uc_PictureBox1.imageBox1.Image = Resources.svn_deleted;
                    return "Error";
                }
            }
            return "ok";
        }
        
        private void Uc_Loai_11_Changed(object sender, EventArgs e)
        {
            btn_Luu_DeSo1.Visible = false;
            btn_SuaVaLuu_User1.Visible = true;
        }

        private void Uc_Loai_21_Changed(object sender, EventArgs e)
        {
            btn_Luu_DeSo1.Visible = false;
            btn_SuaVaLuu_User1.Visible = true;
        }

        private void Uc_Loai_31_Changed(object sender, EventArgs e)
        {
            btn_Luu_DeSo1.Visible = false;
            btn_SuaVaLuu_User1.Visible = true;
        }
        private void Uc_Loai_12_Changed(object sender, EventArgs e)
        {
            btn_Luu_DeSo2.Visible = false;
            btn_SuaVaLuu_User2.Visible = true;
        }

        private void Uc_Loai_22_Changed(object sender, EventArgs e)
        {
            btn_Luu_DeSo2.Visible = false;
            btn_SuaVaLuu_User2.Visible = true;
        }
        private void Uc_Loai_32_Changed(object sender, EventArgs e)
        {
            btn_Luu_DeSo2.Visible = false;
            btn_SuaVaLuu_User2.Visible = true;
        }

        private void btn_Luu_DeSo1_Click(object sender, EventArgs e)
        {
            if (Global.StrCheck=="CHECKDESO")
            {
                Global.db_BCL.LuuDESo(lb_Image.Text, Global.StrBatch, lb_username1.Text, lb_username2.Text, Global.StrUsername);
                ResetData();
                string temp = GetImage_DeSo();

                if (temp == "NULL")
                {
                    uc_PictureBox1.imageBox1.Dispose();
                    MessageBox.Show("Hết Hình!");
                    return;
                }
                if (temp == "Error")
                {
                    MessageBox.Show("Lỗi load hình");
                    return;
                }
                Load_DeSo(Global.StrBatch, lb_Image.Text);
                btn_Luu_DeSo1.Visible = true;
                btn_Luu_DeSo2.Visible = true;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;
            }
            else if (Global.StrCheck == "CHECKDEJP")
            {
                Global.db_BCL.LuuDEJP(lb_Image.Text, Global.StrBatch, lb_username1.Text, lb_username2.Text, Global.StrUsername);
                ResetData();
                string temp = GetImage_DeJP();

                if (temp == "NULL")
                {
                    uc_PictureBox1.imageBox1.Dispose();
                    MessageBox.Show("Hết Hình!");
                    return;
                }
                if (temp == "Error")
                {
                    MessageBox.Show("Lỗi load hình");
                    return;
                }
                Load_DeJP(Global.StrBatch, lb_Image.Text);
                btn_Luu_DeSo1.Visible = true;
                btn_Luu_DeSo2.Visible = true;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;
            }



        }

        private void btn_Luu_DeSo2_Click(object sender, EventArgs e)
        {
            if (Global.StrCheck=="CHECKDESO")
            {
                Global.db_BCL.LuuDESo(lb_Image.Text, Global.StrBatch, lb_username2.Text, lb_username1.Text, Global.StrUsername);
                ResetData();
                string temp = GetImage_DeSo();

                if (temp == "NULL")
                {
                    uc_PictureBox1.imageBox1.Dispose();
                    MessageBox.Show("Hết Hình!");
                    return;
                }
                if (temp == "Error")
                {
                    MessageBox.Show("Lỗi load hình");
                    return;
                }
                Load_DeSo(Global.StrBatch, lb_Image.Text);
                btn_Luu_DeSo1.Visible = true;
                btn_Luu_DeSo2.Visible = true;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;
            }
            else if(Global.StrCheck=="CHECKDEJP")
            {
                Global.db_BCL.LuuDEJP(lb_Image.Text, Global.StrBatch, lb_username2.Text, lb_username1.Text, Global.StrUsername);
                ResetData();
                string temp = GetImage_DeJP();

                if (temp == "NULL")
                {
                    uc_PictureBox1.imageBox1.Dispose();
                    MessageBox.Show("Hết Hình!");
                    return;
                }
                if (temp == "Error")
                {
                    MessageBox.Show("Lỗi load hình");
                    return;
                }
                Load_DeJP(Global.StrBatch, lb_Image.Text);
                btn_Luu_DeSo1.Visible = true;
                btn_Luu_DeSo2.Visible = true;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;
            }
           
        }

        private void btn_SuaVaLuu_User1_Click(object sender, EventArgs e)
        {
            if (Global.StrCheck=="CHECKDESO")
            {
                if (tabcontrol_DeSo1.SelectedTabPage.Name == "tp_Loai_1_DeSo1")
                    Global.db_BCL.SuaVaLuu_deso(lb_username1.Text, lb_username2.Text, lb_Image.Text, Global.StrBatch, Global.StrUsername, uc_Loai_11.txt_Truong_001.Text, uc_Loai_11.txt_Truong_002.Text,
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "Loai1");
                else if (tabcontrol_DeSo1.SelectedTabPage.Name == "tp_Loai_2_DeSo1")
                    Global.db_BCL.SuaVaLuu_deso(lb_username1.Text, lb_username2.Text, lb_Image.Text, Global.StrBatch, Global.StrUsername, "", uc_Loai_21.txt_Truong_002.Text, uc_Loai_21.txt_Truong_003.Text,
                        uc_Loai_21.txt_Truong_004.Text, "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "Loai2");
                else if (tabcontrol_DeSo1.SelectedTabPage.Name == "tp_Loai_3_DeSo1")
                    Global.db_BCL.SuaVaLuu_deso(lb_username1.Text, lb_username2.Text, lb_Image.Text, Global.StrBatch, Global.StrUsername, "", uc_Loai_31.txt_Truong_002.Text, uc_Loai_31.txt_Truong_003.Text,
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "Loai3");
                else if (tabcontrol_DeSo1.SelectedTabPage.Name == "tp_Loai_4_DeSo1")
                {
                    string truong001 = uc_Loai_41.txt_Truong_001_1.Text + uc_Loai_41.txt_Truong_001_2.Text;
                    string truong102 = uc_Loai_41.txt_Truong_102_1.Text + uc_Loai_41.txt_Truong_102_2.Text;

                    Global.db_BCL.SuaVaLuu_deso(lb_username1.Text, lb_username2.Text, lb_Image.Text, Global.StrBatch,
                        Global.StrUsername, truong001,
                        "",
                        uc_Loai_41.txt_Truong_003.Text,
                        uc_Loai_41.txt_Truong_004.Text,
                        uc_Loai_41.txt_Truong_005.Text,
                        uc_Loai_41.txt_Truong_006.Text,
                        uc_Loai_41.txt_Truong_008.Text,
                        uc_Loai_41.txt_Truong_009.Text,
                        uc_Loai_41.txt_Truong_012.Text,
                        uc_Loai_41.txt_Truong_013.Text,
                        uc_Loai_41.txt_Truong_028.Text,
                        uc_Loai_41.txt_Truong_029.Text,
                        uc_Loai_41.txt_Truong_030.Text,
                        uc_Loai_41.txt_Truong_037.Text,
                        uc_Loai_41.txt_Truong_038.Text,
                        uc_Loai_41.txt_Truong_039.Text,
                        uc_Loai_41.txt_Truong_040.Text,
                        uc_Loai_41.txt_Truong_041.Text,
                        uc_Loai_41.txt_Truong_042.Text,
                        uc_Loai_41.txt_Truong_043.Text,
                        uc_Loai_41.txt_Truong_044.Text,
                        uc_Loai_41.txt_Truong_045.Text,
                        uc_Loai_41.txt_Truong_046.Text,
                        uc_Loai_41.txt_Truong_047.Text,
                        uc_Loai_41.txt_Truong_048.Text,
                        "",
                        uc_Loai_41.txt_Truong_050.Text,
                        uc_Loai_41.txt_Truong_051.Text,
                        uc_Loai_41.txt_Truong_052.Text,
                        uc_Loai_41.txt_Truong_053.Text,
                        uc_Loai_41.txt_Truong_057.Text,
                        uc_Loai_41.txt_Truong_058.Text,
                        uc_Loai_41.txt_Truong_063.Text,
                        uc_Loai_41.txt_Truong_064.Text,
                        uc_Loai_41.txt_Truong_065.Text,
                        uc_Loai_41.txt_Truong_066.Text,
                        uc_Loai_41.txt_Truong_077.Text,
                        uc_Loai_41.txt_Truong_078.Text,
                        uc_Loai_41.txt_Truong_079.Text,
                        uc_Loai_41.txt_Truong_080.Text,
                        uc_Loai_41.txt_Truong_081.Text,
                        uc_Loai_41.txt_Truong_082.Text,
                        uc_Loai_41.txt_Truong_083.Text,
                        uc_Loai_41.txt_Truong_084.Text,
                        uc_Loai_41.txt_Truong_085.Text,
                        uc_Loai_41.txt_Truong_086.Text,
                        uc_Loai_41.txt_Truong_088.Text,
                        uc_Loai_41.txt_Truong_089.Text,
                        uc_Loai_41.txt_Truong_090.Text,
                        uc_Loai_41.txt_Truong_091.Text,
                        "",
                        uc_Loai_41.txt_Truong_093.Text,
                        uc_Loai_41.txt_Truong_094.Text,
                        uc_Loai_41.txt_Truong_095.Text,
                        uc_Loai_41.txt_Truong_096.Text,
                        uc_Loai_41.txt_Truong_097.Text,
                        uc_Loai_41.txt_Truong_098.Text,
                        uc_Loai_41.txt_Truong_099.Text,
                        uc_Loai_41.txt_Truong_100.Text,
                        uc_Loai_41.txt_Truong_101.Text,
                        truong102,
                        uc_Loai_41.txt_Truong_103.Text,
                        uc_Loai_41.txt_Truong_104.Text,
                        uc_Loai_41.txt_Truong_105.Text,
                        uc_Loai_41.txt_Truong_106.Text,
                        uc_Loai_41.txt_Truong_107.Text,
                        uc_Loai_41.txt_Truong_108.Text,
                        uc_Loai_41.txt_Truong_109.Text,
                        uc_Loai_41.txt_Truong_110.Text,
                        uc_Loai_41.txt_Truong_112.Text,
                        uc_Loai_41.txt_Truong_158.Text,
                        uc_Loai_41.txt_Truong_159.Text,
                        uc_Loai_41.txt_Truong_160.Text,
                        uc_Loai_41.txt_Truong_161.Text,
                        uc_Loai_41.txt_Truong_162.Text,
                        uc_Loai_41.txt_Truong_165.Text,
                        uc_Loai_41.txt_Truong_166.Text,
                        uc_Loai_41.txt_Truong_167.Text,
                        uc_Loai_41.txt_Truong_168.Text, "Loai4");
                }

                ResetData();
                if (GetImage_DeSo() == "NULL")
                {
                    uc_PictureBox1.imageBox1.Dispose();
                    MessageBox.Show("Hết Hình!");
                    return;
                }
                Load_DeSo(Global.StrBatch, lb_Image.Text);
                btn_Luu_DeSo1.Visible = true;
                btn_Luu_DeSo2.Visible = true;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;
            }
            else if (Global.StrCheck == "CHECKDEJP")
            {
                
                Global.db_BCL.SuaVaLuu_DEJP(lb_username1.Text, lb_username2.Text, lb_Image.Text, Global.StrBatch, Global.StrUsername, uc_DEJP1.txt_Truong_002.Text, "Loai4");
               
                ResetData();
                if (GetImage_DeJP() == "NULL")
                {
                    uc_PictureBox1.imageBox1.Dispose();
                    MessageBox.Show("Hết Hình!");
                    return;
                }
                Load_DeJP(Global.StrBatch, lb_Image.Text);
                btn_Luu_DeSo1.Visible = true;
                btn_Luu_DeSo2.Visible = true;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;
            }
           
        }

        private void btn_SuaVaLuu_User2_Click(object sender, EventArgs e)
        {
            if (Global.StrCheck=="CHECKDESO")
            {
                if (tabcontrol_DeSo2.SelectedTabPage.Name == "tp_Loai_1_DeSo2")
                    Global.db_BCL.SuaVaLuu_deso(lb_username2.Text, lb_username1.Text, lb_Image.Text, Global.StrBatch, Global.StrUsername, uc_Loai_12.txt_Truong_001.Text, uc_Loai_12.txt_Truong_002.Text,
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "Loai1");
                else if (tabcontrol_DeSo2.SelectedTabPage.Name == "tp_Loai_2_DeSo2")
                    Global.db_BCL.SuaVaLuu_deso(lb_username2.Text, lb_username1.Text, lb_Image.Text, Global.StrBatch, Global.StrUsername, "", uc_Loai_22.txt_Truong_002.Text, uc_Loai_22.txt_Truong_003.Text,
                        uc_Loai_22.txt_Truong_004.Text, "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "Loai2");
                else if (tabcontrol_DeSo2.SelectedTabPage.Name == "tp_Loai_3_DeSo2")
                    Global.db_BCL.SuaVaLuu_deso(lb_username2.Text, lb_username1.Text, lb_Image.Text, Global.StrBatch, Global.StrUsername, "", uc_Loai_32.txt_Truong_002.Text, uc_Loai_32.txt_Truong_003.Text,
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "", "", "", "",
                        "", "", "", "", "", "", "Loai3");
                else if (tabcontrol_DeSo2.SelectedTabPage.Name == "tp_Loai_4_DeSo2")
                {
                    string truong001 = uc_Loai_42.txt_Truong_001_1.Text + uc_Loai_42.txt_Truong_001_2.Text;
                    string truong102 = uc_Loai_42.txt_Truong_102_1.Text + uc_Loai_42.txt_Truong_102_2.Text;

                    Global.db_BCL.SuaVaLuu_deso(lb_username2.Text, lb_username1.Text, lb_Image.Text, Global.StrBatch,
                        Global.StrUsername, truong001,
                        "",
                        uc_Loai_42.txt_Truong_003.Text,
                        uc_Loai_42.txt_Truong_004.Text,
                        uc_Loai_42.txt_Truong_005.Text,
                        uc_Loai_42.txt_Truong_006.Text,
                        uc_Loai_42.txt_Truong_008.Text,
                        uc_Loai_42.txt_Truong_009.Text,
                        uc_Loai_42.txt_Truong_012.Text,
                        uc_Loai_42.txt_Truong_013.Text,
                        uc_Loai_42.txt_Truong_028.Text,
                        uc_Loai_42.txt_Truong_029.Text,
                        uc_Loai_42.txt_Truong_030.Text,
                        uc_Loai_42.txt_Truong_037.Text,
                        uc_Loai_42.txt_Truong_038.Text,
                        uc_Loai_42.txt_Truong_039.Text,
                        uc_Loai_42.txt_Truong_040.Text,
                        uc_Loai_42.txt_Truong_041.Text,
                        uc_Loai_42.txt_Truong_042.Text,
                        uc_Loai_42.txt_Truong_043.Text,
                        uc_Loai_42.txt_Truong_044.Text,
                        uc_Loai_42.txt_Truong_045.Text,
                        uc_Loai_42.txt_Truong_046.Text,
                        uc_Loai_42.txt_Truong_047.Text,
                        uc_Loai_42.txt_Truong_048.Text,
                        "",
                        uc_Loai_42.txt_Truong_050.Text,
                        uc_Loai_42.txt_Truong_051.Text,
                        uc_Loai_42.txt_Truong_052.Text,
                        uc_Loai_42.txt_Truong_053.Text,
                        uc_Loai_42.txt_Truong_057.Text,
                        uc_Loai_42.txt_Truong_058.Text,
                        uc_Loai_42.txt_Truong_063.Text,
                        uc_Loai_42.txt_Truong_064.Text,
                        uc_Loai_42.txt_Truong_065.Text,
                        uc_Loai_42.txt_Truong_066.Text,
                        uc_Loai_42.txt_Truong_077.Text,
                        uc_Loai_42.txt_Truong_078.Text,
                        uc_Loai_42.txt_Truong_079.Text,
                        uc_Loai_42.txt_Truong_080.Text,
                        uc_Loai_42.txt_Truong_081.Text,
                        uc_Loai_42.txt_Truong_082.Text,
                        uc_Loai_42.txt_Truong_083.Text,
                        uc_Loai_42.txt_Truong_084.Text,
                        uc_Loai_42.txt_Truong_085.Text,
                        uc_Loai_42.txt_Truong_086.Text,
                        uc_Loai_42.txt_Truong_088.Text,
                        uc_Loai_42.txt_Truong_089.Text,
                        uc_Loai_42.txt_Truong_090.Text,
                        uc_Loai_42.txt_Truong_091.Text,
                        "",
                        uc_Loai_42.txt_Truong_093.Text,
                        uc_Loai_42.txt_Truong_094.Text,
                        uc_Loai_42.txt_Truong_095.Text,
                        uc_Loai_42.txt_Truong_096.Text,
                        uc_Loai_42.txt_Truong_097.Text,
                        uc_Loai_42.txt_Truong_098.Text,
                        uc_Loai_42.txt_Truong_099.Text,
                        uc_Loai_42.txt_Truong_100.Text,
                        uc_Loai_42.txt_Truong_101.Text,
                        truong102,
                        uc_Loai_42.txt_Truong_103.Text,
                        uc_Loai_42.txt_Truong_104.Text,
                        uc_Loai_42.txt_Truong_105.Text,
                        uc_Loai_42.txt_Truong_106.Text,
                        uc_Loai_42.txt_Truong_107.Text,
                        uc_Loai_42.txt_Truong_108.Text,
                        uc_Loai_42.txt_Truong_109.Text,
                        uc_Loai_42.txt_Truong_110.Text,
                        uc_Loai_42.txt_Truong_112.Text,
                        uc_Loai_42.txt_Truong_158.Text,
                        uc_Loai_42.txt_Truong_159.Text,
                        uc_Loai_42.txt_Truong_160.Text,
                        uc_Loai_42.txt_Truong_161.Text,
                        uc_Loai_42.txt_Truong_162.Text,
                        uc_Loai_42.txt_Truong_165.Text,
                        uc_Loai_42.txt_Truong_166.Text,
                        uc_Loai_42.txt_Truong_167.Text,
                        uc_Loai_42.txt_Truong_168.Text, "Loai4");
                }

                ResetData();
                if (GetImage_DeSo() == "NULL")
                {
                    uc_PictureBox1.imageBox1.Dispose();
                    MessageBox.Show("Hết Hình!");
                    return;
                }
                Load_DeSo(Global.StrBatch, lb_Image.Text);
                btn_Luu_DeSo1.Visible = true;
                btn_Luu_DeSo2.Visible = true;
                btn_SuaVaLuu_User1.Visible = false;
                btn_SuaVaLuu_User2.Visible = false;
            }
            else if (Global.StrCheck == "CHECKDEJP")
            {
                
                Global.db_BCL.SuaVaLuu_DEJP(lb_username2.Text, lb_username1.Text, lb_Image.Text, Global.StrBatch, Global.StrUsername, uc_DEJP2.txt_Truong_002.Text, "Loai4");
                
                ResetData();
                if (GetImage_DeJP() == "NULL")
                {
                    uc_PictureBox1.imageBox1.Dispose();
                    MessageBox.Show("Hết Hình!");
                    return;
                }
                Load_DeJP(Global.StrBatch, lb_Image.Text);
                btn_Luu_DeSo1.Visible = true;
                btn_Luu_DeSo2.Visible = true;
                btn_SuaVaLuu_User1.Visible = false;btn_SuaVaLuu_User2.Visible = false;
            }
        }

            
    }
}
