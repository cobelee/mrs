using System;
using System.Collections.Generic;
using System.Text;

namespace MRS.Model
{
    /// <summary>
    /// ϵͳ��½�˻���
    /// </summary>
    [Serializable]
    public class Account
    {
        /// <summary>
        /// �û��ʻ�Id.
        /// </summary>
        private int mId;
        
        /// <summary>
        /// �û��ʻ����ơ�
        /// </summary>
        private string mUserName;
        
        /// <summary>
        /// �û��ʻ����롣
        /// </summary>
        private string mPassword;
        
        /// <summary>
        /// �û��˻����͡�
        /// </summary>
        private string mUserType;

        /// <summary>
        /// �˻�ʹ����Ա��ʵ������
        /// </summary>
        private string mTrueName;

        public Account()
        {
            InitAccount();
        }

        private void InitAccount()
        {
            mUserName = string.Empty;
            mPassword = string.Empty;
            mUserType = string.Empty;
            mTrueName = string.Empty;
        }

        public int Id
        {
            get { return mId; }
            set { mId = value; }
        }

        public string UserName
        {
            get { return mUserName; }
            set { mUserName = value; }
        }

        public string Password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }

        public string UserType
        {
            get { return mUserType; }
            set { mUserType = value; }
        }

        public string TrueName
        {
            get { return mTrueName; }
            set { mTrueName = value; }
        }

    }
}