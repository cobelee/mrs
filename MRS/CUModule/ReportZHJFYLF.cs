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
            lbDescription.Text = @"查询说明：综合减负医疗费包括个人自负、个人承担及由个人历年帐户结余资金抵扣的医疗费。
    输入查询时间段，可以查询综合减负医疗费大于给定值的所有人员医疗费情况。";
        }

        /// <summary>
        /// 过滤非数字字符。退格：8，回车：13，小数点：46
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AllowNumber(object sender, KeyPressEventArgs e)
        {
            //以下代码将过滤掉非数字及非退格，非回车、非小数点的其它字符。
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

                gvReport.Columns["YBH"].HeaderText = "医保号";
                gvReport.Columns["JobNumber"].HeaderText = "工号";
                gvReport.Columns["Name"].HeaderText = "姓名";
                gvReport.Columns["ZHJFYLF"].HeaderText = "综合减负医疗费";
                gvReport.Columns["GRZFuTotal"].HeaderText = "个人自付合计";
                gvReport.Columns["GRZFeiTotal"].HeaderText = "个人自费合计";
                gvReport.Columns["BXJETotal"].HeaderText = "公司补助合计（报销金额）";
            }
            else
            {
                MessageBox.Show("请输入正确的医疗费金额！");
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
        /// 数据报表打印器 绑定数据报表及数据。
        /// </summary>
        /// <param name="row"></param>
        protected void ReportPrinter_DataBind()
        {
            //设置报表模版路径。
            LocalReport report = new LocalReport();
            report.ReportPath = "综合减负医疗费报告.rdlc";
            
            reportPrinter = new ReportPrinter(report);


            //加载报表数据源。
            string reportDataSourceName = reportPrinter.LocalReport.GetDataSourceNames()[0];

            decimal zhjfylf = 0M;
            decimal.TryParse(tbZHJFYLF.Text, out zhjfylf);

            DataTable tableSource = bll_AccountBook.Create_Report_ZHJFYLF_Stat((cbbMPeriod.SelectedItem as MRS.Model.MPeriod).Id, zhjfylf);

            reportPrinter.LocalReport.DataSources.Add(new ReportDataSource(reportDataSourceName, tableSource));

            //设置报表参数值。
            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("PARM_MPeriod", (cbbMPeriod.SelectedItem as MRS.Model.MPeriod).Name);
            //parameters[1] = new ReportParameter("PARM_IssueNumber", cbbIssueNumber.SelectedItem.ToString());

            report.SetParameters(parameters);
        }
    }
}