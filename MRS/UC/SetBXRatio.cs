using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace MRS.UC
{
    public partial class SetBXRatio : UserControl
    {
        BLL.BXRatio bll_ratioRule = new MRS.BLL.BXRatio();

        public SetBXRatio()
        {
            InitializeComponent();
        }

        protected void dgvRule_DateBind()
        {
            BLL.BXRatio bll = new MRS.BLL.BXRatio();
            IList<Model.BXRatio> rules = bll.Select();
            dgvRule.DataSource = rules;

            dgvRule.Columns["Id"].Visible = false;
            dgvRule.Columns["OrderNumber"].Visible = false;
            dgvRule.Columns["MinKBJE"].HeaderText = "下限值(非包含)";
            dgvRule.Columns["MaxKBJE"].HeaderText = "上限值(包含)";
            dgvRule.Columns["HspType"].HeaderText = "就诊方式";
            dgvRule.Columns["HspType"].DisplayIndex = 0;
            dgvRule.Columns["Ratio"].HeaderText = "报销比例";
        }

        private void SetBXRatio_Load(object sender, EventArgs e)
        {
            dgvRule_DateBind();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Dialog.NewBXRatio newRatioRule = new MRS.Dialog.NewBXRatio();

            if (newRatioRule.ShowDialog(this) == DialogResult.OK)
            {
                bll_ratioRule.Insert(newRatioRule.BXRatioRule);
            }
            dgvRule_DateBind();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ruleId = 0;
            foreach (DataGridViewRow row in dgvRule.SelectedRows)
            {
                ruleId = Convert.ToInt32(row.Cells["Id"].Value);
                bll_ratioRule.Delete(ruleId);
            }
            dgvRule_DateBind();
        }
    }
}
