using System;
using System.Collections.Generic;
using System.Text;

namespace MRS.Model
{
    public class AccountBook : BXD
    {
        public AccountBook()
        {
            InitAccountBook();
        }

        private void InitAccountBook()
        {
            mChargeUpDate = new DateTime();
            Cashier = string.Empty;
        }

        protected DateTime mChargeUpDate;
        protected string mCashier;

        public DateTime ChargeUpDate
        {
            get { return mChargeUpDate; }
            set { mChargeUpDate = value; }
        }

        public string Cashier
        {
            get { return mCashier; }
            set { mCashier = value; }
        }
    }
}
