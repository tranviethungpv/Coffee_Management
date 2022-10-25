using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BillInfo_DAO
    {
        private static BillInfo_DAO request;

        public static BillInfo_DAO Request
        {
            get
            {
                if (request == null)
                    request = new BillInfo_DAO();
                return BillInfo_DAO.request;
            }
        }

        private BillInfo_DAO() { }

        public void InsertBillInfo(int billID, int foodID, int amount)
        {
            string query = "USP_InsertBillInfo @BillID , @FoodID , @Amount";
            try
            {
                DatabaseProvider.Request.ExecuteNonQuery(query, new object[] { billID, foodID, amount });
            }
            catch { }
        }

        public void DeleteBillInfoByBillID(int billID)
        {
            string query = string.Format("USP_DeleteBillInfoByBillID @BillID");
            try
            {
                DatabaseProvider.Request.ExecuteNonQuery(query, new object[] { billID });
            }
            catch { }
        }
    }
}
