using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace MRS.SQLServerDAL.DBProcedure
{
    /// <summary>
    /// 存储过程: Delete_HspType .
    /// </summary>
    public class Delete_HspType
    {

        public string Text = "Delete_HspType";

        public SqlParameter PARM_Id = new SqlParameter("@Id", SqlDbType.Int);
    }
}
