using System;
using System.Data;
using System.Linq;

namespace DAO
{
    public class TempBill_DAO
    {
        private static TempBill_DAO request;
        public static TempBill_DAO Request
        {
            get
            {
                if (request == null)
                    request = new TempBill_DAO();
                return TempBill_DAO.request;
            }
        }
        private TempBill_DAO() { }
        public DataTable GetListTempBillByTableID(int tableID)
        {
            string query = "USP_GetListTempBillByTableID @TableID";
            try
            {
                return DatabaseProvider.Request.ExecuteQuery(query, new object[] { tableID });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
