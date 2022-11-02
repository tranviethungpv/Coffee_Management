using DAO;
using System;
using System.Data;
using System.Linq;

namespace BUS
{
    public class AccountType_BUS
    {
        private static AccountType_BUS request = new AccountType_BUS();
        public static AccountType_BUS Request { get => request; set => request = value; }
        public AccountType_BUS() { }
        public DataTable GetAllAccountType()
        {
            try
            {
                return AccountType_DAO.Request.GetAllAccountType();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
