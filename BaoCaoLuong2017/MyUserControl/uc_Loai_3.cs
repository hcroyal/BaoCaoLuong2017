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
    public partial class uc_Loai_3 : UserControl
    {
        public uc_Loai_3()
        {
            InitializeComponent();
        }
        public void ResetData()
        {
            txt_Truong_002.Text = string.Empty;
            txt_Truong_002.BackColor = Color.White;
            txt_Truong_003.Text = string.Empty;
            txt_Truong_003.BackColor = Color.White;

        }

        public bool IsEmpty()
        {
            if (string.IsNullOrEmpty(txt_Truong_002.Text)&&
                string.IsNullOrEmpty(txt_Truong_003.Text))
                return true;
            return false;
        }

        public void SetValue(string truong_001,string truong_002,string truong_003)
        {
            txt_Truong_002.Text = truong_002;
            txt_Truong_003.Text = truong_003;
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
        
    }
}
