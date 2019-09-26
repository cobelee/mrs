using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using MRS.IDAL;
using MRS.DSL;
using Common.DBUtility;

namespace MRS.SQLServerDAL
{
    public class Account : IAccount
    {
        protected MRS.Model.Account Parse(SqlDataReader Reader)
        {
            MRS.Model.Account mAccount = new MRS.Model.Account();
            mAccount.Id = Convert.ToInt32(Reader[DSL.Account.ID_FIELD]);
            mAccount.UserName = Reader[DSL.Account.USER_NAME_FIELD].ToString().Trim();
            mAccount.Password = Reader[DSL.Account.PASSWORD_FIELD].ToString().Trim();
            mAccount.UserType = Reader[DSL.Account.USER_TYPE_FIELD].ToString().Trim();
            mAccount.TrueName = Reader[DSL.Account.TRUE_NAME_FIELD].ToString().Trim();
            return mAccount;
        }

        #region IAccount ≥…‘±

        public IList<MRS.Model.Account> GetAccount()
        {
            IList<MRS.Model.Account> mAccounts = new List<MRS.Model.Account>();

            using (SqlDataReader reader = SqlHelper.ExecuteReader(ConnectionString.ConnectionStringMRS, CommandType.StoredProcedure, CommandText.SELECT_ACCOUNT, null))
            {
                while (reader.Read())
                {
                    MRS.Model.Account mAccount = Parse(reader);
                    mAccounts.Add(mAccount);
                }
            }
            return mAccounts;
        }

        public MRS.Model.Account GetAccountByUserName(string UserName)
        {
            MRS.Model.Account account;
            SqlParameter username_parm = new SqlParameter(DSL.Account.USER_NAME_PARM, SqlDbType.NChar, 32);
            username_parm.Value = UserName;

            using (SqlDataReader reader = SqlHelper.ExecuteReader(ConnectionString.ConnectionStringMRS, CommandType.StoredProcedure, CommandText.SELECT_ACCOUNT_BY_USERNAME, username_parm))
            {
                if (reader.Read())
                    account = Parse(reader);
                else
                    account = new MRS.Model.Account();
            }
            return account;
        }

        public void InsertAccount(string UserName, string Password, string UserType, string TrueName)
        {
            SqlParameter user_name_parm = new SqlParameter(DSL.Account.USER_NAME_PARM, SqlDbType.NChar, 32);
            SqlParameter password_parm = new SqlParameter(DSL.Account.PASSWORD_PARM, SqlDbType.NChar, 32);
            SqlParameter user_type_parm = new SqlParameter(DSL.Account.USER_TYPE_PARM, SqlDbType.NChar, 32);
            SqlParameter true_name_parm = new SqlParameter(DSL.Account.TRUE_NAME_PARM, SqlDbType.NChar, 32);

            user_name_parm.Value = UserName;
            password_parm.Value = Password;
            user_type_parm.Value = UserType;
            true_name_parm.Value = TrueName;

            SqlParameter[] parms = new SqlParameter[4];
            parms.SetValue(user_name_parm, 0);
            parms.SetValue(password_parm, 1);
            parms.SetValue(user_type_parm, 2);
            parms.SetValue(true_name_parm, 3);

            SqlHelper.ExecuteNonQuery(ConnectionString.ConnectionStringMRS, CommandType.StoredProcedure, CommandText.INSERT_ACCOUNT, parms);
        }

        public void UpdateAccount(int Id, string UserName, string Password, string UserType, string TrueName)
        {
            SqlParameter id_parm = new SqlParameter(DSL.Account.ID_PARM, SqlDbType.Int);
            SqlParameter user_name_parm = new SqlParameter(DSL.Account.USER_NAME_PARM, SqlDbType.NChar, 32);
            SqlParameter password_parm = new SqlParameter(DSL.Account.PASSWORD_PARM, SqlDbType.NChar, 32);
            SqlParameter user_type_parm = new SqlParameter(DSL.Account.USER_TYPE_PARM, SqlDbType.NChar, 32);
            SqlParameter true_name_parm = new SqlParameter(DSL.Account.TRUE_NAME_PARM, SqlDbType.NChar, 32);

            id_parm.Value = Id;
            user_name_parm.Value = UserName;
            password_parm.Value = Password;
            user_type_parm.Value = UserType;
            true_name_parm.Value = TrueName;

            SqlParameter[] parms = new SqlParameter[5];

            parms.SetValue(id_parm, 0);
            parms.SetValue(user_name_parm, 1);
            parms.SetValue(password_parm, 2);
            parms.SetValue(user_type_parm, 3);
            parms.SetValue(true_name_parm, 4);

            SqlHelper.ExecuteNonQuery(ConnectionString.ConnectionStringMRS, CommandType.StoredProcedure, CommandText.UPDATE_ACCOUNT, parms);
        }

        public void DeleteAccount(int Id)
        {
            SqlParameter id_parm = new SqlParameter(DSL.Account.ID_PARM, SqlDbType.Int);
            id_parm.Value = Id;

            SqlHelper.ExecuteNonQuery(ConnectionString.ConnectionStringMRS, CommandType.StoredProcedure, CommandText.DELETE_ACCOUNT, id_parm);
        }

        

        #endregion
    }
}
