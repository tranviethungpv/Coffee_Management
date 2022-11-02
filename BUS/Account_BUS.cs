using DAO;
using DTO;
using System;
using System.Data;
using System.Linq;

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
        public DataTable GetAllAccount()
        {
            try
            {
                return Account_DAO.Request.GetAllAccount();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ResetPassword(string userName)
        {
            try
            {
                return Account_DAO.Request.ResetPassword(userName);
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
        public bool Delete(string userName)
        {
            try
            {
                return Account_DAO.Request.Delete(userName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Insert(string userName, string displayName, int type)
        {
            try
            {
                return Account_DAO.Request.Insert(userName, displayName, type);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateInformation(string userName, string displayName, string password, string newPass)
        {
            try
            {
                return Account_DAO.Request.UpdateInformation(userName, displayName, password, newPass);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
