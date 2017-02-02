using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BaoCaoLuonng2017.MyUserControl;
using System.Collections.Generic;

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

                    txt.BackColor = Color.Red;

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
                    txt.BackColor = Color.Red;
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
        private void txt_Truong_003_TextChanged(object sender, EventArgs e)
        {
            if (txt_Truong_003.Text.Length == 10 || txt_Truong_003.Text == "?" || string.IsNullOrEmpty(txt_Truong_003.Text))
            {
                txt_Truong_003.BackColor = Color.White;
                //luon luon bat dau bang so 4 hoac so 99
                if(txt_Truong_003.Text.Length > 1)
                if (txt_Truong_003.Text[0].ToString() != "4")
                        if((txt_Truong_003.Text[0].ToString() + txt_Truong_003.Text[1].ToString()) != "99")
                {
                    txt_Truong_003.BackColor = Color.Red;
                }
                
            }
            
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

            
               


            //if (!(Lenght12(txt_Truong_004) || Lenght13(txt_Truong_004)) && (txt_Truong_004.Text.Length == 12 || txt_Truong_004.Text.Length == 13))
            //{
            //    txt_Truong_004.BackColor = Color.LimeGreen;
            //}
            //else
            //{
                if (txt_Truong_004.Text.Length == 12 || txt_Truong_004.Text.Length == 13 || txt_Truong_004.Text == "?" || string.IsNullOrEmpty(txt_Truong_004.Text))
                    txt_Truong_004.BackColor = Color.White;
                else
                    txt_Truong_004.BackColor = Color.Red;
            //}


            if (txt_Truong_004.Text.Length == 12)
            {
                if (!Lenght12(txt_Truong_004))
                    txt_Truong_004.BackColor = Color.LimeGreen;
            }
            else
                if(txt_Truong_004.Text.Length == 13)
                    if(!Lenght13(txt_Truong_004))
                    txt_Truong_004.BackColor = Color.LimeGreen;

            //txt_Truong_004.BackColor = Color.White;
        }

        private void txt_Truong_004_EditValueChanged(object sender, EventArgs e)
        {

        }


    }
}
