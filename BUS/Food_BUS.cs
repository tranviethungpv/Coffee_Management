using System;
using System.Collections.Generic;
using System.Data;

using DTO;
using DAO;

namespace BUS
{
    public class Food_BUS
    {
        private static Food_BUS request;

        public static Food_BUS Request
        {
            get
            {
                if (request == null)
                    request = new Food_BUS();
                return Food_BUS.request;
            }
        }

        private Food_BUS() { }

        public DataTable GetAllFood()
        {
            try
            {
                return Food_DAO.Request.GetAllFood();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetListFoodByCategoryID(int categoryID)
        {
            try
            {
                return Food_DAO.Request.GetListFoodByCategoryID(categoryID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Food> SearchFoodByName(string name)
        {
            DataTable table;
            try
            {
                table = Food_DAO.Request.SearchFoodByName(name);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            List<Food> lstFood = new List<Food>();
            foreach (DataRow row in table.Rows)
            {
                Food food = new Food(row);
                lstFood.Add(food);
            }
            return lstFood;
        }

        public bool InsertFood(Food newFood)
        {
            return Food_DAO.Request.InsertFood(newFood);
        }

        public bool UpdateFood(Food food)
        {
            return Food_DAO.Request.UpdateFood(food);
        }

        public bool DeleteFood(int ID)
        {
            return Food_DAO.Request.DeleteFood(ID);
        }
    }
}