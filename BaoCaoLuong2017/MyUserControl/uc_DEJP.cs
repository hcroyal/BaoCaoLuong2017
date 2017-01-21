using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BaoCaoLuonng2017.MyUserControl;

namespace BaoCaoLuong2017.MyUserControl
{
    public partial class uc_DEJP : UserControl{
        public event AllTextChange Changed;
        public uc_DEJP()
        {
            InitializeComponent();
        }

        private void uc_DEJP_Load(object sender, EventArgs e)
        {

        }
        public void ResetData()
        {
            txt_Truong_002.Text = string.Empty;
            txt_Truong_002.BackColor = Color.White;
        }
        public bool IsEmpty()
        {
            if (string.IsNullOrEmpty(txt_Truong_002.Text))
                return true;
            return false;
        }

        private void txt_Truong_002_EditValueChanged(object sender, EventArgs e)
        {
            if (Changed != null)
                Changed(sender, e);}
        public void SaveData_DEJP(string idimage)
        {
            Global.db_BCL.Insert_DEJP(idimage, Global.StrBatch, Global.StrUsername, txt_Truong_002.Text);
        }
    }
}
