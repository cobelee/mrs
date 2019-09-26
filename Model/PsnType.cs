using System;
using System.Collections.Generic;
using System.Text;

namespace MRS.Model
{
    /// <summary>
    /// PersonnelType  人员类型。
    /// </summary>
    [Serializable]
    public class PsnType
    {
        /// <summary>
        /// 人员类别Id.
        /// </summary>
        private int mId;

        /// <summary>
        /// 人员类别名称.
        /// </summary>
        private string mName;

        public PsnType()
        {
            InitPersonnelType();
        }

        private void InitPersonnelType()
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


    }
}
