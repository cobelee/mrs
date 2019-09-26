using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MRS.UC
{
    public partial class IndividualQuery : UserControl
    {
        protected MRS.BLL.MPeriod bll_mPeriod = new MRS.BLL.MPeriod();
        protected PMS.BLL.MedicarePerson bllMedicarePerson = new PMS.BLL.MedicarePerson();
        protected MRS.BLL.BXD bllBXD = new MRS.BLL.BXD();
        protected MRS.BLL.BXMX bllBXMX = new MRS.BLL.BXMX();

        public IndividualQuery()
        {
            InitializeComponent();
        }

        public void SetYbh(string ybh)
        {
            tbYBH.Text = ybh;
        }
        private void btnCollapse_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = !splitContainer1.Panel1Collapsed;
            btnCollapse.Text = splitContainer1.Panel1Collapsed ? "显示测边栏" : "隐藏测边栏";
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            QueryPersonInfo();

            IList<MRS.Model.BXD> bxds = bllBXD.GetBXD_By_YBH(tbYBH.Text, dtpBeginDate.Value.Date, dtpEndDate.Value.AddDays(1).Date);

            if (bxds.Count > 0)
            {
                gvIndividual.DataSource = bxds;

                gvIndividual.Columns["BXDId"].DisplayIndex = 0;
                gvIndividual.Columns["BXDId"].HeaderText = "序号";
                gvIndividual.Columns["BXDate"].DisplayIndex = 1;
                gvIndividual.Columns["BXDate"].HeaderText = "报销日期";
                gvIndividual.Columns["PsnType"].DisplayIndex = 2;
                gvIndividual.Columns["PsnType"].HeaderText = "人员类别";
                gvIndividual.Columns["YBH"].Visible = false;
                gvIndividual.Columns["YBH"].HeaderText = "医保号";
                gvIndividual.Columns["Name"].DisplayIndex = 4;
                gvIndividual.Columns["Name"].HeaderText = "姓名";
                gvIndividual.Columns["JobNumber"].Visible = false;
                gvIndividual.Columns["JobNumber"].HeaderText = "工号";
                gvIndividual.Columns["Sex"].Visible = false;
                gvIndividual.Columns["Sex"].HeaderText = "性别";
                gvIndividual.Columns["Organization"].Visible = false;
                gvIndividual.Columns["Organization"].HeaderText = "部门";
                gvIndividual.Columns["YYF"].DisplayIndex = 8;
                gvIndividual.Columns["YYF"].HeaderText = "医药费";
                gvIndividual.Columns["BXJE"].DisplayIndex = 9;
                gvIndividual.Columns["BXJE"].HeaderText = "报销金额";
                gvIndividual.Columns["ZLF"].DisplayIndex = 10;
                gvIndividual.Columns["ZLF"].HeaderText = "自理费";
                gvIndividual.Columns["TCJJ"].DisplayIndex = 11;
                gvIndividual.Columns["TCJJ"].HeaderText = "统筹基金";
                gvIndividual.Columns["Accountant"].DisplayIndex = 12;
                gvIndividual.Columns["Accountant"].HeaderText = "会计";

                gvIndividual.Columns["AttNumber"].Visible = false;
                gvIndividual.Columns["GRZFei"].Visible = false;
                gvIndividual.Columns["GRZFu"].Visible = false;
                gvIndividual.Columns["IdentityCard"].Visible = false;
                gvIndividual.Columns["Birthday"].Visible = false;
                gvIndividual.Columns["ChargeUpSign"].Visible = false;
                gvIndividual.Columns["MPeriodId"].Visible = false;
            }
            else
            {
                MessageBox.Show("无报销纪录！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (gvIndividual.Rows.Count > 0)
            {
                gvIndividual.Rows[0].Selected = true;
            }
        }

        private void QueryPersonInfo()
        {
            PMS.Model.MedicarePerson mp = new PMS.Model.MedicarePerson();
            mp = bllMedicarePerson.GetMedicarePerson(tbYBH.Text);

            if (mp.Name == "")
            {
                lbBXPersonName.Text = "数据库中无此人";
            }
            else
            {
                lbBXPersonName.Text = mp.Name;
            }
            lbMedicareId.Text = mp.MedicareId;
            lbJobNumber.Text = mp.JobNumber;
            lbIdentityCard.Text = mp.IdentityCard;
            lbBirthday.Text = mp.Birthday.ToShortDateString();
            lbOrganization.Text = mp.Organization;
            lbSex.Text = mp.Sex;
            lbPsnType.Text = mp.PsnType;

            pnlPersonInfo.Visible = true;
        }

        private void gvIndividual_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvIndividual.Rows.Count > 0)
            {
                int BXDId;
                BXDId = (int)gvIndividual.SelectedRows[0].Cells["BXDId"].Value;

                gvGR_BXMX.DataSource = bllBXMX.GetBXMX_By_BXDId(BXDId);

                gvGR_BXMX.Columns["BXMXId"].HeaderText = "序号";
                gvGR_BXMX.Columns["BXMXId"].DisplayIndex = 0;

                gvGR_BXMX.Columns["FPDate"].HeaderText = "发票日期";
                gvGR_BXMX.Columns["FPDate"].DisplayIndex = 1;

                gvGR_BXMX.Columns["JZFS"].HeaderText = "就诊方式";
                gvGR_BXMX.Columns["JZFS"].DisplayIndex = 2;
                gvGR_BXMX.Columns["JZFS"].SortMode = DataGridViewColumnSortMode.Automatic;

                gvGR_BXMX.Columns["YYF"].HeaderText = "医药费";
                gvGR_BXMX.Columns["YYF"].DisplayIndex = 3;

                gvGR_BXMX.Columns["GRZFei"].HeaderText = "个人自费";
                gvGR_BXMX.Columns["GRZFei"].DisplayIndex = 4;

                gvGR_BXMX.Columns["GRZFu"].HeaderText = "个人自付";
                gvGR_BXMX.Columns["GRZFu"].DisplayIndex = 5;

                gvGR_BXMX.Columns["GRZFBao"].HeaderText = "个人自负";
                gvGR_BXMX.Columns["GRZFBao"].DisplayIndex = 6;

                gvGR_BXMX.Columns["GRCDBao"].HeaderText = "个人承担";
                gvGR_BXMX.Columns["GRCDBao"].DisplayIndex = 7;

                gvGR_BXMX.Columns["LNZHBao"].HeaderText = "历年账户";
                gvGR_BXMX.Columns["LNZHBao"].DisplayIndex = 8;

                gvGR_BXMX.Columns["TCJJ"].HeaderText = "统筹基金";
                gvGR_BXMX.Columns["TCJJ"].DisplayIndex = 9;

                gvGR_BXMX.Columns["ReimbursementRatio"].HeaderText = "报销比例";
                gvGR_BXMX.Columns["ReimbursementRatio"].DisplayIndex = 10;

                gvGR_BXMX.Columns["BXDId"].Visible = false;
            }
        }

        private void tbYBH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnQuery.PerformClick();
            }
        }

        private void WarrantPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (gvIndividual.Rows.Count > 0)
            {
                int BXDId;
                BXDId = (int)gvIndividual.SelectedRows[0].Cells["BXDId"].Value;

                MRS.MRModule.DrawWarrantGraphic dwg = new MRS.MRModule.DrawWarrantGraphic();

                dwg.BaoXiaoDan = bllBXD.GetBXD_By_BXDId(BXDId);

                ((System.Drawing.Printing.PrintDocument)sender).DocumentName = "报销凭证 " + dwg.BaoXiaoDan.Name + " 记录单号：" + dwg.BaoXiaoDan.BXDId.ToString();


                dwg.WarrantTable = bllBXD.CreateBXWarrantTable(BXDId);
                dwg.Draw(e.Graphics);
            }
            else
            {
                MessageBox.Show("无凭证可打印！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = WarrantPrintDocument;
            ppd.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (gvIndividual.Rows.Count > 0)
            {
                int BXDId;
                MRS.Model.BXD bxd = new MRS.Model.BXD();
                BXDId = (int)gvIndividual.SelectedRows[0].Cells["BXDId"].Value;
                bxd = bllBXD.GetBXD_By_BXDId(BXDId);
                WarrantPrintDocument.DocumentName = "报销凭证 " + bxd.Name + " 记录单号：" + bxd.BXDId.ToString();
                WarrantPrintDocument.Print();
            }
        }

        private void IndividualQuery_Load(object sender, EventArgs e)
        {
            tbYBH.Focus();
            if (!string.IsNullOrEmpty(tbYBH.Text))
            {
                dtpBeginDate.Value = dtpEndDate.Value.AddMonths(-1);
                btnQuery.PerformClick();
            }
        }

    }
}