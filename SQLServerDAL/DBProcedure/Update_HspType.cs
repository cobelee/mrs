using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace MRS.SQLServerDAL.DBProcedure
{
    /// <summary>
    /// 存储过程: Update_HspType .
    /// </summary>
    public class Update_HspType
    {

        public string Text = "Update_HspType";

        public SqlParameter PARM_Id = new SqlParameter("@Id", SqlDbType.Int);
        public SqlParameter PARM_Name = new SqlParameter("@Name", SqlDbType.NChar, 20
);
    }
}
