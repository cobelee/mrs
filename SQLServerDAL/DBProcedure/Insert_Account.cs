using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace MRS.SQLServerDAL.DBProcedure
{
    /// <summary>
    /// 存储过程: Insert_Account .
    /// </summary>
    public class Insert_Account
    {

        public string Text = "Insert_Account";

        public SqlParameter PARM_UserName = new SqlParameter("@UserName", SqlDbType.NChar, 64
);
        public SqlParameter PARM_Password = new SqlParameter("@Password", SqlDbType.NChar, 64
);
        public SqlParameter PARM_UserType = new SqlParameter("@UserType", SqlDbType.NChar, 64
);
        public SqlParameter PARM_TrueName = new SqlParameter("@TrueName", SqlDbType.NChar, 64
);
    }
}
