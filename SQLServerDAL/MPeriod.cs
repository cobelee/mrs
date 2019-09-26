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
    public class MPeriod : IMPeriod
    {
        protected MRS.Model.MPeriod Parse(SqlDataReader Reader)
        {
            MRS.Model.MPeriod mPeriod = new MRS.Model.MPeriod();
            mPeriod.Id = Convert.ToInt32(Reader[DSL.MPeriod.ID_FIELD]);
            mPeriod.Name = Reader[DSL.MPeriod.NAME_FIELD].ToString().Trim();
            mPeriod.BeginDate = Convert.ToDateTime(Reader[DSL.MPeriod.BEGIN_DATE_FIELD]);
            mPeriod.EndDate = Convert.ToDateTime(Reader[DSL.MPeriod.END_DATE_FIELD].ToString().Trim());
            return mPeriod;
        }



        #region IMPeriod ≥…‘±

        public IList<MRS.Model.MPeriod> GetMPeriod()
        {
            IList<MRS.Model.MPeriod> mPeriods = new List<MRS.Model.MPeriod>();

            using (SqlDataReader reader = SqlHelper.ExecuteReader(ConnectionString.ConnectionStringMRS, CommandType.StoredProcedure, CommandText.SELECT_MPERIOD, null))
            {
                while (reader.Read())
                {
                    MRS.Model.MPeriod mPeriod = Parse(reader);
                    mPeriods.Add(mPeriod);
                }
            }
            return mPeriods;
        }

        public void InsertMPeriod(string Name, DateTime BeginDate, DateTime EndDate)
        {
            SqlParameter name_parm = new SqlParameter(DSL.MPeriod.NAME_PARM, SqlDbType.NChar, 128);
            SqlParameter begin_date_parm = new SqlParameter(DSL.MPeriod.BEGIN_DATE_PARM, SqlDbType.DateTime);
            SqlParameter end_date_parm = new SqlParameter(DSL.MPeriod.END_DATE_PARM, SqlDbType.DateTime);

            name_parm.Value = Name;
            begin_date_parm.Value = BeginDate;
            end_date_parm.Value = EndDate;

            SqlParameter[] parms = new SqlParameter[3];
            parms.SetValue(name_parm, 0);
            parms.SetValue(begin_date_parm, 1);
            parms.SetValue(end_date_parm, 2);

            SqlHelper.ExecuteNonQuery(ConnectionString.ConnectionStringMRS, CommandType.StoredProcedure, CommandText.INSERT_MPERIOD, parms);
        }

        public void UpdateMPeriod(int Id, string Name, DateTime BeginDate, DateTime EndDate)
        {
            SqlParameter id_parm = new SqlParameter(DSL.MPeriod.ID_PARM, SqlDbType.Int);
            SqlParameter name_parm = new SqlParameter(DSL.MPeriod.NAME_PARM, SqlDbType.NChar, 128);
            SqlParameter begin_date_parm = new SqlParameter(DSL.MPeriod.BEGIN_DATE_PARM, SqlDbType.DateTime);
            SqlParameter end_date_parm = new SqlParameter(DSL.MPeriod.END_DATE_PARM, SqlDbType.DateTime);

            id_parm.Value = Id;
            name_parm.Value = Name;
            begin_date_parm.Value = BeginDate;
            end_date_parm.Value = EndDate;

            SqlParameter[] parms = new SqlParameter[4];

            parms.SetValue(id_parm, 0);
            parms.SetValue(name_parm, 1);
            parms.SetValue(begin_date_parm, 2);
            parms.SetValue(end_date_parm, 3);

            SqlHelper.ExecuteNonQuery(ConnectionString.ConnectionStringMRS, CommandType.StoredProcedure, CommandText.UPDATE_MPERIOD, parms);

        }

        public void DeleteMPeriod(int Id)
        {
            SqlParameter id_parm = new SqlParameter(DSL.MPeriod.ID_PARM, SqlDbType.Int);
            id_parm.Value = Id;

            SqlHelper.ExecuteNonQuery(ConnectionString.ConnectionStringMRS, CommandType.StoredProcedure, CommandText.DELETE_MPERIOD, id_parm);
        }

        #endregion
    }
}
