using System;
using System.Collections.Generic;
using System.Text;
using MRS.IDAL;

namespace MRS.BLL
{
    public class Account
    {
        private IAccount dalAccount = MRS.DALFactory.DataAccess.CreateAccount();

        public IList<MRS.Model.Account> GetAccountAll()
        {
            return dalAccount.GetAccount();
        }

        public MRS.Model.Account GetAccountByUserName(string UserName)
        {
            return dalAccount.GetAccountByUserName(UserName);
        }

        public void AddAccount(string UserName, string Password, string UserType, string TrueName)
        {
            dalAccount.InsertAccount(UserName, Password, UserType, TrueName);
        }

        public void UpdateAccount(int Id, string UserName, string Password, string UserType, string TrueName)
        {
            dalAccount.UpdateAccount(Id, UserName, Password, UserType, TrueName);
        }

        public void DeleteAccount(int Id)
        {
            dalAccount.DeleteAccount(Id);
        }
    }
}
