using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MRS.MRModule
{
    public delegate void InvoiceGetEventHandler(MRS.Model.BXMX bxmx);

    public partial class InputInvoice : Form
    {

        public event InvoiceGetEventHandler InvoiceGetted;

        public MRS.Model.BXMX Bxmx
        {
            get;
            set;
        }

        public InputInvoice()
        {
            InitializeComponent();
            InitInputInvoice();
            InitSimpleCalc();
            textBox1.Text = @"    ���Ը����Ը�˵��������ҽ������ҩƷ������ҽ�Ʒ�����Ŀ��ת��ؾ�ҽ������ҽ�Ʒѣ��ò��ַ��ð��涨Ӧ�ɡ������Ը�����̯�����ڡ������ʻ������Ϊ�������£����������ʻ�֧����Ŀǰ�����ݹ�˾�涨���ò��ַ��ò����ڹ�˾����ҽ��������Χ��Ӧ��۳���
    �����ı���ʵ���˼򵥵ļӼ����ܣ�δʵ�ֳ˳����ܡ�";
            cbIsZero.Checked = false;
        }



        /// <summary>
        /// ��ʼ�������봰��.
        /// </summary>
        private void InitInputInvoice()
        {
            //�󶨾��﷽ʽ�����ؼ�����
            cbJZFS_DataBind();

            mtbFPDate.Text = System.DateTime.Now.Year.ToString();

            tbGRZFei.TextChanged += new System.EventHandler(Show_YYF);
            tbGRZFu.TextChanged += new System.EventHandler(Show_YYF);
            tbGRZFBao.TextChanged += new System.EventHandler(Show_YYF);
            tbGRCDBao.TextChanged += new System.EventHandler(Show_YYF);
            tbLNZHBao.TextChanged += new EventHandler(Show_YYF);
            tbTCJJ.TextChanged += new System.EventHandler(Show_YYF);

            tbGRZFei.KeyPress += new KeyPressEventHandler(AllowNumber);
            tbGRZFu.KeyPress += new KeyPressEventHandler(AllowNumber);
            tbGRZFBao.KeyPress += new KeyPressEventHandler(AllowNumber);
            tbGRCDBao.KeyPress += new KeyPressEventHandler(AllowNumber);
            tbLNZHBao.KeyPress += new KeyPressEventHandler(AllowNumber);
            tbTCJJ.KeyPress += new KeyPressEventHandler(AllowNumber);

            mtbFPDate.KeyPress += new KeyPressEventHandler(ActiveNextControl);
            cbJZFS.KeyPress += new KeyPressEventHandler(ActiveNextControl);
            tbGRZFei.KeyPress += new KeyPressEventHandler(ActiveNextControl);
            tbGRZFu.KeyPress += new KeyPressEventHandler(ActiveNextControl);
            tbGRZFBao.KeyPress += new KeyPressEventHandler(ActiveNextControl);
            tbGRCDBao.KeyPress += new KeyPressEventHandler(ActiveNextControl);
            tbLNZHBao.KeyPress += new KeyPressEventHandler(ActiveNextControl);
            tbTCJJ.KeyPress += new KeyPressEventHandler(ActiveNextControl);
            tbGRZFuHide.KeyPress += new KeyPressEventHandler(ActiveNextControl);
            cbIsZero.KeyPress += new KeyPressEventHandler(ActiveNextControl);

            mtbFPDate.Enter += new EventHandler(SelectAllText);
            tbGRZFei.Enter += new EventHandler(SelectAllText);
            tbGRZFu.Enter += new EventHandler(SelectAllText);
            tbGRZFBao.Enter += new EventHandler(SelectAllText);
            tbGRCDBao.Enter += new EventHandler(SelectAllText);
            tbLNZHBao.Enter += new EventHandler(SelectAllText);
            tbTCJJ.Enter += new EventHandler(SelectAllText);

            tbGRZFei.Leave += new EventHandler(SetZero_Leave);
            tbGRZFu.Leave += new EventHandler(SetZero_Leave);
            tbGRZFBao.Leave += new EventHandler(SetZero_Leave);
            tbGRCDBao.Leave += new EventHandler(SetZero_Leave);
            tbLNZHBao.Leave += new EventHandler(SetZero_Leave);
            tbTCJJ.Leave += new EventHandler(SetZero_Leave);


        }

        #region ��Ӧ�����ı�������¼��ķ�����

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

        protected void Show_YYF(object sender, EventArgs e)
        {
            lbYYF_number.Text = AddUpYYF().ToString();
        }

        //�ϼ�ҽҩ��
        protected decimal AddUpYYF()
        {
            decimal grzfei, grzfu, grzfbao, grcdbao, lnzhbao, tcjj;
            try
            {
                grzfei = Convert.ToDecimal(tbGRZFei.Text);
                grzfu = Convert.ToDecimal(tbGRZFu.Text);
                grzfbao = Convert.ToDecimal(tbGRZFBao.Text);
                grcdbao = Convert.ToDecimal(tbGRCDBao.Text);
                lnzhbao = Convert.ToDecimal(tbLNZHBao.Text);
                tcjj = Convert.ToDecimal(tbTCJJ.Text);
            }
            catch
            {
                grzfei = grzfu = grzfbao = grcdbao = lnzhbao = tcjj = 0;
            }

            return grzfei + grzfu + grzfbao + grcdbao + lnzhbao + tcjj;
        }

        void ActiveNextControl(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        protected void SelectAllText(object sender, EventArgs e)
        {
            try
            {
                ((TextBox)sender).SelectAll();
            }
            catch
            {
                ((MaskedTextBox)sender).SelectAll();
            }
        }


        void SetZero_Leave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Trim() == "")
            {
                ((TextBox)sender).Text = "0.00";
            }
        }

        #endregion

        /// <summary>
        /// �󶨾��﷽ʽComboBox�ؼ������ݡ�
        /// </summary>
        private void cbJZFS_DataBind()
        {
            MRS.BLL.HspType hspType = new MRS.BLL.HspType();

            cbJZFS.DataSource = hspType.GetHspTypeAll();
            cbJZFS.DisplayMember = "Name";
            cbJZFS.ValueMember = "Id";
        }

        //������������ݣ����������ݡ�
        private bool CheckInputTextBox()
        {
            bool pass = true;������//��ʶ���μ���Ƿ�ͨ��

            //��鷢Ʊ�����Ƿ����룮

            DateTime fpDate, fpDateC;
            fpDate = new DateTime();
            fpDateC = new DateTime();
            DateTime.TryParse(mtbFPDate.Text, out fpDate);

            if (fpDate.Year == fpDateC.Year || fpDate > System.DateTime.Now)
            {
                MessageBox.Show("��Ʊ������������", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pass = false;
            }

            tbGRZFei.Text = tbGRZFei.Text.Trim() == "" ? "0.00" : tbGRZFei.Text;
            tbGRZFu.Text = tbGRZFu.Text.Trim() == "" ? "0.00" : tbGRZFu.Text;
            tbGRZFBao.Text = tbGRZFBao.Text.Trim() == "" ? "0.00" : tbGRZFBao.Text;
            tbGRCDBao.Text = tbGRCDBao.Text.Trim() == "" ? "0.00" : tbGRCDBao.Text;
            tbLNZHBao.Text = tbLNZHBao.Text.Trim() == "" ? "0.00" : tbLNZHBao.Text;
            tbTCJJ.Text = tbTCJJ.Text.Trim() == "" ? "0.00" : tbTCJJ.Text;

            return pass;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (CheckInputTextBox())
            {
                MRS.Model.BXMX bxmx = new Model.BXMX();
                if (this.Bxmx != null)
                {
                    bxmx = this.Bxmx.Clone();
                }
                bxmx.FPDate = Convert.ToDateTime(mtbFPDate.Text);
                bxmx.YYF = Convert.ToDecimal(lbYYF_number.Text);
                bxmx.GRZFei = Convert.ToDecimal(tbGRZFei.Text);
                bxmx.GRZFu = Convert.ToDecimal(tbGRZFu.Text);
                decimal grzfuHide = 0M;
                decimal.TryParse(tbGRZFuHide.Text, out grzfuHide);
                bxmx.GRZFuHide = grzfuHide;
                bxmx.GRZFBao = Convert.ToDecimal(tbGRZFBao.Text);
                bxmx.GRCDBao = Convert.ToDecimal(tbGRCDBao.Text);
                bxmx.LNZHBao = Convert.ToDecimal(tbLNZHBao.Text);
                bxmx.TCJJ = Convert.ToDecimal(tbTCJJ.Text);
                bxmx.JZFS = ((MRS.Model.HspType)cbJZFS.SelectedItem).Name;

                if (this.InvoiceGetted != null)
                {
                    InvoiceGetted(bxmx);
                }
                this.Close();
            }
        }

        private void btnGetDate_Click(object sender, EventArgs e)
        {
            mcFPDate.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mcFPDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            mtbFPDate.Text = e.Start.GetDateTimeFormats('D')[1].ToString();
            ((MonthCalendar)sender).Visible = false;
        }

        //���ô�����ʽ
        private void cbIsZero_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)        //�������Ϊ��
            {
                this.Height = 385;
                btnOK.Top = 321;
                btnClose.Top = 321;
                groupBox1.Visible = true;
                this.Refresh();
            }
            else                                   //����������
            {
                this.Height = 242;
                btnOK.Top = 180;
                btnClose.Top = 180;
                groupBox1.Visible = false;
                this.Refresh();
            }
        }

        private void InputInvoice_Load(object sender, EventArgs e)
        {
            if (this.Bxmx != null && Bxmx.BXMXId > 0)
            {
                mtbFPDate.Text = string.Format("{0:yyyMMdd}", Bxmx.FPDate);
                lbYYF_number.Text = Bxmx.YYF.ToString();
                tbGRZFei.Text = Bxmx.GRZFei.ToString();
                tbGRZFu.Text = Bxmx.GRZFu.ToString();

                tbGRZFuHide.Text = Bxmx.GRZFuHide.ToString();
                tbGRZFBao.Text = Bxmx.GRZFBao.ToString();
                tbGRCDBao.Text = Bxmx.GRCDBao.ToString();
                tbLNZHBao.Text = Bxmx.LNZHBao.ToString();
                tbTCJJ.Text = Bxmx.TCJJ.ToString();


                foreach (object item in cbJZFS.Items)
                {
                    if (cbJZFS.GetItemText(item) == Bxmx.JZFS)
                    {
                        cbJZFS.SelectedItem = item;
                    }
                }

                if (Bxmx.GRZFuHide > 0)
                {
                    cbIsZero.Checked = true;
                }
            }
        }

    }

}