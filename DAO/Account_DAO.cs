using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class Account_DAO
    {
        private static Account_DAO request = new Account_DAO();
        public Account_DAO() { }
        public static Account_DAO Request { get => request; set => request = value; }

        public bool CheckLogin(Account account)
        {
            string query = "USP_Login @UserName , @Password";
            DataTable result = new DataTable();
            try
            {
                result = DatabaseProvider.Request.ExecuteQuery(query, new object[] { account.Username, account.Password });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result.Rows.Count > 0;
        }
        public DataTable GetAccountByUserName(string userName)
        {
            string query = "USP_GetAccountByUserName @UserName";
            try
            {
                return DatabaseProvider.Request.ExecuteQuery(query, new object[] { userName });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
