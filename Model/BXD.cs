using System;
using System.Collections.Generic;
using System.Text;

namespace MRS.Model
{
    
    /// <summary>
    /// ��������
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

        private int mBXDId;              //��������
        private int mMPeriodId;           //ҽ����ȡ�
        private DateTime mBXDate;        //��������
        private string mYBH;             //ҽ����
        private string mPsnType;         //��Ա���
        private int mAttNumber;          //��������
        private string mAccountant;      //���
        private decimal mYYF;            //ҽҩ��
        private decimal mBXJE;           //�������
        private decimal mZLF;            //������
        private decimal mTCJJ;           //ͳ�����
        private decimal mGRZFei;         //�����Է�
        private decimal mGRZFu;          //�����Ը�
        private string mName;            //����
        private string mJobNumber;       //����
        private string mIdentityCard;    //����֤��
        private DateTime mBirthday;      //����
        private string mOrganization;    //����
        private string mSex;             //�Ա�
        private string mChargeUpSign;     //���˱�־


        public int BXDId
        {
            get { return mBXDId; }
            set { mBXDId = value; }
        }

        /// <summary>
        /// ҽ�����Id.
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