using System;
using System.Collections.Generic;
using System.Text;
using MRS.Model;

namespace MRS.IDAL
{
    public interface IHspType
    {
        /// <summary>
        /// 获取所有的就诊类型.
        /// </summary>
        /// <returns></returns>
        IList<MRS.Model.HspType> GetHspTypes();

        MRS.Model.HspType GetHspTypeById(int Id);

        void InsertHspType( string Name);

        void UpdateHspType(int Id, string Name);

        void DeleteHspType(int Id);
    }
}
