using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace MRS.IDAL
{
    public interface IReport
    {
        /// <summary>
        /// ��ȡ��˾����ҽ���ʽ�����ʹ��������档
        /// </summary>
        /// <returns></returns>
        DataTable GetReportZJLNSYQK();

        /// <summary>
        /// ��ȡ��˾����ҽ���ʽ𼾶�ʹ��������档
        /// </summary>
        /// <returns></returns>
        DataTable GetReportZJJDSYQK(int mPeriodId);

        /// <summary>
        /// ��ȡ�������걨���������
        /// </summary>
        /// <param name="ybh">ҽ����</param>
        /// <returns></returns>
        DataTable GetReportGRLNBX(string ybh);
    }
}