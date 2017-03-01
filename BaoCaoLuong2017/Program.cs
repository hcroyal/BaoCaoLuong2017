﻿using BaoCaoLuong2017.MyForm;
using BaoCaoLuong2017.Properties;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using LibraryLogin;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BaoCaoLuong2017
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle(Settings.Default.ApplicationSkinName);
            //Application.Run(new frm_Main());
            bool temp;
            do
            {
                temp = false;
                Frm_Login a = new Frm_Login();
                a.lb_programName.Text = "           Dự Án\n           Báo Cáo Lương 2017 City S";
                a.lb_vision.Text = "Phiên bản :";
                a.grb_1.Text = "Thông Tin PC";
                a.lb_machine.Text = "Tên PC :";
                a.lb_user_window.Text = "Tài khoản window:";
                a.lb_ip.Text = "Địa chỉ IP :";
                a.grb_2.Text = "Thông Tin Tài Khoản Đăng Nhập";
                a.lb_username.Text = "Tên đăng nhập :";
                a.lb_password.Text = "Mật khẩu :";
                a.lb_role.Text = "Vai trò :";
                a.lb_date.Text = "Ngày: ";
                a.lb_time.Text = "Giờ: ";
                a.lb_batchno.Text = "BatchName: ";
                a.btn_thoat.Text = "Thoát";
                a.chb_hienthi.Text = "Hiển Thị";
                a.chb_luu.Text = "Lưu";
                a.lb_version.Text = @"1.7";
                a.UrlUpdateVersion = @"\\10.10.10.254\DE_Viet\2017\BAO-CAO-LUONG-TP_S";
                a.LoginEvent += a_LoginEvent;
                a.ButtonLoginEven += a_ButtonLoginEven;
                if (a.ShowDialog() == DialogResult.OK)
                {
                    Global.StrMachine = a.StrMachine;
                    Global.StrUserWindow = a.StrUserWindow;
                    Global.StrIpAddress = a.StrIpAddress;
                    Global.StrUsername = a.StrUserName; Global.StrBatch = a.StrBatch;
                    Global.StrRole = a.StrRole;
                    Global.Strtoken = a.Token;
                    frm_Main f = new frm_Main();
                    if (f.ShowDialog() == DialogResult.Yes)
                    {
                        f.Close();
                        temp = true;
                    }
                }
            }
            while (temp);
        }

        private static void a_ButtonLoginEven(int iLogin, string strMachine, string strUserWindow, string strIpAddress, string strUsername, string password, string strBatch, string strRole, string strToken, ref bool LoginOk)
        {
            if (iLogin == 1)
            {
                //Kiểm tra Token

                bool has = Global.db_BPO.tbl_TokenLogins.Any(w => w.UserName == strUsername && w.IDProject == Global.StrIdProject);
                if (has)
                {
                    var token = (from w in Global.db_BPO.tbl_TokenLogins where w.UserName == strUsername && w.IDProject == Global.StrIdProject select w.Token).FirstOrDefault();
                    if (token == "")
                    {
                        Global.db_BPO.updateToken(strUsername, Global.StrIdProject, strToken);
                        Global.db_BPO.InsertLoginTime(strUsername, DateTime.Now, strUserWindow, strMachine, strIpAddress, strToken);
                        LoginOk = true;
                    }
                    else
                    {
                        if (MessageBox.Show("User này đã đăng nhập ở máy khác. Bạn có muốn tiếp tục đăng nhập?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Global.db_BPO.updateToken(strUsername, Global.StrIdProject, strToken);
                            Global.db_BPO.InsertLoginTime(strUsername, DateTime.Now, strUserWindow, strMachine, strIpAddress, strToken);
                            LoginOk = true;
                        }
                        else
                        {
                            LoginOk = false;
                        }
                    }
                }
                else
                {
                    var token = new tbl_TokenLogin();
                    token.UserName = strUsername;
                    token.IDProject = Global.StrIdProject;
                    token.Token = "";
                    token.DateLogin = DateTime.Now;
                    Global.db_BPO.tbl_TokenLogins.InsertOnSubmit(token);
                    Global.db_BPO.SubmitChanges();
                    LoginOk = true;
                    Global.db_BPO.updateToken(strUsername, Global.StrIdProject, strToken);
                    Global.db_BPO.InsertLoginTime(strUsername, DateTime.Now, strUserWindow, strMachine, strIpAddress, strToken);
                }
            }
        }

        private static void a_LoginEvent(string username, string password, ref string strVersion, ref int iKiemtraLogin, ref string role, ref ComboBox cbb)
        {
            try
            {
                iKiemtraLogin = Global.db_BPO.KiemTraLogin(username, password);
                strVersion = (from w in Global.db_BPO.tbl_Versions where w.IDProject == Global.StrIdProject select w.IDVersion).FirstOrDefault();
                role = (from w in Global.db_BPO.tbl_Users where w.Username == username select w.IDRole).FirstOrDefault();
                if (!string.IsNullOrEmpty(role))
                    role = role.ToUpper();
                if (iKiemtraLogin == 1 && role == "ADMIN")
                {
                    cbb.DataSource = Global.db_BCL.GetBatch();
                    cbb.DisplayMember = "fBatchName";
                }
                else if (iKiemtraLogin == 1 && role == "DEJP")
                {
                    cbb.DataSource = Global.db_BCL.GetBatNotFinishDeJP(username);
                    cbb.DisplayMember = "fBatchName";
                }
                else if (iKiemtraLogin == 1 && role == "DESO")
                {
                    cbb.DataSource = Global.db_BCL.GetBatNotFinishDeSo(username);
                    cbb.DisplayMember = "fBatchName";
                }
                else if (iKiemtraLogin == 1 && role == "CHECKERDEJP")
                {
                    cbb.DataSource = Global.db_BCL.GetBatNotFinishCheckerDeJP(username);
                    cbb.DisplayMember = "fBatchName";
                }
                else if (iKiemtraLogin == 1 && role == "CHECKERDESO")
                {
                    cbb.DataSource = Global.db_BCL.GetBatNotFinishCheckerDeSo(username);
                    cbb.DisplayMember = "fBatchName";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error connecting to server, please check your connection Internet\r\n" + e.Message);
            }
        }
    }
}