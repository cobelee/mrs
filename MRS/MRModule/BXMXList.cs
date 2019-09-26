using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MRS.MRModule
{
    /// <summary>
    /// 该窗口将被废弃。
    /// </summary>
    public partial class BXMXList : Form
    {
        protected BLL.BXMX bll_bxmx = new MRS.BLL.BXMX();
        protected BLL.BXD bll_bxd = new MRS.BLL.BXD();

        private int bxdId;
        private int nudAttNumber;

        public int BXDId
        {
            get { return bxdId; }
            set { bxdId = value; }
        }

        /// <summary>
        /// 报销单明细列表。
        /// </summary>
        /// <param name="bxdId">报销单号。</param>
        public BXMXList(int bxdId)
        {
            InitializeComponent();
            this.bxdId = bxdId;
        }

        private void dgvBXMX_DataBind(int bxdId)
        {

            dgvBXMX.DataSource = bll_bxmx.GetBXMX_By_BXDId(bxdId);

            dgvBXMX.Columns["BXMXId"].HeaderText = "序号";
            dgvBXMX.Columns["BXMXId"].DisplayIndex = 0;
            dgvBXMX.Columns["BXMXId"].Visible = false;

            dgvBXMX.Columns["FPDate"].HeaderText = "发票日期";
            dgvBXMX.Columns["FPDate"].DisplayIndex = 1;

            dgvBXMX.Columns["JZFS"].HeaderText = "就诊方式";
            dgvBXMX.Columns["JZFS"].DisplayIndex = 2;
            dgvBXMX.Columns["JZFS"].SortMode = DataGridViewColumnSortMode.Automatic;

            dgvBXMX.Columns["YYF"].HeaderText = "医药费";
            dgvBXMX.Columns["YYF"].DisplayIndex = 3;

            dgvBXMX.Columns["GRZFei"].HeaderText = "个人自费";
            dgvBXMX.Columns["GRZFei"].DisplayIndex = 4;

            dgvBXMX.Columns["GRZFu"].HeaderText = "个人自付";
            dgvBXMX.Columns["GRZFu"].DisplayIndex = 5;

            dgvBXMX.Columns["GRZFBao"].HeaderText = "个人自负";
            dgvBXMX.Columns["GRZFBao"].DisplayIndex = 6;

            dgvBXMX.Columns["GRCDBao"].HeaderText = "个人承担";
            dgvBXMX.Columns["GRCDBao"].DisplayIndex = 7;

            dgvBXMX.Columns["LNZHBao"].HeaderText = "历年账户";
            dgvBXMX.Columns["LNZHBao"].DisplayIndex = 8;

            dgvBXMX.Columns["TCJJ"].HeaderText = "统筹基金";
            dgvBXMX.Columns["TCJJ"].DisplayIndex = 9;

            dgvBXMX.Columns["ReimbursementRatio"].HeaderText = "报销比例";
            dgvBXMX.Columns["ReimbursementRatio"].DisplayIndex = 10;

            dgvBXMX.Columns["GRZFuHide"].HeaderText = "隐性个人自付";
            dgvBXMX.Columns["GRZFuHide"].DisplayIndex = 11;

            dgvBXMX.Columns["BXDId"].Visible = false;

        }

        private void BXMXList_Load(object sender, EventArgs e)
        {
            if (bxdId > 0)
            {
                Model.BXD bxd = bll_bxd.GetBXD_By_BXDId(bxdId);
                lbBXDId.Text = bxdId.ToString();
                lbName.Text = bxd.Name;
                nudAttNumber = bxd.AttNumber;
                dgvBXMX_DataBind(bxdId);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("删除该记录吗?", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.nudAttNumber--;
                bll_bxmx.DeleteBXMX(Convert.ToInt32(dgvBXMX.SelectedRows[0].Cells["BXMXId"].Value));


                //保存报销明细汇总到报销单
                bll_bxd.Save_BXMX_Stat_To_BXD(bxdId, this.nudAttNumber);

                dgvBXMX_DataBind(this.bxdId);
            }
        }
    }
}