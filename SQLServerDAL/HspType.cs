using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using MRS.IDAL;
using MRS.DSL;
using Common.DBUtility;

namespace MRS.SQLServerDAL
{
    public class HspType : IHspType
    {
        protected MRS.Model.HspType Parse(SqlDataReader Reader)
        {
            MRS.Model.HspType hspType = new MRS.Model.HspType();
            hspType.Id = Convert.ToInt32(Reader[DSL.HspType.ID_FIELD]);
            hspType.Name = Reader[DSL.HspType.NAME_FIELD].ToString().Trim();
            return hspType;
        }

        #region IHspType ≥…‘±

        public IList<MRS.Model.HspType> GetHspTypes()
        {
            IList<MRS.Model.HspType> hspTypes = new List<MRS.Model.HspType>();
            using (SqlDataReader reader = SqlHelper.ExecuteReader(ConnectionString.ConnectionStringMRS, CommandType.StoredProcedure, DSL.CommandText.SELECT_HSPTYPE, null))
            {
                while (reader.Read())
                {
                    MRS.Model.HspType hspType = Parse(reader);
                    hspTypes.Add(hspType);
                }
            }
            return hspTypes;
        }

        public MRS.Model.HspType GetHspTypeById(int Id)
        {
            MRS.Model.HspType hspType = new MRS.Model.HspType();

            SqlParameter id_parm = new SqlParameter(DSL.HspType.ID_PARM, SqlDbType.Int);
            id_parm.Value = Id;

            using (SqlDataReader reader = SqlHelper.ExecuteReader(ConnectionString.ConnectionStringMRS, CommandType.StoredProcedure, CommandText.SELECT_HSPTYPE_BY_ID, id_parm))
            {
                if (reader.Read())
                {
                    hspType = Parse(reader);
                }
            }
            return hspType;
        }

        public void InsertHspType(string Name)
        {
            SqlParameter name_parm = new SqlParameter(DSL.HspType.NAME_PARM, SqlDbType.NChar, 10);
            name_parm.Value = Name;

            SqlParameter[] pars = new SqlParameter[1];

            pars.SetValue(name_parm, 0);

            SqlHelper.ExecuteNonQuery(ConnectionString.ConnectionStringMRS, CommandType.StoredProcedure, CommandText.INSERT_HSPTYPE, pars);
        }

        public void UpdateHspType(int Id, string Name)
        {
            SqlParameter id_parm = new SqlParameter(DSL.HspType.ID_PARM, SqlDbType.Int);
            SqlParameter name_parm = new SqlParameter(DSL.HspType.NAME_PARM, SqlDbType.NChar, 10);
            id_parm.Value = Id;
            name_parm.Value = Name;

            SqlParameter[] pars = new SqlParameter[2];

            pars.SetValue(id_parm, 0);
            pars.SetValue(name_parm, 1);

            SqlHelper.ExecuteNonQuery(ConnectionString.ConnectionStringMRS, CommandType.StoredProcedure, CommandText.UPDATE_HSPTYPE, pars);
        }

        public void DeleteHspType(int Id)
        {
            SqlParameter id_parm = new SqlParameter(DSL.HspType.ID_PARM, SqlDbType.Int);
            id_parm.Value = Id;

            SqlHelper.ExecuteNonQuery(ConnectionString.ConnectionStringMRS, CommandType.StoredProcedure, CommandText.DELETE_HSPTYPE, id_parm);
        }


        #endregion
    }
}
