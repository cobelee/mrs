using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace MRS.SQLServerDAL.DBProcedure
{
    /// <summary>
    /// 存储过程: Delete_BXRatio .
    /// </summary>
    public class Delete_BXRatio
    {

        public string Text = "Delete_BXRatio";

        public SqlParameter PARM_Id = new SqlParameter("@Id", SqlDbType.Int);
    }
}
