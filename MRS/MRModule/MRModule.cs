using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MRS.MRModule
{
    public partial class MRModule : Form
    {
        public ShowAccountDelegate ShowAccountant;


        public MRModule()
        {
            InitializeComponent();
            ShowAccountant += new ShowAccountDelegate(Show_Account);
        }

        private void msExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "确认要退出系统吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void msBaoXiao_Click(object sender, EventArgs e)
        {

            BXForm bxForm = new BXForm();
            bxForm.MdiParent = this;
            bxForm.Show();
            bxForm.WindowState = FormWindowState.Maximized;
            bxForm.ShowAccountant(tslbAccountant.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        public void Show_Account(string AccountantName)
        {
            this.tslbAccountant.Text = AccountantName;
        }

        private void msIndividualQuery_Click(object sender, EventArgs e)
        {
            //IndividualQuery frmIndividualQuery = new IndividualQuery();
            //frmIndividualQuery.MdiParent = this;
            //frmIndividualQuery.Show();
            //frmIndividualQuery.WindowState = FormWindowState.Maximized;
        }

        private void Balance_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Balance balanceForm = new Balance();
            balanceForm.MdiParent = this;
            balanceForm.Show();
            balanceForm.WindowState = FormWindowState.Maximized;
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void menuItemPersonInfo_Click(object sender, EventArgs e)
        {
            PersonInfo personInfo = new PersonInfo();
            personInfo.MdiParent = this;
            personInfo.Show();
            personInfo.WindowState = FormWindowState.Normal;
        }

        private void 报销比例查询RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //BXRatioQuery bxRatio = new BXRatioQuery();
            //bxRatio.MdiParent = this;
            //bxRatio.Show();
            //bxRatio.WindowState = FormWindowState.Maximized;
        }

        private void 技术支持TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TechnicalSupport sup = new TechnicalSupport();
            sup.ShowDialog(this);
        }

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CUModule.AboutMRS about = new MRS.CUModule.AboutMRS();
            about.ShowDialog(this);
        }
    }
}