using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using MRS.IDAL;
using Common.DBUtility;

namespace MRS.SQLServerDAL
{
    public class BXRatio : IBXRatio
    {
        protected Model.BXRatio Parse(System.Data.SqlClient.SqlDataReader reader)
        {
            Model.BXRatio ratio = new Model.BXRatio();
            DBTable.BXRatio table = new SQLServerDAL.DBTable.BXRatio();
            ratio.Id = Convert.ToInt32(reader[table.Id.Text]);
            ratio.OrderNumber = Convert.ToInt32(reader[table.OrderNumber.Text]);
            ratio.MinKBJE = Convert.ToDecimal(reader[table.MinKBJE.Text]);
            ratio.MaxKBJE = Convert.ToDecimal(reader[table.MaxKBJE.Text]);
            ratio.HspType = reader[table.HspType.Text].ToString().Trim();
            ratio.Ratio = Convert.ToDecimal(reader[table.Ratio.Text]);

            return ratio;
        }

        #region IBXRatio 成员

        public bool Insert(MRS.Model.BXRatio ratio)
        {
            bool returnValue = false;
            DBProcedure.Insert_BXRatio prdCmdText = new SQLServerDAL.DBProcedure.Insert_BXRatio();
            SQLProcedure Procedure = new SQLProcedure(DS.ConnectionString.ConnectionStringMRS, prdCmdText.Text);
            Procedure.SetInputValue(prdCmdText.PARM_OrderNumber.ParameterName, ratio.OrderNumber);
            Procedure.SetInputValue(prdCmdText.PARM_MinKBJE.ParameterName, ratio.MinKBJE);
            Procedure.SetInputValue(prdCmdText.PARM_MaxKBJE.ParameterName, ratio.MaxKBJE);
            Procedure.SetInputValue(prdCmdText.PARM_HspType.ParameterName, ratio.HspType);
            Procedure.SetInputValue(prdCmdText.PARM_Ratio.ParameterName, ratio.Ratio);

            returnValue = Procedure.ExecuteNonQuery();
            Procedure.Dispose();
            return returnValue;
        }

        public IList<MRS.Model.BXRatio> Select()
        {
            IList<MRS.Model.BXRatio> ratioes = new List<MRS.Model.BXRatio>();
            DBProcedure.Select_BXRatio_All prdCmdText = new SQLServerDAL.DBProcedure.Select_BXRatio_All();

            SQLProcedure prdHelper = new SQLProcedure(DS.ConnectionString.ConnectionStringMRS, prdCmdText.Text);

            using (SqlDataReader reader = prdHelper.ExecuteReader())
            {
                while (reader.Read())
                {
                    Model.BXRatio ratio = Parse(reader);
                    ratioes.Add(ratio);
                }
            }
            prdHelper.Dispose();

            return ratioes;
        }

        public bool Delete(int ruleId)
        {
            bool returnValue = false;
            DBProcedure.Delete_BXRatio prdCmdText = new DBProcedure.Delete_BXRatio();

            SQLProcedure prdHelper = new SQLProcedure(DS.ConnectionString.ConnectionStringMRS, prdCmdText.Text);
            prdHelper.SetInputValue(prdCmdText.PARM_Id.ParameterName, ruleId);

            returnValue = prdHelper.ExecuteNonQuery();
            prdHelper.Dispose();
            return returnValue;
        }

        /// <summary>
        /// 获取当前报销比例。
        /// </summary>
        /// <param name="mPeriodId">医保年度。</param>
        /// <param name="YBH">医保号。</param>
        /// <param name="hspType">就诊方式。</param>
        /// <returns></returns>
        public decimal GetRatio(int mPeriodId, string YBH, string hspType)
        {
            decimal  ratio = 0;
            DBProcedure.Select_BXRatio prdCmdText = new SQLServerDAL.DBProcedure.Select_BXRatio();
            DBTable.BXRatio table = new SQLServerDAL.DBTable.BXRatio();

            SQLProcedure prdHelper = new SQLProcedure(DS.ConnectionString.ConnectionStringMRS, prdCmdText.Text);
            prdHelper.SetInputValue(prdCmdText.PARM_MPeriodId.ParameterName, mPeriodId);
            prdHelper.SetInputValue(prdCmdText.PARM_YBH.ParameterName, YBH);
            prdHelper.SetInputValue(prdCmdText.PARM_HspType.ParameterName, hspType);

            using (SqlDataReader reader = prdHelper.ExecuteReader())
            {
                if (reader.Read())
                {
                    ratio = Convert.ToDecimal(reader[table.Ratio.Text]);
                }
            }
            prdHelper.Dispose();

            return ratio;
        }

        #endregion
    }
}
