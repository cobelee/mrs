using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MRS.SettingModule
{
    public partial class SettingMain : Form
    {
        MRS.BLL.Account bllAccount;
        MRS.BLL.HspType bllHspType;
        MRS.BLL.MPeriod bllMPeriod;
        
        public SettingMain()
        {
            InitializeComponent();
            InitSettingMain();

            gvAccountBind();
            gvHspTypeBind();
            gvMPeriodBind();
            
        }

        public void InitSettingMain()
        {
            bllAccount = new MRS.BLL.Account();
            bllHspType = new MRS.BLL.HspType();
            bllMPeriod = new MRS.BLL.MPeriod();
        }

        protected void gvAccountBind()
        {
            gvAccount.DataSource = bllAccount.GetAccountAll();
            gvAccount.Columns[2].Visible = false;
        }

        protected void gvHspTypeBind()
        {
            gvHspType.DataSource = bllHspType.GetHspTypeAll();
            gvHspType.Columns[1].HeaderText = "就诊方式";
        }

        protected void gvMPeriodBind()
        {
            gvMPeriod.DataSource = bllMPeriod.GetMPeriodAll();

        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string UserType = BLL.UserType.Accountant.ToString();
            
            switch (cbUserType.SelectedIndex)
            {
                case 0 : UserType = BLL.UserType.Accountant.ToString();
                    break;
                case 1 : UserType = BLL.UserType.Cashier.ToString();
                    break;
                case 2 : UserType = BLL.UserType.Administrator.ToString();
                    break;
            }



            if (tbPassword1.Text == tbPassword2.Text)
            {
                bllAccount.AddAccount(tbUserName.Text, tbPassword1.Text, UserType, tbTrueName.Text);

                gvAccountBind();
                tbUserName.Text = "";
                tbPassword1.Text = "";
                tbPassword2.Text = "";
            }
            else
            {
                MessageBox.Show("输入密码与确认密码不一致，请重新输入！", "输入错误",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("将要删除账号，是否继续？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int accountId;
                accountId = Convert.ToInt32(gvAccount.SelectedRows[0].Cells[2].Value);
                bllAccount.DeleteAccount(accountId);
                gvAccountBind();

            }
        }

        private void btnAddHspType_Click(object sender, EventArgs e)
        {
            if (tbHspType.Text != "")
            {
                bllHspType.AddHspType(tbHspType.Text);
                gvHspTypeBind();
                tbHspType.Text = "";
            }
            else
            {
                MessageBox.Show("请输入数据！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteHspType_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("将要删除记录，是否继续？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int hspTypeId;
                hspTypeId = Convert.ToInt32(gvHspType.SelectedRows[0].Cells[0].Value);
                bllHspType.DeleteHspType(hspTypeId);
                gvHspTypeBind();
            }

        }

        private void mcBeginDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            tbBeginDate.Text = e.Start.ToShortDateString();
        }

        private void mcEndDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            tbEndDate.Text = e.Start.ToShortDateString();
        }

        private void btnAddMPeriod_Click(object sender, EventArgs e)
        {
            if (tbMPeriod.Text != "" && tbBeginDate.Text != "" && tbEndDate.Text != "")
            {
                DateTime beginDate, endDate;
                beginDate = Convert.ToDateTime(tbBeginDate.Text);
                endDate = Convert.ToDateTime(tbEndDate.Text);
                bllMPeriod.AddMPeriod(tbMPeriod.Text, beginDate, endDate);
                gvMPeriodBind();
                tbMPeriod.Text = "";
            }
            else
            {
                MessageBox.Show("输入数据不充分。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteMPeriod_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("将要删除记录，是否继续？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int mPeriodId;
                mPeriodId = Convert.ToInt32(gvMPeriod.SelectedRows[0].Cells[2].Value);
                bllMPeriod.DeleteMPeriod(mPeriodId);
                gvMPeriodBind();
            }
        }

        private void 系统配置SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingModule.Option option = new Option();
            option.ShowDialog();
        }
    }
}