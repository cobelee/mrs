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
    /// 该类为 InputInvoice 窗体的部分类，主要用于实现 tbGRZFuHide 文本框的简单计算功能。
    /// 目前只支持简单加减功能，未有乘除功能。
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
        /// 过滤非数字字符。退格：8，回车：13，小数点：46
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FilterInputChar(object sender, KeyPressEventArgs e)
        {
            //以下代码将过滤掉非数字及非退格，非回车、非小数点的其它字符。
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
        /// 截获计算操作符。加号：43，减号：45，等于：61，确定：13
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GetOperator(object sender, KeyPressEventArgs e)
        {
            lbKeyCharNumber.Text = ((int)e.KeyChar).ToString();
            //若接收到按键“+”
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
