﻿using BUS;
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
using DevExpress.XtraReports.UI;

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
            textEdit1.Text = totalPrice.ToString();
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
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Table table = listView1.Tag as Table;
            if (table == null)
                return;

            int billID = -1;
            try
            {
                billID = Bill_BUS.Request.GetUnCheckBillIDByTableID(table.ID);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }
            int discount = (int)spinEdit2.Value;
            double totalPrice = Convert.ToDouble(textEdit1.Text);
            double finalPrice = totalPrice - (totalPrice / 100) * discount;
            if (billID != -1)
            {
                if (XtraMessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho {0}?", table.Name),
                    "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    // Print bill
                    List<TempBill> lstTempBill = new List<TempBill>();
                    try
                    {
                        lstTempBill = TempBill_BUS.Request.GetListTempBillByTableID(table.ID);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Error: " + ex);
                    }
                    SplashScreenManager.ShowForm(typeof(WaitForm1));
                    XtraReport1 report = new XtraReport1();
                    report.DataSource = lstTempBill;
                    report.Parameters["Staff"].Value = fManager.acc.DisplayName;
                    report.Parameters["Table"].Value = table.ID;
                    report.Parameters["Discount"].Value = discount;
                    report.Parameters["Date"].Value = DateTime.Now;
                    report.Parameters["TotalPrice"].Value = finalPrice;
                    ReportPrintTool tool = new ReportPrintTool(report);
                    tool.ShowPreview();
                    SplashScreenManager.CloseForm();

                    // Save bill to database
                    Bill_BUS.Request.CheckOut(billID, discount, (int)finalPrice);
                    ShowBill(table.ID);
                    LoadTable();
                    LoadLookUpEditTable();
                }
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int id1 = (listView1.Tag as Table).ID;
            int id2;
            if (lookUpEdit3.EditValue == null)
            {
                XtraMessageBox.Show("Hãy chọn bàn muốn chuyển");
                return;
            }
            else
                id2 = (int)lookUpEdit3.EditValue;
            if (XtraMessageBox.Show(string.Format("Bạn có thật sự muốn chuyển {0} sang {1}?",
                (listView1.Tag as Table).Name, lookUpEdit3.Text),
                "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Table_BUS.Request.SwitchTable(id1, id2);
                LoadTable();
                LoadLookUpEditTable();
                simpleButton2.Enabled = false;
                foreach (SimpleButton item in flowLayoutPanel1.Controls)
                    if ((item.Tag as Table).ID == id2)
                    {
                        listView1.Tag = item.Tag;
                        break;
                    }
            }
        }
    }
}