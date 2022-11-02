using DAO;
using System;
using System.Data;
using System.Linq;

namespace BUS
{
    public class Category_BUS
    {
        private static Category_BUS request;
        public static Category_BUS Request
        {
            get
            {
                if (request == null)
                    request = new Category_BUS();
                return Category_BUS.request;
            }
        }
        private Category_BUS() { }
        public DataTable GetAllCategory()
        {
            try
            {
                return Category_DAO.Request.GetAllCategory();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool InsertCategory(string name)
        {
            try
            {
                return Category_DAO.Request.InsertCategory(name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateCategory(int id, string name)
        {
            try
            {
                return Category_DAO.Request.UpdateCategory(id, name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DeleteCategory(int id)
        {
            try
            {
                return Category_DAO.Request.DeleteCategory(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
