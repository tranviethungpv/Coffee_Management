using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DTO;
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
    public partial class fManager : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Account acc;
        public fManager()
        {
            InitializeComponent();
        }
        public fManager(Account account)
        {
            if(account.TypeID == 1)
            {
                InitializeComponent();
                this.acc = account;
                ribbonPageManager.Visible = true;
            }
            else
            {
                InitializeComponent();
                this.acc = account;
                ribbonPageManager.Visible = false;
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Coffe Management ver 0.0.1","Phiên bản",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
        private Form CheckFormExist(Type fType)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.GetType() == fType)
                    return f;
            }
            return null;
        }
        private void btnShowForm_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(fMain));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fMain f = new fMain();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnAccountInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(fAccountInformation));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fAccountInformation f = new fAccountInformation();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnViewFood_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(fFood));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fFood f = new fFood();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnCategoryFood_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(fCategory));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fCategory f = new fCategory();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnViewTable_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(fTable));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fTable f = new fTable();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnViewAccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(fAccount));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fAccount f = new fAccount();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnViewBill_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(fBill));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fBill f = new fBill();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnStatistic_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(fStatistic));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fStatistic f = new fStatistic();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}