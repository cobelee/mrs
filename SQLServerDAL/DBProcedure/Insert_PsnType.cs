using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace MRS.SQLServerDAL.DBProcedure
{
    /// <summary>
    /// 存储过程: Insert_PsnType .
    /// </summary>
    public class Insert_PsnType
    {

        public string Text = "Insert_PsnType";

        public SqlParameter PARM_Name = new SqlParameter("@Name", SqlDbType.NChar, 20
);
    }
}
