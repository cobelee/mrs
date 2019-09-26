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
    public class BXMX : IBXMX
    {
        protected MRS.Model.BXMX Parse(SqlDataReader Reader)
        {
            MRS.Model.BXMX mBXMX = new MRS.Model.BXMX();
            mBXMX.BXMXId = Convert.ToInt32(Reader[DSL.BXMX.BXMX_ID_FIELD]);
            mBXMX.BXDId = Convert.ToInt32(Reader[DSL.BXMX.BXD_ID_FIELD]);
            mBXMX.FPDate = Convert.ToDateTime(Reader[DSL.BXMX.FP_DATE_FIELD]);
            mBXMX.YYF = Convert.ToDecimal(Reader[DSL.BXMX.YYF_FIELD]);
            mBXMX.GRZFei = Convert.ToDecimal(Reader[DSL.BXMX.GRZFEI_FIELD]);
            mBXMX.GRZFu = Convert.ToDecimal(Reader[DSL.BXMX.GRZFU_FIELD]);
            mBXMX.GRZFuHide = Convert.ToDecimal(Reader[DSL.BXMX.GRZFU_HIDE_FIELD]);
            mBXMX.GRZFBao = Convert.ToDecimal(Reader[DSL.BXMX.GRZF_BAO_FIELD]);
            mBXMX.GRCDBao = Convert.ToDecimal(Reader[DSL.BXMX.GRCD_BAO_FIELD]);
            mBXMX.LNZHBao = Convert.ToDecimal(Reader[DSL.BXMX.LNZH_BAO_FIELD]);
            mBXMX.TCJJ = Convert.ToDecimal(Reader[DSL.BXMX.TCJJ_FIELD]);
            mBXMX.JZFS = Reader[DSL.BXMX.JZFS_FIELD].ToString().Trim();
            mBXMX.ReimbursementRatio = Convert.ToDecimal(Reader[DSL.BXMX.RBM_RATIO_FIELD]);

            return mBXMX;
        }

        #region IBXMX 成员

        public IList<MRS.Model.BXMX> GetBXMX_By_BXDId(int BXDId)
        {
            IList<MRS.Model.BXMX> mBXMXs = new List<MRS.Model.BXMX>();

            SqlParameter bxdid_parm = new SqlParameter(DSL.BXMX.BXD_ID_PARM, SqlDbType.Int);
            bxdid_parm.Value = BXDId;

            using (SqlDataReader reader = SqlHelper.ExecuteReader(ConnectionString.ConnectionStringMRS, CommandType.StoredProcedure, CommandText.SELECT_BXMX_BY_BXDID, bxdid_parm))
            {
                while (reader.Read())
                {
                    MRS.Model.BXMX mBXMX = Parse(reader);
                    mBXMXs.Add(mBXMX);
                }
            }
            return mBXMXs;
        }

        /// <summary>
        /// 根据报销明细Id，获取报销明细记录。
        /// </summary>
        /// <param name="bxmxId">报销明细记录号。</param>
        /// <returns></returns>
        public MRS.Model.BXMX GetBxmx_By_BxmxId(int bxmxId)
        {
            MRS.Model.BXMX bxmx = new MRS.Model.BXMX();

            DBProcedure.Select_BXMX_By_BxmxId prdCmd = new DBProcedure.Select_BXMX_By_BxmxId();
            SqlParameter bxmxId_parm = new SqlParameter(prdCmd.PARM_BxmxId.ParameterName, SqlDbType.Int);
            bxmxId_parm.Value = bxmxId;

            using (SqlDataReader reader = SqlHelper.ExecuteReader(ConnectionString.ConnectionStringMRS, CommandType.StoredProcedure, prdCmd.Text, bxmxId_parm))
            {
                if (reader.Read())
                {
                    bxmx = Parse(reader);
                }
            }
            return bxmx;
        }

        public void InsertBXMX(MRS.Model.BXMX bxmx)
        {
            SqlParameter bxdid_parm = new SqlParameter(DSL.BXMX.BXD_ID_PARM, SqlDbType.Int);
            SqlParameter fp_date_parm = new SqlParameter(DSL.BXMX.FP_DATE_PARM, SqlDbType.DateTime);
            SqlParameter yyf_parm = new SqlParameter(DSL.BXMX.YYF_PARM, SqlDbType.Decimal);
            SqlParameter grzfei_parm = new SqlParameter(DSL.BXMX.GRZFEI_PARM, SqlDbType.Decimal);
            SqlParameter grzfu_parm = new SqlParameter(DSL.BXMX.GRZFU_PARM, SqlDbType.Decimal);
            SqlParameter grzfu_hide_parm = new SqlParameter(DSL.BXMX.GRZFU_HIDE_PARM, SqlDbType.Decimal);
            SqlParameter grzfbao_parm = new SqlParameter(DSL.BXMX.GRZF_BAO_PARM, SqlDbType.Decimal);
            SqlParameter grcdbao_parm = new SqlParameter(DSL.BXMX.GRCD_BAO_PARM, SqlDbType.Decimal);
            SqlParameter lnzhbao_parm = new SqlParameter(DSL.BXMX.LNZH_BAO_PARM, SqlDbType.Decimal);
            SqlParameter tcjj_parm = new SqlParameter(DSL.BXMX.TCJJ_PARM, SqlDbType.Decimal);
            SqlParameter jzfs_parm = new SqlParameter(DSL.BXMX.JZFS_PARM, SqlDbType.NChar, 10);
            SqlParameter rbmRatio_parm = new SqlParameter(DSL.BXMX.RBM_RATIO_PARM, SqlDbType.Decimal);

            bxdid_parm.Value = bxmx.BXDId;
            fp_date_parm.Value = bxmx.FPDate;
            yyf_parm.Value = bxmx.YYF;
            grzfei_parm.Value = bxmx.GRZFei;
            grzfu_parm.Value = bxmx.GRZFu;
            grzfu_hide_parm.Value = bxmx.GRZFuHide;
            grzfbao_parm.Value = bxmx.GRZFBao;
            grcdbao_parm.Value = bxmx.GRCDBao;
            lnzhbao_parm.Value = bxmx.LNZHBao;
            tcjj_parm.Value = bxmx.TCJJ;
            jzfs_parm.Value = bxmx.JZFS;
            rbmRatio_parm.Value = bxmx.ReimbursementRatio;

            SqlParameter[] parms = new SqlParameter[12];
            parms.SetValue(bxdid_parm, 0);
            parms.SetValue(fp_date_parm, 1);
            parms.SetValue(yyf_parm, 2);
            parms.SetValue(grzfei_parm, 3);
            parms.SetValue(grzfu_parm, 4);
            parms.SetValue(grzfu_hide_parm, 5);
            parms.SetValue(grzfbao_parm, 6);
            parms.SetValue(grcdbao_parm, 7);
            parms.SetValue(lnzhbao_parm, 8);
            parms.SetValue(tcjj_parm, 9);
            parms.SetValue(jzfs_parm, 10);
            parms.SetValue(rbmRatio_parm, 11);

            SqlHelper.ExecuteNonQuery(ConnectionString.ConnectionStringMRS, CommandType.StoredProcedure, CommandText.INSERT_BXMX, parms);

        }

        /// <summary>
        /// 更新报销发票明细。
        /// </summary>
        /// <param name="bxmx"></param>
        public void UpdateBXMX(MRS.Model.BXMX bxmx)
        {
            DBProcedure.Update_BXMX prdCmd = new DBProcedure.Update_BXMX();
            SqlParameter bxmxid_parm = new SqlParameter(DSL.BXMX.BXMX_ID_FIELD, SqlDbType.Int);
            SqlParameter fpdate_parm = new SqlParameter(prdCmd.PARM_FpDate.ParameterName, SqlDbType.DateTime);
            SqlParameter yyf_parm = new SqlParameter(DSL.BXMX.YYF_PARM, SqlDbType.Decimal);
            SqlParameter grzfei_parm = new SqlParameter(DSL.BXMX.GRZFEI_PARM, SqlDbType.Decimal);
            SqlParameter grzfu_parm = new SqlParameter(DSL.BXMX.GRZFU_PARM, SqlDbType.Decimal);
            SqlParameter grzfuHide_parm = new SqlParameter(prdCmd.PARM_GRZFuHide.ParameterName, SqlDbType.Decimal);
            SqlParameter grzfbao_parm = new SqlParameter(prdCmd.PARM_GRZFBao.ParameterName, SqlDbType.Decimal);
            SqlParameter grcdbao_parm = new SqlParameter(DSL.BXMX.GRCD_BAO_PARM, SqlDbType.Decimal);
            SqlParameter lnzhbao_parm = new SqlParameter(DSL.BXMX.LNZH_BAO_PARM, SqlDbType.Decimal);
            SqlParameter tcjj_parm = new SqlParameter(DSL.BXMX.TCJJ_PARM, SqlDbType.Decimal);
            SqlParameter jzfs_parm = new SqlParameter(DSL.BXMX.JZFS_PARM, SqlDbType.NChar, 10);
            SqlParameter rbmRatio_parm = new SqlParameter(DSL.BXMX.RBM_RATIO_PARM, SqlDbType.Decimal);

            bxmxid_parm.Value = bxmx.BXMXId;
            fpdate_parm.Value = bxmx.FPDate;
            yyf_parm.Value = bxmx.YYF;
            grzfei_parm.Value = bxmx.GRZFei;
            grzfu_parm.Value = bxmx.GRZFu;
            grzfuHide_parm.Value = bxmx.GRZFuHide;
            grzfbao_parm.Value = bxmx.GRZFBao;
            grcdbao_parm.Value = bxmx.GRCDBao;
            lnzhbao_parm.Value = bxmx.LNZHBao;
            tcjj_parm.Value = bxmx.TCJJ;
            jzfs_parm.Value = bxmx.JZFS;
            rbmRatio_parm.Value = bxmx.ReimbursementRatio;

            SqlParameter[] parms = new SqlParameter[12];
            parms.SetValue(bxmxid_parm, 0);
            parms.SetValue(fpdate_parm, 1);
            parms.SetValue(yyf_parm, 2);
            parms.SetValue(grzfei_parm, 3);
            parms.SetValue(grzfu_parm, 4);
            parms.SetValue(grzfuHide_parm, 5);
            parms.SetValue(grzfbao_parm, 6);
            parms.SetValue(grcdbao_parm, 7);
            parms.SetValue(lnzhbao_parm, 8);
            parms.SetValue(tcjj_parm, 9);
            parms.SetValue(jzfs_parm, 10);
            parms.SetValue(rbmRatio_parm, 11);

            SqlHelper.ExecuteNonQuery(ConnectionString.ConnectionStringMRS, CommandType.StoredProcedure, CommandText.UPDATE_BXMX, parms);

        }

        public void DeleteBXMX(int BXMXId)
        {
            SqlParameter bxmxid_parm = new SqlParameter(DSL.BXMX.BXMX_ID_PARM, SqlDbType.Int);
            bxmxid_parm.Value = BXMXId;

            SqlHelper.ExecuteNonQuery(ConnectionString.ConnectionStringMRS, CommandType.StoredProcedure, CommandText.DELETE_BXMX, bxmxid_parm);
        }

        #endregion
    }
}
