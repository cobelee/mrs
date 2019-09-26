using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MRS.MRModule
{
    public partial class BxMain : Form
    {
        private string ybh;
        private int bxdId;

        protected PMS.BLL.MedicarePerson bll_mPerson = new PMS.BLL.MedicarePerson();
        public ShowAccountDelegate ShowAccountant;
        public event EventHandler YbhChanged;
        public event EventHandler BxdListChanged;

        public BxMain()
        {
            InitializeComponent();

            ShowAccountant += new ShowAccountDelegate(Show_Account);
            this.YbhChanged += new EventHandler(BxMain_YbhChanged);
            tabWorkSpace.TabPages.Clear();
            ActiveTabBxdList();
        }

        void BxMain_YbhChanged(object sender, EventArgs e)
        {
            lbYbh.Text = this.ybh;
            PMS.Model.MedicarePerson mPerson = bll_mPerson.GetMedicarePerson(this.ybh);
            lbBxrName.Text = mPerson.Name;
        }

        #region 属性
        public string Ybh
        {
            get { return ybh; }
            set
            {
                if (ybh != value)
                {
                    ybh = value;
                    if (YbhChanged != null)
                    {
                        YbhChanged(this, new EventArgs());
                    }
                }
            }
        }

        public int BxdId
        {
            get { return bxdId; }
            set
            {
                if (bxdId != value)
                {
                    bxdId = value;
                    lbBxdId.Text = bxdId.ToString();
                }
            }
        }
        #endregion

        public void Show_Account(string AccountantName)
        {
            this.tslbAccountant.Text = AccountantName;
        }

        //退出系统
        private void BxMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show(this, "确认要退出系统吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //新建报销单。
        private void btnNewBx_Click(object sender, EventArgs e)
        {
            BXForm bxForm = new BXForm();
            bxForm.BxdCreated += new BxdSelectedDelegate(BxdList_Update);
            bxForm.BxdUpdated += new BxdSelectedDelegate(BxdList_Update);
            bxForm.Show(this);
            bxForm.WindowState = FormWindowState.Maximized;
            bxForm.ShowAccountant(tslbAccountant.Text);
        }

        public void BxdList_Update(object sender, BxdSelectedEventArgs e)
        {
            if (this.BxdListChanged != null)
            {
                this.BxdListChanged(sender, (e as EventArgs));
            }
        }


        private void btnIndividualQuery_Click(object sender, EventArgs e)
        {
            ActiveTabIndividualQuery(string.Empty);
        }

        private void btnPersonInfo_Click(object sender, EventArgs e)
        {
            PersonInfo personInfo = new PersonInfo();
            personInfo.SetYbh(this.ybh);
            personInfo.Show(this);
            personInfo.WindowState = FormWindowState.Normal;
        }

        private void btnLastBxdList_Click(object sender, EventArgs e)
        {
            ActiveTabBxdList();
        }

        public void ActiveTabBxdList()
        {
            bool hasLastBxdListPage = false;
            foreach (TabPage tabPage in tabWorkSpace.TabPages)
            {
                if (tabPage.Text == "近期报销记录")
                {
                    tabWorkSpace.SelectedTab = tabPage;
                    hasLastBxdListPage = true;
                }
            }

            if (hasLastBxdListPage == false)
            {
                TabPage tabPage = new TabPage("近期报销记录");
                UC.BxdList bxdList = new UC.BxdList();
                bxdList.BxdSelected += new MRS.BxdSelectedDelegate(bxdList_BxdSelect);
                //bxdList.BxdDoubleClicked += new BxdSelectedDelegate(bxdList_BxdSelect);
                this.BxdListChanged += new EventHandler(bxdList.BxdList_DataBind);
                tabPage.Controls.Clear();
                tabPage.Controls.Add(bxdList as Control);
                tabPage.ToolTipText = "双击可关闭选项卡";
                bxdList.Dock = DockStyle.Fill;
                tabWorkSpace.TabPages.Add(tabPage);
                tabWorkSpace.SelectedTab = tabPage;
            }
        }

        protected void bxdList_BxdSelect(object sender, BxdSelectedEventArgs e)
        {
            MRS.BLL.BXD bll_bxd = new BLL.BXD();
            MRS.Model.BXD bxd = bll_bxd.GetBXD_By_BXDId(e.BxdId);
            this.BxdId = e.BxdId;
            this.Ybh = bxd.YBH;
        }

        public void ActiveTabIndividualQuery(string ybh)
        {
            string tabPageText = string.Empty;
            if (!string.IsNullOrEmpty(ybh))
            {
                PMS.BLL.MedicarePerson bll_person = new PMS.BLL.MedicarePerson();
                PMS.Model.MedicarePerson person = bll_person.GetMedicarePerson(ybh);
                tabPageText = person.Name + ybh;
            }
            else
            {
                tabPageText = "个人报销记录查询";
            }
            bool hasYbh = false;
            foreach (TabPage tabPage in tabWorkSpace.TabPages)
            {
                if (tabPage.Text == tabPageText)
                {
                    tabWorkSpace.SelectedTab = tabPage;
                    hasYbh = true;
                }
            }

            if (hasYbh == false)
            {
                TabPage tabPage = new TabPage(tabPageText);
                UC.IndividualQuery iq = new UC.IndividualQuery();
                iq.SetYbh(this.ybh);
                tabPage.Controls.Clear();
                tabPage.Controls.Add(iq as Control);
                tabPage.ToolTipText = "双击可关闭选项卡";
                iq.Dock = DockStyle.Fill;
                tabWorkSpace.TabPages.Add(tabPage);
                tabWorkSpace.SelectedTab = tabPage;
            }
        }

        /// <summary>
        /// 激活 医保报销比例 页
        /// </summary>
        public void ActiveTabRatioQuery()
        {
            bool hasRatioPage = false;
            string tabPageName = "医保报销比例";
            foreach (TabPage tabPage in tabWorkSpace.TabPages)
            {
                if (tabPage.Text == tabPageName)
                {
                    tabWorkSpace.SelectedTab = tabPage;
                    hasRatioPage = true;
                }
            }

            if (hasRatioPage == false)
            {
                TabPage tabPage = new TabPage(tabPageName);
                UC.BXRatioQuery ratioQuery = new UC.BXRatioQuery();
                tabPage.Controls.Add(ratioQuery as Control);
                tabPage.ToolTipText = "双击可关闭选项卡";
                ratioQuery.Dock = DockStyle.Fill;
                tabWorkSpace.TabPages.Add(tabPage);
                tabWorkSpace.SelectedTab = tabPage;
            }
        }

        private void tabWorkSpace_DoubleClick(object sender, EventArgs e)
        {
            tabWorkSpace.TabPages.Remove(tabWorkSpace.SelectedTab);
        }

        private void btnQueryRatio_Click(object sender, EventArgs e)
        {
            ActiveTabRatioQuery();
        }

        private void lklbAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TechnicalSupport sup = new TechnicalSupport();
            sup.ShowDialog(this);
        }

        private void lklbAbout_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CUModule.AboutMRS about = new MRS.CUModule.AboutMRS();
            about.ShowDialog(this);
        }

    }
}
