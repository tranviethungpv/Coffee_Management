using DevExpress.XtraEditors;
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
using DTO;

namespace GUI
{
    public partial class fLogin : DevExpress.XtraEditors.XtraForm
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_fLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
                e.Cancel = true;
        }

        private void btn_login_fLogin_Click(object sender, EventArgs e)
        {
            Account account = new Account(text_login_fLogin.Text, text_password_fLogin.Text);
            if (Account_BUS.Request.CheckLogin(account))
            {
                Account acc = Account_BUS.Request.GetAccountByUserName(account.Username);
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                fManager fManager = new fManager(acc);
                this.Hide();
                SplashScreenManager.CloseForm();
                fManager.ShowDialog();
                this.Show();
            }
            else
            {
                XtraMessageBox.Show("Thông tin đăng nhập không hợp lệ!","Lỗi",MessageBoxButtons.OK);
                return;
            }
        }
        private void checkbox_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_showPass.Checked)
            {
                text_password_fLogin.Properties.PasswordChar = (char)0;
            }
            else
            {
                text_password_fLogin.Properties.PasswordChar = '❤';
            }
        }

        private void text_password_fLogin_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btn_login_fLogin.PerformClick();
            }
        }
    }
}