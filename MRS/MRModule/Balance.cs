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
    /// �ô��ڽ���������
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
                gvBalance.Columns["BXDId"].HeaderText = "���";
                gvBalance.Columns["BXDate"].DisplayIndex = 1;
                gvBalance.Columns["BXDate"].HeaderText = "��������";
                gvBalance.Columns["PsnType"].DisplayIndex = 2;
                gvBalance.Columns["PsnType"].HeaderText = "��Ա���";
                gvBalance.Columns["YBH"].DisplayIndex = 3;
                gvBalance.Columns["YBH"].HeaderText = "ҽ����";
                gvBalance.Columns["Name"].DisplayIndex = 4;
                gvBalance.Columns["Name"].HeaderText = "����";
                gvBalance.Columns["JobNumber"].DisplayIndex = 5;
                gvBalance.Columns["JobNumber"].HeaderText = "����";
                gvBalance.Columns["Sex"].DisplayIndex = 6;
                gvBalance.Columns["Sex"].HeaderText = "�Ա�";
                gvBalance.Columns["Organization"].DisplayIndex = 7;
                gvBalance.Columns["Organization"].HeaderText = "����";
                gvBalance.Columns["YYF"].DisplayIndex = 8;
                gvBalance.Columns["YYF"].HeaderText = "ҽҩ��";
                gvBalance.Columns["BXJE"].DisplayIndex = 9;
                gvBalance.Columns["BXJE"].HeaderText = "�������";
                gvBalance.Columns["ZLF"].DisplayIndex = 10;
                gvBalance.Columns["ZLF"].HeaderText = "������";
                gvBalance.Columns["TCJJ"].DisplayIndex = 11;
                gvBalance.Columns["TCJJ"].HeaderText = "ͳ�����";
                gvBalance.Columns["Accountant"].DisplayIndex = 12;
                gvBalance.Columns["Accountant"].HeaderText = "���";

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
                MessageBox.Show("û��δ���ʵı�����¼", "��Ϣ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            int bxdid;
            bool result = false;
            if (gvBalance.Rows.Count > 0)
            {
                bxdid = (int)gvBalance.SelectedRows[0].Cells["BXDId"].Value;


                if (MessageBox.Show("ȷ�ϵ�" + bxdid.ToString() + "�ż�¼��������", "ѯ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (result = bllBXD.DeleteBXD(bxdid))
                    {
                        MessageBox.Show("���˳ɹ�");
                    }

                }
            }
            else
            {
                MessageBox.Show("���Ȳ�ѯ", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("���Ȳ�ѯ", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}