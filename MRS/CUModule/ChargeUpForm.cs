using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MRS.CUModule
{
    public partial class ChargeUpForm : Form
    {
        MRS.BLL.BXD bllBXD;
        MRS.BLL.AccountBook bllAccountBook;
        public ShowAccountDelegate ShowCashier;

        public ChargeUpForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            InitChargeUpForm();
            ShowBXDList();
        }

        protected void InitChargeUpForm()
        {
            bllBXD = new MRS.BLL.BXD();
            bllAccountBook = new MRS.BLL.AccountBook();

            ShowCashier += new ShowAccountDelegate(Show_Cashier);
        }

        protected void Show_Cashier(string CashierName)
        {
            lbCashier.Text = CashierName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowBXDList()
        {
            IList<MRS.Model.BXD> bxds = bllBXD.GetBXD_With_Not_Charge_Up();

            if (bxds.Count > 0)
            {
                gvBXD_To_ChargeUP.DataSource = bxds;

                gvBXD_To_ChargeUP.Columns["BXDId"].DisplayIndex = 0;
                gvBXD_To_ChargeUP.Columns["BXDId"].HeaderText = "���";
                gvBXD_To_ChargeUP.Columns["BXDate"].DisplayIndex = 1;
                gvBXD_To_ChargeUP.Columns["BXDate"].HeaderText = "��������";
                gvBXD_To_ChargeUP.Columns["PsnType"].DisplayIndex = 2;
                gvBXD_To_ChargeUP.Columns["PsnType"].HeaderText = "��Ա���";
                gvBXD_To_ChargeUP.Columns["YBH"].DisplayIndex = 3;
                gvBXD_To_ChargeUP.Columns["YBH"].HeaderText = "ҽ����";
                gvBXD_To_ChargeUP.Columns["Name"].DisplayIndex = 4;
                gvBXD_To_ChargeUP.Columns["Name"].HeaderText = "����";
                gvBXD_To_ChargeUP.Columns["JobNumber"].DisplayIndex = 5;
                gvBXD_To_ChargeUP.Columns["JobNumber"].HeaderText = "����";
                gvBXD_To_ChargeUP.Columns["Sex"].DisplayIndex = 6;
                gvBXD_To_ChargeUP.Columns["Sex"].HeaderText = "�Ա�";
                gvBXD_To_ChargeUP.Columns["Organization"].DisplayIndex = 7;
                gvBXD_To_ChargeUP.Columns["Organization"].HeaderText = "����";
                gvBXD_To_ChargeUP.Columns["YYF"].DisplayIndex = 8;
                gvBXD_To_ChargeUP.Columns["YYF"].HeaderText = "ҽҩ��";
                gvBXD_To_ChargeUP.Columns["BXJE"].DisplayIndex = 9;
                gvBXD_To_ChargeUP.Columns["BXJE"].HeaderText = "�������";
                gvBXD_To_ChargeUP.Columns["ZLF"].DisplayIndex = 10;
                gvBXD_To_ChargeUP.Columns["ZLF"].HeaderText = "������";
                gvBXD_To_ChargeUP.Columns["TCJJ"].DisplayIndex = 11;
                gvBXD_To_ChargeUP.Columns["TCJJ"].HeaderText = "ͳ�����";
                gvBXD_To_ChargeUP.Columns["Accountant"].DisplayIndex = 12;
                gvBXD_To_ChargeUP.Columns["Accountant"].HeaderText = "���";

                gvBXD_To_ChargeUP.Columns["AttNumber"].Visible = false;
                gvBXD_To_ChargeUP.Columns["GRZFei"].Visible = false;
                gvBXD_To_ChargeUP.Columns["GRZFu"].Visible = false;
                gvBXD_To_ChargeUP.Columns["IdentityCard"].Visible = false;
                gvBXD_To_ChargeUP.Columns["Birthday"].Visible = false;
                gvBXD_To_ChargeUP.Columns["ChargeUpSign"].Visible = false;
                gvBXD_To_ChargeUP.Columns["MPeriodId"].Visible = false;
            }
        }

        private void btnChargeUp_Click(object sender, EventArgs e)
        {
            if (gvBXD_To_ChargeUP.Rows.Count > 0)
            {
                if (MessageBox.Show("ȷ��Ҫ������", "ѯ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (bllAccountBook.Charge_Up_BXD_To_AccountBook(lbCashier.Text))
                    {
                        MessageBox.Show("���˳ɹ���", "��Ϣ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("�ޱ�������¼��", "��Ϣ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}