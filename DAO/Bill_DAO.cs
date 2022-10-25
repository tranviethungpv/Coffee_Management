using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAO
{
    public class Bill_DAO
    {
        private static Bill_DAO request;

        public static Bill_DAO Request
        {
            get
            {
                if (request == null)
                    request = new Bill_DAO();
                return Bill_DAO.request;
            }
        }

        private Bill_DAO() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableID"></param>
        /// <returns>Bill ID, if Bill ID is null, this function will return -1</returns>
        public int GetUnCheckBillIDByTableID(int tableID)
        {
            DataTable table;
            try
            {
                table = DatabaseProvider.Request.ExecuteQuery("GetUnCheckBillIDByTableID @TableID", new object[] { tableID });
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (table.Rows.Count > 0)
            {
                Bill bill = new Bill(table.Rows[0]);
                return bill.ID;
            }
            return -1;
        }

        public void InsertBill(int tableID)
        {
            try
            {
                DatabaseProvider.Request.ExecuteNonQuery("USP_InsertBill @TableID", new object[] { tableID });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetMaxBillID()
        {
            try
            {
                return (int)DatabaseProvider.Request.ExecuteScalar("USP_GetMaxBillID");
            }
            catch
            {
                return 1;
            }
        }

        public void CheckOut(int billID, int discount, int totalPrice)
        {
            string query = "USP_CheckOut @ID , @Discount , @TotalPrice";
            try
            {
                DatabaseProvider.Request.ExecuteNonQuery(query, new object[] { billID, discount, totalPrice });
            }
            catch { }
        }

        public DataTable GetListBillByDate(DateTime fromDate, DateTime toDate)
        {
            try
            {
                return DatabaseProvider.Request.ExecuteQuery("USP_GetListBillByDay @fromDate , @toDate",
                    new object[] { fromDate, toDate });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteBill(int id)
        {
            string query = string.Format("USP_DeleteBill @ID");
            int result;
            try
            {
                result = DatabaseProvider.Request.ExecuteNonQuery(query, new object[] { id });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
    }
}
