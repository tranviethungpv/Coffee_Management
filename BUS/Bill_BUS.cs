using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BUS
{
    public class Bill_BUS
    {
        private static Bill_BUS request;
        public static Bill_BUS Request
        {
            get
            {
                if (request == null)
                    request = new Bill_BUS();
                return Bill_BUS.request;
            }
        }

        private Bill_BUS() { }

        public int GetUnCheckBillIDByTableID(int id)
        {
            try
            {
                return Bill_DAO.Request.GetUnCheckBillIDByTableID(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertBill(int tableID)
        {
            try
            {
                Bill_DAO.Request.InsertBill(tableID);
            }
            catch { }
        }

        public int GetMaxBillID()
        {
            try
            {
                return Bill_DAO.Request.GetMaxBillID();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CheckOut(int billID, int discount, int totalPrice)
        {
            try
            {
                Bill_DAO.Request.CheckOut(billID, discount, totalPrice);
            }
            catch { }
        }

        public DataTable GetListBillByDate(DateTime fromDate, DateTime toDate)
        {
            try
            {
                return Bill_DAO.Request.GetListBillByDate(fromDate, toDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteBill(int id)
        {
            try
            {
                return Bill_DAO.Request.DeleteBill(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
