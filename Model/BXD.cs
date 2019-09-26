using System;
using System.Collections.Generic;
using System.Text;

namespace MRS.Model
{
    
    /// <summary>
    /// 报销单。
    /// </summary>
    [Serializable]
    public class BXD
    {
        public enum ChargeUpSignType
        {
            IsChargeUp,
            NochargeUP
        }

        public BXD()
        {
            InitBXD();
        }

        private void InitBXD()
        {
            mBXDate = new DateTime();
            mYBH = string.Empty;
            mPsnType = string.Empty;
            mAccountant = string.Empty;
        }

        private int mBXDId;              //报销单号
        private int mMPeriodId;           //医保年度。
        private DateTime mBXDate;        //报销日期
        private string mYBH;             //医保号
        private string mPsnType;         //人员类别
        private int mAttNumber;          //附件张数
        private string mAccountant;      //会计
        private decimal mYYF;            //医药费
        private decimal mBXJE;           //报销金额
        private decimal mZLF;            //自理费
        private decimal mTCJJ;           //统筹基金
        private decimal mGRZFei;         //个人自费
        private decimal mGRZFu;          //个人自付
        private string mName;            //姓名
        private string mJobNumber;       //工号
        private string mIdentityCard;    //身份证号
        private DateTime mBirthday;      //生日
        private string mOrganization;    //部门
        private string mSex;             //性别
        private string mChargeUpSign;     //记账标志


        public int BXDId
        {
            get { return mBXDId; }
            set { mBXDId = value; }
        }

        /// <summary>
        /// 医保年度Id.
        /// </summary>
        public int MPeriodId
        {
            get { return mMPeriodId; }
            set { mMPeriodId = value; }
        }

        public DateTime BXDate
        {
            get { return mBXDate; }
            set { mBXDate = value; }
        }

        public string YBH
        {
            get { return mYBH; }
            set { mYBH = value; }
        }

        public string PsnType
        {
            get { return mPsnType; }
            set { mPsnType = value; }
        }

        public int AttNumber
        {
            get { return mAttNumber; }
            set { mAttNumber = value; }
        }

        public string Accountant
        {
            get { return mAccountant; }
            set { mAccountant = value; }
        }

        public decimal YYF
        {
            get { return mYYF; }
            set { mYYF = value; }
        }

        public decimal BXJE
        {
            get { return mBXJE; }
            set { mBXJE = value; }
        }

        public decimal ZLF
        {
            get { return mZLF; }
            set { mZLF = value; }
        }

        public decimal TCJJ
        {
            get { return mTCJJ; }
            set { mTCJJ = value; }
        }

        public decimal GRZFei
        {
            get { return mGRZFei; }
            set { mGRZFei = value; }
        }

        public decimal GRZFu
        {
            get { return mGRZFu; }
            set { mGRZFu = value; }
        }

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public string JobNumber
        {
            get { return mJobNumber; }
            set { mJobNumber = value; }
        }

        public string IdentityCard
        {
            get { return mIdentityCard; }
            set { mIdentityCard = value; }
        }

        public DateTime Birthday
        {
            get { return mBirthday; }
            set { mBirthday = value; }
        }

        public string Organization
        {
            get { return mOrganization; }
            set { mOrganization = value; }
        }

        public string Sex
        {
            get { return mSex; }
            set { mSex = value; }
        }

        public string ChargeUpSign
        {
            get { return mChargeUpSign; }
            set { mChargeUpSign = value; }
        }



    }
}
