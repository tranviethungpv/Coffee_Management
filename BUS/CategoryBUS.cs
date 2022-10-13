using DevExpress.ReportServer.ServiceModel.DataContracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class CategoryBUS
    {
        private static CategoryBUS request;

        public static CategoryBUS Request
        {
            get
            {
                if (request == null)
                    request = new CategoryBUS();
                return CategoryBUS.request;
            }
        }

        private CategoryBUS() { }

        public DataTable GetAllCategory()
        {
            try
            {
                return CategoryDAO.Request.GetAllCategory();
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
                return CategoryDAO.Request.InsertCategory(name);
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
                return CategoryDAO.Request.UpdateCategory(id, name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeteleCategory(int id)
        {
            try
            {
                return CategoryDAO.Request.DeteleCategory(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Category> SearchCategoryByName(string name)
        {
            try
            {
                return CategoryDAO.Request.SearchCategoryByName(name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
