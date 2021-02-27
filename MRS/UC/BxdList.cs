using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MRS.UC
{
    public partial class BxdList : UserControl
    {
        protected MRS.BLL.BXD bllBXD = new BLL.BXD();
        protected MRS.BLL.BXMX bllBXMX = new MRS.BLL.BXMX();
        protected MRS.BLL.BXRatio bll_ratio = new MRS.BLL.BXRatio();

        public BxdSelectedDelegate BxdSelected;

        public BxdSelectedDelegate BxdDoubleClicked;

        public BxdList()
        {
            InitializeComponent();
            ShowBXDList();
        }

        public void BxdList_DataBind(object sender, EventArgs e)
        {
            ShowBXDList();
        }

        /// <summary>
        /// 显示报销单记录。
        /// </summary>
        private void ShowBXDList()
        {
            IList<MRS.Model.BXD> bxds = bllBXD.GetBXD_With_Not_Charge_Up();

            if (bxds.Count > 0)
            {
                gvBXD_Not_ChargeUP.DataSource = bxds;

                gvBXD_Not_ChargeUP.Columns["BXDId"].DisplayIndex = 0;
                gvBXD_Not_ChargeUP.Columns["BXDId"].HeaderText = "序号";
                gvBXD_Not_ChargeUP.Columns["BXDate"].DisplayIndex = 1;
                gvBXD_Not_ChargeUP.Columns["BXDate"].HeaderText = "报销日期";
                gvBXD_Not_ChargeUP.Columns["PsnType"].DisplayIndex = 2;
                gvBXD_Not_ChargeUP.Columns["PsnType"].HeaderText = "人员类别";
                gvBXD_Not_ChargeUP.Columns["YBH"].DisplayIndex = 3;
                gvBXD_Not_ChargeUP.Columns["YBH"].HeaderText = "医保号";
                gvBXD_Not_ChargeUP.Columns["Name"].DisplayIndex = 4;
                gvBXD_Not_ChargeUP.Columns["Name"].HeaderText = "姓名";
                gvBXD_Not_ChargeUP.Columns["JobNumber"].DisplayIndex = 5;
                gvBXD_Not_ChargeUP.Columns["JobNumber"].HeaderText = "工号";
                gvBXD_Not_ChargeUP.Columns["Sex"].DisplayIndex = 6;
                gvBXD_Not_ChargeUP.Columns["Sex"].HeaderText = "性别";
                gvBXD_Not_ChargeUP.Columns["Organization"].DisplayIndex = 7;
                gvBXD_Not_ChargeUP.Columns["Organization"].HeaderText = "部门";
                gvBXD_Not_ChargeUP.Columns["YYF"].DisplayIndex = 8;
                gvBXD_Not_ChargeUP.Columns["YYF"].HeaderText = "医药费";
                gvBXD_Not_ChargeUP.Columns["BXJE"].DisplayIndex = 9;
                gvBXD_Not_ChargeUP.Columns["BXJE"].HeaderText = "报销金额";
                gvBXD_Not_ChargeUP.Columns["ZLF"].DisplayIndex = 10;
                gvBXD_Not_ChargeUP.Columns["ZLF"].HeaderText = "自理费";
                gvBXD_Not_ChargeUP.Columns["TCJJ"].DisplayIndex = 11;
                gvBXD_Not_ChargeUP.Columns["TCJJ"].HeaderText = "统筹基金";
                gvBXD_Not_ChargeUP.Columns["Accountant"].DisplayIndex = 12;
                gvBXD_Not_ChargeUP.Columns["Accountant"].HeaderText = "会计";

                gvBXD_Not_ChargeUP.Columns["AttNumber"].Visible = false;
                gvBXD_Not_ChargeUP.Columns["GRZFei"].Visible = false;
                gvBXD_Not_ChargeUP.Columns["GRZFu"].Visible = false;
                gvBXD_Not_ChargeUP.Columns["IdentityCard"].Visible = false;
                gvBXD_Not_ChargeUP.Columns["Birthday"].Visible = false;
                gvBXD_Not_ChargeUP.Columns["ChargeUpSign"].Visible = false;
                gvBXD_Not_ChargeUP.Columns["MPeriodId"].Visible = false;
            }
        }

        //显示报销明细记录。
        private void Show_Bxmx(int bxdId)
        {
            gvBXMX.DataSource = bllBXMX.GetBXMX_By_BXDId(bxdId);

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

            gvBXMX.Columns["BXDId"].Visible = false;
        }

        //激发报销单被选中后事件。
        private void gvBXD_Not_ChargeUP_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int bxdId;
            bxdId = (int)gvBXD_Not_ChargeUP.Rows[e.RowIndex].Cells["BXDId"].Value;
            Show_Bxmx(bxdId);
            if (BxdSelected != null)
            {
                BxdSelectedEventArgs arg = new BxdSelectedEventArgs();
                arg.BxdId = bxdId;
                BxdSelected(this, arg);
            }
        }

        // 删除发票明细记录。
        private void btnDeleteBxmx_Click(object sender, EventArgs e)
        {
            if (gvBXMX.SelectedRows.Count > 0)
            {
                int bxmxId = 0;
                bxmxId = Convert.ToInt32(gvBXMX.SelectedRows[0].Cells["BXMXId"].Value);
                if (MessageBox.Show("要删除编号为 " + bxmxId.ToString() + " 的报销明细记录吗?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bllBXMX.DeleteBXMX(bxmxId);
                    int bxdId = 0;
                    bxdId = (int)gvBXD_Not_ChargeUP.SelectedRows[0].Cells["BXDId"].Value;

                    //保存报销明细汇总到报销单
                    bllBXD.Save_BXMX_Stat_To_BXD(bxdId);

                    Show_Bxmx(bxdId);
                }
            }
            else
            {
                MessageBox.Show("请选择报销单明细记录");
            }
        }

        //报销单被冲帐。
        private void btnBalance_Click(object sender, EventArgs e)
        {
            int bxdid;
            bool result = false;
            if (gvBXD_Not_ChargeUP.SelectedRows.Count > 0)
            {
                bxdid = (int)gvBXD_Not_ChargeUP.SelectedRows[0].Cells["BXDId"].Value;

                if (MessageBox.Show("确认第 " + bxdid.ToString() + " 号记录被冲帐吗？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (result = bllBXD.DeleteBXD(bxdid))
                    {
                        ShowBXDList();
                        MessageBox.Show("冲账成功");
                    }

                }
            }
            else
            {
                MessageBox.Show("请先查询", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // 点击“修改”报销明细按钮。
        private void btnUpdateFpmx_Click(object sender, EventArgs e)
        {
            if (gvBXMX.SelectedRows.Count > 0)
            {
                int bxmxId = 0;
                bxmxId = (int)gvBXMX.SelectedRows[0].Cells["BXMXId"].Value;
                MRS.Model.BXMX bxmx = bllBXMX.GetBxmx_By_BxmxId(bxmxId);

                MRS.MRModule.InputInvoice invoice = new MRModule.InputInvoice();
                invoice.InvoiceGetted += new MRModule.InvoiceGetEventHandler(invoice_InvoiceGetted);
                invoice.Bxmx = bxmx;
                invoice.ShowDialog(this);
            }
        }

        // 报销明细被修改.
        void invoice_InvoiceGetted(Model.BXMX bxmx)
        {
            bllBXMX.UpdateBXMX(bxmx);
            bllBXD.Save_BXMX_Stat_To_BXD(bxmx.BXDId);
            Show_Bxmx(bxmx.BXDId);
        }

        // 点击“添加”报销明细按钮。
        private void btnAddFpmx_Click(object sender, EventArgs e)
        {
            if (gvBXD_Not_ChargeUP.SelectedRows.Count > 0)
            {
                MRS.MRModule.InputInvoice invoice = new MRModule.InputInvoice();
                invoice.InvoiceGetted += new MRModule.InvoiceGetEventHandler(AddInvoice_InvoiceGetted);
                invoice.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("请选择报销单记录。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // 当收集完毕报销发票明细数据后，添加报销明细
        void AddInvoice_InvoiceGetted(Model.BXMX bxmx)
        {
            if (gvBXD_Not_ChargeUP.SelectedRows.Count > 0)
            {
                int bxdId = (int)gvBXD_Not_ChargeUP.SelectedRows[0].Cells["BXDId"].Value;
                //需要给bxmx 赋bxdId,和报销比例。
                MRS.Model.BXD bxd = bllBXD.GetBXD_By_BXDId(bxdId);
                
                bxmx.BXDId = bxdId;
                bxmx.ReimbursementRatio = bll_ratio.GetRatio(bxd.MPeriodId, bxd.YBH, bxmx.JZFS);
                bllBXMX.AddBXMX(bxmx);
                bllBXD.Save_BXMX_Stat_To_BXD(bxdId);
                Show_Bxmx(bxmx.BXDId);
            }

        }

        // 打印预览报销单凭证。
        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog ppd = new PrintPreviewDialog();

            ppd.Document = WarrantPrintDocument;
            ppd.PrintPreviewControl.Zoom = 1;
            ppd.Width = 650;
            ppd.Height = 500;
            ppd.ShowDialog(this);
        }

        // 打印报销单凭证。
        private void WarrantPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (gvBXD_Not_ChargeUP.Rows.Count > 0)
            {
                int bxdId;
                bxdId = (int)gvBXD_Not_ChargeUP.SelectedRows[0].Cells["BXDId"].Value;

                MRS.MRModule.DrawWarrantGraphic dwg = new MRS.MRModule.DrawWarrantGraphic();

                dwg.BaoXiaoDan = bllBXD.GetBXD_By_BXDId(bxdId);

                ((System.Drawing.Printing.PrintDocument)sender).DocumentName = "报销凭证 " + dwg.BaoXiaoDan.Name + " 记录单号：" + dwg.BaoXiaoDan.BXDId.ToString();


                dwg.WarrantTable = bllBXD.CreateBXWarrantTable(bxdId);
                dwg.Draw(e.Graphics);
            }
            else
            {
                MessageBox.Show("无凭证可打印！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gvBXMX_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnUpdateFpmx.PerformClick();
        }

        //激发报销单被双击后事件。
        private void gvBXD_Not_ChargeUP_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int bxdId;
            bxdId = (int)gvBXD_Not_ChargeUP.Rows[e.RowIndex].Cells["BXDId"].Value;
            if (BxdDoubleClicked != null)
            {
                BxdSelectedEventArgs arg = new BxdSelectedEventArgs();
                arg.BxdId = bxdId;
                BxdDoubleClicked(this, arg);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ShowBXDList();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog(this) == DialogResult.OK)
            {
                printDialog1.Document = WarrantPrintDocument;
                WarrantPrintDocument.PrinterSettings = printDialog1.PrinterSettings;
                WarrantPrintDocument.Print();
            }
            
        }
    }




}

namespace MRS
{
    public class BxdSelectedEventArgs : EventArgs
    {
        public int BxdId
        {
            get;
            set;
        }
    }

    public delegate void BxdSelectedDelegate(object sender, BxdSelectedEventArgs e);
}
