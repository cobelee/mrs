using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace MRS.SQLServerDAL.DBProcedure
{
    /// <summary>
    /// 存储过程: Insert_BXRatio .
    /// </summary>
    public class Insert_BXRatio
    {

        public string Text = "Insert_BXRatio";

        public SqlParameter PARM_OrderNumber = new SqlParameter("@OrderNumber", SqlDbType.Int);
        public SqlParameter PARM_MinKBJE = new SqlParameter("@MinKBJE", SqlDbType.Decimal, 9
);
        public SqlParameter PARM_MaxKBJE = new SqlParameter("@MaxKBJE", SqlDbType.Decimal, 9
);
        public SqlParameter PARM_HspType = new SqlParameter("@HspType", SqlDbType.NChar, 20
);
        public SqlParameter PARM_Ratio = new SqlParameter("@Ratio", SqlDbType.Decimal, 9
);
    }
}
