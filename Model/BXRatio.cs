using System;
using System.Collections.Generic;
using System.Text;

namespace MRS.Model
{
    /// <summary>
    /// 报销比例规则。
    /// </summary>
    [Serializable]
    public class BXRatio
    {
        private Int32 mId;        // 
        private Int32 mOrderNumber;        // 规则顺序号。（暂时无用）
        private System.Decimal mMinKBJE;        // 可报销金额范围下限，不包含下限值。
        private System.Decimal mMaxKBJE;        // 可报销金额范围上限，包含上限值。
        private String mHspType;        // 就诊类型。
        private System.Decimal mRatio;        // 报销比例。如90%，此处值记为0.90

        public BXRatio()
        {
            InitBXRatio();
        }

        private void InitBXRatio()
        {
            mHspType = string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        public Int32 Id
        {
            get { return mId; }
            set { mId = value; }
        }

        /// <summary>
        /// 规则顺序号。（暂时无用）
        /// </summary>
        public Int32 OrderNumber
        {
            get { return mOrderNumber; }
            set { mOrderNumber = value; }
        }

        /// <summary>
        /// 可报销金额范围下限，不包含下限值。
        /// </summary>
        public System.Decimal MinKBJE
        {
            get { return mMinKBJE; }
            set { mMinKBJE = value; }
        }

        /// <summary>
        /// 可报销金额范围上限，包含上限值。
        /// </summary>
        public System.Decimal MaxKBJE
        {
            get { return mMaxKBJE; }
            set { mMaxKBJE = value; }
        }

        /// <summary>
        /// 就诊类型。
        /// </summary>
        public String HspType
        {
            get { return mHspType; }
            set { mHspType = value; }
        }

        /// <summary>
        /// 报销比例。如90%，此处值记为0.90
        /// </summary>
        public System.Decimal Ratio
        {
            get { return mRatio; }
            set { mRatio = value; }
        }

    }
}
