using DevExpress.XtraEditors.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class Account_BUS
    {
        private static Account_BUS request = new Account_BUS();

        public static Account_BUS Request { get => request; set => request = value; }
        public Account_BUS() { }
        public bool CheckLogin(Account account)
        {
            if (account.Username == "")
                return false;
            if (account.Password == "")
                return false;

            try
            {
                return Account_DAO.Request.CheckLogin(account);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Account GetAccountByUserName(string userName)
        {
            DataTable table;
            try
            {
                table = Account_DAO.Request.GetAccountByUserName(userName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return new Account(table.Rows[0]);
        }
    }
}
