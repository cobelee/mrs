using System;
using System.Collections.Generic;
using System.Text;

namespace MRS.IDAL
{
    public interface IBXD
    {
        /// <summary>
        /// ���ݱ�����Id����ȡ��������
        /// </summary>
        /// <param name="BXDId"></param>
        /// <returns></returns>
        MRS.Model.BXD GetBXD_By_BXDId(int BXDId);

        /// <summary>
        /// ��ѯָ����һ��ʱ����ڣ���Ҫ���˵ı�������
        /// </summary>
        /// <returns></returns>
        IList<MRS.Model.BXD> GetBXD_Not_Charge_Up();

        /// <summary>
        /// ��ѯ���˱�����¼��
        /// </summary>
        /// <param name="YBH">ҽ���š�</param>
        /// <param name="BeginDate">��ʼ���ڡ�</param>
        /// <param name="EndDate">�������ڡ�</param>
        /// <returns></returns>
        IList<MRS.Model.BXD> GetBXD_By_YBH(string YBH, DateTime BeginDate, DateTime EndDate);

        /// <summary>
        /// �����ݿ��д�����������
        /// </summary>
        /// <param name="bxd">����������</param>
        /// <returns></returns>
        int CreateBXD(MRS.Model.BXD bxd);

        void UpdateBXD(MRS.Model.BXD bxd);

        /// <summary>
        /// ��ָ�����������µı�����ϸͳ����Ϣ���浽�������У�
        /// </summary>
        /// <param name="BXDId"></param>
        void Save_BXMX_Stat_To_BXD(int BXDId, int AttNumber);

        bool DeleteBXD(int BXDId);


        /// <summary>
        /// ���ݱ�����Id�����ɱ��α���ƾ֤��ͬʱ���α���ƾ֤����������ۼ�ҽ�Ʒѡ�
        /// </summary>
        /// <param name="BXDId">��������</param>
        /// <returns></returns>
        MRS.Model.BXWarrantTable CreateBXWarrantTable(int BXDId);
    }
}