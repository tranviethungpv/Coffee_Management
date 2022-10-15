using DTO;
using System;
using System.Data;

namespace DAO
{
    public class Food_DAO
    {
        private static Food_DAO request;
        public static Food_DAO Request
        {
            get
            {
                if (request == null)
                    request = new Food_DAO();
                return Food_DAO.request;
            }
        }
        private Food_DAO() { }
        public DataTable GetAllFood()
        {
            string query = "USP_GetAllFood";
            try
            {
                return DatabaseProvider.Request.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetListFoodByCategoryID(int categoryID)
        {
            string query = "USP_GetListFoodByCategoryID @CategoryID";
            try
            {
                return DatabaseProvider.Request.ExecuteQuery(query, new object[] { categoryID });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool InsertFood(Food newFood)
        {
            string query = string.Format("USP_InsertFood @Name , @CategoryID , @Price");
            int result;
            try
            {
                result = DatabaseProvider.Request.ExecuteNonQuery(query,
                    new object[] { newFood.Name, newFood.CategoryID, newFood.Price });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public bool UpdateFood(Food food)
        {
            string query = string.Format("USP_UpdateFood @ID , @Name , @CategoryID , @Price");
            int result;
            try
            {
                result = DatabaseProvider.Request.ExecuteNonQuery(query,
                    new object[] { food.ID, food.Name, food.CategoryID, food.Price });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public bool DeleteFood(int ID)
        {
            int result;
            try
            {
                result = DatabaseProvider.Request.ExecuteNonQuery("USP_DeleteFood @ID", new object[] { ID });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
    }
}