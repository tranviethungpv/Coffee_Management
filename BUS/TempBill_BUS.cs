using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BUS
{
    public class TempBill_BUS
    {
        private static TempBill_BUS request;
        public static TempBill_BUS Request
        {
            get
            {
                if (request == null)
                    request = new TempBill_BUS();
                return TempBill_BUS.request;
            }
        }
        private TempBill_BUS() { }
        public List<TempBill> GetListTempBillByTableID(int tableID)
        {
            DataTable table;
            try
            {
                table = TempBill_DAO.Request.GetListTempBillByTableID(tableID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            List<TempBill> lstTempBill = new List<TempBill>();
            foreach (DataRow row in table.Rows)
            {
                TempBill tmp = new TempBill(row);
                lstTempBill.Add(tmp);
            }
            return lstTempBill;
        }
    }
}
