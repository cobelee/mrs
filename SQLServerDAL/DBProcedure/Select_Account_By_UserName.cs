using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace MRS.SQLServerDAL.DBProcedure
{
    /// <summary>
    /// 存储过程: Select_Account_By_UserName .
    /// </summary>
    public class Select_Account_By_UserName
    {

        public string Text = "Select_Account_By_UserName";

        public SqlParameter PARM_UserName = new SqlParameter("@UserName", SqlDbType.NChar, 64
);
    }
}
