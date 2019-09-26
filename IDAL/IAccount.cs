using System;
using System.Collections.Generic;
using System.Text;


namespace MRS.IDAL
{
    public interface IAccount
    {
        /// <summary>
        /// 获取所有系统账户列表。
        /// </summary>
        /// <returns></returns>
        IList<MRS.Model.Account> GetAccount();

        MRS.Model.Account GetAccountByUserName(string UserName);

        void InsertAccount(string UserName, string Password, string UserType, string TrueName);

        void UpdateAccount(int Id, string UserName, string Password, string UserType, string TrueName);

        void DeleteAccount(int Id);
    }
}
