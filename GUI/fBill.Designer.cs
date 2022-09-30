namespace GUI
{
    partial class fBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBill));
            this.txtTuNgay = new System.Windows.Forms.Label();
            this.txtNgayDen = new System.Windows.Forms.Label();
            this.deFormDate = new DevExpress.XtraEditors.DateEdit();
            this.deToDate = new DevExpress.XtraEditors.DateEdit();
            this.gcBill = new DevExpress.XtraGrid.GridControl();
            this.gvBill = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnShowBill = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.deFormDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFormDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTuNgay
            // 
            this.txtTuNgay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTuNgay.AutoSize = true;
            this.txtTuNgay.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuNgay.Location = new System.Drawing.Point(47, 30);
            this.txtTuNgay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtTuNgay.Name = "txtTuNgay";
            this.txtTuNgay.Size = new System.Drawing.Size(76, 21);
            this.txtTuNgay.TabIndex = 0;
            this.txtTuNgay.Text = "Từ ngày:";
            // 
            // txtNgayDen
            // 
            this.txtNgayDen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNgayDen.AutoSize = true;
            this.txtNgayDen.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayDen.Location = new System.Drawing.Point(590, 32);
            this.txtNgayDen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtNgayDen.Name = "txtNgayDen";
            this.txtNgayDen.Size = new System.Drawing.Size(86, 21);
            this.txtNgayDen.TabIndex = 4;
            this.txtNgayDen.Text = "Đến ngày:";
            // 
            // deFormDate
            // 
            this.deFormDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deFormDate.EditValue = null;
            this.deFormDate.Location = new System.Drawing.Point(671, 23);
            this.deFormDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.deFormDate.Name = "deFormDate";
            this.deFormDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deFormDate.Properties.Appearance.Options.UseFont = true;
            this.deFormDate.Properties.AutoHeight = false;
            this.deFormDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFormDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFormDate.Size = new System.Drawing.Size(175, 43);
            this.deFormDate.TabIndex = 5;
            // 
            // deToDate
            // 
            this.deToDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deToDate.EditValue = null;
            this.deToDate.Location = new System.Drawing.Point(127, 22);
            this.deToDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.deToDate.Name = "deToDate";
            this.deToDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deToDate.Properties.Appearance.Options.UseFont = true;
            this.deToDate.Properties.AutoHeight = false;
            this.deToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deToDate.Size = new System.Drawing.Size(175, 42);
            this.deToDate.TabIndex = 6;
            // 
            // gcBill
            // 
            this.gcBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcBill.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gcBill.Location = new System.Drawing.Point(-1, 83);
            this.gcBill.MainView = this.gvBill;
            this.gcBill.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gcBill.Name = "gcBill";
            this.gcBill.Size = new System.Drawing.Size(906, 422);
            this.gcBill.TabIndex = 7;
            this.gcBill.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBill});
            // 
            // gvBill
            // 
            this.gvBill.DetailHeight = 295;
            this.gvBill.GridControl = this.gcBill;
            this.gvBill.Name = "gvBill";
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRemove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.ImageOptions.Image")));
            this.btnRemove.Location = new System.Drawing.Point(465, 21);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(104, 47);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Xóa";
            // 
            // btnShowBill
            // 
            this.btnShowBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShowBill.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnShowBill.ImageOptions.Image")));
            this.btnShowBill.Location = new System.Drawing.Point(333, 21);
            this.btnShowBill.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnShowBill.Name = "btnShowBill";
            this.btnShowBill.Size = new System.Drawing.Size(104, 47);
            this.btnShowBill.TabIndex = 9;
            this.btnShowBill.Text = "Xem";
            // 
            // fBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 507);
            this.Controls.Add(this.btnShowBill);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gcBill);
            this.Controls.Add(this.deToDate);
            this.Controls.Add(this.deFormDate);
            this.Controls.Add(this.txtNgayDen);
            this.Controls.Add(this.txtTuNgay);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "fBill";
            this.Text = "Doanh thu";
            ((System.ComponentModel.ISupportInitialize)(this.deFormDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFormDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTuNgay;
        private System.Windows.Forms.Label txtNgayDen;
        private DevExpress.XtraEditors.DateEdit deFormDate;
        private DevExpress.XtraEditors.DateEdit deToDate;
        private DevExpress.XtraGrid.GridControl gcBill;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBill;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.SimpleButton btnShowBill;
    }
}