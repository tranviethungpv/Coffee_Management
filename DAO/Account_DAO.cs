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


        public DataTable GetAllAcount()
        {
            try
            {
                return DatabaseProvider.Request.ExecuteQuery("USP_GetAllAccount");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ResetPassword(string userName)
        {
            string query = string.Format("USP_ResetPassword @UserName");
            int result;
            try
            {
                result = DatabaseProvider.Request.ExecuteNonQuery(query, new object[] { userName });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

        public DataTable SearchAccountByUserName(string userName)
        {

            string query = string.Format("USP_SearchAccountByUserName @UserName");

            DataTable table = new DataTable();
            try
            {
                return DatabaseProvider.Request.ExecuteQuery(query, new object[] { userName });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


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
        public bool Delete(string userName)
        {
            string query = string.Format("USP_DeleteAccount @UserName");
            int result;
            try
            {
                result = DatabaseProvider.Request.ExecuteNonQuery(query, new object[] { userName });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public bool Insert(string userName, string displayName, int typeID)
        {
            string query = string.Format("USP_InsertAccount @UserName , @DisplayName , @TypeID");
            int result;
            try
            {
                result = DatabaseProvider.Request.ExecuteNonQuery(query,
                    new object[] { userName, displayName, typeID });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
    }
}
