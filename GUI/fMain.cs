using BUS;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
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
using DTO;
using System.Globalization;

namespace GUI
{
    public partial class fMain : DevExpress.XtraEditors.XtraForm
    {
        private SimpleButton currentClickButton = new SimpleButton();
        public fMain()
        {
            InitializeComponent();
            currentClickButton = null;
            simpleButton2.Enabled = false;
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            LoadTable();
            LoadCategory();
            LoadLookUpEditTable();
            SplashScreenManager.CloseForm();
        }
        private void LoadTable()
        {
            flowLayoutPanel1.Controls.Clear();
            List<Table> tableList = Table_BUS.Request.GetTableList();
            foreach (Table item in tableList)
            {
                SimpleButton button = new SimpleButton() { Width = 80, Height = 80 };
                button.Text = item.Name;
                button.Click += btn_Click;
                button.Tag = item;
                button.ImageList = imageList;

                switch (item.Status)
                {
                    case "Có người":
                        button.ImageIndex = 0;
                        break;
                    default:
                        break;
                }
                flowLayoutPanel1.Controls.Add(button);
            }
        }
        private void ShowBill(int tableID)
        {
            listView1.Items.Clear();
            List<TempBill> listTempBill = new List<TempBill>();
            try
            {
                listTempBill = TempBill_BUS.Request.GetListTempBillByTableID(tableID);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }

            int totalPrice = 0;
            foreach (TempBill item in listTempBill)
            {
                ListViewItem lsvItem = new ListViewItem(item.Food.ToString());
                lsvItem.SubItems.Add(item.AmountFood.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.Total.ToString());

                totalPrice += item.Total;
                listView1.Items.Add(lsvItem);
            }

            CultureInfo culture = new CultureInfo("vi-VN");
            // Thread.CurrentThread.CurrentCulture = culture;
            textEdit1.Text = totalPrice.ToString("c", culture);
        }
        void btn_Click(object sender, EventArgs e)
        {
            if ((sender as SimpleButton) != currentClickButton)
            {
                if (currentClickButton != null)
                {
                    if ((currentClickButton.Tag as Table).Status == "Có người")
                        currentClickButton.ImageIndex = 0;
                    else
                        currentClickButton.ImageIndex = -1;
                }
            }

            (sender as SimpleButton).ImageIndex = 1;
            int tableID = ((sender as SimpleButton).Tag as Table).ID;
            listView1.Tag = (sender as SimpleButton).Tag;
            ShowBill(tableID);
            currentClickButton = sender as SimpleButton;
            simpleButton2.Enabled = true;

        }
        private void LoadCategory()
        {
            lookUpEdit1.Properties.DataSource = Category_BUS.Request.GetAllCategory();
            lookUpEdit1.Properties.DisplayMember = "Name";
            lookUpEdit1.Properties.ValueMember = "ID";
        }
        private void LoadLookUpEditTable()
        {
            lookUpEdit3.Properties.DataSource = Table_BUS.Request.GetTableList();
            lookUpEdit3.Properties.DisplayMember = "Name";
            lookUpEdit3.Properties.ValueMember = "ID";
        }
        private void GetListFoodByCategory(int categoryID)
        {
            lookUpEdit2.Properties.DataSource = Food_BUS.Request.GetListFoodByCategoryID(categoryID);
            lookUpEdit2.Properties.DisplayMember = "Name";
            lookUpEdit2.Properties.ValueMember = "ID";
        }
        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            int id = (int)lookUpEdit1.EditValue;
            GetListFoodByCategory(id);
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Table table = listView1.Tag as Table;
            if (table == null)
            {
                XtraMessageBox.Show("Hãy chọn bàn");
                return;
            }

            if (spinEdit1.Value == 0)
                return;
            int amount = (int)spinEdit1.Value;

            int billID = Bill_BUS.Request.GetUnCheckBillIDByTableID(table.ID);

            if (lookUpEdit2.EditValue == null)
            {
                XtraMessageBox.Show("Hãy chọn món");
                return;
            }
            int foodID = (int)lookUpEdit2.EditValue;

            if (billID == -1)
            {
                try
                {
                    Bill_BUS.Request.InsertBill(table.ID);
                    BillInfo_BUS.Request.InsertBillInfo(Bill_BUS.Request.GetMaxBillID(), foodID, amount);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error: " + ex);
                }
            }
            else
            {
                try
                {
                    BillInfo_BUS.Request.InsertBillInfo(billID, foodID, amount);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Eror: " + ex);
                }
            }
            ShowBill(table.ID);
            LoadTable();
            LoadLookUpEditTable();
        }
    }
}