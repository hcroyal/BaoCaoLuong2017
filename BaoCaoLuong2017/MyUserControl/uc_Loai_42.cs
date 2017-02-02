﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BaoCaoLuonng2017.MyUserControl;
using DevExpress.XtraEditors;

namespace BaoCaoLuong2017.MyUserControl
{
    public partial class uc_Loai_42 : UserControl
    {
        public event AllTextChange Changed;
        public uc_Loai_42()
        {
            InitializeComponent();
        }

        private void uc_Loai_4_Load(object sender, EventArgs e)
        {

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
            txt_Truong_047.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_042.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_043.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_045.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_048.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_041.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_029.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_030.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_063.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_066.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_065.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_064.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_044.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_104.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_106.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_053.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_051.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_046.GotFocus += Txt_Truong_001_1_GotFocus;
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
        
        public void ResetData()
        {
            txt_Truong_004.Text = "";
            txt_Truong_012.Text = "";
            txt_Truong_006.Text = "";
            txt_Truong_009.Text = "";
            txt_Truong_013.Text = "";
            txt_Truong_008.Text = "";
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
            txt_Truong_047.Text = "";
            txt_Truong_042.Text = "";
            txt_Truong_050.Text = "";
            txt_Truong_043.Text = "";
            txt_Truong_045.Text = "";
            txt_Truong_048.Text = "";
            txt_Truong_041.Text = "";
            txt_Truong_029.Text = "";
            txt_Truong_030.Text = "";
            txt_Truong_063.Text = "";
            txt_Truong_066.Text = "";
            txt_Truong_065.Text = "";
            txt_Truong_064.Text = "";
            txt_Truong_044.Text = "";
            txt_Truong_104.Text = "";
            txt_Truong_106.Text = "";
            txt_Truong_053.Text = "";
            txt_Truong_051.Text = "";
            txt_Truong_046.Text = "";
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

        }
        public bool IsEmpty()
        {
            if (string.IsNullOrEmpty(txt_Truong_004.Text) &&
                string.IsNullOrEmpty(txt_Truong_012.Text) &&
                string.IsNullOrEmpty(txt_Truong_006.Text) &&
                string.IsNullOrEmpty(txt_Truong_009.Text) &&
                string.IsNullOrEmpty(txt_Truong_013.Text) &&
                string.IsNullOrEmpty(txt_Truong_008.Text) &&
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
                string.IsNullOrEmpty(txt_Truong_047.Text) &&
                string.IsNullOrEmpty(txt_Truong_042.Text) &&
                string.IsNullOrEmpty(txt_Truong_043.Text) &&
                string.IsNullOrEmpty(txt_Truong_045.Text) &&
                string.IsNullOrEmpty(txt_Truong_048.Text) &&
                string.IsNullOrEmpty(txt_Truong_041.Text) &&
                string.IsNullOrEmpty(txt_Truong_029.Text) &&
                string.IsNullOrEmpty(txt_Truong_030.Text) &&
                string.IsNullOrEmpty(txt_Truong_063.Text) &&
                string.IsNullOrEmpty(txt_Truong_066.Text) &&
                string.IsNullOrEmpty(txt_Truong_065.Text) &&
                string.IsNullOrEmpty(txt_Truong_064.Text) &&
                string.IsNullOrEmpty(txt_Truong_044.Text) &&
                string.IsNullOrEmpty(txt_Truong_104.Text) &&
                string.IsNullOrEmpty(txt_Truong_106.Text) &&
                string.IsNullOrEmpty(txt_Truong_053.Text) &&
                string.IsNullOrEmpty(txt_Truong_051.Text) &&
                string.IsNullOrEmpty(txt_Truong_046.Text) &&
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
                string.IsNullOrEmpty(txt_Truong_001_2.Text) )
                return true;
            return false;
        }

        public void SaveData_Loai_42(string idImage)
        {
            string txtTruong001 = txt_Truong_001_1.Text + txt_Truong_001_2.Text;
            string txtTruong102 = txt_Truong_102_1.Text + txt_Truong_102_2.Text;
            Global.db_BCL.Insert_Loai42(idImage, Global.StrBatch, Global.StrUsername, "Loai4",
                txt_Truong_004.Text,
                txt_Truong_012.Text,
                txt_Truong_006.Text,
                txt_Truong_009.Text,
                txt_Truong_013.Text,
                txt_Truong_008.Text,
                "",
                txt_Truong_028.Text,
                txt_Truong_037.Text?.Replace(",", ""),
                txt_Truong_038.Text?.Replace(",", ""),
                txt_Truong_039.Text?.Replace(",", ""),
                txt_Truong_040.Text?.Replace(",", ""),
                txt_Truong_077.Text,
                txt_Truong_078.Text,
                txt_Truong_052.Text?.Replace(",", ""),
                txt_Truong_080.Text,
                txt_Truong_082.Text,
                txt_Truong_081.Text,
                txt_Truong_079.Text,
                txt_Truong_086.Text,
                txt_Truong_085.Text,
                txt_Truong_084.Text,
                txt_Truong_083.Text,
                "",
                txt_Truong_047.Text?.Replace(",", ""),
                txt_Truong_042.Text?.Replace(",", ""),
                txt_Truong_043.Text?.Replace(",", ""),
                txt_Truong_045.Text?.Replace(",", ""),
                txt_Truong_048.Text?.Replace(",", ""),
                txt_Truong_041.Text?.Replace(",", ""),
                txt_Truong_029.Text,
                txt_Truong_030.Text,
                "",
                txt_Truong_063.Text?.Replace(",", ""),
                txt_Truong_066.Text?.Replace(",", ""),
                txt_Truong_065.Text?.Replace(",", ""),
                txt_Truong_064.Text?.Replace(",", ""),
                txt_Truong_044.Text?.Replace(",", ""),
                txt_Truong_104.Text,
                txt_Truong_106.Text,
                "",
                "",
                txt_Truong_053.Text?.Replace(",", ""),
                "",
                "",
                "",
                "",
                txt_Truong_051.Text?.Replace(",", ""),
                txt_Truong_050.Text?.Replace(",", ""),
                txt_Truong_046.Text?.Replace(",", ""),
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
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
                "",
                "",
                "",
                true);
        }
        
        private void curency(TextEdit txt)
        {
            if (txt.SelectionLength != txt.Text.Length)
            {
                if (!string.IsNullOrEmpty(txt.Text) && txt.Text != "?")
                {
                    System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                    int valueBefore = Int32.Parse(txt.Text, System.Globalization.NumberStyles.AllowThousands);
                    txt.Text = String.Format(culture, "{0:N0}", valueBefore);
                    txt.Select(txt.Text.Length, 0);
                }
            }
        }
        private void txt_Truong_037_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                curency(txt_Truong_037);
            }
            catch
            {
                
            }
           
        }

        

        private void txt_Truong_038_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                curency(txt_Truong_038);
            }
            catch
            {

            }
        }

        private void txt_Truong_039_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                curency(txt_Truong_039);
            }
            catch
            {

            }
        }

        private void txt_Truong_040_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                curency(txt_Truong_040);
            }
            catch
            {

            }
        }

        private void txt_Truong_052_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                curency(txt_Truong_052);
            }
            catch
            {

            }
        }

        private void txt_Truong_047_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                curency(txt_Truong_047);
            }
            catch
            {

            }
        }

        private void txt_Truong_042_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                curency(txt_Truong_042);
            }
            catch
            {

            }
        }

        private void txt_Truong_043_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                curency(txt_Truong_043);
            }
            catch
            {

            }
        }

        private void txt_Truong_045_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                curency(txt_Truong_045);
            }
            catch
            {

            }
        }

        private void txt_Truong_048_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                curency(txt_Truong_048);
            }
            catch
            {

            }
        }

        private void txt_Truong_041_KeyUp(object sender, KeyEventArgs e)
        {
            //try
            //{
            //    curency(txt_Truong_041);
            //}
            //catch
            //{

            //}
        }

        private void txt_Truong_063_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                curency(txt_Truong_063);
            }
            catch
            {

            }
        }

        private void txt_Truong_066_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                curency(txt_Truong_066);
            }
            catch
            {

            }
        }

        private void txt_Truong_065_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                curency(txt_Truong_065);
            }
            catch
            {

            }
        }

        private void txt_Truong_064_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                curency(txt_Truong_064);
            }
            catch
            {

            }
        }

        private void txt_Truong_044_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                curency(txt_Truong_044);
            }
            catch
            {

            }
        }
        
        private void txt_Truong_053_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                curency(txt_Truong_053);
            }
            catch
            {

            }
        }
        
        private void txt_Truong_051_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                curency(txt_Truong_051);
            }
            catch
            {

            }
        }

        private void txt_Truong_050_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                curency(txt_Truong_050);
            }
            catch
            {

            }
        }

        private void txt_Truong_046_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                curency(txt_Truong_046);
            }
            catch
            {

            }
        }

        private void doimautrongkhoang(TextEdit txt, int so_nho, int so_lon)
        {
            
            if (!string.IsNullOrEmpty(txt.Text)|| txt.Text != "?")
            {
                if (txt.Text.Length>=so_nho&&txt.Text.Length<=so_lon)
                {
                    txt.ForeColor = Color.Black;
                    txt.BackColor = Color.White;
                    
                }
                else
                {
                    txt.ForeColor = Color.White;
                    txt.BackColor = Color.Red;
                }
            }
            else
            {
                txt.ForeColor = Color.Black;
                txt.BackColor = Color.White;
            }
        }

        private void txt_Truong_004_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit) sender, 0,12);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_012_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit) sender, 0, 1);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_006_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit) sender, 0, 12);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_009_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 10);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_013_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 1);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_008_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 25);
            if (txt_Truong_008.Text == "0")
                txt_Truong_008.BackColor = Color.Red;
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_003_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 12);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_028_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 1);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_037_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 10);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_038_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 10);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_039_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 10);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_040_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 10);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_052_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 10);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_080_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 2);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_082_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 2);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_081_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 2);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_079_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 2);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_086_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 2);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_085_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 2);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_084_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 2);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_083_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 2);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_110_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 2);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_047_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 10);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_042_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 10);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_043_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 10);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_045_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 10);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_048_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 10);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_041_EditValueChanged(object sender, EventArgs e)
        {
            //doimautrongkhoang((TextEdit)sender, 0, 10);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_029_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 1);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_030_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 1);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_063_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 10);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_066_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 10);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_065_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 10);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_064_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 10);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_044_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 10);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_104_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 1);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_106_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 7);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_057_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 10);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_053_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 10);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_107_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 7);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_058_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 10);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_158_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 12);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_051_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 10);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_050_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 10);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_046_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 10);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_159_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 12);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_165_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 12);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_160_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 12);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_166_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 12);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_161_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 12);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_167_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 12);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_162_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 12);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_168_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 12);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_102_1_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 1);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_102_2_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Truong_102_2.Text))
                doimautrongkhoang((TextEdit)sender, 6, 6);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_001_1_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 1);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_001_2_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 6);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_005_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 13);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_105_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 1);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_103_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 1);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_001_2_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_Truong_001_2.Text))
                doimautrongkhoang((TextEdit)sender, 6, 6);
        }
    }
}