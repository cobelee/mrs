using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace MRS.CUModule
{
    public partial class ReportZHJFYLF : Form
    {
        MRS.BLL.MPeriod bll_mPeriod = new MRS.BLL.MPeriod();
        MRS.BLL.AccountBook bll_AccountBook = new MRS.BLL.AccountBook();
        ReportPrinter reportPrinter;

        public ReportZHJFYLF()
        {
            InitializeComponent();
            InitReportZHJFYLF();
        }

        private void InitReportZHJFYLF()
        {
            tbZHJFYLF.KeyPress += new KeyPressEventHandler(AllowNumber);
            lbDescription.Text = @"��ѯ˵�����ۺϼ���ҽ�ƷѰ��������Ը������˳е����ɸ��������ʻ������ʽ�ֿ۵�ҽ�Ʒѡ�
    �����ѯʱ��Σ����Բ�ѯ�ۺϼ���ҽ�ƷѴ��ڸ���ֵ��������Աҽ�Ʒ������";
        }

        /// <summary>
        /// ���˷������ַ����˸�8���س���13��С���㣺46
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AllowNumber(object sender, KeyPressEventArgs e)
        {
            //���´��뽫���˵������ּ����˸񣬷ǻس�����С����������ַ���
            if ((e.KeyChar != 8 && !char.IsDigit(e.KeyChar)) && e.KeyChar != 13 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DataTable report = new DataTable();
            decimal zhjfylf = 0;
            int mPeriodId = 0;
            mPeriodId = (cbbMPeriod.SelectedItem as MRS.Model.MPeriod).Id;
            if (decimal.TryParse(tbZHJFYLF.Text, out zhjfylf))
            {
                report = bll_AccountBook.Create_Report_ZHJFYLF_Stat(mPeriodId, zhjfylf);

                gvReport.DataSource = report;

                gvReport.Columns["YBH"].HeaderText = "ҽ����";
                gvReport.Columns["JobNumber"].HeaderText = "����";
                gvReport.Columns["Name"].HeaderText = "����";
                gvReport.Columns["ZHJFYLF"].HeaderText = "�ۺϼ���ҽ�Ʒ�";
                gvReport.Columns["GRZFuTotal"].HeaderText = "�����Ը��ϼ�";
                gvReport.Columns["GRZFeiTotal"].HeaderText = "�����ԷѺϼ�";
                gvReport.Columns["BXJETotal"].HeaderText = "��˾�����ϼƣ�������";
            }
            else
            {
                MessageBox.Show("��������ȷ��ҽ�Ʒѽ�");
            }
        }

        private void ReportZHJFYLF_Load(object sender, EventArgs e)
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ReportPrinter_DataBind();

            ReportZHJFYLF_Preview prv = new ReportZHJFYLF_Preview();
            prv.PrintPreviewControl.Document = reportPrinter.PrintDocument;
            prv.MdiParent = this.MdiParent;
            prv.Show();
            prv.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// ���ݱ�����ӡ�� �����ݱ��������ݡ�
        /// </summary>
        /// <param name="row"></param>
        protected void ReportPrinter_DataBind()
        {
            //���ñ���ģ��·����
            LocalReport report = new LocalReport();
            report.ReportPath = "�ۺϼ���ҽ�Ʒѱ���.rdlc";
            
            reportPrinter = new ReportPrinter(report);


            //���ر�������Դ��
            string reportDataSourceName = reportPrinter.LocalReport.GetDataSourceNames()[0];

            decimal zhjfylf = 0M;
            decimal.TryParse(tbZHJFYLF.Text, out zhjfylf);

            DataTable tableSource = bll_AccountBook.Create_Report_ZHJFYLF_Stat((cbbMPeriod.SelectedItem as MRS.Model.MPeriod).Id, zhjfylf);

            reportPrinter.LocalReport.DataSources.Add(new ReportDataSource(reportDataSourceName, tableSource));

            //���ñ�������ֵ��
            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("PARM_MPeriod", (cbbMPeriod.SelectedItem as MRS.Model.MPeriod).Name);
            //parameters[1] = new ReportParameter("PARM_IssueNumber", cbbIssueNumber.SelectedItem.ToString());

            report.SetParameters(parameters);
        }
    }
}