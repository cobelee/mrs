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
        /// ��������ϸ�б���
        /// </summary>
        /// <param name="bxdId">�������š�</param>
        public BXMXList(int bxdId)
        {
            InitializeComponent();
            this.bxdId = bxdId;
        }

        private void dgvBXMX_DataBind(int bxdId)
        {

            dgvBXMX.DataSource = bll_bxmx.GetBXMX_By_BXDId(bxdId);

            dgvBXMX.Columns["BXMXId"].HeaderText = "���";
            dgvBXMX.Columns["BXMXId"].DisplayIndex = 0;
            dgvBXMX.Columns["BXMXId"].Visible = false;

            dgvBXMX.Columns["FPDate"].HeaderText = "��Ʊ����";
            dgvBXMX.Columns["FPDate"].DisplayIndex = 1;

            dgvBXMX.Columns["JZFS"].HeaderText = "���﷽ʽ";
            dgvBXMX.Columns["JZFS"].DisplayIndex = 2;
            dgvBXMX.Columns["JZFS"].SortMode = DataGridViewColumnSortMode.Automatic;

            dgvBXMX.Columns["YYF"].HeaderText = "ҽҩ��";
            dgvBXMX.Columns["YYF"].DisplayIndex = 3;

            dgvBXMX.Columns["GRZFei"].HeaderText = "�����Է�";
            dgvBXMX.Columns["GRZFei"].DisplayIndex = 4;

            dgvBXMX.Columns["GRZFu"].HeaderText = "�����Ը�";
            dgvBXMX.Columns["GRZFu"].DisplayIndex = 5;

            dgvBXMX.Columns["GRZFBao"].HeaderText = "�����Ը�";
            dgvBXMX.Columns["GRZFBao"].DisplayIndex = 6;

            dgvBXMX.Columns["GRCDBao"].HeaderText = "���˳е�";
            dgvBXMX.Columns["GRCDBao"].DisplayIndex = 7;

            dgvBXMX.Columns["LNZHBao"].HeaderText = "�����˻�";
            dgvBXMX.Columns["LNZHBao"].DisplayIndex = 8;

            dgvBXMX.Columns["TCJJ"].HeaderText = "ͳ�����";
            dgvBXMX.Columns["TCJJ"].DisplayIndex = 9;

            dgvBXMX.Columns["ReimbursementRatio"].HeaderText = "��������";
            dgvBXMX.Columns["ReimbursementRatio"].DisplayIndex = 10;

            dgvBXMX.Columns["GRZFuHide"].HeaderText = "���Ը����Ը�";
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
            if (MessageBox.Show("ɾ���ü�¼��?", "ѯ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.nudAttNumber--;
                bll_bxmx.DeleteBXMX(Convert.ToInt32(dgvBXMX.SelectedRows[0].Cells["BXMXId"].Value));


                //���汨����ϸ���ܵ�������
                bll_bxd.Save_BXMX_Stat_To_BXD(bxdId, this.nudAttNumber);

                dgvBXMX_DataBind(this.bxdId);
            }
        }
    }
}