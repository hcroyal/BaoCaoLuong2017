using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

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
            txt_Truong_001.Text = string.Empty;
            txt_Truong_001.BackColor = Color.White;
        }

        public bool IsEmpty()
        {
            if (string.IsNullOrEmpty(txt_Truong_001.Text))
                return true;
            return false;
        }

        public void SetValue(string truong01)
        {
            txt_Truong_001.Text = truong01;
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

        private void txt_Truong_001_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txt_Truong_002_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar) || e.KeyChar == '1'|| e.KeyChar=='2'))
            {
                e.Handled = true;
            }
        }
    }
}
