using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraGrid.Views.Grid;

using BUS;

namespace GUI
{
    public partial class fTable : DevExpress.XtraEditors.XtraForm
    {
        public fTable()
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            LoadTable();
            barButtonItem2.Enabled = false;
            SplashScreenManager.CloseForm();
        }
        private void LoadTable()
        {
            try
            {
                gcTable.DataSource = Table_BUS.Request.GetAllTable();
                gvTable.Columns[0].Caption = "Mã số";
                gvTable.Columns[0].OptionsColumn.AllowEdit = false;
                gvTable.Columns[1].Caption = "Tên bàn";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }
        }
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        mark:
            fAddTable f = new fAddTable();
            f.ShowDialog();
            if (f.Table == -1)
                return;
            string table = "Bàn " + f.Table;

            for (int i = 0; i < gvTable.RowCount - 1; i++)
            {
                if (table.Equals(gvTable.GetRowCellValue(i, gvTable.Columns[1]).ToString()))
                {
                    XtraMessageBox.Show("Tên bàn này đã tồn tại!");
                    goto mark;
                }
            }

            if (Table_BUS.Request.InsertTable(table))
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                LoadTable();
                SplashScreenManager.CloseForm();
                XtraMessageBox.Show("Thêm bàn mới thành công");
                int tableID = (int)gvTable.GetRowCellValue(gvTable.RowCount - 1, gvTable.Columns[0]);
            }
            else
                XtraMessageBox.Show("Thêm bàn mới thất bại!", "Lỗi");
        }
        private void gcTable_DoubleClick(object sender, EventArgs e)
        {
            barButtonItem2.Enabled = true;
        }
        private void btnRemove_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            int id = (int)gvTable.GetRowCellValue(gvTable.FocusedRowHandle, gvTable.Columns[0]);
            string name = gvTable.GetRowCellValue(gvTable.FocusedRowHandle, gvTable.Columns[1]).ToString();

            if (XtraMessageBox.Show("Xóa " + name + "?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Table_BUS.Request.DeleteTable(id))
                {
                    LoadTable();
                    SplashScreenManager.CloseForm();
                    XtraMessageBox.Show("Đã xóa " + name, "Thông báo");
                }
                else
                {
                    SplashScreenManager.CloseForm();
                    XtraMessageBox.Show("Không thể xóa bàn đang có người", "Lỗi");
                }
            }
            barButtonItem2.Enabled = false;
        }
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadTable();
        }
    }
}