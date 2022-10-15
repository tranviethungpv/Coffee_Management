using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;

namespace DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO request;

        public static CategoryDAO Request
        {
            get
            {
                if (request == null)
                    request = new CategoryDAO();
                return CategoryDAO.request;
            }
        }

        private CategoryDAO() { }

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

        public bool DeteleCategory(int id)
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

        public List<Category> SearchCategoryByName(string name)
        {
            List<Category> listCategory = new List<Category>();
            string query = string.Format("select * from CategoryFood where dbo.fuConvertToUnsign1(Name) like N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

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
                Category category = new Category(row);
                listCategory.Add(category);
            }
            return listCategory;
        }
    }
}
