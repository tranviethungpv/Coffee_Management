using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.BarCode;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace GUI
{
    public partial class fBill : DevExpress.XtraEditors.XtraForm
    {
        public fBill()
        {
            InitializeComponent();
        }
        private void fBill_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            deFromDate.EditValue = new DateTime(today.Year, today.Month, 1);
            deFromDate.EditValue = deFromDate.DateTime.AddMonths(1).AddDays(-1);
            btnRemove.Enabled = false;
        }       
        private void gvBill_DoubleClick(object sender, EventArgs e)
        {
            btnRemove.Enabled = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
    
            int id = (int)gvBill.GetRowCellValue(gvBill.FocusedRowHandle, gvBill.Columns[0]);

            if (XtraMessageBox.Show("Xóa hóa đơn " + id + "?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    BillInfo_BUS.Request.DeleteBillInfoByBillID(id);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error: " + ex);
                }

                if (Bill_BUS.Requeset.DeleteBill(id))
                {
                    btnShowBill_Click(sender, e);
                    XtraMessageBox.Show("Xóa hóa đơn thành công", "Thông báo");

                }
            }
            else
               XtraMessageBox.Show("Không thể xóa hóa đơn", "Lỗi");
            
            btnRemove.Enabled = false;
        }

        private void btnShowBill_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            LoadListBillByDate((DateTime)deFromDate.EditValue, (DateTime)deToDate.EditValue);
            SplashScreenManager.CloseForm();
        }
     
        private void LoadListBillByDate(DateTime fromDate, DateTime toDate)
        {
            try
            {
                gcBill.DataSource = Bill_BUS.Requeset.GetListBillByDate(fromDate, toDate);
                gvBill.Columns[0].Caption = "Mã hóa đơn";
                gvBill.Columns[1].Caption = "Tên bàn";
                gvBill.Columns[2].Caption = "Ngày vào";
                gvBill.Columns[3].Caption = "Giảm giá";
                gvBill.Columns[4].Caption = "Tổng tiền";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }
        }

        

     

        private void gvBill_Click(object sender, EventArgs e)
        {
             btnRemove.Enabled = true;
        }

    }
}