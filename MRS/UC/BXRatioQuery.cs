using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MRS.UC
{
    public partial class BXRatioQuery : UserControl
    {
        public BXRatioQuery()
        {
            InitializeComponent();
        }

        protected void dgvBXRatio_DataBind()
        {
            BLL.BXRatio bll_ratio = new MRS.BLL.BXRatio();
            dgvBXRatio.DataSource = bll_ratio.Select();

            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvBXRatio.Columns["Id"].Visible = false;
            dgvBXRatio.Columns["OrderNumber"].Visible = false;
            dgvBXRatio.Columns["MinKBJE"].HeaderText = "下限值(非包含)元";
            dgvBXRatio.Columns["MinKBJE"].DefaultCellStyle = style;

            dgvBXRatio.Columns["MaxKBJE"].HeaderText = "上限值(包含)元";
            dgvBXRatio.Columns["MaxKBJE"].DefaultCellStyle = style;

            dgvBXRatio.Columns["HspType"].HeaderText = "就诊方式";
            dgvBXRatio.Columns["HspType"].DisplayIndex = 0;

            dgvBXRatio.Columns["Ratio"].HeaderText = "报销比例";
            dgvBXRatio.Columns["Ratio"].DefaultCellStyle = style;
        }

        private void BXRatioQuery_Load(object sender, EventArgs e)
        {
            dgvBXRatio_DataBind();
        }
    }
}