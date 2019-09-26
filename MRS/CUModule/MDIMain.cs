using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MRS.CUModule
{
    public partial class MDIMain : Form
    {
        public ShowAccountDelegate ShowCashier;

        public MDIMain()
        {
            InitializeComponent();
            ShowCashier += new ShowAccountDelegate(Show_Cashier);
        }

        protected void Show_Cashier(string CashierName)
        {
            tslbCashier.Text = CashierName;
        }




        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutMRS aboutForm = new AboutMRS();
            aboutForm.ShowDialog();
        }

        private void ChargeUp_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChargeUpForm cuForm = new ChargeUpForm();
            cuForm.MdiParent = this;
            cuForm.ShowCashier(tslbCashier.Text);
            cuForm.Show();
        }

        private void PaymentList_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentForm plForm = new PaymentForm();
            plForm.MdiParent = this;
            plForm.WindowState = FormWindowState.Maximized;
            plForm.Show();
        }

        private void zhjfylfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportZHJFYLF reportForm = new ReportZHJFYLF();
            reportForm.MdiParent = this;
            reportForm.WindowState = FormWindowState.Maximized;
            reportForm.Show();
            
        }

        private void menuItemExitApplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MDIMain_FormClosing(object sender, FormClosingEventArgs e)
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

    }
}
