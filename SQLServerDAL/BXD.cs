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
    public class BXD : IBXD
    {
        protected MRS.Model.BXD Parse(SqlDataReader Reader)
        {
            MRS.Model.BXD mBXD = new MRS.Model.BXD();
            mBXD.BXDId = Convert.ToInt32(Reader[DSL.BXD.BXDID_FIELD]);
            mBXD.MPeriodId = Convert.ToInt32(Reader[DSL.BXD.M_PERIOD_ID_FIELD]);
            mBXD.BXDate = Convert.ToDateTime(Reader[DSL.BXD.BXDATE_FIELD]);
            mBXD.YBH = Reader[DSL.BXD.YBH_FIELD].ToString().Trim();
            mBXD.PsnType = Reader[DSL.BXD.PSN_TYPE_FIELD].ToString().Trim();
            mBXD.AttNumber = Convert.ToInt32(Reader[DSL.BXD.ATT_NUMBER_FIELD]);
            mBXD.Accountant = Reader[DSL.BXD.ACCOUNTANT_FIELD].ToString().Trim();
            mBXD.YYF = Convert.ToDecimal(Reader[DSL.BXD.YYF_FIELD]);
            mBXD.BXJE = Convert.ToDecimal(Reader[DSL.BXD.BXJE_FIELD]);
            mBXD.ZLF = Convert.ToDecimal(Reader[DSL.BXD.ZLF_FIELD]);
            mBXD.TCJJ = Convert.ToDecimal(Reader[DSL.BXD.TCJJ_FIELD]);
            mBXD.GRZFei = Convert.ToDecimal(Reader[DSL.BXD.GRZFEI_FIELD]);
            mBXD.GRZFu = Convert.ToDecimal(Reader[DSL.BXD.GRZFU_FIELD]);
            mBXD.Name = Reader[DSL.BXD.NAME_FIELD].ToString().Trim();
            mBXD.JobNumber = Reader[DSL.BXD.JOB_NUMBER_FIELD].ToString().Trim();
            mBXD.IdentityCard = Reader[DSL.BXD.IDENTITY_CARD_FIELD].ToString().Trim();
            mBXD.Birthday = Convert.ToDateTime(Reader[DSL.BXD.BIRTHDAY_FIELD]);
            mBXD.Organization = Reader[DSL.BXD.ORGANIZATION_FIELD].ToString().Trim();
            mBXD.Sex = Reader[DSL.BXD.SEX_FIELD].ToString().Trim();
            mBXD.ChargeUpSign = Reader[DSL.BXD.CHARGE_UP_SIGN_FIELD].ToString().Trim();


            return mBXD;
        }


        #region IBXD 成员

        public MRS.Model.BXD GetBXD_By_BXDId(int BXDId)
        {
            MRS.Model.BXD mBXD = new MRS.Model.BXD();

            SqlParameter bxdid_parm = new SqlParameter(DSL.BXD.BXDID_PARM, SqlDbType.Int);
            bxdid_parm.Value = BXDId;

            using (SqlDataReader reader = SqlHelper.ExecuteReader(ConnectionString.ConnectionStringMRS, CommandType.StoredProcedure, CommandText.SELECT_BXD_BY_BXDID, bxdid_parm))
            {
                if (reader.Read())
                {
                    mBXD = Parse(reader);
                }
            }
            return mBXD;
        }

        /// <summary>
        /// 从报销单数据表中获取未记账的记录。
        /// </summary>
        /// <returns></returns>
        public IList<MRS.Model.BXD> GetBXD_Not_Charge_Up()
        {
            IList<MRS.Model.BXD> mBXDs = new List<MRS.Model.BXD>();

            DBProcedure.Select_BXD_Not_Charge_Up prdCmd = new DBProcedure.Select_BXD_Not_Charge_Up();

            using (SqlDataReader reader = SqlHelper.ExecuteReader(ConnectionString.ConnectionStringMRS, CommandType.StoredProcedure, prdCmd.Text, null))
            {
                while (reader.Read())
                {
                    MRS.Model.BXD bxd = Parse(reader);
                    mBXDs.Add(bxd);
                }
            }
            return mBXDs;
        }

        public IList<MRS.Model.BXD> GetBXD_By_YBH(string YBH, DateTime BeginDate, DateTime EndDate)
        {
            IList<MRS.Model.BXD> mBXDs = new List<MRS.Model.BXD>();

            SqlParameter ybh_parm = new SqlParameter(DSL.BXD.YBH_PARM, SqlDbType.NChar, 10);
            SqlParameter begin_date_parm = new SqlParameter(DSL.BXD.CHARGE_UP_BEGIN_DATE_PARM, SqlDbType.DateTime);
            SqlParameter end_date_parm = new SqlParameter(DSL.BXD.CHARGE_UP_END_DATE_PARM, SqlDbType.DateTime);

            ybh_parm.Value = YBH;
            begin_date_parm.Value = BeginDate;
            end_date_parm.Value = EndDate;

            SqlParameter[] parms = new SqlParameter[3];
            parms.SetValue(ybh_parm, 0);
            parms.SetValue(begin_date_parm, 1);
            parms.SetValue(end_date_parm, 2);

            using (SqlDataReader reader = SqlHelper.ExecuteReader(ConnectionString.ConnectionStringMRS, CommandType.StoredProcedure, CommandText.SELECT_BXD_BY_YBH, parms))
            {
                while (reader.Read())
                {
                    MRS.Model.BXD bxd = Parse(reader);
                    mBXDs.Add(bxd);
                }
            }
            return mBXDs;
        }

        public int CreateBXD(MRS.Model.BXD bxd)
        {
            int bxdid;
            SqlParameter m_period_id_parm = new SqlParameter(DSL.BXD.M_PERIOD_ID_FIELD, SqlDbType.Int);
            SqlParameter bxdate_parm = new SqlParameter(DSL.BXD.BXDATE_PARM, SqlDbType.DateTime);
            SqlParameter ybh_parm = new SqlParameter(DSL.BXD.YBH_PARM, SqlDbType.NChar,10);
            SqlParameter psntype_parm = new SqlParameter(DSL.BXD.PSN_TYPE_PARM, SqlDbType.NChar, 10);
            SqlParameter attnumber_parm = new SqlParameter(DSL.BXD.ATT_NUMBER_PARM, SqlDbType.Int);
            SqlParameter accountant_parm = new SqlParameter(DSL.BXD.ACCOUNTANT_PARM, SqlDbType.NChar,10);
            SqlParameter yyf_parm = new SqlParameter(DSL.BXD.YYF_PARM, SqlDbType.Decimal);
            SqlParameter bxje_parm = new SqlParameter(DSL.BXD.BXJE_PARM, SqlDbType.Decimal);
            SqlParameter zlf_parm = new SqlParameter(DSL.BXD.ZLF_PARM, SqlDbType.Decimal);
            SqlParameter tcjj_parm = new SqlParameter(DSL.BXD.TCJJ_PARM, SqlDbType.Decimal);
            SqlParameter grzfei_parm = new SqlParameter(DSL.BXD.GRZFEI_PARM, SqlDbType.Decimal);
            SqlParameter grzfu_parm = new SqlParameter(DSL.BXD.GRZFU_PARM, SqlDbType.Decimal);
            SqlParameter name_parm = new SqlParameter(DSL.BXD.NAME_PARM, SqlDbType.NChar, 12);
            SqlParameter jobnumber_parm = new SqlParameter(DSL.BXD.JOB_NUMBER_PARM, SqlDbType.NChar, 6);
            SqlParameter identity_card_parm = new SqlParameter(DSL.BXD.IDENTITY_CARD_PARM, SqlDbType.NChar, 21);
            SqlParameter birthday_parm = new SqlParameter(DSL.BXD.BIRTHDAY_PARM, SqlDbType.DateTime);
            SqlParameter organization_parm = new SqlParameter(DSL.BXD.ORGANIZATION_PARM, SqlDbType.NChar, 50);
            SqlParameter sex_parm = new SqlParameter(DSL.BXD.SEX_PARM, SqlDbType.NChar, 1);
            SqlParameter charge_up_sign_parm = new SqlParameter(DSL.BXD.CHARGE_UP_SIGN_PARM, SqlDbType.NChar, 10);

            m_period_id_parm.Value = bxd.MPeriodId;
            bxdate_parm.Value = bxd.BXDate;
            ybh_parm.Value = bxd.YBH;
            psntype_parm.Value = bxd.PsnType;
            attnumber_parm.Value = bxd.AttNumber;
            accountant_parm.Value = bxd.Accountant;
            yyf_parm.Value = bxd.YYF;
            bxje_parm.Value = bxd.BXJE;
            zlf_parm.Value = bxd.ZLF;
            tcjj_parm.Value = bxd.TCJJ;
            grzfei_parm.Value = bxd.GRZFei;
            grzfu_parm.Value = bxd.GRZFu;
            name_parm.Value = bxd.Name;
            jobnumber_parm.Value = bxd.JobNumber;
            identity_card_parm.Value = bxd.IdentityCard;
            birthday_parm.Value = bxd.Birthday;
            organization_parm.Value = bxd.Organization;
            sex_parm.Value = bxd.Sex;
            charge_up_sign_parm.Value = bxd.ChargeUpSign;

            SqlParameter[] parms = new SqlParameter[19];
            parms.SetValue(m_period_id_parm, 0);
            parms.SetValue(bxdate_parm, 1);
            parms.SetValue(ybh_parm, 2);
            parms.SetValue(psntype_parm, 3);
            parms.SetValue(attnumber_parm, 4);
            parms.SetValue(accountant_parm, 5);
            parms.SetValue(yyf_parm, 6);
            parms.SetValue(bxje_parm, 7);
            parms.SetValue(zlf_parm, 8);
            parms.SetValue(tcjj_parm, 9);
            parms.SetValue(grzfei_parm, 10);
            parms.SetValue(grzfu_parm, 11);
            parms.SetValue(name_parm, 12);
            parms.SetValue(jobnumber_parm, 13);
            parms.SetValue(identity_card_parm, 14);
            parms.SetValue(birthday_parm, 15);
            parms.SetValue(organization_parm, 16);
            parms.SetValue(sex_parm, 17);
            parms.SetValue(charge_up_sign_parm, 18);

            bxdid = Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString.ConnectionStringMRS, CommandType.StoredProcedure, CommandText.INSERT_BXD, parms));

            return bxdid;
        }

        public void UpdateBXD(MRS.Model.BXD bxd)
        {
            SqlParameter bxdid_parm = new SqlParameter(DSL.BXD.BXDID_PARM, SqlDbType.Int);
            SqlParameter att_number_parm = new SqlParameter(DSL.BXD.ATT_NUMBER_PARM, SqlDbType.Int);
            SqlParameter yyf_parm = new SqlParameter(DSL.BXD.YYF_PARM, SqlDbType.Decimal);
            SqlParameter bxje_parm = new SqlParameter(DSL.BXD.BXJE_PARM, SqlDbType.Decimal);
            SqlParameter zlf_parm = new SqlParameter(DSL.BXD.ZLF_PARM, SqlDbType.Decimal);
            SqlParameter tcjj_parm = new SqlParameter(DSL.BXD.TCJJ_PARM, SqlDbType.Decimal);
            SqlParameter grzfei_parm = new SqlParameter(DSL.BXD.GRZFEI_PARM, SqlDbType.Decimal);
            SqlParameter grzfu_parm = new SqlParameter(DSL.BXD.GRZFU_PARM, SqlDbType.Decimal);

            bxdid_parm.Value = bxd.BXDId;
            att_number_parm.Value = bxd.AttNumber;
            yyf_parm.Value = bxd.YYF;
            bxje_parm.Value = bxd.BXJE;
            zlf_parm.Value = bxd.ZLF;
            tcjj_parm.Value = bxd.TCJJ;
            grzfei_parm.Value = bxd.GRZFei;
            grzfu_parm.Value = bxd.GRZFu;

            SqlParameter[] parms = new SqlParameter[8];
            parms.SetValue(bxdid_parm, 0);
            parms.SetValue(att_number_parm, 1);
            parms.SetValue(yyf_parm, 2);
            parms.SetValue(bxje_parm, 3);
            parms.SetValue(zlf_parm, 4);
            parms.SetValue(tcjj_parm, 5);
            parms.SetValue(grzfei_parm, 6);
            parms.SetValue(grzfu_parm, 7);

            SqlHelper.ExecuteNonQuery(ConnectionString.ConnectionStringMRS, CommandType.StoredProcedure, CommandText.UPDATE_BXD, parms);

        }

        public bool DeleteBXD(int BXDId)
        {
            bool result = false;

            SqlParameter bxdid_parm = new SqlParameter(DSL.BXD.BXDID_PARM, SqlDbType.Int);
            bxdid_parm.Value = BXDId;
            result = Convert.ToBoolean(SqlHelper.ExecuteScalar(ConnectionString.ConnectionStringMRS, CommandType.StoredProcedure, CommandText.DELETE_BXD, bxdid_parm));
            return result;
        }


        public MRS.Model.BXWarrantTable CreateBXWarrantTable(int BXDId)
        {
            MRS.Model.BXWarrantTable wTable = new MRS.Model.BXWarrantTable();
            SqlParameter bxdid_parm = new SqlParameter(DSL.BXD.BXDID_PARM, SqlDbType.Int);

            bxdid_parm.Value = BXDId;

            SqlParameter[] parms = new SqlParameter[1];
            parms.SetValue(bxdid_parm, 0);

            using (SqlDataReader reader = SqlHelper.ExecuteReader(ConnectionString.ConnectionStringMRS,CommandType.StoredProcedure,CommandText.CREATE_BX_WARRANT,parms ))
            {
                while (reader.Read())
                {
                    DataRow row = wTable.NewRow();
                    row["OrderIndex"] = reader[DSL.BXWarrantTable.ORDER_INDEX_FIELD].ToString().Trim();
                    row["JZFS"] = reader[DSL.BXWarrantTable.JZFS_FIELD].ToString().Trim();
                    row["YYF"] = reader[DSL.BXWarrantTable.YYF_FIELD].ToString().Trim();
                    row["BXJE"] = reader[DSL.BXWarrantTable.BXJE_FIELD].ToString().Trim();
                    row["ZLF"] = reader[DSL.BXWarrantTable.ZLF_FIELD].ToString().Trim();
                    row["TCJJ"] = reader[DSL.BXWarrantTable.TCJJ_FIELD].ToString().Trim();
                    row["GRZFei"] = reader[DSL.BXWarrantTable.GRZFEI_FIELD].ToString().Trim();
                    row["GRZFu"] = reader[DSL.BXWarrantTable.GRZFU_FIELD].ToString().Trim();
                    wTable.Rows.Add(row);
                }
            }

            wTable.Columns["OrderIndex"].ColumnName = "序号";
            wTable.Columns["JZFS"].ColumnName = "就诊方式";
            wTable.Columns["YYF"].ColumnName = "医药费";
            wTable.Columns["BXJE"].ColumnName = "公司补助";
            wTable.Columns["ZLF"].ColumnName = "自理费";
            wTable.Columns["TCJJ"].ColumnName = "统筹基金";
            wTable.Columns["GRZFei"].ColumnName = "个人自费";
            wTable.Columns["GRZFu"].ColumnName = "个人自付";

            return wTable;
        }


        public void Save_BXMX_Stat_To_BXD(int BXDId, int AttNumber)
        {
            SqlParameter bxdid_parm = new SqlParameter(DSL.BXD.BXDID_PARM, SqlDbType.Int);
            SqlParameter att_number_parm = new SqlParameter(DSL.BXD.ATT_NUMBER_PARM, SqlDbType.Int);

            bxdid_parm.Value = BXDId;
            att_number_parm.Value = AttNumber;

            SqlParameter[] parms = new SqlParameter[2];
            parms.SetValue(bxdid_parm, 0);
            parms.SetValue(att_number_parm, 1);

            SqlHelper.ExecuteNonQuery(ConnectionString.ConnectionStringMRS, CommandType.StoredProcedure, CommandText.SAVE_BXMX_STAT_TO_BXD, parms);
        }

        

        #endregion
    }
}
