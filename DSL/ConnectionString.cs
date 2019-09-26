using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace MRS.DSL
{
    public class ConnectionString
    {
        public static readonly string ConnectionStringMRS = ConfigurationManager.ConnectionStrings["MRS_SQL_ConnString"].ConnectionString;
    }
}
