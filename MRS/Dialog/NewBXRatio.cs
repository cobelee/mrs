using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MRS.Dialog
{
    public partial class NewBXRatio : Form
    {
        private Model.BXRatio ratioRule;

        public NewBXRatio()
        {
            InitializeComponent();
            tbBXRatio.KeyPress += new KeyPressEventHandler(AllowNumber);
            tbMin.KeyPress += new KeyPressEventHandler(AllowNumber);
            tbMax.KeyPress += new KeyPressEventHandler(AllowNumber);

            ratioRule = new MRS.Model.BXRatio();
        }

        /// <summary>
        /// 报销比例规则。
        /// </summary>
        public Model.BXRatio BXRatioRule
        {
            get { return ratioRule; }
            set { ratioRule = value; }
        }

        protected void ccbHspType_DataBind()
        {
            BLL.HspType bll_HspType = new MRS.BLL.HspType();

            IList<Model.HspType> hspTypes = bll_HspType.GetHspTypeAll();
            foreach (Model.HspType type in hspTypes)
            {
                cbbHspType.Items.Add(type);
            }
            if (cbbHspType.Items.Count > 0)
            {
                cbbHspType.SelectedIndex = 0;
            }
        }

        private void NewBXRatio_Load(object sender, EventArgs e)
        {
            ccbHspType_DataBind();
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                decimal min, max, ratio;
                decimal.TryParse(tbMin.Text, out min);
                decimal.TryParse(tbMax.Text, out max);
                decimal.TryParse(tbBXRatio.Text, out ratio);
                this.ratioRule.MinKBJE = min;
                this.ratioRule.MaxKBJE = max;
                this.ratioRule.OrderNumber = 0;
                this.ratioRule.HspType = cbbHspType.SelectedItem.ToString();
                this.ratioRule.Ratio = ratio;
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private void groupBox1_Validating(object sender, CancelEventArgs e)
        {
            decimal min, max;
            decimal.TryParse(tbMin.Text, out min);
            decimal.TryParse(tbMax.Text, out max);
            if (max > 0 && min > max)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbMin as Control, "该值不允许大于最大值");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbMin as Control, null);
            }
        }

        private void tbBXRatio_Validating(object sender, CancelEventArgs e)
        {
            decimal ratio;
            decimal.TryParse(tbBXRatio.Text, out ratio);
            if (ratio > 1 || ratio < 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbBXRatio as Control, "该值介于0与1之间的两位数小数");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbBXRatio as Control, null);
            }
        }
    }
}