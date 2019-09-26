using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MRS.MRModule
{


    public partial class BXForm : Form
    {
        public ShowAccountDelegate ShowAccountant;
        protected MRS.BLL.MPeriod bll_mPeriod = new MRS.BLL.MPeriod();

        protected MRS.BLL.BXD bll_BXD = new MRS.BLL.BXD();
        protected MRS.BLL.BXMX bllBXMX = new MRS.BLL.BXMX();
        protected MRS.BLL.HspType bllHspType = new MRS.BLL.HspType();
        protected PMS.BLL.MedicarePerson bllMedicarePerson = new PMS.BLL.MedicarePerson();
        protected MRS.BLL.BXRatio bll_ratio = new MRS.BLL.BXRatio();

        public BxdSelectedDelegate BxdCreated;
        public BxdSelectedDelegate BxdUpdated;

        public BXForm()
        {
            InitializeComponent();
            //在状态栏显示会计姓名。
            InitBXForm();
        }

        public void InitBXForm()
        {
            ShowAccountant += new ShowAccountDelegate(ShowAccountantName);

            //绑定医保年度下拉控件数据
            cbbMPeriod_DataBind();
            this.splitContainer1.Panel2Collapsed = true;


            this.FormClosing += new FormClosingEventHandler(Check_Can_Close);

            tbYBH.Select();
        }


        protected void Check_Can_Close(object sender, FormClosingEventArgs e)
        {
            if (btnStat.Enabled == true)
            {
                MessageBox.Show("报销明细有改动，需要重新汇总！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }

        //报销发票明细数据绑定。
        private void gvBXMX_DataBind()
        {
            if (lbBXDid.Text != "")
            {
                gvBXMX.DataSource = bllBXMX.GetBXMX_By_BXDId(Convert.ToInt32(lbBXDid.Text));

                gvBXMX.Columns["BXMXId"].HeaderText = "序号";
                gvBXMX.Columns["BXMXId"].DisplayIndex = 0;

                gvBXMX.Columns["FPDate"].HeaderText = "发票日期";
                gvBXMX.Columns["FPDate"].DisplayIndex = 1;

                gvBXMX.Columns["JZFS"].HeaderText = "就诊方式";
                gvBXMX.Columns["JZFS"].DisplayIndex = 2;
                gvBXMX.Columns["JZFS"].SortMode = DataGridViewColumnSortMode.Automatic;

                gvBXMX.Columns["YYF"].HeaderText = "医药费";
                gvBXMX.Columns["YYF"].DisplayIndex = 3;

                gvBXMX.Columns["GRZFei"].HeaderText = "个人自费";
                gvBXMX.Columns["GRZFei"].DisplayIndex = 4;

                gvBXMX.Columns["GRZFu"].HeaderText = "个人自付";
                gvBXMX.Columns["GRZFu"].DisplayIndex = 5;

                gvBXMX.Columns["GRZFBao"].HeaderText = "个人自负";
                gvBXMX.Columns["GRZFBao"].DisplayIndex = 6;

                gvBXMX.Columns["GRCDBao"].HeaderText = "个人承担";
                gvBXMX.Columns["GRCDBao"].DisplayIndex = 7;

                gvBXMX.Columns["LNZHBao"].HeaderText = "历年账户";
                gvBXMX.Columns["LNZHBao"].DisplayIndex = 8;

                gvBXMX.Columns["TCJJ"].HeaderText = "统筹基金";
                gvBXMX.Columns["TCJJ"].DisplayIndex = 9;

                gvBXMX.Columns["ReimbursementRatio"].HeaderText = "报销比例";
                gvBXMX.Columns["ReimbursementRatio"].DisplayIndex = 10;

                gvBXMX.Columns["GRZFuHide"].HeaderText = "隐性个人自付";
                gvBXMX.Columns["GRZFuHide"].DisplayIndex = 11;

                gvBXMX.Columns["BXDId"].Visible = false;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            tslbTime.Text = "当前时间：" + DateTime.Now.ToLongTimeString();
        }

        //报销下一位人员，新建窗口，同时关闭本窗口
        private void btnNextPerson_Click(object sender, EventArgs e)
        {
            BXForm bxForm = new BXForm();
            bxForm.ShowAccountantName(tslbAccount.Text);
            bxForm.WindowState = FormWindowState.Maximized;
            if (this.Owner != null)
            {
                if (this.Owner is BxMain)
                {
                    BxMain bxMain = this.Owner as BxMain;
                    bxForm.BxdCreated += new BxdSelectedDelegate(bxMain.BxdList_Update);
                    bxForm.BxdUpdated += new BxdSelectedDelegate(bxMain.BxdList_Update);
                    bxForm.Show(bxMain);
                }
            }
            else
            {
                bxForm.Show();
            }

            this.Close();
        }

        private void tbYBH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                lbDataReading.Visible = true;
                PMS.Model.MedicarePerson mp = new PMS.Model.MedicarePerson();
                mp = bllMedicarePerson.GetMedicarePerson(tbYBH.Text);

                if (mp.Name == "")
                {
                    lbBXPersonName.Text = "数据库中无此人";
                    this.Text = "数据库中无此人";
                }
                else
                {
                    lbBXPersonName.Text = mp.Name;
                    this.Text = "医保号:" + tbYBH.Text + "  姓名:" + mp.Name;
                }
                lbMedicareId.Text = mp.MedicareId;
                lbJobNumber.Text = mp.JobNumber;
                lbIdentityCard.Text = mp.IdentityCard;
                lbBirthday.Text = mp.Birthday.ToShortDateString();
                lbOrganization.Text = mp.Organization;
                lbSex.Text = mp.Sex;
                lbPsnType.Text = mp.PsnType;

                lbDataReading.Visible = false;

                pnlPersonInfo.Visible = true;
                splitContainer1.Panel2Collapsed = false;

                btnGetInvoice.Focus();
            }
        }

        /// <summary>
        /// 绑定医保年度ComboBox控件的数据。
        /// </summary>
        private void cbbMPeriod_DataBind()
        {
            IList<MRS.Model.MPeriod> mPeriods = bll_mPeriod.GetMPeriodAll();
            cbbMPeriod.Items.Clear();
            foreach (MRS.Model.MPeriod mPeriod in mPeriods)
            {
                cbbMPeriod.Items.Add(mPeriod);
            }
            if (cbbMPeriod.Items.Count > 0)
            {
                cbbMPeriod.SelectedIndex = 0;
            }
        }


        private int AddBXD()
        {
            MRS.Model.BXD bxd = new MRS.Model.BXD();

            bxd.MPeriodId = (cbbMPeriod.SelectedItem as MRS.Model.MPeriod).Id;
            bxd.BXDate = DateTime.Now;
            bxd.YBH = lbMedicareId.Text;
            bxd.PsnType = lbPsnType.Text;
            bxd.Accountant = tslbAccount.Text;

            bxd.Name = lbBXPersonName.Text;
            bxd.JobNumber = lbJobNumber.Text;
            bxd.IdentityCard = lbIdentityCard.Text;
            bxd.Birthday = Convert.ToDateTime(lbBirthday.Text);
            bxd.Organization = lbOrganization.Text;
            bxd.Sex = lbSex.Text;
            bxd.ChargeUpSign = MRS.Model.BXD.ChargeUpSignType.NochargeUP.ToString();
            int bxdId = bll_BXD.CreateBXD(bxd);
            if (this.BxdCreated != null)
            {
                BxdSelectedEventArgs arg = new BxdSelectedEventArgs();
                arg.BxdId = bxdId;
                this.BxdCreated(this, arg);
            }
            return bxdId;
        }

        public void ShowAccountantName(string accountantName)
        {
            tslbAccount.Text = accountantName;
        }

        private void btnStat_Click(object sender, EventArgs e)
        {
            //保存报销明细汇总到报销单
            bll_BXD.Save_BXMX_Stat_To_BXD(Convert.ToInt32(lbBXDid.Text), Convert.ToInt32(nudAttNumber.Value));

            if (this.BxdUpdated != null)
            {
                BxdSelectedEventArgs arg = new BxdSelectedEventArgs();
                arg.BxdId = Convert.ToInt32(lbBXDid.Text);
                this.BxdUpdated(this, arg);
            }

            //创建报销凭证。
            MRS.Model.BXWarrantTable warrant = bll_BXD.CreateBXWarrantTable(Convert.ToInt32(lbBXDid.Text));
            gvWarrant.DataSource = warrant;

            gvWarrant.Columns["序号"].Visible = false;

            foreach (DataGridViewColumn column in gvWarrant.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            btnStat.Enabled = false;
            btnPrint1.Enabled = true;
            btnNextPerson.Enabled = true;
        }

        private void btnDeleteBXMX_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("删除该记录吗?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bllBXMX.DeleteBXMX(Convert.ToInt32(gvBXMX.SelectedRows[0].Cells["BXMXId"].Value));
                gvBXMX_DataBind();
                nudAttNumber.Value--;
                btnStat.Enabled = true;
                btnPrint1.Enabled = false;
                btnNextPerson.Enabled = false;
            }
        }

        private void WarrantPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DrawWarrantGraphic dwg = new DrawWarrantGraphic();

            dwg.BaoXiaoDan = bll_BXD.GetBXD_By_BXDId(Convert.ToInt32(lbBXDid.Text));



            dwg.WarrantTable = bll_BXD.CreateBXWarrantTable(Convert.ToInt32(lbBXDid.Text));
            dwg.Draw(e.Graphics);

        }

        private void btnPrint1_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = WarrantPrintDocument;
            ppd.PrintPreviewControl.Zoom = 1;
            WarrantPrintDocument.DocumentName = "报销凭证 " + lbBXPersonName.Text + " 记录单号：" + lbBXDid.Text;
            ppd.Width = 650;
            ppd.Height = 500;
            ppd.ShowDialog(this);
        }

        //private void btnClear_Click(object sender, EventArgs e)
        //{
        //    tbGRZFei.Text = string.Empty;
        //    tbGRZFu.Text = string.Empty;
        //    tbGRZFBao.Text = string.Empty;
        //    tbGRCDBao.Text = string.Empty;
        //    tbLNZHBao.Text = string.Empty;
        //    tbTCJJ.Text = string.Empty;
        //}

        //采集发票数据，新建采集数据窗口。
        private void btnGetInvoice_Click(object sender, EventArgs e)
        {
            InputInvoice inputInvoice = new InputInvoice();
            inputInvoice.InvoiceGetted += new InvoiceGetEventHandler(AddBXMX);
            inputInvoice.Text = "医疗发票数据采集窗口  [医保号:" + lbMedicareId.Text + "  姓名:" + lbBXPersonName.Text + "]";
            inputInvoice.ShowDialog(this);
        }

        /// <summary>
        /// 响应 InputInvoice 发票数据输入结束事件的方法。
        /// </summary>
        /// <param name="bxmx"></param>
        void AddBXMX(MRS.Model.BXMX bxmx)
        {
            int mPeriodId = 0;
            string ybh = string.Empty;
            mPeriodId = (cbbMPeriod.SelectedItem as MRS.Model.MPeriod).Id;
            ybh = lbMedicareId.Text;

            if (lbBXDid.Text == "")
            {
                lbBXDid.Text = AddBXD().ToString();
            }

            if (lbBXDid.Text != "")
            {
                bxmx.BXDId = Convert.ToInt32(lbBXDid.Text);
                bxmx.ReimbursementRatio = bll_ratio.GetRatio(mPeriodId, ybh, bxmx.JZFS);
                bllBXMX.AddBXMX(bxmx);
                gvBXMX_DataBind();
                nudAttNumber.Value++;
                btnStat.Enabled = true;
                btnPrint1.Enabled = false;
                btnNextPerson.Enabled = false;
            }
        }

        // 点击“修改”报销明细按钮。
        private void btnEditBxmx_Click(object sender, EventArgs e)
        {
            if (gvBXMX.SelectedRows.Count > 0)
            {
                int bxmxId = 0;
                bxmxId = (int)gvBXMX.SelectedRows[0].Cells["BXMXId"].Value;
                MRS.Model.BXMX bxmx = bllBXMX.GetBxmx_By_BxmxId(bxmxId);

                MRS.MRModule.InputInvoice invoice = new MRS.MRModule.InputInvoice();
                invoice.InvoiceGetted += new MRS.MRModule.InvoiceGetEventHandler(invoice_InvoiceGetted);
                invoice.Bxmx = bxmx;
                invoice.ShowDialog(this);
            }
        }

        // 报销明细被修改.
        void invoice_InvoiceGetted(Model.BXMX bxmx)
        {
            bllBXMX.UpdateBXMX(bxmx);
            bll_BXD.Save_BXMX_Stat_To_BXD(bxmx.BXDId);
            gvBXMX_DataBind();

        }


    }
}