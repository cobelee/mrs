using System;
using System.Collections.Generic;
using System.Text;

namespace MRS.IDAL
{
    public interface IBXD
    {
        /// <summary>
        /// 根据报销单Id，获取报销单。
        /// </summary>
        /// <param name="BXDId"></param>
        /// <returns></returns>
        MRS.Model.BXD GetBXD_By_BXDId(int BXDId);

        /// <summary>
        /// 查询指定的一个时间段内，需要记账的报销单。
        /// </summary>
        /// <returns></returns>
        IList<MRS.Model.BXD> GetBXD_Not_Charge_Up();

        /// <summary>
        /// 查询个人报销记录。
        /// </summary>
        /// <param name="YBH">医保号。</param>
        /// <param name="BeginDate">开始日期。</param>
        /// <param name="EndDate">结束日期。</param>
        /// <returns></returns>
        IList<MRS.Model.BXD> GetBXD_By_YBH(string YBH, DateTime BeginDate, DateTime EndDate);

        /// <summary>
        /// 在数据库中创建报销单。
        /// </summary>
        /// <param name="bxd">报销单对象。</param>
        /// <returns></returns>
        int CreateBXD(MRS.Model.BXD bxd);

        void UpdateBXD(MRS.Model.BXD bxd);

        /// <summary>
        /// 将指定报销单号下的报销明细统计信息保存到报销单中．
        /// </summary>
        /// <param name="BXDId"></param>
        void Save_BXMX_Stat_To_BXD(int BXDId, int AttNumber);

        bool DeleteBXD(int BXDId);


        /// <summary>
        /// 根据报销单Id，生成本次报销凭证，同时本次报销凭证饱含本年度累计医疗费。
        /// </summary>
        /// <param name="BXDId">报销单号</param>
        /// <returns></returns>
        MRS.Model.BXWarrantTable CreateBXWarrantTable(int BXDId);
    }
}
