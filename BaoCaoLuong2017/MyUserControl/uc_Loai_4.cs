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
    public partial class uc_Loai_4 : UserControl
    {
        public event AllTextChange Changed;
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
            txt_Truong_005.GotFocus  += Txt_Truong_001_1_GotFocus;
            txt_Truong_105.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_103.GotFocus += Txt_Truong_001_1_GotFocus;



            txt_Truong_158.LostFocus += Txt_Truong_158_LostFocus;
            txt_Truong_159.LostFocus += Txt_Truong_158_LostFocus;
            txt_Truong_160.LostFocus += Txt_Truong_158_LostFocus;
            txt_Truong_161.LostFocus += Txt_Truong_158_LostFocus;
            txt_Truong_162.LostFocus += Txt_Truong_158_LostFocus;
            txt_Truong_165.LostFocus += Txt_Truong_158_LostFocus;
            txt_Truong_166.LostFocus += Txt_Truong_158_LostFocus;
            txt_Truong_167.LostFocus += Txt_Truong_158_LostFocus;
            txt_Truong_168.LostFocus += Txt_Truong_158_LostFocus;
            txt_Truong_003.LostFocus += Txt_Truong_158_LostFocus;

        }

        private void Txt_Truong_158_LostFocus(object sender, EventArgs e)
        {
            if(((TextEdit)(sender)).BackColor == Color.LimeGreen)
            {
                //MessageBox.Show("Bạn nhập không đúng công thức, Vui lòng kiểm tra lại.");// \r\nYes = Nhập Lại\r\nNo = Nhập ô khác", "Thông báo dữ liệu không đúng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                   
            }
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
            txt_Truong_077.BackColor = Color.White;
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
            txt_Truong_050.Text = "";
            txt_Truong_043.Text = "";
            txt_Truong_045.Text = "";
            txt_Truong_048.Text = "";
            txt_Truong_041.Text = "";
            txt_Truong_029.Text = "";
            txt_Truong_030.Text = "";
            txt_Truong_112.Text = "";
            txt_Truong_063.Text = "";
            txt_Truong_066.Text = "";
            txt_Truong_066.BackColor = Color.White;
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
                txt_Truong_037.Text?.Replace(",",""),
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
                txt_Truong_110.Text,
                txt_Truong_047.Text?.Replace(",", ""),
                txt_Truong_042.Text?.Replace(",", ""),
                txt_Truong_043.Text?.Replace(",", ""),
                txt_Truong_045.Text?.Replace(",", ""),
                txt_Truong_048.Text?.Replace(",", ""),
                txt_Truong_041.Text?.Replace(",", ""),
                txt_Truong_029.Text,
                txt_Truong_030.Text,
                txt_Truong_112.Text,
                txt_Truong_063.Text?.Replace(",", ""),
                txt_Truong_066.Text?.Replace(",", ""),
                txt_Truong_065.Text?.Replace(",", ""),
                txt_Truong_064.Text?.Replace(",", ""),
                txt_Truong_044.Text?.Replace(",", ""),
                txt_Truong_104.Text,
                txt_Truong_106.Text,
                txt_Truong_108.Text,
                txt_Truong_057.Text?.Replace(",", ""),
                txt_Truong_053.Text?.Replace(",", ""),
                txt_Truong_107.Text,
                txt_Truong_109.Text,
                txt_Truong_058.Text?.Replace(",", ""),
                txt_Truong_158.Text,
                txt_Truong_051.Text?.Replace(",", ""),
                txt_Truong_050.Text?.Replace(",", ""),
                txt_Truong_046.Text?.Replace(",", ""),
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
        public bool Lenght12(TextEdit txt)
        {
            try
            {
                int intMod = 11;
                List<string> P = new List<string>();

                for (int i = 0; i < txt.Text.Length; i++)
                {
                    P.Add(txt.Text[i].ToString());
                    //chỉ lấy 11 ký tự đầu để so sánh. ký tự thứu 12 để compare
                }

                if (P.Count != 12)
                {
                    return false;
                }

                List<int> Q = new List<int> { 6, 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };

                List<string> P_Q = new List<string>();

                for (int i = 0; i < 11; i++)
                {
                    P_Q.Add((int.Parse(P[i]) * Q[i]).ToString());
                }

                int sum = 0;
                for (int i = 0; i < 11; i++)
                {
                    sum += int.Parse(P_Q[i]);
                }

                //MessageBox.Show(sum.ToString());

                int checksum = intMod - sum % intMod;
                if (checksum >= 10)
                    checksum = 0;

                if (P[11] == checksum.ToString())
                    return true;
                else
                    return false;
            }
            catch { return false; }

        }
        public bool Lenght13(TextEdit txt)
        {
            try
            {
                int intMod2 = 9;
                List<string> P = new List<string>();

                for (int i = txt.Text.Length - 1; i >= 0; i--)
                {
                    P.Add(txt.Text[i].ToString());
                    //chỉ lấy 12 ký tự đầu để so sánh. ký tự thứu 13 để compare
                }

                if (P.Count != 13)
                {

                    return false;
                }

                List<int> Q = new List<int> { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2 };

                List<string> P_Q = new List<string>();

                for (int i = 0; i < 12; i++)
                {
                    P_Q.Add((int.Parse(P[i]) * Q[i]).ToString());
                }

                int sum = 0;
                for (int i = 0; i < 12; i++)
                {
                    sum += int.Parse(P_Q[i]);
                }

                //MessageBox.Show(sum.ToString());

                int checksum = intMod2 - sum % intMod2;
                if (checksum >= 10)
                    checksum = 0;
                if (P[12] == checksum.ToString())
                    return true;
                else
                    return false;
            }
            catch { return false; }
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

        private void txt_Truong_057_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                curency(txt_Truong_057);
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

        private void txt_Truong_058_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                curency(txt_Truong_058);
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
            doimautrongkhoang((TextEdit) sender, 0, 10);

            if (txt_Truong_006.Text.Length == 10 || txt_Truong_006.Text == "?" || string.IsNullOrEmpty(txt_Truong_006.Text))
            {
                txt_Truong_006.BackColor = Color.White;
                //luon luon bat dau bang so 4 hoac so 99
                if (txt_Truong_006.Text.Length > 1)
                    if (txt_Truong_006.Text[0].ToString() != "4")
                        if ((txt_Truong_006.Text[0].ToString() + txt_Truong_006.Text[1].ToString()) != "99")
                        {
                            txt_Truong_006.BackColor = Color.Red;
                        }

            }

            else
                txt_Truong_006.BackColor = Color.Red;

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
            if (Lenght12(txt_Truong_003))
                txt_Truong_003.BackColor = Color.White;
            else
            {
                if (txt_Truong_003.Text.Length > 12)
                    txt_Truong_003.BackColor = Color.Red;
                else
                    txt_Truong_003.BackColor = Color.LimeGreen;
            }
            
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
            doimautrongkhoang((TextEdit)sender, 0, 9);
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
            
            if (Lenght12(txt_Truong_158))
                txt_Truong_158.BackColor = Color.White;
            else
            {
                if(txt_Truong_158.Text.Length > 12)
                    txt_Truong_158.BackColor = Color.Red;
                else
                txt_Truong_158.BackColor = Color.LimeGreen;
            }
                
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
           
            if (Lenght12(txt_Truong_159))
                txt_Truong_159.BackColor = Color.White;
            else
            {
                if (txt_Truong_159.Text.Length > 12)
                    txt_Truong_159.BackColor = Color.Red;
                else
                    txt_Truong_159.BackColor = Color.LimeGreen;
            }
            //doimautrongkhoang((TextEdit)sender, 0, 12);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_165_EditValueChanged(object sender, EventArgs e)
        {
            if (Lenght12(txt_Truong_165))
                txt_Truong_165.BackColor = Color.White;
            else
            {
                if (txt_Truong_165.Text.Length > 12)
                    txt_Truong_165.BackColor = Color.Red;
                else
                    txt_Truong_165.BackColor = Color.LimeGreen;
            }
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_160_EditValueChanged(object sender, EventArgs e)
        {
            if (Lenght12(txt_Truong_160))
                txt_Truong_160.BackColor = Color.White;
            else
            {
                if (txt_Truong_160.Text.Length > 12)
                    txt_Truong_160.BackColor = Color.Red;
                else
                    txt_Truong_160.BackColor = Color.LimeGreen;
            }
            
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_166_EditValueChanged(object sender, EventArgs e)
        {
            if (Lenght12(txt_Truong_166))
                txt_Truong_166.BackColor = Color.White;
            else
            {
                if (txt_Truong_166.Text.Length > 12)
                    txt_Truong_166.BackColor = Color.Red;
                else
                    txt_Truong_166.BackColor = Color.LimeGreen;
            }
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_161_EditValueChanged(object sender, EventArgs e)
        {
            if (Lenght12(txt_Truong_161))
                txt_Truong_161.BackColor = Color.White;
            else
            {
                if (txt_Truong_161.Text.Length > 12)
                    txt_Truong_161.BackColor = Color.Red;
                else
                    txt_Truong_161.BackColor = Color.LimeGreen;
            }

            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_167_EditValueChanged(object sender, EventArgs e)
        {
            if (Lenght12(txt_Truong_167))
                txt_Truong_167.BackColor = Color.White;
            else
            {
                if (txt_Truong_167.Text.Length > 12)
                    txt_Truong_167.BackColor = Color.Red;
                else
                    txt_Truong_167.BackColor = Color.LimeGreen;
            }
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_162_EditValueChanged(object sender, EventArgs e)
        {
            if (Lenght12(txt_Truong_162))
                txt_Truong_162.BackColor = Color.White;
            else
            {
                if (txt_Truong_162.Text.Length > 12)
                    txt_Truong_162.BackColor = Color.Red;
                else
                    txt_Truong_162.BackColor = Color.LimeGreen;
            }
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_168_EditValueChanged(object sender, EventArgs e)
        {
            if (Lenght12(txt_Truong_168))
                txt_Truong_168.BackColor = Color.White;
            else
            {
                if (txt_Truong_168.Text.Length > 12)
                    txt_Truong_168.BackColor = Color.Red;
                else
                    txt_Truong_168.BackColor = Color.LimeGreen;
            }
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
            if (Changed != null)
                Changed(sender, e);

            
            //if (!(Lenght12(txt_Truong_005) || Lenght13(txt_Truong_005)) && (txt_Truong_005.Text.Length == 12 || txt_Truong_005.Text.Length == 13))
            //{
            //    txt_Truong_005.BackColor = Color.LimeGreen;
            //}
            //else
                doimautrongkhoang((TextEdit)sender, 0, 13);

            if(txt_Truong_005.Text.Length == 12)
            {
                if (!Lenght12(txt_Truong_005))
                    txt_Truong_005.BackColor = Color.LimeGreen;
            }
            else if(txt_Truong_005.Text.Length == 13)
                if(!Lenght13(txt_Truong_005))
                    txt_Truong_005.BackColor = Color.LimeGreen;



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

        private void txt_Truong_158_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Truong_077_EditValueChanged(object sender, EventArgs e)
        {
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_100_EditValueChanged(object sender, EventArgs e)
        {
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_101_EditValueChanged(object sender, EventArgs e)
        {
            if (Changed != null)
                Changed(sender, e);
        }
    }
}