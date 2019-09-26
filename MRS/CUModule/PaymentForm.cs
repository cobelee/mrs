using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using org.in2bits.MyXls;

namespace MRS.CUModule
{
    public partial class PaymentForm : Form
    {
        DateTime beginDate, endDate;
        MRS.BLL.AccountBook bllAccountBook;
        ReportPrinter reportPrinter;

        public PaymentForm()
        {
            InitializeComponent();
            InitPaymentForm();
        }

        protected void InitPaymentForm()
        {
            beginDate = new DateTime();
            endDate = new DateTime();
            bllAccountBook = new MRS.BLL.AccountBook();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            beginDate = dtpBeginDate.Value.Date;
            endDate = dtpEndDate.Value.AddDays(1).Date;

            IList<MRS.Model.AccountBook> accountBook = new List<MRS.Model.AccountBook>();
            accountBook = bllAccountBook.Select_AccountBook_PaymentList(beginDate, endDate);

            gvPaymentList.DataSource = accountBook;

            gvPaymentList.Columns["PsnType"].DisplayIndex = 0;
            gvPaymentList.Columns["PsnType"].HeaderText = "人员类别";
            gvPaymentList.Columns["Organization"].DisplayIndex = 1;
            gvPaymentList.Columns["Organization"].HeaderText = "部门";
            gvPaymentList.Columns["YBH"].DisplayIndex = 2;
            gvPaymentList.Columns["YBH"].HeaderText = "医保号";
            gvPaymentList.Columns["Name"].DisplayIndex = 3;
            gvPaymentList.Columns["Name"].HeaderText = "姓名";
            gvPaymentList.Columns["JobNumber"].DisplayIndex = 4;
            gvPaymentList.Columns["JobNumber"].HeaderText = "工号";
            gvPaymentList.Columns["BXJE"].DisplayIndex = 5;
            gvPaymentList.Columns["BXJE"].HeaderText = "报销金额";
            gvPaymentList.Columns["BXDate"].DisplayIndex = 6;
            gvPaymentList.Columns["BXDate"].HeaderText = "报销日期";
            gvPaymentList.Columns["Cashier"].DisplayIndex = 7;
            gvPaymentList.Columns["Cashier"].HeaderText = "出纳";


            gvPaymentList.Columns["BXDId"].Visible = false;
            gvPaymentList.Columns["BXDId"].HeaderText = "序号";
            gvPaymentList.Columns["Sex"].Visible = false;
            gvPaymentList.Columns["Sex"].HeaderText = "性别";
            gvPaymentList.Columns["YYF"].Visible = false;
            gvPaymentList.Columns["YYF"].HeaderText = "医药费";
            gvPaymentList.Columns["ZLF"].Visible = false;
            gvPaymentList.Columns["ZLF"].HeaderText = "自理费";
            gvPaymentList.Columns["TCJJ"].Visible = false;
            gvPaymentList.Columns["TCJJ"].HeaderText = "统筹基金";
            gvPaymentList.Columns["Accountant"].Visible = false;
            gvPaymentList.Columns["Accountant"].HeaderText = "会计";

            gvPaymentList.Columns["AttNumber"].Visible = false;
            gvPaymentList.Columns["GRZFei"].Visible = false;
            gvPaymentList.Columns["GRZFu"].Visible = false;
            gvPaymentList.Columns["IdentityCard"].Visible = false;
            gvPaymentList.Columns["Birthday"].Visible = false;
            gvPaymentList.Columns["ChargeUpSign"].Visible = false;
            gvPaymentList.Columns["ChargeUpDate"].Visible = false;
            gvPaymentList.Columns["MPeriodId"].Visible = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ReportPrinter_DataBind();

            PaymentPrintPreview prv = new PaymentPrintPreview();
            prv.PrintPreviewControl.Document = reportPrinter.PrintDocument;
            prv.Width = 800;
            prv.Height = 700;
            prv.ShowDialog(this);

        }

        /// <summary>
        /// 数据报表打印器 绑定数据报表及数据。
        /// </summary>
        /// <param name="row"></param>
        protected void ReportPrinter_DataBind()
        {
            //设置报表模版路径。
            LocalReport report = new LocalReport();
            report.ReportPath = "Report\\Payment.rdlc";

            reportPrinter = new ReportPrinter(report);


            //加载报表数据源。
            string reportDataSourceName = reportPrinter.LocalReport.GetDataSourceNames()[0];

            IList<Model.AccountBook> table = bllAccountBook.Select_AccountBook_PaymentList(beginDate, endDate);

            reportPrinter.LocalReport.DataSources.Add(new ReportDataSource(reportDataSourceName, table));

            //设置报表参数值。
            //ReportParameter[] parameters = new ReportParameter[1];
            //parameters[0] = new ReportParameter("PARM_MPeriod", (cbbMPeriod.SelectedItem as MRS.Model.MPeriod).Name);
            //parameters[1] = new ReportParameter("PARM_IssueNumber", cbbIssueNumber.SelectedItem.ToString());

            //report.SetParameters(parameters);
        }

        #region 导出Excel 文件
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (gvPaymentList.Rows.Count > 0)
            {
                beginDate = dtpBeginDate.Value.Date;
                endDate = dtpEndDate.Value.AddDays(1).Date;

                IList<MRS.Model.AccountBook> accountBooks = new List<MRS.Model.AccountBook>();
                accountBooks = bllAccountBook.Select_AccountBook_PaymentList(beginDate, endDate);

                System.Text.StringBuilder fileName = new StringBuilder();
                fileName.Append("医保报销帐单 ");
                fileName.Append(DateTime.Now.Year.ToString());
                fileName.Append(DateTime.Now.Month.ToString().PadLeft(2, '0'));
                fileName.Append(DateTime.Now.Day.ToString().PadLeft(2, '0'));
                fileName.Append(".xls");
                XlsDocument xlsDoc = new XlsDocument();
                xlsDoc.FileName = fileName.ToString();

                //定义Excel文档属性.
                xlsDoc.SummaryInformation.Author = "Cobe lee";
                xlsDoc.SummaryInformation.Title = "医保报销帐单";
                xlsDoc.SummaryInformation.Comments = "This workbook generated by ZPITC! http://www.tiyi.biz";
                xlsDoc.SummaryInformation.Subject = "医保报销帐单";
                xlsDoc.DocumentSummaryInformation.Company = "镇海石化工业贸易有限责任公司";

                Worksheet sheet = xlsDoc.Workbook.Worksheets.Add("Sheet1");
                xlsDoc.Workbook.Worksheets.Add("Sheet2");
                xlsDoc.Workbook.Worksheets.Add("Sheet3");
                Cells cells = sheet.Cells;

                //以下定义 银行帐号 及 身份证号 的列宽.
                ColumnInfo col0 = new ColumnInfo(xlsDoc, sheet);
                col0.ColumnIndexEnd = 0;
                col0.ColumnIndexStart = 0;
                col0.Width = 21 * 269;
                sheet.AddColumnInfo(col0);

                ColumnInfo col3 = new ColumnInfo(xlsDoc, sheet);
                col3.ColumnIndexEnd = 3;
                col3.ColumnIndexStart = 3;
                col3.Width = 21 * 269;
                sheet.AddColumnInfo(col3);


                //以下定义文档标题 副标题
                int rint = 1;

                cells.Merge(rint, rint, 1, 5);
                Cell cell = cells.Add(rint, 1, "医保报销帐单");
                cell.Font.Height = 16 * 20;
                cell.HorizontalAlignment = HorizontalAlignments.Centered;
                rint++;


                cells.Merge(rint, rint, 1, 5);
                Cell cell2 = cells.Add(rint, 1, "( " + beginDate.ToShortDateString() + "至" + dtpEndDate.Value.ToShortDateString() + " )");
                cell2.Font.Height = 12 * 20;
                cell2.Font.FontName = "宋体";
                cell2.HorizontalAlignment = HorizontalAlignments.Centered;
                rint++;

                FormatHead(cells.Add(rint, 1, "银行帐号"));
                FormatHead(cells.Add(rint, 2, "金额"));
                FormatHead(cells.Add(rint, 3, "姓名"));
                FormatHead(cells.Add(rint, 4, "身份证号"));
                FormatHead(cells.Add(rint, 5, "备注"));
                foreach (MRS.Model.AccountBook account in accountBooks)
                {
                    rint++;
                    PMS.BLL.MedicarePerson bll_mp = new PMS.BLL.MedicarePerson();
                    string bankAccount = bll_mp.GetMedicarePerson(account.YBH).BankAccount;
                    if (bankAccount != null)
                    {
                        FormatCellNumber(cells.Add(rint, 1, bankAccount));
                        FormatCellAmount(cells.Add(rint, 2, Convert.ToDouble(account.BXJE)));
                        FormatCellName(cells.Add(rint, 3, account.Name));
                        FormatCellNumber(cells.Add(rint, 4, account.IdentityCard));
                        FormatCellName(cells.Add(rint, 5, "报销"));
                    }

                }

                rint++;
                FormatCellButtom(cells.Add(rint, 1, ""));
                FormatCellButtom(cells.Add(rint, 2, ""));
                FormatCellButtom(cells.Add(rint, 3, ""));
                FormatCellButtom(cells.Add(rint, 4, ""));
                FormatCellButtom(cells.Add(rint, 5, ""));

                saveFileDialog1.DefaultExt = "xls";
                saveFileDialog1.FileName = fileName.ToString();
                saveFileDialog1.Filter = "Excel 97-2003 工作簿(*.xls)|*.xls";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = System.IO.Path.GetDirectoryName(saveFileDialog1.FileName);
                    try
                    {
                        xlsDoc.Save(path, true);
                    }
                    catch
                    {
                        MessageBox.Show("文件 \"" + System.IO.Path.GetFileName(saveFileDialog1.FileName) + "\" 正被其它程序打开，\n请关闭该文件，并重试！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
            else
            {
                MessageBox.Show("无医保报销帐单!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        protected void FormatHead(Cell cell)
        {
            cell.Font.Bold = true;
            cell.UseBorder = true;

            cell.BottomLineColor = Colors.Black;
            cell.BottomLineStyle = 1;
            cell.TopLineStyle = 1;

        }

        protected void FormatCellName(Cell cell)
        {
            cell.Font.FontName = "宋体";
        }

        protected void FormatCellNumber(Cell cell)
        {
            cell.Font.FontName = "Arial";
        }

        protected void FormatCellAmount(Cell cell)
        {
            cell.Font.FontName = "Arial";
            cell.HorizontalAlignment = HorizontalAlignments.Right;
        }

        private void FormatCellButtom(Cell cell)
        {
            cell.UseBorder = true;
            cell.TopLineStyle = 2;
        }

        #endregion
    }
}
