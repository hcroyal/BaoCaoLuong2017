using BaoCaoLuonng2017.MyUserControl;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BaoCaoLuong2017.MyUserControl
{
    public partial class uc_Loai_4 : UserControl
    {
        public event AllTextChange Changed;

        private List<Category> category = new List<Category>();

        public uc_Loai_4()
        {
            InitializeComponent();
        }

        public bool bSubmit = false;

        private List<string> lChar = new List<string>
                                        { "ぁ",
                                        "あ",
                                        "ぃ",
                                        "い",
                                        "ぅ",
                                        "う",
                                        "ぇ",
                                        "え",
                                        "ぉ",
                                        "お",
                                        "か",
                                        "が",
                                        "き",
                                        "ぎ",
                                        "く",
                                        "ぐ",
                                        "け",
                                        "げ",
                                        "こ",
                                        "ご",
                                        "さ",
                                        "ざ",
                                        "し",
                                        "じ",
                                        "す",
                                        "ず",
                                        "せ",
                                        "ぜ",
                                        "そ",
                                        "ぞ",
                                        "た",
                                        "だ",
                                        "ち",
                                        "ぢ",
                                        "っ",
                                        "つ",
                                        "づ",
                                        "て",
                                        "で",
                                        "と",
                                        "ど",
                                        "な",
                                        "に",
                                        "ぬ",
                                        "ね",
                                        "の",
                                        "は",
                                        "ば",
                                        "ぱ",
                                        "ひ",
                                        "び",
                                        "ぴ",
                                        "ふ",
                                        "ぶ",
                                        "ぷ",
                                        "へ",
                                        "べ",
                                        "ぺ",
                                        "ほ",
                                        "ぼ",
                                        "ぽ",
                                        "ま",
                                        "み",
                                        "む",
                                        "め",
                                        "も",
                                        "ゃ",
                                        "や",
                                        "ゅ",
                                        "ゆ",
                                        "ょ",
                                        "よ",
                                        "ら",
                                        "り",
                                        "る",
                                        "れ",
                                        "ろ",
                                        "ゎ",
                                        "わ",
                                        "ゐ",
                                        "ゑ",
                                        "を",
                                        "ん",
                                        "ァ",
                                        "ア",
                                        "ィ",
                                        "イ",
                                        "ゥ",
                                        "ウ",
                                        "ェ",
                                        "エ",
                                        "ォ",
                                        "オ",
                                        "カ",
                                        "ガ",
                                        "キ",
                                        "ギ",
                                        "ク",
                                        "グ",
                                        "ケ",
                                        "ゲ",
                                        "コ",
                                        "ゴ",
                                        "サ",
                                        "ザ",
                                        "シ",
                                        "ジ",
                                        "ス",
                                        "ズ",
                                        "セ",
                                        "ゼ",
                                        "ソ",
                                        "ゾ",
                                        "タ",
                                        "ダ",
                                        "チ",
                                        "ヂ",
                                        "ッ",
                                        "ツ",
                                        "ヅ",
                                        "テ",
                                        "デ",
                                        "ト",
                                        "ド",
                                        "ナ",
                                        "ニ",
                                        "ヌ",
                                        "ネ",
                                        "ノ",
                                        "ハ",
                                        "バ",
                                        "パ",
                                        "ヒ",
                                        "ビ",
                                        "ピ",
                                        "フ",
                                        "ブ",
                                        "プ",
                                        "ヘ",
                                        "ベ",
                                        "ペ",
                                        "ホ",
                                        "ボ",
                                        "ポ",
                                        "マ",
                                        "ミ",
                                        "ム",
                                        "メ",
                                        "モ",
                                        "ャ",
                                        "ヤ",
                                        "ュ",
                                        "ユ",
                                        "ョ",
                                        "ヨ",
                                        "ラ",
                                        "リ",
                                        "ル",
                                        "レ",
                                        "ロ",
                                        "ヮ",
                                        "ワ",
                                        "ヰ",
                                        "ヱ",
                                        "ヲ",
                                        "ン",
                                        "ヴ",
                                        "ヵ",
                                        "ヶ",
                                        "Ａ",
                                        "Ｂ",
                                        "Ｃ",
                                        "Ｄ",
                                        "Ｅ",
                                        "Ｆ",
                                        "Ｇ",
                                        "Ｈ",
                                        "Ｉ",
                                        "Ｊ",
                                        "Ｋ",
                                        "Ｌ",
                                        "Ｍ",
                                        "Ｎ",
                                        "Ｏ",
                                        "Ｐ",
                                        "Ｑ",
                                        "Ｒ",
                                        "Ｓ",
                                        "Ｔ",
                                        "Ｕ",
                                        "Ｖ",
                                        "Ｗ",
                                        "Ｘ",
                                        "Ｙ",
                                        "Ｚ",
                                        "ａ",
                                        "ｂ",
                                        "ｃ",
                                        "ｄ",
                                        "ｅ",
                                        "ｆ",
                                        "ｇ",
                                        "ｈ",
                                        "ｉ",
                                        "ｊ",
                                        "ｋ",
                                        "ｌ",
                                        "ｍ",
                                        "ｎ",
                                        "ｏ",
                                        "ｐ",
                                        "ｑ",
                                        "ｒ",
                                        "ｓ",
                                        "ｔ",
                                        "ｕ",
                                        "ｖ",
                                        "ｗ",
                                        "ｘ",
                                        "ｙ",
                                        "ｚ",
                                        "０",
                                        "１",
                                        "２",
                                        "３",
                                        "４",
                                        "５",
                                        "６",
                                        "７",
                                        "８",
                                        "９",
                                        "ｬ",
                                        "ｭ",
                                        "ｮ",
                                        "ｧ",
                                        "ｨ",
                                        "ｩ",
                                        "ｪ",
                                        "ｫ",
                                        "　",
                                        "ｰ",
                                        "ｯ"
                                        };

        private void uc_Loai_4_Load(object sender, EventArgs e)
        {
            SetDataLookUpEdit();
            txt_Truong_052.Properties.DataSource = category;
            txt_Truong_052.Properties.DisplayMember = "Value_SO";
            txt_Truong_052.Properties.ValueMember = "Value_SO";

            txt_Truong_055.Properties.DataSource = category;
            txt_Truong_055.Properties.DisplayMember = "Value_SO";
            txt_Truong_055.Properties.ValueMember = "Value_SO";

            txt_Truong_001.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_002.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_004.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_005.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_006.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_007.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_008.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_009.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_010.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_011.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_012.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_013.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_014.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_015.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_016.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_017.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_018.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_019.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_020.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_021.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_022.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_023.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_024.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_025.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_026.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_027.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_028.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_029.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_030.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_031.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_032.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_033.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_034.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_035.GotFocus += Txt_Truong_001_1_GotFocus;

            txt_Truong_036.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_0373839.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_040.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_0414243.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_044.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_045.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_046.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_047.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_048.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_049.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_050.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_051.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_052.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_053.GotFocus += Txt_Truong_001_1_GotFocus;

            txt_Truong_055.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_057.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_058.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_059.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_061.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_063.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_065.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_067.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_069.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_071.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_073.GotFocus += Txt_Truong_001_1_GotFocus;
            txt_Truong_075.GotFocus += Txt_Truong_001_1_GotFocus;
        }

        //private void Txt_Truong_158_LostFocus(object sender, EventArgs e)
        //{
        //    if (((TextEdit)(sender)).BackColor == Color.LimeGreen)
        //    {
        //        //MessageBox.Show("Bạn nhập không đúng công thức, Vui lòng kiểm tra lại.");// \r\nYes = Nhập Lại\r\nNo = Nhập ô khác", "Thông báo dữ liệu không đúng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        //    }
        //}

        private void Txt_Truong_001_1_GotFocus(object sender, EventArgs e)
        {
            ((TextEdit)sender).SelectAll();
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
            txt_Truong_001.Text = "";
            txt_Truong_002.Text = "";
            txt_Truong_004.Text = "";
            txt_Truong_005.Text = "";
            txt_Truong_006.Text = "";
            txt_Truong_007.Text = "";
            txt_Truong_008.Text = "";
            txt_Truong_009.Text = "";
            txt_Truong_010.Text = "";
            txt_Truong_011.Text = "";
            txt_Truong_012.Text = "";
            txt_Truong_013.Text = "";
            txt_Truong_014.Text = "";
            txt_Truong_015.Text = "";
            txt_Truong_016.Text = "";
            txt_Truong_017.Text = "";
            txt_Truong_018.Text = "";
            txt_Truong_019.Text = "";
            txt_Truong_020.Text = "";
            txt_Truong_021.Text = "";
            txt_Truong_022.Text = "";
            txt_Truong_023.Text = "";
            txt_Truong_024.Text = "";
            txt_Truong_025.Text = "";
            txt_Truong_026.Text = "";
            txt_Truong_027.Text = "";
            txt_Truong_028.Text = "";
            txt_Truong_029.Text = "";
            txt_Truong_030.Text = "";
            txt_Truong_031.Text = "";
            txt_Truong_032.Text = "";
            txt_Truong_033.Text = "";
            txt_Truong_034.Text = "";
            txt_Truong_035.Text = "";
            txt_Truong_036.Text = "";
            txt_Truong_0373839.Text = "";
            txt_Truong_040.Text = "";
            txt_Truong_0414243.Text = "";
            txt_Truong_044.Text = "";
            txt_Truong_045.Text = "";
            txt_Truong_046.Text = "";
            txt_Truong_047.Text = "";
            txt_Truong_048.Text = "";
            txt_Truong_049.Text = "";
            txt_Truong_050.Text = "";
            txt_Truong_051.Text = "";
            txt_Truong_052.ItemIndex =0;
            txt_Truong_053.Text = "";
            txt_Truong_054.Text = "";
            txt_Truong_055.ItemIndex =0;
            txt_Truong_057.Text = "";
            txt_Truong_058.Text = "";
            txt_Truong_059.Text = "";
            txt_Truong_061.Text = "";
            txt_Truong_063.Text = "";
            txt_Truong_065.Text = "";
            txt_Truong_067.Text = "";
            txt_Truong_069.Text = "";
            txt_Truong_071.Text = "";
            txt_Truong_073.Text = "";
            txt_Truong_075.Text = "";

            txt_Truong_015.BackColor = Color.White;
            txt_Truong_016.BackColor = Color.White;
            txt_Truong_017.BackColor = Color.White;
            txt_Truong_018.BackColor = Color.White;
            txt_Truong_019.BackColor = Color.White;
            txt_Truong_020.BackColor = Color.White;
            txt_Truong_021.BackColor = Color.White;
            txt_Truong_022.BackColor = Color.White;
            txt_Truong_023.BackColor = Color.White;
            txt_Truong_024.BackColor = Color.White;
            txt_Truong_025.BackColor = Color.White;
            txt_Truong_026.BackColor = Color.White;
            txt_Truong_027.BackColor = Color.White;
            txt_Truong_028.BackColor = Color.White;
            txt_Truong_029.BackColor = Color.White;
            txt_Truong_030.BackColor = Color.White;
            txt_Truong_031.BackColor = Color.White;
            txt_Truong_032.BackColor = Color.White;
            txt_Truong_033.BackColor = Color.White;
            txt_Truong_034.BackColor = Color.White;
            txt_Truong_035.BackColor = Color.White;
            txt_Truong_036.BackColor = Color.White;
            txt_Truong_0373839.BackColor = Color.White;
            txt_Truong_040.BackColor = Color.White;
            txt_Truong_0414243.BackColor = Color.White;
            txt_Truong_044.BackColor = Color.White;
            txt_Truong_045.BackColor = Color.White;
            txt_Truong_046.BackColor = Color.White;
            txt_Truong_047.BackColor = Color.White;
            txt_Truong_048.BackColor = Color.White;
            txt_Truong_049.BackColor = Color.White;
            txt_Truong_050.BackColor = Color.White;
            txt_Truong_051.BackColor = Color.White;
            txt_Truong_052.BackColor = Color.White;
            txt_Truong_053.BackColor = Color.White;
            txt_Truong_054.BackColor = Color.White;
            txt_Truong_055.BackColor = Color.White;
            txt_Truong_057.BackColor = Color.White;
            txt_Truong_058.BackColor = Color.White;
            txt_Truong_059.BackColor = Color.White;
            txt_Truong_061.BackColor = Color.White;
            txt_Truong_063.BackColor = Color.White;
            txt_Truong_065.BackColor = Color.White;
            txt_Truong_067.BackColor = Color.White;
            txt_Truong_069.BackColor = Color.White;
            txt_Truong_071.BackColor = Color.White;
            txt_Truong_073.BackColor = Color.White;
            txt_Truong_075.BackColor = Color.White;
        }

        public bool IsEmpty()
        {
            if (string.IsNullOrEmpty(txt_Truong_001.Text) &&
                string.IsNullOrEmpty(txt_Truong_002.Text) &&
                string.IsNullOrEmpty(txt_Truong_004.Text) &&
                string.IsNullOrEmpty(txt_Truong_005.Text) &&
                string.IsNullOrEmpty(txt_Truong_006.Text) &&
                string.IsNullOrEmpty(txt_Truong_007.Text) &&
                string.IsNullOrEmpty(txt_Truong_008.Text) &&
                string.IsNullOrEmpty(txt_Truong_009.Text) &&
                string.IsNullOrEmpty(txt_Truong_010.Text) &&
                string.IsNullOrEmpty(txt_Truong_011.Text) &&
                string.IsNullOrEmpty(txt_Truong_012.Text) &&
                string.IsNullOrEmpty(txt_Truong_013.Text) &&
                string.IsNullOrEmpty(txt_Truong_014.Text) &&
                string.IsNullOrEmpty(txt_Truong_015.Text) &&
                string.IsNullOrEmpty(txt_Truong_016.Text) &&
                string.IsNullOrEmpty(txt_Truong_017.Text) &&
                string.IsNullOrEmpty(txt_Truong_018.Text) &&
                string.IsNullOrEmpty(txt_Truong_019.Text) &&
                string.IsNullOrEmpty(txt_Truong_020.Text) &&
                string.IsNullOrEmpty(txt_Truong_021.Text) &&
                string.IsNullOrEmpty(txt_Truong_022.Text) &&
                string.IsNullOrEmpty(txt_Truong_023.Text) &&
                string.IsNullOrEmpty(txt_Truong_024.Text) &&
                string.IsNullOrEmpty(txt_Truong_025.Text) &&
                string.IsNullOrEmpty(txt_Truong_026.Text) &&
                string.IsNullOrEmpty(txt_Truong_027.Text) &&
                string.IsNullOrEmpty(txt_Truong_028.Text) &&
                string.IsNullOrEmpty(txt_Truong_029.Text) &&
                string.IsNullOrEmpty(txt_Truong_030.Text) &&
                string.IsNullOrEmpty(txt_Truong_031.Text) &&
                string.IsNullOrEmpty(txt_Truong_032.Text) &&
                string.IsNullOrEmpty(txt_Truong_033.Text) &&
                string.IsNullOrEmpty(txt_Truong_034.Text) &&
                string.IsNullOrEmpty(txt_Truong_035.Text) &&
                string.IsNullOrEmpty(txt_Truong_036.Text) &&
                string.IsNullOrEmpty(txt_Truong_0373839.Text) &&
                string.IsNullOrEmpty(txt_Truong_040.Text) &&
                string.IsNullOrEmpty(txt_Truong_0414243.Text) &&
                string.IsNullOrEmpty(txt_Truong_044.Text) &&
                string.IsNullOrEmpty(txt_Truong_045.Text) &&
                string.IsNullOrEmpty(txt_Truong_046.Text) &&
                string.IsNullOrEmpty(txt_Truong_047.Text) &&
                string.IsNullOrEmpty(txt_Truong_048.Text) &&
                string.IsNullOrEmpty(txt_Truong_049.Text) &&
                string.IsNullOrEmpty(txt_Truong_050.Text) &&
                string.IsNullOrEmpty(txt_Truong_051.Text) &&
                string.IsNullOrEmpty(txt_Truong_052.Text) &&
                string.IsNullOrEmpty(txt_Truong_053.Text) &&
                string.IsNullOrEmpty(txt_Truong_054.Text) &&
                string.IsNullOrEmpty(txt_Truong_055.Text) &&
                string.IsNullOrEmpty(txt_Truong_057.Text) &&
                string.IsNullOrEmpty(txt_Truong_058.Text) &&
                string.IsNullOrEmpty(txt_Truong_059.Text) &&
                string.IsNullOrEmpty(txt_Truong_061.Text) &&
                string.IsNullOrEmpty(txt_Truong_063.Text) &&
                string.IsNullOrEmpty(txt_Truong_065.Text) &&
                string.IsNullOrEmpty(txt_Truong_067.Text) &&
                string.IsNullOrEmpty(txt_Truong_069.Text) &&
                string.IsNullOrEmpty(txt_Truong_071.Text) &&
                string.IsNullOrEmpty(txt_Truong_073.Text) &&
                string.IsNullOrEmpty(txt_Truong_075.Text))
                return true;
            return false;
        }

        public void SaveData_Loai_4(string idImage)
        {
            Global.db_BCL.Insert_Loai4(idImage, Global.StrBatch, Global.StrUsername, "Loai4",

                //txt_Truong_037.Text?.Replace(",", ""),
                txt_Truong_001.Text,
                txt_Truong_002.Text,
                "",
                txt_Truong_004.Text?.Replace(",", ""),
                txt_Truong_005.Text?.Replace(",", ""),
                txt_Truong_006.Text?.Replace(",", ""),
                txt_Truong_007.Text?.Replace(",", ""),
                txt_Truong_008.Text,
                txt_Truong_009.Text,
                txt_Truong_010.Text,
                txt_Truong_011.Text?.Replace(",", ""),
                txt_Truong_012.Text,
                txt_Truong_013.Text,
                txt_Truong_014.Text,
                txt_Truong_015.Text,
                txt_Truong_016.Text,
                txt_Truong_017.Text,
                txt_Truong_018.Text,
                txt_Truong_019.Text,
                txt_Truong_020.Text?.Replace(",", ""),
                txt_Truong_021.Text?.Replace(",", ""),
                txt_Truong_022.Text?.Replace(",", ""),
                txt_Truong_023.Text?.Replace(",", ""),
                txt_Truong_024.Text?.Replace(",", ""),
                txt_Truong_025.Text,
                txt_Truong_026.Text,
                txt_Truong_027.Text,
                txt_Truong_028.Text,
                txt_Truong_029.Text,
                txt_Truong_030.Text,
                txt_Truong_031.Text,
                txt_Truong_032.Text,
                txt_Truong_033.Text,
                txt_Truong_034.Text,
                txt_Truong_035.Text,
                txt_Truong_036.Text,
                txt_Truong_0373839.Text,
                "",
                "",
                txt_Truong_040.Text,
                txt_Truong_0414243.Text,
                "",
                "",
                txt_Truong_044.Text,
                txt_Truong_045.Text?.Replace(",", ""),
                txt_Truong_046.Text?.Replace(",", ""),
                txt_Truong_047.Text?.Replace(",", ""),
                txt_Truong_048.Text?.Replace(",", ""),
                txt_Truong_049.Text?.Replace(",", ""),
                txt_Truong_050.Text?.Replace(",", ""),
                txt_Truong_051.Text,
                txt_Truong_052.Text,
                txt_Truong_053.Text?.Replace(",", ""),
                txt_Truong_054.Text,
                txt_Truong_055.Text,
                "",
                txt_Truong_057.Text,
                txt_Truong_058.Text?.Replace(",", ""),
                txt_Truong_059.Text?.Replace(",", ""),
                "",
                txt_Truong_061.Text,
                "",
                txt_Truong_063.Text,
                "",
                txt_Truong_065.Text,
                "",
                txt_Truong_067.Text,
                "",
                txt_Truong_069.Text,
                "",
                txt_Truong_071.Text,
                "",
                txt_Truong_073.Text,
                "",
                txt_Truong_075.Text);
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

                for (int i = txt.Text.Length - 1; i >= 0; i--){
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

        private void curency(TextEdit txt)
        {
            string t;
            if (txt.Text.Length > 0)
            {
                if (txt.Text.Substring(0, 1) == "-")
                {
                    if (txt.Text.Length > 1)
                    {
                        t = txt.Text.Substring(1, txt.Text.Length - 1);
                        if (txt.SelectionLength != txt.Text.Length)
                        {
                            if (txt.Text != "?")
                            {
                                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                                int valueBefore = Int32.Parse(t, System.Globalization.NumberStyles.AllowThousands);
                                txt.Text = "-" + String.Format(culture, "{0:N0}", valueBefore);
                                txt.Select(txt.Text.Length, 0);
                            }
                        }
                    }

                }
                else
                {
                    if (txt.SelectionLength != txt.Text.Length)
                    {
                        if (txt.Text != "?")
                        {
                            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                            int valueBefore = Int32.Parse(txt.Text, System.Globalization.NumberStyles.AllowThousands);
                            txt.Text = String.Format(culture, "{0:N0}", valueBefore);
                            txt.Select(txt.Text.Length, 0);
                        }
                    }
                }
            }
        }

        //private void txt_Truong_037_KeyUp(object sender, KeyEventArgs e)
        //{
        //    try
        //    {
        //        curency(txt_Truong_037);
        //    }
        //    catch
        //    {
        //    }
        //}

        //private void txt_Truong_041_KeyUp(object sender, KeyEventArgs e)
        //{
        //    try
        //    {
        //        curency((TextEdit)sender);
        //    }
        //    catch
        //    {
        //    }
        //}

        private void doimautrongkhoang(TextEdit txt, int so_nho, int so_lon)
        {
            if (txt.Text.Length > 0)
            {
                if (txt.Text != "?")
                {
                    if (txt.Text.Substring(0, 1) == "-")
                    {
                        if (txt.Text.Length >= so_nho && txt.Text.Length <= so_lon + 1)
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
                        if (txt.Text.Length >= so_nho && txt.Text.Length <= so_lon)
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
                }
                else
                {
                    txt.ForeColor = Color.Black;
                    txt.BackColor = Color.White;
                }
            }
            else
            {
                txt.ForeColor = Color.Black;
                txt.BackColor = Color.White;
            }
        }

        //private void txt_Truong_006_EditValueChanged(object sender, EventArgs e)
        //{
        //    doimautrongkhoang((TextEdit)sender, 0, 10);

        //    if (txt_Truong_006_.Text.Length == 10 || txt_Truong_006_.Text == "?" || string.IsNullOrEmpty(txt_Truong_006_.Text))
        //    {
        //        txt_Truong_006_.BackColor = Color.White;
        //        //luon luon bat dau bang so 4 hoac so 99
        //        if (txt_Truong_006_.Text.Length > 1)
        //            if (txt_Truong_006_.Text[0].ToString() != "4")
        //                if ((txt_Truong_006_.Text[0].ToString() + txt_Truong_006_.Text[1].ToString()) != "99")
        //                {
        //                    txt_Truong_006_.BackColor = Color.Red;
        //                }
        //    }
        //    else
        //        txt_Truong_006_.BackColor = Color.Red;

        //    if (Changed != null)
        //        Changed(sender, e);
        //}

        private void txt_Truong_009_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 10);
            if (Changed != null)
                Changed(sender, e);
        }

        //private void txt_Truong_008_EditValueChanged_1(object sender, EventArgs e)
        //{
        //    doimautrongkhoang((TextEdit)sender, 0, 25);

        //    if (!string.IsNullOrEmpty(txt_Truong_008_.Text))
        //    {
        //        if (txt_Truong_008_.Text.Length >= 2)
        //        {
        //            if (txt_Truong_008_.Text.Substring(txt_Truong_008_.Text.Length - 2, 2) == "  ")
        //            {
        //                txt_Truong_008_.BackColor = Color.Red;
        //                txt_Truong_008_.ForeColor = Color.White;
        //                bSubmit = true;
        //                txt_Truong_008_.Properties.MaxLength = txt_Truong_008_.Text.Length;
        //            }
        //            else
        //            {
        //                string result = lChar.Find(s => s == txt_Truong_008_.Text[txt_Truong_008_.Text.Length - 1].ToString());
        //                if (!string.IsNullOrEmpty(result))
        //                {
        //                    txt_Truong_008_.BackColor = Color.Red;
        //                    txt_Truong_008_.ForeColor = Color.White;
        //                    bSubmit = true;
        //                    txt_Truong_008_.Properties.MaxLength = txt_Truong_008_.Text.Length;
        //                }
        //                else
        //                {
        //                    txt_Truong_008_.BackColor = Color.White;
        //                    txt_Truong_008_.ForeColor = Color.Black;
        //                    bSubmit = false;
        //                    txt_Truong_008_.Properties.MaxLength = 0;
        //                    doimautrongkhoang((TextEdit)sender, 0, 25);
        //                }

        //            }

        //        }

        //        else
        //        {
        //            string result = lChar.Find(s => s == txt_Truong_008_.Text[txt_Truong_008_.Text.Length - 1].ToString());
        //            if (!string.IsNullOrEmpty(result))
        //            {
        //                txt_Truong_008_.BackColor = Color.Red;
        //                txt_Truong_008_.ForeColor = Color.White;
        //                bSubmit = true;
        //                txt_Truong_008_.Properties.MaxLength = txt_Truong_008_.Text.Length;
        //            }
        //            else
        //            {
        //                txt_Truong_008_.BackColor = Color.White;
        //                txt_Truong_008_.ForeColor = Color.Black;
        //                bSubmit = false;
        //                txt_Truong_008_.Properties.MaxLength = 0;
        //            }
        //        }

        //    }
        //    else
        //    {
        //        txt_Truong_008_.BackColor = Color.White;
        //        txt_Truong_008_.ForeColor = Color.Black;
        //        bSubmit = false;
        //        txt_Truong_008_.Properties.MaxLength = 0;
        //    }

        //    if (txt_Truong_008_.Text == "0")
        //    {
        //        txt_Truong_008_.BackColor = Color.Red;
        //        txt_Truong_008_.ForeColor = Color.White;
        //    }

        //    if (Changed != null)
        //        Changed(sender, e);
        //}

        //private void txt_Truong_003_EditValueChanged(object sender, EventArgs e)
        //{
        //    if (Lenght12(txt_Truong_003))
        //        txt_Truong_003.BackColor = Color.White;
        //    else
        //    {
        //        if (txt_Truong_003.Text.Length > 12)
        //            txt_Truong_003.BackColor = Color.Red;
        //        else
        //            txt_Truong_003.BackColor = Color.LimeGreen;
        //    }

        //    if (Changed != null)
        //        Changed(sender, e);
        //}
        

        //private void txt_Truong_158_EditValueChanged(object sender, EventArgs e)
        //{
        //    if (Lenght12(txt_Truong_158))
        //        txt_Truong_158.BackColor = Color.White;
        //    else
        //    {
        //        if (txt_Truong_158.Text.Length > 12)
        //            txt_Truong_158.BackColor = Color.Red;
        //        else
        //            txt_Truong_158.BackColor = Color.LimeGreen;
        //    }

        //    if (Changed != null)
        //        Changed(sender, e);
        //}
        

        //----------------------------------

        private void txt_Truong_001_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 25);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_002_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 12);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_004_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 11);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_005_EditValueChanged(object sender, EventArgs e)
        {
            
            doimautrongkhoang((TextEdit)sender, 0, 11);
            if (Changed != null)
                Changed(sender, e);

            //if (!(Lenght12(txt_Truong_005) || Lenght13(txt_Truong_005)) && (txt_Truong_005.Text.Length == 12 || txt_Truong_005.Text.Length == 13))
            //{
            //    txt_Truong_005.BackColor = Color.LimeGreen;
            //}
            //else

            //if (txt_Truong_005.Text.Length == 12)
            //{
            //    if (!Lenght12(txt_Truong_005))
            //        txt_Truong_005.BackColor = Color.LimeGreen;
            //}
            //else if (txt_Truong_005.Text.Length == 13)
            //    if (!Lenght13(txt_Truong_005))
            //        txt_Truong_005.BackColor = Color.LimeGreen;
        }

        private void txt_Truong_006_EditValueChanged_1(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 11);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_007_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 11);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_008_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 1);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_009_EditValueChanged_1(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 1);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_010_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 1);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_011_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 11);
            if (Changed != null)
                Changed(sender, e);
        }
        private void txt_Truong_012_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 1);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_013_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 1);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_014_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 1);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_015_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 2);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_016_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 2);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_017_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 1);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_018_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 1);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_019_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 1);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_020_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 11);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_021_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 11);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_022_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 11);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_023_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 11);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_024_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 11);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_025_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 1);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_026_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 1);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_027_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 1);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_028_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 1);
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

        private void txt_Truong_031_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 1);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_032_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 1);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_033_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 1);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_034_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 1);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_035_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 1);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_036_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 1);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong0373839_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(((TextEdit)sender).Text))
                if (((TextEdit)sender).Text!= "?")
                {
                    doimautrongkhoang((TextEdit)sender, 6, 6);
                }
                else
                {
                    doimautrongkhoang((TextEdit)sender, 0, 1);
                }
            
            else
            {
                doimautrongkhoang((TextEdit)sender, 0, 1);
            }
            
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_040_EditValueChanged(object sender, EventArgs e)
        {
            
            doimautrongkhoang((TextEdit)sender, 0, 1);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_0414243_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(((TextEdit)sender).Text))
            {
                if (((TextEdit)sender).Text != "?")
                {
                    doimautrongkhoang((TextEdit)sender, 6, 6);
                }
                else
                {
                    doimautrongkhoang((TextEdit)sender, 0, 1);
                }
            }
            else
            {
                doimautrongkhoang((TextEdit)sender, 0, 1);
            }
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_044_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 13);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_045_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 11);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_046_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 11);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_047_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 11);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_048_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 11);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_049_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 11);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_050_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 11);
            if (Changed != null)
                Changed(sender, e);
        }
        private void txt_Truong_051_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 7);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_052_EditValueChanged(object sender, EventArgs e)
        {
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_052_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Back || e.KeyData == Keys.Delete)
            {
                txt_Truong_052.ItemIndex = 0;
                e.Handled = true;
            }
        }

        private void txt_Truong053_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 11);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_054_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 7);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_055_EditValueChanged(object sender, EventArgs e)
        {
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_055_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Back || e.KeyData == Keys.Delete)
            {
                txt_Truong_055.ItemIndex = 0;
                e.Handled = true;
            }
        }

        private void txt_Truong_057_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 12);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_058_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 11);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_059_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 11);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_061_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 12);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_063_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 12);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_065_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 12);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_067_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 12);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_069_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 12);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_071_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 12);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_073_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 12);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_075_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 12);
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_004_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                curency((TextEdit)sender);
            }
            catch
            {
            }
        }

        private void txt_Truong_005_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                curency(txt_Truong_005);
            }
            catch
            {
            }
        }

        private void txt_Truong_006_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                curency(txt_Truong_006);
            }
            catch
            {
            }
        }

        private void txt_Truong_007_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                curency(txt_Truong_007);
            }
            catch
            {
            }
        }
    }
}