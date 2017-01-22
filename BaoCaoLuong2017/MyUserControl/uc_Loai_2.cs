using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BaoCaoLuonng2017.MyUserControl;

namespace BaoCaoLuong2017.MyUserControl
{
    public partial class uc_Loai_2 : UserControl
    {
        public event AllTextChange Changed;
        public uc_Loai_2()
        {
            InitializeComponent();
        }
        public void ResetData()
        {
            txt_Truong_002.Text = string.Empty;
            txt_Truong_002.BackColor = Color.White;
            txt_Truong_003.Text = string.Empty;
            txt_Truong_003.BackColor = Color.White;
            txt_Truong_004.Text = string.Empty;
            txt_Truong_004.BackColor = Color.White;
        }

        public bool IsEmpty()
        {
            if (string.IsNullOrEmpty(txt_Truong_002.Text)&&
                string.IsNullOrEmpty(txt_Truong_003.Text)&&
                string.IsNullOrEmpty(txt_Truong_004.Text))
                return true;
            return false;
        }
        public void SaveData_Loai_2(string idimage)
        {
            Global.db_BCL.Insert_Loai2(idimage, Global.StrBatch, Global.StrUsername, txt_Truong_002.Text, txt_Truong_003.Text, txt_Truong_004.Text);
        }
       
        private void txt_Truong_003_TextChanged(object sender, EventArgs e)
        {
            if (txt_Truong_003.Text.Length == 10 || txt_Truong_003.Text == "?" || string.IsNullOrEmpty(txt_Truong_003.Text))
                txt_Truong_003.BackColor = Color.White;
            else
                txt_Truong_003.BackColor = Color.Red;
            if (Changed != null)
                Changed(sender, e);
        }
        
        private void txt_Truong_002_TextChanged(object sender, EventArgs e)
        {
            if (txt_Truong_002.Text.Length == 12 || txt_Truong_002.Text == "?" || string.IsNullOrEmpty(txt_Truong_002.Text))
                txt_Truong_002.BackColor = Color.White;
            else
                txt_Truong_002.BackColor = Color.Red;
            if (Changed != null)
                Changed(sender, e);
        }

        private void txt_Truong_004_TextChanged(object sender, EventArgs e)
        {
            if (Changed != null)
                Changed(sender, e);
        }

       
    }
}
