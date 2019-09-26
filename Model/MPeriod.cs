using System;
using System.Collections.Generic;
using System.Text;

namespace MRS.Model
{
    /// <summary>
    /// Medicare Period 医保年度。
    /// </summary>
    [Serializable]
    public class MPeriod
    {
        /// <summary>
        /// 医保年度 Id.
        /// </summary>
        private int mId;
        
        /// <summary>
        /// 医保年度名称。
        /// </summary>
        private string mName;
        
        /// <summary>
        /// 医保年度开始日期。
        /// </summary>
        private DateTime mBeginDate;
        
        /// <summary>
        /// 医保年度结束日期。
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
