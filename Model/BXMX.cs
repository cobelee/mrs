using System;
using System.Collections.Generic;
using System.Text;

namespace MRS.Model
{
    /// <summary>
    /// 报销单明细。
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

        private int mBXMXId;                       //报销单明细号
        private int mBXDId;                        //报销单号
        private DateTime mFPDate;                  //医院就诊发票日期
        private decimal mYYF;                      //医药费
        private decimal mGRZFei;                   //个人自费
        private decimal mGRZFu;                    //个人自付
        private decimal mGRZFuHide;                //隐性个人自付   2009年5月9日修改添加
        private decimal mGRZFBao;                  //个人自负
        private decimal mGRCDBao;                  //个人承担
        private decimal mLNZHBao;                  //历年账户
        private decimal mTCJJ;                     //统筹基金
        private string mJZFS;                      //就诊方式
        private decimal mReimbursementRatio;       //报销比例

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
        /// 医药费
        /// </summary>
        public decimal YYF
        {
            get { return mYYF; }
            set { mYYF = value; }
        }

        /// <summary>
        /// 个人自费
        /// </summary>
        public decimal GRZFei
        {
            get { return mGRZFei; }
            set { mGRZFei = value; }
        }

        /// <summary>
        /// 个人自付
        /// </summary>
        public decimal GRZFu
        {
            get { return mGRZFu; }
            set { mGRZFu = value; }
        }

        /// <summary>
        /// 隐性个人自付   2009年5月9日修改添加
        /// </summary>
        public decimal GRZFuHide
        {
            get { return mGRZFuHide; }
            set { mGRZFuHide = value; }
        }

        /// <summary>
        /// 个人自负
        /// </summary>
        public decimal GRZFBao
        {
            get { return mGRZFBao; }
            set { mGRZFBao = value; }
        }

        /// <summary>
        /// 个人承担
        /// </summary>
        public decimal GRCDBao
        {
            get { return mGRCDBao; }
            set { mGRCDBao = value; }
        }

        /// <summary>
        /// 历年账户
        /// </summary>
        public decimal LNZHBao
        {
            get { return mLNZHBao; }
            set { mLNZHBao = value; }
        }

        /// <summary>
        /// 统筹基金
        /// </summary>
        public decimal TCJJ
        {
            get { return mTCJJ; }
            set { mTCJJ = value; }
        }

        /// <summary>
        /// 就诊方式
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
