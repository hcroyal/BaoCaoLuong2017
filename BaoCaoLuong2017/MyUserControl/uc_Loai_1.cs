using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BaoCaoLuong2017;

namespace BaoCaoLuonng2017.MyUserControl
{
    public delegate void AllTextChange(object sender, EventArgs e);
    public partial class uc_Loai_1 : UserControl
    {
        public event AllTextChange Changed;
        public uc_Loai_1()
        {
            InitializeComponent();
        }
        public void ResetData()
        {
            txt_Truong_001.Text = "";
            txt_Truong_001.BackColor = Color.White;
            txt_Truong_002.Text = "";
            txt_Truong_002.BackColor = Color.White;
        }

        public bool IsEmpty()
        {
            if (string.IsNullOrEmpty(txt_Truong_001.Text)&&
                string.IsNullOrEmpty(txt_Truong_002.Text))
                return true;
            return false;
        }

        public void SetValue(string truong_001, string truong_002)
        {
            txt_Truong_001.Text = truong_001;
            txt_Truong_002.Text = truong_002;
        }

        private void DoiMau(int soByteBe, int soBytelon, TextEdit textBox)
        {
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                if (textBox.Text != "?")
                {
                    if (textBox.Text.Length >= soByteBe && textBox.Text.Length <= soBytelon)
                    {
                        textBox.BackColor = Color.White;
                        textBox.ForeColor = Color.Black;
                    }
                    else
                    {
                        textBox.BackColor = Color.Red;
                        textBox.ForeColor = Color.White;
                    }
                }
                else
                {
                    textBox.BackColor = Color.White;
                    textBox.ForeColor = Color.Black;
                }
            }
            else
            {
                textBox.BackColor = Color.White;
                textBox.ForeColor = Color.Black;
            }
        }
        
        public void SaveData_Loai_1(string idimage)
        {
            Global.db_BCL.Insert_Loai1(idimage,Global.StrBatch,Global.StrUsername,txt_Truong_001.Text,txt_Truong_002.Text);
        }
        private void txt_Truong_001_TextChanged(object sender, EventArgs e)
        {
            if (Changed != null)
                Changed(sender, e);
            if (txt_Truong_001.Text == "06" || txt_Truong_001.Text == "07")
            {
                txt_Truong_002.Enabled = true;
            }
            else
            {
                txt_Truong_002.Text = "";
                txt_Truong_002.Enabled = false;
            }
        }

    }
}
