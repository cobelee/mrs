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
    public class PsnType : IPsnType
    {
        protected MRS.Model.PsnType Parse(SqlDataReader Reader)
        {
            MRS.Model.PsnType psnType = new MRS.Model.PsnType();
            psnType.Id = Convert.ToInt32(Reader[DSL.PsnType.ID_FIELD]);
            psnType.Name = Reader[DSL.PsnType.NAME_FIELD].ToString().Trim();
            return psnType;
        }

        #region IPsnType ≥…‘±

        public IList<MRS.Model.PsnType> GetPsnType()
        {
            IList<MRS.Model.PsnType> psnTypes = new List<MRS.Model.PsnType>();
            using (SqlDataReader reader = SqlHelper.ExecuteReader(ConnectionString.ConnectionStringMRS, CommandType.StoredProcedure, CommandText.SELECT_PSNTYPE, null))
            {
                while (reader.Read())
                {
                    MRS.Model.PsnType psnType = Parse(reader);
                    psnTypes.Add(psnType);
                }
            }
            return psnTypes;
        }

        public void InsertPsnType(string Name)
        {
            SqlParameter name_parm = new SqlParameter(DSL.PsnType.NAME_FIELD, SqlDbType.NChar, 10);
            name_parm.Value = Name;

            SqlHelper.ExecuteNonQuery(ConnectionString.ConnectionStringMRS, CommandType.StoredProcedure, CommandText.INSERT_PSNTYPE, name_parm);
        }

        public void UpdatePsnType(int Id, string Name)
        {
            SqlParameter id_parm = new SqlParameter(DSL.PsnType.ID_PARM, SqlDbType.Int);
            SqlParameter name_parm = new SqlParameter(DSL.PsnType.NAME_PARM, SqlDbType.NChar, 10);
            id_parm.Value = Id;
            name_parm.Value = Name;

            SqlParameter[] pars = new SqlParameter[2];
            pars.SetValue(id_parm, 0);
            pars.SetValue(name_parm, 1);

            SqlHelper.ExecuteNonQuery(ConnectionString.ConnectionStringMRS, CommandType.StoredProcedure, CommandText.UPDATE_PSNTYPE, pars);
        }

        public void DeletePsnType(int Id)
        {
            SqlParameter id_parm = new SqlParameter(DSL.PsnType.ID_PARM, SqlDbType.Int);
            id_parm.Value = Id;

            SqlHelper.ExecuteNonQuery(ConnectionString.ConnectionStringMRS, CommandType.StoredProcedure, CommandText.DELETE_PSNTYPE, id_parm);
        }

        #endregion
    }
}
