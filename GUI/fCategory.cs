using BUS;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class fCategory : DevExpress.XtraEditors.XtraForm
    {
        string curName;
        public fCategory()
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            btnRemove.Enabled = false;
            LoadCategory();
            SplashScreenManager.CloseForm();
        }
        private void LoadCategory()
        {
            try
            {
                gcCategory.DataSource = Category_BUS.Request.GetAllCategory();
                gvCategory.Columns[0].Caption = "Mã danh mục";
                gvCategory.Columns[0].OptionsColumn.AllowEdit = false;
                gvCategory.Columns[1].Caption = "Tên danh mục";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }
        }
        private void InsertCategory(GridView view, int rowHandle)
        {
            string name = view.GetRowCellValue(rowHandle, view.Columns[1]).ToString();
            if (name == "")
            {
                XtraMessageBox.Show("Tên danh mục không hợp lệ");
                return;
            }

            if (Category_BUS.Request.InsertCategory(name))
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                LoadCategory();
                SplashScreenManager.CloseForm();
            }
            else
                XtraMessageBox.Show("Thêm danh mục thất bại", "Lỗi");
        }
        private void UpdateCategory(GridView view, int rowHandle)
        {
            string id = view.GetRowCellValue(rowHandle, view.Columns[0]).ToString();
            if (id == "")
            {
                InsertCategory(view, rowHandle);
                return;
            }

            string name = view.GetRowCellValue(rowHandle, view.Columns[1]).ToString();
            if (name == "")
            {
                XtraMessageBox.Show("Tên danh mục không hợp lệ");
                return;
            }

            if (Category_BUS.Request.UpdateCategory(int.Parse(id), name))
            {
                LoadCategory();
            }
            else
                XtraMessageBox.Show("Sửa danh mục thất bại", "Lỗi");
        }
        private void gcCategory_DoubleClick(object sender, EventArgs e)
        {
            if (gvCategory.FocusedRowHandle >= 0)
                btnRemove.Enabled = true;

        }
        private void gvCategory_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;

            if (view.IsNewItemRow(e.RowHandle))
                InsertCategory(view, e.RowHandle);
            else
                UpdateCategory(view, e.RowHandle);
        }
        private void btnRemove_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string id = gvCategory.GetRowCellValue(gvCategory.FocusedRowHandle, gvCategory.Columns[0]).ToString();
            string name = gvCategory.GetRowCellValue(gvCategory.FocusedRowHandle, gvCategory.Columns[1]).ToString();

            if (XtraMessageBox.Show("Xóa danh mục " + name + "?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Category_BUS.Request.DeleteCategory(int.Parse(id)))
                {
                    SplashScreenManager.ShowForm(typeof(WaitForm1));
                    LoadCategory();
                    SplashScreenManager.CloseForm();
                    XtraMessageBox.Show("Xóa danh mục thành công", "Thông báo");
                }
                else
                    XtraMessageBox.Show("Xóa danh mục thất bại\nDanh mục được xóa phải rỗng", "Lỗi");
            }
            btnRemove.Enabled = false;
        }
        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadCategory();
        }
        private void gvCategory_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvCategory.GetRowCellValue(gvCategory.FocusedRowHandle, gvCategory.Columns[0]) != null)
                curName = gvCategory.GetRowCellValue(gvCategory.FocusedRowHandle, gvCategory.Columns[1]).ToString();
        }
    }
}