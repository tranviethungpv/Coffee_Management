using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fStatistic : DevExpress.XtraEditors.XtraForm
    {
        public fStatistic()
        {
            InitializeComponent();
        }

        private void fStatistic_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffee_ManagementDataSet1.CategoryWithPrice' table. You can move, or remove it, as needed.
            this.categoryWithPriceTableAdapter.Fill(this.coffee_ManagementDataSet1.CategoryWithPrice);
            // TODO: This line of code loads data into the 'coffee_ManagementDataSet.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.coffee_ManagementDataSet.Bill);

        }
    }
}