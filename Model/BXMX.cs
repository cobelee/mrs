using System;
using System.Collections.Generic;
using System.Text;

namespace MRS.Model
{
    /// <summary>
    /// ��������ϸ��
    /// </summary>
    [Serializable]
    public class BXMX
    {
        public BXMX()
        {
            InitBXMX();
        }

        private void InitBXMX()
        {
            mFPDate = new DateTime();
        }

        private int mBXMXId;                       //��������ϸ��
        private int mBXDId;                        //��������
        private DateTime mFPDate;                  //ҽԺ���﷢Ʊ����
        private decimal mYYF;                      //ҽҩ��
        private decimal mGRZFei;                   //�����Է�
        private decimal mGRZFu;                    //�����Ը�
        private decimal mGRZFuHide;                //���Ը����Ը�   2009��5��9���޸�����
        private decimal mGRZFBao;                  //�����Ը�
        private decimal mGRCDBao;                  //���˳е�
        private decimal mLNZHBao;                  //�����˻�
        private decimal mTCJJ;                     //ͳ�����
        private string mJZFS;                      //���﷽ʽ
        private decimal mReimbursementRatio;       //��������

        public int BXMXId
        {
            get { return mBXMXId; }
            set { mBXMXId = value; }
        }

        public MRS.Model.BXMX Clone()
        {
            MRS.Model.BXMX bxmx = new BXMX();
            bxmx.BXDId = this.BXDId;
            bxmx.BXMXId = this.BXMXId;
            if (this.FPDate != null)
            {
                bxmx.FPDate = this.FPDate;
            }
            bxmx.YYF = this.YYF;
            bxmx.GRZFei = this.GRZFei;
            bxmx.GRZFu = this.GRZFu;
            bxmx.GRZFuHide = this.GRZFuHide;
            bxmx.GRZFBao = this.GRZFBao;
            bxmx.GRCDBao = this.GRCDBao;
            bxmx.LNZHBao = this.LNZHBao;
            bxmx.TCJJ = this.TCJJ;
            bxmx.JZFS = this.JZFS;
            bxmx.ReimbursementRatio = this.ReimbursementRatio;

            return bxmx;
        }

        public int BXDId
        {
            get { return mBXDId; }
            set { mBXDId = value; }
        }

        public DateTime FPDate
        {
            get { return mFPDate; }
            set { mFPDate = value; }
        }

        /// <summary>
        /// ҽҩ��
        /// </summary>
        public decimal YYF
        {
            get { return mYYF; }
            set { mYYF = value; }
        }

        /// <summary>
        /// �����Է�
        /// </summary>
        public decimal GRZFei
        {
            get { return mGRZFei; }
            set { mGRZFei = value; }
        }

        /// <summary>
        /// �����Ը�
        /// </summary>
        public decimal GRZFu
        {
            get { return mGRZFu; }
            set { mGRZFu = value; }
        }

        /// <summary>
        /// ���Ը����Ը�   2009��5��9���޸�����
        /// </summary>
        public decimal GRZFuHide
        {
            get { return mGRZFuHide; }
            set { mGRZFuHide = value; }
        }

        /// <summary>
        /// �����Ը�
        /// </summary>
        public decimal GRZFBao
        {
            get { return mGRZFBao; }
            set { mGRZFBao = value; }
        }

        /// <summary>
        /// ���˳е�
        /// </summary>
        public decimal GRCDBao
        {
            get { return mGRCDBao; }
            set { mGRCDBao = value; }
        }

        /// <summary>
        /// �����˻�
        /// </summary>
        public decimal LNZHBao
        {
            get { return mLNZHBao; }
            set { mLNZHBao = value; }
        }

        /// <summary>
        /// ͳ�����
        /// </summary>
        public decimal TCJJ
        {
            get { return mTCJJ; }
            set { mTCJJ = value; }
        }

        /// <summary>
        /// ���﷽ʽ
        /// </summary>
        public string JZFS
        {
            get { return mJZFS; }
            set { mJZFS = value; }
        }

        public decimal ReimbursementRatio
        {
            get { return mReimbursementRatio; }
            set { mReimbursementRatio = value; }
        }
    }
}