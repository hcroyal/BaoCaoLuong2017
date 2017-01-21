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
            if (Global.StrRole == "CHECKERDESO")
            {
                uc_Loai_11.ResetData();
                uc_Loai_12.ResetData();

                uc_Loai_21.ResetData();
                uc_Loai_22.ResetData();

                uc_Loai_31.ResetData();
                uc_Loai_32.ResetData();
                
            }
            else if(Global.StrRole == "CHECKERDEJP")
            {
                
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


                if (Global.StrRole == "CHECKERDESO")
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

                    uc_Loai_12.Changed += Uc_Loai_12_Changed;
                    uc_Loai_22.Changed += Uc_Loai_22_Changed;
                    uc_Loai_32.Changed += Uc_Loai_32_Changed;
                    
                }
                else if (Global.StrRole == "CheckerDEJP")
                {
                    tp_DEJP1.PageVisible = true;
                    
                    tp_DEJP2.PageVisible = true;

                    btn_Luu_DeSo1.Visible = false;
                    btn_Luu_DeSo2.Visible = false;
                    var soloi =((from w in Global.db_BCL.tbl_DEJPs where w.fBatchName == Global.StrBatch && w.Dem == 1 select w.IdImage).Count() / 2).ToString();
                    lb_Loi.Text = soloi + " Lỗi";
                }
            }
            catch( Exception i)
            {
                MessageBox.Show("Lỗi" + i);
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (Global.StrRole == "CHECKERDESO")
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
                //if (sohinh > nhap)
                //{
                //    MessageBox.Show("Chưa nhập xong DeSo!");
                //    return;
                //}
                //if (check > 0)
                //{
                //    MessageBox.Show("Chưa nhập xong DeSo!");
                //    return;
                //}
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
            else if(Global.StrRole == "CHECKERDEJP")
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
                    MessageBox.Show("Chưa nhập xong DeJP!");
                    return;
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

        private void Load_DeJP(string strBatch, string text)
        {
           
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
            if (deso[0].LoaiPhieu == "Loai2")
            {
                tabcontrol_DeSo1.SelectedTabPage = tp_Loai_2_DeSo1;

                uc_Loai_21.txt_Truong_002.Text = deso[0].Truong_002;
                uc_Loai_21.txt_Truong_003.Text = deso[0].Truong_003;
                uc_Loai_21.txt_Truong_004.Text = deso[0].Truong_004;
            }
            if (deso[0].LoaiPhieu == "Loai3")
            {
                tabcontrol_DeSo1.SelectedTabPage = tp_Loai_3_DeSo1;

                tp_DEJP1.PageVisible = false;

                uc_Loai_31.txt_Truong_002.Text = deso[0].Truong_002;
                uc_Loai_31.txt_Truong_003.Text = deso[0].Truong_003;
            }


            if (deso[1].LoaiPhieu == "Loai1")
            {
                tabcontrol_DeSo2.SelectedTabPage = tp_Loai_1_DeSo2;

                uc_Loai_12.txt_Truong_001.Text = deso[1].Truong_001;
                uc_Loai_12.txt_Truong_002.Text = deso[1].Truong_002;
            }
            if (deso[1].LoaiPhieu == "Loai2")
            {
                tabcontrol_DeSo2.SelectedTabPage = tp_Loai_2_DeSo2;

                uc_Loai_22.txt_Truong_002.Text = deso[1].Truong_002;
                uc_Loai_22.txt_Truong_003.Text = deso[1].Truong_003;
                uc_Loai_22.txt_Truong_004.Text = deso[1].Truong_004;
            }
            if (deso[1].LoaiPhieu == "Loai3")
            {
                tabcontrol_DeSo2.SelectedTabPage = tp_Loai_3_DeSo2;
                
                uc_Loai_32.txt_Truong_002.Text = deso[1].Truong_002;
                uc_Loai_32.txt_Truong_003.Text = deso[1].Truong_003;

            }
            Compare_TextBox(uc_Loai_11.txt_Truong_001, uc_Loai_12.txt_Truong_001);
            Compare_TextBox(uc_Loai_11.txt_Truong_002, uc_Loai_12.txt_Truong_002);

            Compare_TextBox(uc_Loai_21.txt_Truong_002, uc_Loai_22.txt_Truong_002);
            Compare_TextBox(uc_Loai_21.txt_Truong_002, uc_Loai_22.txt_Truong_002);
            Compare_TextBox(uc_Loai_21.txt_Truong_002, uc_Loai_22.txt_Truong_002);

            Compare_TextBox(uc_Loai_31.txt_Truong_002, uc_Loai_32.txt_Truong_002);
            Compare_TextBox(uc_Loai_31.txt_Truong_002, uc_Loai_32.txt_Truong_002);

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
            //
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

        private void btn_Luu_DeSo2_Click(object sender, EventArgs e)
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

        private void btn_SuaVaLuu_User1_Click(object sender, EventArgs e)
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
                Global.db_BCL.SuaVaLuu_deso(lb_username1.Text, lb_username2.Text, lb_Image.Text, Global.StrBatch, Global.StrUsername, uc_Loai_21.txt_Truong_002.Text, uc_Loai_21.txt_Truong_003.Text,
                    uc_Loai_21.txt_Truong_004.Text, "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "Loai2");
            else if (tabcontrol_DeSo1.SelectedTabPage.Name == "tp_Loai_3_DeSo1")
                Global.db_BCL.SuaVaLuu_deso(lb_username1.Text, lb_username2.Text, lb_Image.Text, Global.StrBatch, Global.StrUsername, uc_Loai_31.txt_Truong_002.Text, uc_Loai_31.txt_Truong_003.Text,
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "Loai3");
            else if (tabcontrol_DeSo1.SelectedTabPage.Name == "tp_Loai_4_DeSo1")
                MessageBox.Show("Hoangnt làm");

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

        private void btn_SuaVaLuu_User2_Click(object sender, EventArgs e)
        {
            if (tabcontrol_DeSo2.SelectedTabPage.Name == "tp_Loai_1_DeSo2")
                Global.db_BCL.SuaVaLuu_deso(lb_username2.Text, lb_username1.Text,lb_Image.Text, Global.StrBatch, Global.StrUsername, uc_Loai_12.txt_Truong_001.Text, uc_Loai_12.txt_Truong_002.Text,
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "Loai1");
            else if (tabcontrol_DeSo2.SelectedTabPage.Name == "tp_Loai_2_DeSo2")
                Global.db_BCL.SuaVaLuu_deso(lb_username2.Text, lb_username1.Text, lb_Image.Text, Global.StrBatch, Global.StrUsername, uc_Loai_22.txt_Truong_002.Text, uc_Loai_22.txt_Truong_003.Text,
                    uc_Loai_22.txt_Truong_004.Text, "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "Loai2");
            else if (tabcontrol_DeSo2.SelectedTabPage.Name == "tp_Loai_3_DeSo2")
                Global.db_BCL.SuaVaLuu_deso(lb_username2.Text, lb_username1.Text, lb_Image.Text, Global.StrBatch, Global.StrUsername, uc_Loai_32.txt_Truong_002.Text, uc_Loai_32.txt_Truong_003.Text,
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "", "", "",
                    "", "", "", "", "", "", "", "Loai3");
            else if (tabcontrol_DeSo2.SelectedTabPage.Name == "tp_Loai_4_DeSo2")
                MessageBox.Show("Hoangnt làm");

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
    }
}
