﻿using DevExpress.XtraEditors.Internal;
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

        public DataTable GetAllAcount()
        {
            try
            {
                return Account_DAO.Request.GetAllAcount();
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
        public List<Account> SearchAccountByUserName(string userName)
        {
            List<Account> listAccount = new List<Account>();
            DataTable table;
            try
            {
                table = Account_DAO.Request.SearchAccountByUserName(userName);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            foreach (DataRow row in table.Rows)
            {
                Account account = new Account(row);
                listAccount.Add(account);
            }
            return listAccount;
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
    }
}