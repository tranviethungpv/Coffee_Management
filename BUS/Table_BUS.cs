using System;
using System.Collections.Generic;
using System.Data;

using DAO;
using DTO;

namespace BUS
{
    public class TableBUS
    {
        private static TableBUS request;

        public static TableBUS Request
        {
            get
            {
                if (request == null)
                    request = new TableBUS();
                return TableBUS.request;
            }
        }

        public DataTable GetAllTable()
        {
            try
            {
                return TableDAO.Request.GetAllTable();
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
                table = TableDAO.Request.GetTableList();
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
                TableDAO.Request.SwitchTable(tableID1, tableID2);
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
                TableDAO.Request.MergeTable(tableID1, tableID2);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool InsertTable(string name)
        {
            return TableDAO.Request.InsertTable(name);
        }

        public bool UpdateTable(int id, string name)
        {
            return TableDAO.Request.UpdateTable(id, name);
        }

        public bool DeleteTable(int id)
        {
            return TableDAO.Request.DeleteTable(id);
        }
    }
}