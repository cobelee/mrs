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
    /// ����Ϊ InputInvoice ����Ĳ����࣬��Ҫ����ʵ�� tbGRZFuHide �ı���ļ򵥼��㹦�ܡ�
    /// Ŀǰֻ֧�ּ򵥼Ӽ����ܣ�δ�г˳����ܡ�
    /// </summary>
    public partial class InputInvoice
    {
        decimal CalcResult;
        bool IsCalculated = false;
        string CalcMethod = "+";

        private void InitSimpleCalc()
        {
            tbGRZFuHide.KeyPress += new KeyPressEventHandler(FilterInputChar);
            tbGRZFuHide.KeyPress += new KeyPressEventHandler(GetOperator);
            btnInitCalc.Click += new EventHandler(btnInitCalc_Click);
        }

        void btnInitCalc_Click(object sender, EventArgs e)
        {
            CalcMethod = "+";
            IsCalculated = false;
            CalcResult = 0;
            tbGRZFuHide.Text = "0.0";
            tbGRZFuHide.SelectAll();
        }

        /// <summary>
        /// ���˷������ַ����˸�8���س���13��С���㣺46
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FilterInputChar(object sender, KeyPressEventArgs e)
        {
            //���´��뽫���˵������ּ����˸񣬷ǻس�����С����������ַ���
            if ((e.KeyChar != 8 && !char.IsDigit(e.KeyChar)) && e.KeyChar != 13 && e.KeyChar != 46)
            {
                e.Handled = true;
            }

            if (char.IsDigit(e.KeyChar) && IsCalculated)
            {
                tbGRZFuHide.Text = string.Empty;
                IsCalculated = false;
            }
        }

        /// <summary>
        /// �ػ������������Ӻţ�43�����ţ�45�����ڣ�61��ȷ����13
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GetOperator(object sender, KeyPressEventArgs e)
        {
            lbKeyCharNumber.Text = ((int)e.KeyChar).ToString();
            //�����յ�������+��
            if (e.KeyChar == 43)
            {
                Calculate();
                CalcMethod = "+";
            }

            if (e.KeyChar == 45)
            {
                Calculate();
                CalcMethod = "-";
            }

            if (e.KeyChar == 61 || e.KeyChar == 13)
            {
                Calculate();
            }
        }

        void Calculate()
        {
            if (CalcMethod == "+" && IsCalculated == false && tbGRZFuHide.Text != "")
            {
                CalcResult += Convert.ToDecimal(tbGRZFuHide.Text);
                tbGRZFuHide.Text = CalcResult.ToString();
            }

            if (CalcMethod == "-" && IsCalculated == false && tbGRZFuHide.Text != "")
            {
                CalcResult -= Convert.ToDecimal(tbGRZFuHide.Text);
                tbGRZFuHide.Text = CalcResult.ToString();
            }

            IsCalculated = true;
        }
    }
}