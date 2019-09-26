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
    public partial class Balance : Form
    {
        MRS.BLL.BXD bllBXD;

        public Balance()
        {
            InitializeComponent();
            InitBalance();
        }

        public void InitBalance()
        {
            bllBXD = new MRS.BLL.BXD();
        }


        private void btnQuery_Click(object sender, EventArgs e)
        {
            IList<MRS.Model.BXD> bxds = new List<MRS.Model.BXD>();
            bxds = bllBXD.GetBXD_With_Not_Charge_Up();

            if (bxds.Count > 0)
            {
                gvBalance.DataSource = bxds;

                gvBalance.Columns["BXDId"].DisplayIndex = 0;
                gvBalance.Columns["BXDId"].HeaderText = "序号";
                gvBalance.Columns["BXDate"].DisplayIndex = 1;
                gvBalance.Columns["BXDate"].HeaderText = "报销日期";
                gvBalance.Columns["PsnType"].DisplayIndex = 2;
                gvBalance.Columns["PsnType"].HeaderText = "人员类别";
                gvBalance.Columns["YBH"].DisplayIndex = 3;
                gvBalance.Columns["YBH"].HeaderText = "医保号";
                gvBalance.Columns["Name"].DisplayIndex = 4;
                gvBalance.Columns["Name"].HeaderText = "姓名";
                gvBalance.Columns["JobNumber"].DisplayIndex = 5;
                gvBalance.Columns["JobNumber"].HeaderText = "工号";
                gvBalance.Columns["Sex"].DisplayIndex = 6;
                gvBalance.Columns["Sex"].HeaderText = "性别";
                gvBalance.Columns["Organization"].DisplayIndex = 7;
                gvBalance.Columns["Organization"].HeaderText = "部门";
                gvBalance.Columns["YYF"].DisplayIndex = 8;
                gvBalance.Columns["YYF"].HeaderText = "医药费";
                gvBalance.Columns["BXJE"].DisplayIndex = 9;
                gvBalance.Columns["BXJE"].HeaderText = "报销金额";
                gvBalance.Columns["ZLF"].DisplayIndex = 10;
                gvBalance.Columns["ZLF"].HeaderText = "自理费";
                gvBalance.Columns["TCJJ"].DisplayIndex = 11;
                gvBalance.Columns["TCJJ"].HeaderText = "统筹基金";
                gvBalance.Columns["Accountant"].DisplayIndex = 12;
                gvBalance.Columns["Accountant"].HeaderText = "会计";

                gvBalance.Columns["AttNumber"].Visible = false;
                gvBalance.Columns["GRZFei"].Visible = false;
                gvBalance.Columns["GRZFu"].Visible = false;
                gvBalance.Columns["IdentityCard"].Visible = false;
                gvBalance.Columns["Birthday"].Visible = false;
                gvBalance.Columns["ChargeUpSign"].Visible = false;
                gvBalance.Columns["MPeriodId"].Visible = false;
            }
            else
            {
                MessageBox.Show("没有未记帐的报销记录", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            int bxdid;
            bool result = false;
            if (gvBalance.Rows.Count > 0)
            {
                bxdid = (int)gvBalance.SelectedRows[0].Cells["BXDId"].Value;


                if (MessageBox.Show("确认第" + bxdid.ToString() + "号记录被冲帐吗？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (result = bllBXD.DeleteBXD(bxdid))
                    {
                        MessageBox.Show("冲账成功");
                    }

                }
            }
            else
            {
                MessageBox.Show("请先查询", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void gvBalance_DoubleClick(object sender, EventArgs e)
        {
            
            int bxdid;
            if (gvBalance.Rows.Count > 0)
            {
                bxdid = (int)gvBalance.SelectedRows[0].Cells["BXDId"].Value;

                BXMXList bxmxList = new BXMXList(bxdid);
                bxmxList.Show(this);

            }
            else
            {
                MessageBox.Show("请先查询", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}