namespace GUI
{
    partial class fLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_title_fLogin = new DevExpress.XtraEditors.LabelControl();
            this.label_login_fLogin = new DevExpress.XtraEditors.LabelControl();
            this.label_password_fLogin = new DevExpress.XtraEditors.LabelControl();
            this.text_login_fLogin = new DevExpress.XtraEditors.TextEdit();
            this.text_password_fLogin = new DevExpress.XtraEditors.TextEdit();
            this.btn_login_fLogin = new DevExpress.XtraEditors.SimpleButton();
            this.btn_exit_fLogin = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.text_login_fLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_password_fLogin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title_fLogin
            // 
            this.label_title_fLogin.Appearance.Font = new System.Drawing.Font("Vinhan", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title_fLogin.Appearance.ForeColor = System.Drawing.Color.IndianRed;
            this.label_title_fLogin.Appearance.Options.UseFont = true;
            this.label_title_fLogin.Appearance.Options.UseForeColor = true;
            this.label_title_fLogin.Location = new System.Drawing.Point(155, 36);
            this.label_title_fLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.label_title_fLogin.Name = "label_title_fLogin";
            this.label_title_fLogin.Size = new System.Drawing.Size(157, 45);
            this.label_title_fLogin.TabIndex = 1;
            this.label_title_fLogin.Text = "User Login";
            // 
            // label_login_fLogin
            // 
            this.label_login_fLogin.Appearance.Font = new System.Drawing.Font("Vinhan", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login_fLogin.Appearance.ForeColor = System.Drawing.Color.IndianRed;
            this.label_login_fLogin.Appearance.Options.UseFont = true;
            this.label_login_fLogin.Appearance.Options.UseForeColor = true;
            this.label_login_fLogin.Location = new System.Drawing.Point(59, 107);
            this.label_login_fLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.label_login_fLogin.Name = "label_login_fLogin";
            this.label_login_fLogin.Size = new System.Drawing.Size(41, 24);
            this.label_login_fLogin.TabIndex = 2;
            this.label_login_fLogin.Text = "Login";
            // 
            // label_password_fLogin
            // 
            this.label_password_fLogin.Appearance.Font = new System.Drawing.Font("Vinhan", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password_fLogin.Appearance.ForeColor = System.Drawing.Color.IndianRed;
            this.label_password_fLogin.Appearance.Options.UseFont = true;
            this.label_password_fLogin.Appearance.Options.UseForeColor = true;
            this.label_password_fLogin.Location = new System.Drawing.Point(25, 161);
            this.label_password_fLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.label_password_fLogin.Name = "label_password_fLogin";
            this.label_password_fLogin.Size = new System.Drawing.Size(73, 24);
            this.label_password_fLogin.TabIndex = 3;
            this.label_password_fLogin.Text = "Password";
            this.label_password_fLogin.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // text_login_fLogin
            // 
            this.text_login_fLogin.Location = new System.Drawing.Point(123, 105);
            this.text_login_fLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.text_login_fLogin.Name = "text_login_fLogin";
            this.text_login_fLogin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_login_fLogin.Properties.Appearance.Options.UseFont = true;
            this.text_login_fLogin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.text_login_fLogin.Size = new System.Drawing.Size(226, 26);
            this.text_login_fLogin.TabIndex = 4;
            this.text_login_fLogin.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // text_password_fLogin
            // 
            this.text_password_fLogin.Location = new System.Drawing.Point(123, 159);
            this.text_password_fLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.text_password_fLogin.Name = "text_password_fLogin";
            this.text_password_fLogin.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.text_password_fLogin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_password_fLogin.Properties.Appearance.Options.UseBackColor = true;
            this.text_password_fLogin.Properties.Appearance.Options.UseFont = true;
            this.text_password_fLogin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.text_password_fLogin.Size = new System.Drawing.Size(226, 26);
            this.text_password_fLogin.TabIndex = 5;
            // 
            // btn_login_fLogin
            // 
            this.btn_login_fLogin.Appearance.Font = new System.Drawing.Font("Vinhan", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_fLogin.Appearance.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_login_fLogin.Appearance.Options.UseFont = true;
            this.btn_login_fLogin.Appearance.Options.UseForeColor = true;
            this.btn_login_fLogin.Location = new System.Drawing.Point(111, 223);
            this.btn_login_fLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_login_fLogin.Name = "btn_login_fLogin";
            this.btn_login_fLogin.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_login_fLogin.Size = new System.Drawing.Size(100, 40);
            this.btn_login_fLogin.TabIndex = 6;
            this.btn_login_fLogin.Text = "Login";
            this.btn_login_fLogin.Click += new System.EventHandler(this.btn_login_fLogin_Click);
            // 
            // btn_exit_fLogin
            // 
            this.btn_exit_fLogin.Appearance.Font = new System.Drawing.Font("Vinhan", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit_fLogin.Appearance.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_exit_fLogin.Appearance.Options.UseFont = true;
            this.btn_exit_fLogin.Appearance.Options.UseForeColor = true;
            this.btn_exit_fLogin.Location = new System.Drawing.Point(235, 223);
            this.btn_exit_fLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_exit_fLogin.Name = "btn_exit_fLogin";
            this.btn_exit_fLogin.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_exit_fLogin.Size = new System.Drawing.Size(100, 40);
            this.btn_exit_fLogin.TabIndex = 7;
            this.btn_exit_fLogin.Text = "Exit";
            this.btn_exit_fLogin.Click += new System.EventHandler(this.btn_exit_fLogin_Click);
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::GUI.Properties.Resources.pngtree_white_keyboard_coffee_pure_white_desktop_photography_map_image_750305;
            this.ClientSize = new System.Drawing.Size(662, 313);
            this.Controls.Add(this.btn_exit_fLogin);
            this.Controls.Add(this.btn_login_fLogin);
            this.Controls.Add(this.text_password_fLogin);
            this.Controls.Add(this.text_login_fLogin);
            this.Controls.Add(this.label_password_fLogin);
            this.Controls.Add(this.label_login_fLogin);
            this.Controls.Add(this.label_title_fLogin);
            this.IconOptions.Image = global::GUI.Properties.Resources.rsz_1172719c1774ee6ad29e6969a5c3d6ba7;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.text_login_fLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_password_fLogin.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl label_title_fLogin;
        private DevExpress.XtraEditors.LabelControl label_login_fLogin;
        private DevExpress.XtraEditors.LabelControl label_password_fLogin;
        private DevExpress.XtraEditors.TextEdit text_login_fLogin;
        private DevExpress.XtraEditors.TextEdit text_password_fLogin;
        private DevExpress.XtraEditors.SimpleButton btn_login_fLogin;
        private DevExpress.XtraEditors.SimpleButton btn_exit_fLogin;
    }
}