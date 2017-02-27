using BaoCaoLuonng2017.MyUserControl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BaoCaoLuong2017.MyUserControl
{
    public partial class uc_DEJP : UserControl
    {
        public event AllTextChange Changed;

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

        public uc_DEJP()
        {
            InitializeComponent();
        }

        private void uc_DEJP_Load(object sender, EventArgs e)
        {
        }

        public void setRandom()
        {
            Random rd = new Random();
            txt_Truong_002.Text = rd.Next(40, 700).ToString();
        }

        public void ResetData()
        {
            txt_Truong_001.Text = string.Empty;
            txt_Truong_002.Text = string.Empty;
            txt_Truong_003.Text = string.Empty;
            txt_Truong_004.Text = string.Empty;
            txt_Truong_005.Text = string.Empty;
            txt_Truong_006.Text = string.Empty;
            txt_Truong_007.Text = string.Empty;
            txt_Truong_008.Text = string.Empty;
            txt_Truong_009.Text = string.Empty;
            txt_Truong_010.Text = string.Empty;

            txt_Truong_001.BackColor = Color.White;
            txt_Truong_002.BackColor = Color.White;
            txt_Truong_003.BackColor = Color.White;
            txt_Truong_004.BackColor = Color.White;
            txt_Truong_005.BackColor = Color.White;
            txt_Truong_006.BackColor = Color.White;
            txt_Truong_007.BackColor = Color.White;
            txt_Truong_008.BackColor = Color.White;
            txt_Truong_009.BackColor = Color.White;
            txt_Truong_010.BackColor = Color.White;

        }

        public bool IsEmpty()
        {
            if (string.IsNullOrEmpty(txt_Truong_001.Text) &&
                 string.IsNullOrEmpty(txt_Truong_002.Text) &&
                 string.IsNullOrEmpty(txt_Truong_003.Text) &&
                 string.IsNullOrEmpty(txt_Truong_004.Text) &&
                 string.IsNullOrEmpty(txt_Truong_005.Text) &&
                 string.IsNullOrEmpty(txt_Truong_006.Text) &&
                 string.IsNullOrEmpty(txt_Truong_007.Text) &&
                 string.IsNullOrEmpty(txt_Truong_008.Text) &&
                 string.IsNullOrEmpty(txt_Truong_009.Text) &&
                 string.IsNullOrEmpty(txt_Truong_010.Text)
                )
                return true;
            return false;
        }
        private void doimautrongkhoang(TextEdit txt, int so_nho, int so_lon)
        {
            if (!string.IsNullOrEmpty(txt.Text))
            {
                if (txt.Text.Length >= 2)
                {
                    if (txt.Text.Substring(txt.Text.Length - 2, 2) == "  ")
                    {
                        txt.BackColor = Color.Red;
                        txt.ForeColor = Color.White;
                        bSubmit = true;
                        txt.Properties.MaxLength = txt.Text.Length;
                    }
                    else
                    {
                        string result = lChar.Find(s => s == txt.Text[txt.Text.Length - 1].ToString());
                        if (!string.IsNullOrEmpty(result))
                        {
                            txt.BackColor = Color.Red;
                            txt.ForeColor = Color.White;
                            bSubmit = true;
                            txt.Properties.MaxLength = txt.Text.Length;
                        }
                        else
                        {
                            txt.BackColor = Color.White;
                            txt.ForeColor = Color.Black;
                            bSubmit = false;
                            txt.Properties.MaxLength = 0;
                        }
                    }
                }
                else
                {
                    string result = lChar.Find(s => s == txt.Text[txt.Text.Length - 1].ToString());
                    if (!string.IsNullOrEmpty(result))
                    {
                        txt.BackColor = Color.Red;
                        txt.ForeColor = Color.White;
                        bSubmit = true;
                        txt.Properties.MaxLength = txt.Text.Length;
                    }
                    else
                    {
                        txt.BackColor = Color.White;
                        txt.ForeColor = Color.Black;
                        bSubmit = false;
                        txt.Properties.MaxLength = 0;
                    }
                }

            }
            else
            {
                txt.BackColor = Color.White;
                txt.ForeColor = Color.Black;
                bSubmit = false;
                txt.Properties.MaxLength = 0;
            }
        }
        private void txt_Truong_002_EditValueChanged(object sender, EventArgs e)
        {
            doimautrongkhoang((TextEdit)sender, 0, 25);
            
            if (Changed != null)
                Changed(sender, e);
        }

        public void SaveData_DEJP(string idimage)
        {
            Global.db_BCL.Insert_DEJP(idimage, Global.StrBatch, Global.StrUsername, txt_Truong_002.Text);
        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }
    }
}