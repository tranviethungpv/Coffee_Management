using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BUS
{
    public class BillInfo_BUS
    {
        private static BillInfo_BUS request;

        public static BillInfo_BUS Request
        {
            get
            {
                if (request == null)
                    request = new BillInfo_BUS();
                return BillInfo_BUS.request;
            }
        }

        private BillInfo_BUS() { }

        public void InsertBillInfo(int billID, int foodID, int amount)
        {
            try
            {
                BillInfo_DAO.Request.InsertBillInfo(billID, foodID, amount);
            }
            catch { }
        }

        public void DeleteBillInfoByBillID(int billID)
        {
            try
            {
                BillInfo_DAO.Request.DeleteBillInfoByBillID(billID);
            }
            catch { }
        }
    }
}
