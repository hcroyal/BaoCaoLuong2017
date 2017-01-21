using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BaoCaoLuong2017.MyClass;
using BaoCaoLuong2017.Properties;

namespace BaoCaoLuong2017.MyForm
{
    public partial class frm_Main : DevExpress.XtraEditors.XtraForm
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        CLHandling_Loai1 Class_Loai_1 = new CLHandling_Loai1();
        private void frm_Main_Load(object sender, EventArgs e)
        {
            setValue();
        }

        private void btn_Check_DESO_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frm_Check().ShowDialog();
            frm_Main_Load(sender, e);
        }
        private void setValue()
        {
            if (Global.StrRole == "DESO")
            {
                lb_SoHinhConLai.Text = (from w in Global.db_BCL.tbl_Images
                                      where (w.ReadImageDESo == 0 | w.ReadImageDESo == 1) & w.fbatchname == Global.StrBatch & w.UserNameDESo!=Global.StrUsername
                                      select w.idimage).Count().ToString();
                lb_SoHinhLamDuoc.Text = (from w in Global.db_BCL.tbl_MissImage_DESOs
                                       where w.UserName == Global.StrUsername & w.fBatchName==Global.StrBatch select w.IdImage).Count().ToString();
            }
            else if (Global.StrRole == "DEJP")
            {
                lb_SoHinhConLai.Text = (from w in Global.db_BCL.tbl_Images
                                      where (w.ReadImageDEJP == 0 | w.ReadImageDEJP == 1) & w.fbatchname == Global.StrBatch & w.UserNameDESo == Global.StrUsername
                                        select w.idimage).Count().ToString();
                lb_SoHinhLamDuoc.Text = (from w in Global.db_BCL.tbl_MissImage_DEJPs
                                       where w.UserName == lb_UserName.Text select w.IdImage).Count().ToString();
            }
        }
        public string GetImage()
        {
            if (Global.StrRole == "DESO")
            {
                string temp = (from w in Global.db_BCL.tbl_MissImage_DESOs
                               where w.fBatchName == Global.StrBatch && w.UserName == Global.StrUsername && w.Submit == 0
                               select w.IdImage).FirstOrDefault();
                if (string.IsNullOrEmpty(temp))
                {
                    try
                    {
                        var getFilename =
                            (from w in Global.db_BCL.LayHinhMoi_DeSo(Global.StrBatch, Global.StrUsername)
                             select w.Column1).FirstOrDefault();
                        if (string.IsNullOrEmpty(getFilename))
                        {
                            return "NULL";
                        }
                        lb_IdImage.Text = getFilename;
                        uc_PictureBox1.imageBox1.Image = null;
                        if (uc_PictureBox1.LoadImage(Global.Webservice + Global.StrBatch + "/" + getFilename, getFilename,
                            Settings.Default.ZoomImage) == "Error")
                        {
                            uc_PictureBox1.imageBox1.Image = Resources.svn_deleted;
                            return "Error";

                        }
                    }
                    catch (Exception)
                    {
                        return "NULL";
                    }
                }
                else
                {
                    lb_IdImage.Text = temp;
                    uc_PictureBox1.imageBox1.Image = null;
                    if (uc_PictureBox1.LoadImage(Global.Webservice + Global.StrBatch + "/" + temp, temp,
                        Settings.Default.ZoomImage) == "Error")
                    {
                        uc_PictureBox1.imageBox1.Image = Resources.svn_deleted;
                        return "Error";
                    }
                }
            }
            return "OK";
        }
        private void btn_Start_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_Start_Submit.Text == "Start")
                {
                    if (string.IsNullOrEmpty(Global.StrBatch))
                    {
                        MessageBox.Show("Vui lòng đăng nhập lại và chọn Batch!");
                        return;
                    }
                    string temp = GetImage();
                    if (temp == "NULL")
                    {
                        MessageBox.Show("Hết Hình!");
                        btn_Logout_ItemClick(null, null);
                    }
                    else if (temp == "Error")
                    {
                        MessageBox.Show("Không thể load hình!");
                        btn_Logout_ItemClick(null, null);
                    }
                    uc_Loai_11.ResetData();
                    uc_Loai_21.ResetData();
                    uc_Loai_31.ResetData();
                    setValue();
                    btn_Start_Submit.Text = "Submit";
                    btn_Submit_Logout.Visible = true;
                }
                else
                {
                    if (Global.StrRole == "DESO")
                    {
                        if (tabcontrol.SelectedTabPage.Name == "tp_Loai_1")
                        {
                            if (uc_Loai_11.IsEmpty())
                            {
                                if (MessageBox.Show("Bạn đang để trống 1 hoặc nhiều trường. Bạn có muốn submit không? \r\nYes = Submit và chuyển qua hình khác<Nhấn Enter>\r\nNo = nhập lại trường trống cho hình này.<nhấn phím N>", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                                    return;
                            }
                            uc_Loai_11.SaveData_Loai_1(lb_IdImage.Text);
                            uc_Loai_11.ResetData();
                        }
                        else if (tabcontrol.SelectedTabPage.Name == "tp_Loai_2")
                        {
                            if (uc_Loai_21.IsEmpty())
                            {
                                if (MessageBox.Show("Bạn đang để trống 1 hoặc nhiều trường. Bạn có muốn submit không? \r\nYes = Submit và chuyển qua hình khác<Nhấn Enter>\r\nNo = nhập lại trường trống cho hình này.<nhấn phím N>", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                                    return;
                            }
                            uc_Loai_21.SaveData_Loai_2(lb_IdImage.Text);
                            uc_Loai_21.ResetData();
                        }
                        else if (tabcontrol.SelectedTabPage.Name == "tp_Loai_3")
                        {
                            if (uc_Loai_31.IsEmpty())
                            {
                                if (MessageBox.Show("Bạn đang để trống 1 hoặc nhiều trường. Bạn có muốn submit không? \r\nYes = Submit và chuyển qua hình khác<Nhấn Enter>\r\nNo = nhập lại trường trống cho hình này.<nhấn phím N>", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                                    return;
                            }
                            uc_Loai_31.SaveData_Loai_3(lb_IdImage.Text);
                            uc_Loai_31.ResetData();
                            
                        }
                        setValue();
                    }
                    string temp = GetImage();
                    if (temp == "NULL")
                    {
                        MessageBox.Show("Hết Hình!");
                        btn_Logout_ItemClick(null, null);
                    }
                    else if (temp == "Error")
                    {
                        MessageBox.Show("Không thể load hình!");
                        btn_Logout_ItemClick(null, null);
                    }
                }
            }
            catch { MessageBox.Show("Lỗi khi Submit"); }
        }

        private void btn_QuanLyBatch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frm_ManagerBatch().ShowDialog();
            frm_Main_Load(sender, e);
        }

        private void btn_Submit_Logout_Click(object sender, EventArgs e)
        {
            try
            {
                if (Global.StrRole == "DESO")
                {
                    if (tabcontrol.SelectedTabPage.Name == "tp_Loai_1")
                    {
                        if (uc_Loai_11.IsEmpty())
                        {
                            if (MessageBox.Show("Bạn đang để trống 1 hoặc nhiều trường. Bạn có muốn submit không? \r\nYes = Submit và chuyển qua hình khác<Nhấn Enter>\r\nNo = nhập lại trường trống cho hình này.<nhấn phím N>", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                                return;
                        }
                        uc_Loai_11.SaveData_Loai_1(lb_IdImage.Text);
                    }
                    else if (tabcontrol.SelectedTabPage.Name == "tp_Loai_2")
                    {
                        if (uc_Loai_21.IsEmpty())
                        {
                            if (MessageBox.Show("Bạn đang để trống 1 hoặc nhiều trường. Bạn có muốn submit không? \r\nYes = Submit và chuyển qua hình khác<Nhấn Enter>\r\nNo = nhập lại trường trống cho hình này.<nhấn phím N>", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                                return;
                        }
                        uc_Loai_21.SaveData_Loai_2(lb_IdImage.Text);
                    }
                    else if (tabcontrol.SelectedTabPage.Name == "tp_Loai_3")
                    {
                        if (uc_Loai_31.IsEmpty())
                        {
                            if (MessageBox.Show("Bạn đang để trống 1 hoặc nhiều trường. Bạn có muốn submit không? \r\nYes = Submit và chuyển qua hình khác<Nhấn Enter>\r\nNo = nhập lại trường trống cho hình này.<nhấn phím N>", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                                return;
                        }
                        uc_Loai_31.SaveData_Loai_3(lb_IdImage.Text);
                    }
                    Application.Exit();
                }
            }
            catch { MessageBox.Show("Lỗi khi Submit"); }
        }

        private void btn_Logout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }
    }
}
