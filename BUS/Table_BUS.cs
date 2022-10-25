using System;
using System.Collections.Generic;
using System.Data;

using DAO;
using DTO;

namespace BUS
{
    public class Table_BUS
    {
        private static Table_BUS request;
        public static Table_BUS Request
        {
            get
            {
                if (request == null)
                    request = new Table_BUS();
                return Table_BUS.request;
            }
        }
        public DataTable GetAllTable()
        {
            try
            {
                return Table_DAO.Request.GetAllTable();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Table> GetTableList()
        {
            DataTable table;
            try
            {
                table = Table_DAO.Request.GetTableList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            List<Table> lstTable = new List<Table>();
            foreach (DataRow row in table.Rows)
            {
                Table tb = new Table(row);
                lstTable.Add(tb);
            }
            return lstTable;
        }
        public void SwitchTable(int tableID1, int tableID2)
        {
            try
            {
                Table_DAO.Request.SwitchTable(tableID1, tableID2);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void MergeTable(int tableID1, int tableID2)
        {
            try
            {
                Table_DAO.Request.MergeTable(tableID1, tableID2);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool InsertTable(string name)
        {
            return Table_DAO.Request.InsertTable(name);
        }
        public bool UpdateTable(int id, string name)
        {
            return Table_DAO.Request.UpdateTable(id, name);
        }
        public bool DeleteTable(int id)
        {
            return Table_DAO.Request.DeleteTable(id);
        }
    }
}