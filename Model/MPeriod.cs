using System;
using System.Collections.Generic;
using System.Text;

namespace MRS.Model
{
    /// <summary>
    /// Medicare Period ҽ����ȡ�
    /// </summary>
    [Serializable]
    public class MPeriod
    {
        /// <summary>
        /// ҽ����� Id.
        /// </summary>
        private int mId;
        
        /// <summary>
        /// ҽ��������ơ�
        /// </summary>
        private string mName;
        
        /// <summary>
        /// ҽ����ȿ�ʼ���ڡ�
        /// </summary>
        private DateTime mBeginDate;
        
        /// <summary>
        /// ҽ����Ƚ������ڡ�
        /// </summary>
        private DateTime mEndDate;

        public MPeriod()
        {
            InitMPeriod();
        }

        private void InitMPeriod()
        {
            mName = string.Empty;
            mBeginDate = new DateTime();
            mEndDate = new DateTime();
        }

        public int Id
        {
            get { return mId; }
            set { mId = value; }
        }

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public DateTime BeginDate
        {
            get { return mBeginDate; }
            set { mBeginDate = value; }
        }

        public DateTime EndDate
        {
            get { return mEndDate; }
            set { mEndDate = value; }
        }

        public override string ToString()
        {
            return mName;
        }
    }
}