using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BaoCaoLuong2017.MyUserControl
{
    public partial class uc_Loai_4 : UserControl
    {
        List<Category> category = new List<Category>();
        public uc_Loai_4()
        {
            InitializeComponent();
        }

        private void uc_Loai_4_Load(object sender, EventArgs e)
        {
            SetDataLookUpEdit();
            txt_Truong_108.Properties.DataSource = category;
            txt_Truong_108.Properties.DisplayMember = "Value_SO";
            txt_Truong_108.Properties.ValueMember = "Value_SO";

            txt_Truong_109.Properties.DataSource = category;
            txt_Truong_109.Properties.DisplayMember = "Value_SO";
            txt_Truong_109.Properties.ValueMember = "Value_SO";

            txt_Truong_001_1.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_001_2.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_102_1.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_102_2.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_004.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_012.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_006.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_009.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_013.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_008.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_003.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_028.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_037.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_038.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_039.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_040.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_077.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_078.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_052.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_080.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_082.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_081.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_079.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_086.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_085.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_084.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_083.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_110.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_047.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_042.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_043.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_045.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_048.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_041.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_029.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_030.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_112.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_063.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_066.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_065.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_064.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_044.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_104.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_106.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_057.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_053.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_107.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_058.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_158.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_051.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_046.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_159.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_165.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_160.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_166.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_161.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_167.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_162.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_168.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_088.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_099.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_097.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_098.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_089.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_091.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_090.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_093.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_094.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_095.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_096.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_100.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_101.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_005.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_105.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_103.GotFocus += Txt_Truong_001_1_GotFocus;
        }

  
        private void Txt_Truong_001_1_GotFocus(object sender, EventArgs e)
        {
            ((TextEdit) sender).SelectAll();
        }

        public class Category
        {
            public string Value_JP { get; set; }
            public string Value_SO { get; set; }
        }

        private void SetDataLookUpEdit()
        {
            category.Add(new Category() { Value_JP = "", Value_SO = "" });
            category.Add(new Category() { Value_JP = "住", Value_SO = "01" });
            category.Add(new Category() { Value_JP = "認", Value_SO = "02" });
            category.Add(new Category() { Value_JP = "増", Value_SO = "03" });
            category.Add(new Category() { Value_JP = "震", Value_SO = "04" });
            category.Add(new Category() { Value_JP = "住（特）", Value_SO = "11" });
            category.Add(new Category() { Value_JP = "認（特）", Value_SO = "12" });
            category.Add(new Category() { Value_JP = "増（特）", Value_SO = "13" });
            category.Add(new Category() { Value_JP = "震（特）", Value_SO = "14" });
            category.Add(new Category() { Value_JP = "特", Value_SO = "11" });
            category.Add(new Category() { Value_JP = "特定", Value_SO = "11" });
        }
        public void ResetData()
        {
            txt_Truong_004.Text = "";
            txt_Truong_012.Text = "";
            txt_Truong_006.Text = "";
            txt_Truong_009.Text = "";
            txt_Truong_013.Text = "";
            txt_Truong_008.Text = "";
            txt_Truong_003.Text = "";
            txt_Truong_028.Text = "";
            txt_Truong_037.Text = "";
            txt_Truong_038.Text = "";
            txt_Truong_039.Text = "";
            txt_Truong_040.Text = "";
            txt_Truong_077.Text = "";
            txt_Truong_078.Text = "";
            txt_Truong_052.Text = "";
            txt_Truong_080.Text = "";
            txt_Truong_082.Text = "";
            txt_Truong_081.Text = "";
            txt_Truong_079.Text = "";
            txt_Truong_086.Text = "";
            txt_Truong_085.Text = "";
            txt_Truong_084.Text = "";
            txt_Truong_083.Text = "";
            txt_Truong_110.Text = "";
            txt_Truong_047.Text = "";
            txt_Truong_042.Text = "";
            txt_Truong_043.Text = "";
            txt_Truong_045.Text = "";
            txt_Truong_048.Text = "";
            txt_Truong_041.Text = "";
            txt_Truong_029.Text = "";
            txt_Truong_030.Text = "";
            txt_Truong_112.Text = "";
            txt_Truong_063.Text = "";
            txt_Truong_066.Text = "";
            txt_Truong_065.Text = "";
            txt_Truong_064.Text = "";
            txt_Truong_044.Text = "";
            txt_Truong_104.Text = "";
            txt_Truong_106.Text = "";
            txt_Truong_108.ItemIndex = 0; 
            txt_Truong_057.Text = "";
            txt_Truong_053.Text = "";
            txt_Truong_107.Text = "";
            txt_Truong_109.ItemIndex = 0;
            txt_Truong_058.Text = "";
            txt_Truong_158.Text = "";
            txt_Truong_051.Text = "";
            txt_Truong_046.Text = "";
            txt_Truong_159.Text = "";
            txt_Truong_165.Text = "";
            txt_Truong_160.Text = "";
            txt_Truong_166.Text = "";
            txt_Truong_161.Text = "";
            txt_Truong_167.Text = "";
            txt_Truong_162.Text = "";
            txt_Truong_168.Text = "";
            txt_Truong_088.Text = "";
            txt_Truong_099.Text = "";
            txt_Truong_097.Text = "";
            txt_Truong_098.Text = "";
            txt_Truong_089.Text = "";
            txt_Truong_091.Text = "";
            txt_Truong_090.Text = "";
            txt_Truong_093.Text = "";
            txt_Truong_094.Text = "";
            txt_Truong_095.Text = "";
            txt_Truong_096.Text = "";
            txt_Truong_100.Text = "";
            txt_Truong_101.Text = "";
            txt_Truong_102_1.Text = "";
            txt_Truong_102_2.Text = "";
            txt_Truong_001_1.Text = "";
            txt_Truong_001_2.Text = "";
            txt_Truong_005.Text = "";
            txt_Truong_105.Text = "";
            txt_Truong_103.Text = "";

        }
        public bool IsEmpty()
        {
            if (string.IsNullOrEmpty(txt_Truong_004.Text) &&
                string.IsNullOrEmpty(txt_Truong_012.Text) &&
                string.IsNullOrEmpty(txt_Truong_006.Text) &&
                string.IsNullOrEmpty(txt_Truong_009.Text) &&
                string.IsNullOrEmpty(txt_Truong_013.Text) &&
                string.IsNullOrEmpty(txt_Truong_008.Text) &&
                string.IsNullOrEmpty(txt_Truong_003.Text) &&
                string.IsNullOrEmpty(txt_Truong_028.Text) &&
                string.IsNullOrEmpty(txt_Truong_037.Text) &&
                string.IsNullOrEmpty(txt_Truong_038.Text) &&
                string.IsNullOrEmpty(txt_Truong_039.Text) &&
                string.IsNullOrEmpty(txt_Truong_040.Text) &&
                string.IsNullOrEmpty(txt_Truong_077.Text) &&
                string.IsNullOrEmpty(txt_Truong_078.Text) &&
                string.IsNullOrEmpty(txt_Truong_052.Text) &&
                string.IsNullOrEmpty(txt_Truong_080.Text) &&
                string.IsNullOrEmpty(txt_Truong_082.Text) &&
                string.IsNullOrEmpty(txt_Truong_081.Text) &&
                string.IsNullOrEmpty(txt_Truong_079.Text) &&
                string.IsNullOrEmpty(txt_Truong_086.Text) &&
                string.IsNullOrEmpty(txt_Truong_085.Text) &&
                string.IsNullOrEmpty(txt_Truong_084.Text) &&
                string.IsNullOrEmpty(txt_Truong_083.Text) &&
                string.IsNullOrEmpty(txt_Truong_110.Text) &&
                string.IsNullOrEmpty(txt_Truong_047.Text) &&
                string.IsNullOrEmpty(txt_Truong_042.Text) &&
                string.IsNullOrEmpty(txt_Truong_043.Text) &&
                string.IsNullOrEmpty(txt_Truong_045.Text) &&
                string.IsNullOrEmpty(txt_Truong_048.Text) &&
                string.IsNullOrEmpty(txt_Truong_041.Text) &&
                string.IsNullOrEmpty(txt_Truong_029.Text) &&
                string.IsNullOrEmpty(txt_Truong_030.Text) &&
                string.IsNullOrEmpty(txt_Truong_112.Text) &&
                string.IsNullOrEmpty(txt_Truong_063.Text) &&
                string.IsNullOrEmpty(txt_Truong_066.Text) &&
                string.IsNullOrEmpty(txt_Truong_065.Text) &&
                string.IsNullOrEmpty(txt_Truong_064.Text) &&
                string.IsNullOrEmpty(txt_Truong_044.Text) &&
                string.IsNullOrEmpty(txt_Truong_104.Text) &&
                string.IsNullOrEmpty(txt_Truong_106.Text) &&
                string.IsNullOrEmpty(txt_Truong_108.Text) &&
                string.IsNullOrEmpty(txt_Truong_057.Text) &&
                string.IsNullOrEmpty(txt_Truong_053.Text) &&
                string.IsNullOrEmpty(txt_Truong_107.Text) &&
                string.IsNullOrEmpty(txt_Truong_109.Text) &&
                string.IsNullOrEmpty(txt_Truong_058.Text) &&
                string.IsNullOrEmpty(txt_Truong_158.Text) &&
                string.IsNullOrEmpty(txt_Truong_051.Text) &&
                string.IsNullOrEmpty(txt_Truong_046.Text) &&
                string.IsNullOrEmpty(txt_Truong_159.Text) &&
                string.IsNullOrEmpty(txt_Truong_165.Text) &&
                string.IsNullOrEmpty(txt_Truong_160.Text) &&
                string.IsNullOrEmpty(txt_Truong_166.Text) &&
                string.IsNullOrEmpty(txt_Truong_161.Text) &&
                string.IsNullOrEmpty(txt_Truong_167.Text) &&
                string.IsNullOrEmpty(txt_Truong_162.Text) &&
                string.IsNullOrEmpty(txt_Truong_168.Text) &&
                string.IsNullOrEmpty(txt_Truong_088.Text) &&
                string.IsNullOrEmpty(txt_Truong_099.Text) &&
                string.IsNullOrEmpty(txt_Truong_097.Text) &&
                string.IsNullOrEmpty(txt_Truong_098.Text) &&
                string.IsNullOrEmpty(txt_Truong_089.Text) &&
                string.IsNullOrEmpty(txt_Truong_091.Text) &&
                string.IsNullOrEmpty(txt_Truong_090.Text) &&
                string.IsNullOrEmpty(txt_Truong_093.Text) &&
                string.IsNullOrEmpty(txt_Truong_094.Text) &&
                string.IsNullOrEmpty(txt_Truong_095.Text) &&
                string.IsNullOrEmpty(txt_Truong_096.Text) &&
                string.IsNullOrEmpty(txt_Truong_100.Text) &&
                string.IsNullOrEmpty(txt_Truong_101.Text) &&
                string.IsNullOrEmpty(txt_Truong_102_1.Text) &&
                string.IsNullOrEmpty(txt_Truong_102_2.Text) &&
                string.IsNullOrEmpty(txt_Truong_001_1.Text) &&
                string.IsNullOrEmpty(txt_Truong_001_2.Text) &&
                string.IsNullOrEmpty(txt_Truong_005.Text) &&
                string.IsNullOrEmpty(txt_Truong_105.Text) &&
                string.IsNullOrEmpty(txt_Truong_103.Text) )
                return true;
            return false;
        }

        public void SaveData_Loai_4(string idImage)
        {
            string txtTruong001 = txt_Truong_001_1.Text + txt_Truong_001_2.Text;
            string txtTruong102 = txt_Truong_102_1.Text + txt_Truong_102_2.Text;
            Global.db_BCL.Insert_Loai4(idImage,Global.StrBatch,Global.StrUsername,"Loai4",
                txt_Truong_004.Text,
                txt_Truong_012.Text,
                txt_Truong_006.Text,
                txt_Truong_009.Text,
                txt_Truong_013.Text,
                txt_Truong_008.Text,
                txt_Truong_003.Text,
                txt_Truong_028.Text,
                txt_Truong_037.Text,
                txt_Truong_038.Text,
                txt_Truong_039.Text,
                txt_Truong_040.Text,
                txt_Truong_077.Text,
                txt_Truong_078.Text,
                txt_Truong_052.Text,
                txt_Truong_080.Text,
                txt_Truong_082.Text,
                txt_Truong_081.Text,
                txt_Truong_079.Text,
                txt_Truong_086.Text,
                txt_Truong_085.Text,
                txt_Truong_084.Text,
                txt_Truong_083.Text,
                txt_Truong_110.Text,
                txt_Truong_047.Text,
                txt_Truong_042.Text,
                txt_Truong_043.Text,
                txt_Truong_045.Text,
                txt_Truong_048.Text,
                txt_Truong_041.Text,
                txt_Truong_029.Text,
                txt_Truong_030.Text,
                txt_Truong_112.Text,
                txt_Truong_063.Text,
                txt_Truong_066.Text,
                txt_Truong_065.Text,
                txt_Truong_064.Text,
                txt_Truong_044.Text,
                txt_Truong_104.Text,
                txt_Truong_106.Text,
                txt_Truong_108.Text,
                txt_Truong_057.Text,
                txt_Truong_053.Text,
                txt_Truong_107.Text,
                txt_Truong_109.Text,
                txt_Truong_058.Text,
                txt_Truong_158.Text,
                txt_Truong_051.Text,
                txt_Truong_046.Text,
                txt_Truong_159.Text,
                txt_Truong_165.Text,
                txt_Truong_160.Text,
                txt_Truong_166.Text,
                txt_Truong_161.Text,
                txt_Truong_167.Text,
                txt_Truong_162.Text,
                txt_Truong_168.Text,
                txt_Truong_088.Text,
                txt_Truong_099.Text,
                txt_Truong_097.Text,
                txt_Truong_098.Text,
                txt_Truong_089.Text,
                txt_Truong_091.Text,
                txt_Truong_090.Text,
                txt_Truong_093.Text,
                txt_Truong_094.Text,
                txt_Truong_095.Text,
                txt_Truong_096.Text,
                txt_Truong_100.Text,
                txt_Truong_101.Text,
                txtTruong102,
                txtTruong001,
                txt_Truong_005.Text,
                txt_Truong_105.Text,
                txt_Truong_103.Text);
        }

        private void txt_Truong_108_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Back || e.KeyData == Keys.Delete)
            {
                txt_Truong_108.ItemIndex = 0;
                e.Handled = true;
            }
        }

        private void txt_Truong_109_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Back || e.KeyData == Keys.Delete)
            {
                txt_Truong_109.ItemIndex = 0;
                e.Handled = true;
            }
        }
    }
}
