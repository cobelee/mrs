using System;
using System.Collections.Generic;
using System.Text;

namespace MRS.BLL
{
    public enum UserType
    {
        Administrator,
        Accountant,
        Cashier
    }

    public class Authentication
    {
        

        public Authentication()
        {
            InitAuthentication();
        }

        private void InitAuthentication()
        {
           
            
        }

        public static bool Authenticate(string UserName, string Password, string UserType)
        {
            bool result = false;
            Account daAccount = new Account();
            MRS.Model.Account account = new MRS.Model.Account();
            account = daAccount.GetAccountByUserName(UserName);
            if (account.UserName != string.Empty)
            {
                if (account.UserName == UserName && account.Password == Password && account.UserType == UserType)
                {
                    result = true;
                }
            }
            return result;
        }

        public static bool ChangePassword(string UserName, string OldPassword, string NewPassword)
        {
            bool result = false;
            Account daAccount = new Account();
            MRS.Model.Account account = new MRS.Model.Account();
            account = daAccount.GetAccountByUserName(UserName);
            if (account.UserName != string.Empty)
            {
                if (account.UserName == UserName && account.Password == OldPassword)
                {
                    daAccount.UpdateAccount(account.Id, account.UserName, NewPassword, account.UserType, account.TrueName);
                    result = true;
                }
            }
            return result;
        }
    }
}
