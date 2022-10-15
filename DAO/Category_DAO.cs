using DTO;
using System;
using System.Data;
using System.Linq;

namespace DAO
{
    public class Category_DAO
    {
        private static Category_DAO request;
        public static Category_DAO Request
        {
            get
            {
                if (request == null)
                    request = new Category_DAO();
                return Category_DAO.request;
            }
        }
        private Category_DAO() { }
        public DataTable GetAllCategory()
        {
            try
            {
                return DatabaseProvider.Request.ExecuteQuery("select * from CategoryFood");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Category GetCategoryByID(int categoryID)
        {
            Category category = new Category();
            string query = "select * from CategoryFood where ID = " + categoryID;
            DataTable table = new DataTable();
            try
            {
                table = DatabaseProvider.Request.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            foreach (DataRow row in table.Rows)
            {
                category = new Category(row);
                return category;
            }
            return category;
        }
        public bool InsertCategory(string name)
        {
            string query = string.Format("insert into CategoryFood (Name) values (N'{0}')", name);
            int result;
            try
            {
                result = DatabaseProvider.Request.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public bool UpdateCategory(int id, string name)
        {
            string query = string.Format("update CategoryFood set Name = N'{0}' where ID = {1}", name, id);
            int result;
            try
            {
                result = DatabaseProvider.Request.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public bool DeleteCategory(int id)
        {
            string query = string.Format("USP_DeleteCategory @ID");
            int result;
            try
            {
                result = DatabaseProvider.Request.ExecuteNonQuery("USP_DeleteCategory @ID", new object[] { id });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
    }
}
