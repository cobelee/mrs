using System;
using System.Collections.Generic;
using System.Text;
using MRS.IDAL;
using MRS.Model;

namespace MRS.BLL
{
    public class HspType
    {
        private IHspType dalHspType = MRS.DALFactory.DataAccess.CreateHspType();

        public IList<MRS.Model.HspType> GetHspTypeAll()
        {
            return dalHspType.GetHspTypes();
        }

        public MRS.Model.HspType GetHspType(int Id)
        {
            return dalHspType.GetHspTypeById(Id);
        }

        public void UpdateHspType( int Id, string Name)
        {
            dalHspType.UpdateHspType(Id,Name);
        }

        public void AddHspType(string Name)
        {
            dalHspType.InsertHspType(Name);
        }

        public void DeleteHspType(int Id)
        {
            dalHspType.DeleteHspType(Id);
        }
    }
}
