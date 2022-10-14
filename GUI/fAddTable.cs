using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GUI
{
    public partial class fAddTable : DevExpress.XtraEditors.XtraForm
    {
        public int Table { get; set; }

        public fAddTable()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (textEdit1.Text == "")
            {
                XtraMessageBox.Show("Hãy nhập dữ liệu!!");
                return;
            }

            int temp;
            if (int.TryParse(textEdit1.Text, out temp) == false)
            {
                XtraMessageBox.Show("Dữ liệu không hợp lệ!!");
                textEdit1.Focus();
                return;
            }
            else
            {
                Table = temp;
                this.Close();
            }
        }

        private void fAddTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textEdit1.Text == "")
                Table = -1;
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void fAddTable_Load(object sender, EventArgs e)
        {

        }
    }
}