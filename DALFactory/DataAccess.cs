using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using MRS.IDAL;
using System.Reflection;

namespace MRS.DALFactory
{
    public sealed class DataAccess
    {
        private static readonly string MRS_DAL_PATH = ConfigurationManager.AppSettings["MRS_SQL_DAL"];

        private DataAccess() { }

        public static MRS.IDAL.IHspType CreateHspType()
        {
            string className = MRS_DAL_PATH + ".HspType";
            return (MRS.IDAL.IHspType)Assembly.Load(MRS_DAL_PATH).CreateInstance(className);
        }

        public static MRS.IDAL.IPsnType CreatePsnType()
        {
            string className = MRS_DAL_PATH + ".PsnType";
            return (MRS.IDAL.IPsnType)Assembly.Load(MRS_DAL_PATH).CreateInstance(className);
        }

        public static MRS.IDAL.IMPeriod CreateMPeriod()
        {
            string className = MRS_DAL_PATH + ".MPeriod";
            return (MRS.IDAL.IMPeriod)Assembly.Load(MRS_DAL_PATH).CreateInstance(className);
        }

        public static MRS.IDAL.IAccount CreateAccount()
        {
            string className = MRS_DAL_PATH + ".Account";
            return (MRS.IDAL.IAccount)Assembly.Load(MRS_DAL_PATH).CreateInstance(className);
        }

        public static MRS.IDAL.IBXMX CreateBXMX()
        {
            string className = MRS_DAL_PATH + ".BXMX";
            return (MRS.IDAL.IBXMX)Assembly.Load(MRS_DAL_PATH).CreateInstance(className);
        }

        public static MRS.IDAL.IBXD CreateBXD()
        {
            string className = MRS_DAL_PATH + ".BXD";
            return (MRS.IDAL.IBXD)Assembly.Load(MRS_DAL_PATH).CreateInstance(className);
        }

        public static MRS.IDAL.IAccountBook CreateAccountBook()
        {
            string className = MRS_DAL_PATH + ".AccountBook";
            return (MRS.IDAL.IAccountBook)Assembly.Load(MRS_DAL_PATH).CreateInstance(className);
        }

        public static MRS.IDAL.IBXRatio CreateBXRatio()
        {
            string className = MRS_DAL_PATH + ".BXRatio";
            return (MRS.IDAL.IBXRatio)Assembly.Load(MRS_DAL_PATH).CreateInstance(className);
        }

        public static MRS.IDAL.IReport CreateReport()
        {
            string className = MRS_DAL_PATH + ".Report";
            return (MRS.IDAL.IReport)Assembly.Load(MRS_DAL_PATH).CreateInstance(className);
        }
    }
}
