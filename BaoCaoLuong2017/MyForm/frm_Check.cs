using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaoCaoLuong2017.MyForm
{
    public partial class frm_Check : DevExpress.XtraEditors.XtraForm
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
        private void frm_Check_Load(object sender, EventArgs e)
        {
            try
            {
                lb_fBatchName.Text = Global.StrBatch;
                tabcontrol_DeSo1.TabPages.Remove(tp_Loai_1_DeSo1);
                tabcontrol_DeSo1.TabPages.Remove(tp_Loai_2_DeSo1);
                tabcontrol_DeSo1.TabPages.Remove(tp_Loai_3_DeSo1);
                tabcontrol_DeSo1.TabPages.Remove(tp_Loai_4_DeSo1);
                tabcontrol_DeSo1.TabPages.Remove(tp_Loai_4_1_DeSo1);
                tabcontrol_DeSo1.TabPages.Remove(tp_DEJP1);

                tabcontrol_DeSo2.TabPages.Remove(tp_Loai_1_DeSo2);
                tabcontrol_DeSo2.TabPages.Remove(tp_Loai_2_DeSo2);
                tabcontrol_DeSo2.TabPages.Remove(tp_Loai_3_DeSo2);
                tabcontrol_DeSo2.TabPages.Remove(tp_Loai_4_DeSo2);
                tabcontrol_DeSo2.TabPages.Remove(tp_Loai_4_1_DeSo2);
                tabcontrol_DeSo2.TabPages.Remove(tp_DEJP2);


                if (Global.StrRole == "CHECKERDESO")
                {
                    var soloi =((from w in Global.db_BCL.tbl_DESOs where w.fBatchName == Global.StrBatch && w.Dem == 1 select w.IdImage).Count() / 2).ToString();
                    lb_Loi.Text = soloi + " Lỗi";

                    tabcontrol_DeSo1.TabPages.Add(tp_Loai_1_DeSo1);
                    tabcontrol_DeSo1.TabPages.Add(tp_Loai_2_DeSo1);
                    tabcontrol_DeSo1.TabPages.Add(tp_Loai_3_DeSo1);
                    tabcontrol_DeSo1.TabPages.Add(tp_Loai_4_DeSo1);
                    tabcontrol_DeSo1.TabPages.Add(tp_Loai_4_1_DeSo1);

                    tabcontrol_DeSo2.TabPages.Add(tp_Loai_1_DeSo2);
                    tabcontrol_DeSo2.TabPages.Add(tp_Loai_2_DeSo2);
                    tabcontrol_DeSo2.TabPages.Add(tp_Loai_3_DeSo2);
                    tabcontrol_DeSo2.TabPages.Add(tp_Loai_4_DeSo2);
                    tabcontrol_DeSo2.TabPages.Add(tp_Loai_4_1_DeSo2);

                    btn_Luu_DeSo1.Visible = false;
                    btn_SuavaLuu_DeSo1.Visible = false;
                    btn_Luu_DeSo2.Visible = false;
                    btn_SuavaLuu_DeSo2.Visible = false;

                    uc_Loai_11.Changed += Uc_Loai_11_Changed;
                    uc_Loai_21.Changed += Uc_Loai_21_Changed;
                    uc_Loai_31.Changed += Uc_Loai_31_Changed;

                    uc_Loai_12.Changed += Uc_Loai_12_Changed;
                    uc_Loai_22.Changed += Uc_Loai_22_Changed;
                    uc_Loai_32.Changed += Uc_Loai_32_Changed;
                    
                }
                else if (Global.StrRole == "CheckerDEJP")
                {
                    tabcontrol_DeSo1.TabPages.Add(tp_DEJP1);
                    tabcontrol_DeSo2.TabPages.Add(tp_DEJP2);
                    btn_Luu_DeSo1.Visible = false;
                    btn_SuavaLuu_DeSo1.Visible = false;
                    btn_Luu_DeSo2.Visible = false;
                    btn_SuavaLuu_DeSo2.Visible = false;
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
                if (sohinh > nhap)
                {
                    MessageBox.Show("Chưa nhập xong DeSo!");
                    return;
                }
                if (check > 0)
                {
                    MessageBox.Show("Chưa nhập xong DeSo!");
                    return;
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
                btn_SuavaLuu_DeSo1.Visible = false;
                btn_SuavaLuu_DeSo2.Visible = false;
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
                }Load_DeJP(Global.StrBatch, lb_Image.Text);
                btn_Luu_DeSo1.Visible = true;
                btn_Luu_DeSo2.Visible = true;
                btn_SuavaLuu_DeSo1.Visible = false;
                btn_SuavaLuu_DeSo2.Visible = false;
            }
            btn_Start.Visible = false;
        }

        private void Load_DeJP(string strBatch, string text)
        {
            throw new NotImplementedException();
        }

        private string GetImage_DeJP()
        {
            throw new NotImplementedException();
        }

        private void Load_DeSo(string strBatch, string text)
        {
            throw new NotImplementedException();
        }

        private string GetImage_DeSo()
        {
            throw new NotImplementedException();
        }

        private void Uc_Loai_11_Changed(object sender, EventArgs e)
        {
            btn_Luu_DeSo1.Visible = false;
            btn_SuavaLuu_DeSo1.Visible = true;
        }

        private void Uc_Loai_21_Changed(object sender, EventArgs e)
        {
            btn_Luu_DeSo1.Visible = false;
            btn_SuavaLuu_DeSo1.Visible = true;
        }

        private void Uc_Loai_31_Changed(object sender, EventArgs e)
        {
            btn_Luu_DeSo1.Visible = false;
            btn_SuavaLuu_DeSo1.Visible = true;
        }
        private void Uc_Loai_12_Changed(object sender, EventArgs e)
        {
            btn_Luu_DeSo2.Visible = false;
            btn_SuavaLuu_DeSo2.Visible = true;
        }

        private void Uc_Loai_22_Changed(object sender, EventArgs e)
        {
            btn_Luu_DeSo2.Visible = false;
            btn_SuavaLuu_DeSo2.Visible = true;
        }
        private void Uc_Loai_32_Changed(object sender, EventArgs e)
        {
            btn_Luu_DeSo2.Visible = false;
            btn_SuavaLuu_DeSo2.Visible = true;
        }
    }
}
