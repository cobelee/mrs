using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MRS.BLL;

namespace MRS
{
    public delegate void ShowAccountDelegate(string AccountName);

    public partial class Login : Form
    {
        //MRModule.MRModule mrModule;
        MRModule.BxMain mrBxMain;
        SettingModule.SettingMain settingMain;
        CUModule.MDIMain cuMain;
        MRS.BLL.Account bllAccount;

        public Login()
        {
            InitializeComponent();
            Init_Login_From();
            cbUserType.SelectedIndex = 0;
            tbUserName.Focus();
        }

        protected void Init_Login_From()
        {
            //mrModule = new MRModule.MRModule();
            mrBxMain = new MRModule.BxMain();
            settingMain = new MRS.SettingModule.SettingMain();
            cuMain = new MRS.CUModule.MDIMain();
            bllAccount = new MRS.BLL.Account();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string UserType = BLL.UserType.Accountant.ToString();
            switch (cbUserType.SelectedIndex)
            {
                case 0: UserType = BLL.UserType.Accountant.ToString();
                    break;
                case 1: UserType = BLL.UserType.Cashier.ToString();
                    break;
                case 2: UserType = BLL.UserType.Administrator.ToString();
                    break;
            }
            if (Authentication.Authenticate(tbUserName.Text, tbPassword.Text, UserType))
            {
                MRS.Model.Account account = new MRS.Model.Account();
                account = bllAccount.GetAccountByUserName(tbUserName.Text);
                switch (UserType)
                {
                    case "Accountant":
                        //mrModule.Show();
                        //mrModule.ShowAccountant(account.TrueName);
                        mrBxMain.Show();
                        mrBxMain.WindowState = FormWindowState.Maximized;
                        mrBxMain.ShowAccountant(account.TrueName);
                        break;
                    case "Cashier": cuMain.Show();
                        cuMain.ShowCashier(account.TrueName);
                        break;
                    case "Administrator": settingMain.Show();
                        break;
                }

                this.Visible = false;
            }
            else
            {
                MessageBox.Show("用户名或密码错误");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }


    }
}