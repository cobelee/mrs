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
            //��״̬����ʾ���������
            InitBXForm();
        }

        public void InitBXForm()
        {
            ShowAccountant += new ShowAccountDelegate(ShowAccountantName);

            //��ҽ����������ؼ�����
            cbbMPeriod_DataBind();
            this.splitContainer1.Panel2Collapsed = true;


            this.FormClosing += new FormClosingEventHandler(Check_Can_Close);

            tbYBH.Select();
        }


        protected void Check_Can_Close(object sender, FormClosingEventArgs e)
        {
            if (btnStat.Enabled == true)
            {
                MessageBox.Show("������ϸ�иĶ�����Ҫ���»��ܣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }

        //������Ʊ��ϸ���ݰ󶨡�
        private void gvBXMX_DataBind()
        {
            if (lbBXDid.Text != "")
            {
                gvBXMX.DataSource = bllBXMX.GetBXMX_By_BXDId(Convert.ToInt32(lbBXDid.Text));

                gvBXMX.Columns["BXMXId"].HeaderText = "���";
                gvBXMX.Columns["BXMXId"].DisplayIndex = 0;

                gvBXMX.Columns["FPDate"].HeaderText = "��Ʊ����";
                gvBXMX.Columns["FPDate"].DisplayIndex = 1;

                gvBXMX.Columns["JZFS"].HeaderText = "���﷽ʽ";
                gvBXMX.Columns["JZFS"].DisplayIndex = 2;
                gvBXMX.Columns["JZFS"].SortMode = DataGridViewColumnSortMode.Automatic;

                gvBXMX.Columns["YYF"].HeaderText = "ҽҩ��";
                gvBXMX.Columns["YYF"].DisplayIndex = 3;

                gvBXMX.Columns["GRZFei"].HeaderText = "�����Է�";
                gvBXMX.Columns["GRZFei"].DisplayIndex = 4;

                gvBXMX.Columns["GRZFu"].HeaderText = "�����Ը�";
                gvBXMX.Columns["GRZFu"].DisplayIndex = 5;

                gvBXMX.Columns["GRZFBao"].HeaderText = "�����Ը�";
                gvBXMX.Columns["GRZFBao"].DisplayIndex = 6;

                gvBXMX.Columns["GRCDBao"].HeaderText = "���˳е�";
                gvBXMX.Columns["GRCDBao"].DisplayIndex = 7;

                gvBXMX.Columns["LNZHBao"].HeaderText = "�����˻�";
                gvBXMX.Columns["LNZHBao"].DisplayIndex = 8;

                gvBXMX.Columns["TCJJ"].HeaderText = "ͳ�����";
                gvBXMX.Columns["TCJJ"].DisplayIndex = 9;

                gvBXMX.Columns["ReimbursementRatio"].HeaderText = "��������";
                gvBXMX.Columns["ReimbursementRatio"].DisplayIndex = 10;

                gvBXMX.Columns["GRZFuHide"].HeaderText = "���Ը����Ը�";
                gvBXMX.Columns["GRZFuHide"].DisplayIndex = 11;

                gvBXMX.Columns["BXDId"].Visible = false;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            tslbTime.Text = "��ǰʱ�䣺" + DateTime.Now.ToLongTimeString();
        }

        //������һλ��Ա���½����ڣ�ͬʱ�رձ�����
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
                    lbBXPersonName.Text = "���ݿ����޴���";
                    this.Text = "���ݿ����޴���";
                }
                else
                {
                    lbBXPersonName.Text = mp.Name;
                    this.Text = "ҽ����:" + tbYBH.Text + "  ����:" + mp.Name;
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
        /// ��ҽ�����ComboBox�ؼ������ݡ�
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
            //���汨����ϸ���ܵ�������
            bll_BXD.Save_BXMX_Stat_To_BXD(Convert.ToInt32(lbBXDid.Text), Convert.ToInt32(nudAttNumber.Value));

            if (this.BxdUpdated != null)
            {
                BxdSelectedEventArgs arg = new BxdSelectedEventArgs();
                arg.BxdId = Convert.ToInt32(lbBXDid.Text);
                this.BxdUpdated(this, arg);
            }

            //��������ƾ֤��
            MRS.Model.BXWarrantTable warrant = bll_BXD.CreateBXWarrantTable(Convert.ToInt32(lbBXDid.Text));
            gvWarrant.DataSource = warrant;

            gvWarrant.Columns["���"].Visible = false;

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
            if (MessageBox.Show("ɾ���ü�¼��?", "ѯ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            WarrantPrintDocument.DocumentName = "����ƾ֤ " + lbBXPersonName.Text + " ��¼���ţ�" + lbBXDid.Text;
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

        //�ɼ���Ʊ���ݣ��½��ɼ����ݴ��ڡ�
        private void btnGetInvoice_Click(object sender, EventArgs e)
        {
            InputInvoice inputInvoice = new InputInvoice();
            inputInvoice.InvoiceGetted += new InvoiceGetEventHandler(AddBXMX);
            inputInvoice.Text = "ҽ�Ʒ�Ʊ���ݲɼ�����  [ҽ����:" + lbMedicareId.Text + "  ����:" + lbBXPersonName.Text + "]";
            inputInvoice.ShowDialog(this);
        }

        /// <summary>
        /// ��Ӧ InputInvoice ��Ʊ������������¼��ķ�����
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

        // ������޸ġ�������ϸ��ť��
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

        // ������ϸ���޸�.
        void invoice_InvoiceGetted(Model.BXMX bxmx)
        {
            bllBXMX.UpdateBXMX(bxmx);
            bll_BXD.Save_BXMX_Stat_To_BXD(bxmx.BXDId);
            gvBXMX_DataBind();

        }


    }
}