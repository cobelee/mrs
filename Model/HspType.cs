using System;
using System.Collections.Generic;
using System.Text;

namespace MRS.Model
{
    /// <summary>
    /// HospitalizationType  就诊类型对象。
    /// </summary>
    [Serializable]
    public class HspType
    {
        /// <summary>
        /// 就诊类型Id.
        /// </summary>
        private int mId;

        /// <summary>
        /// 就诊类型名称.
        /// </summary>
        private string mName;


        public HspType()
        {
            InitHospitalizationType();
        }

        private void InitHospitalizationType()
        {
            mName = string.Empty;
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

        public override string ToString()
        {
            return mName;
        }
    }
}
