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
            this.deToDate = new DevExpress.XtraEditors.DateEdit();
            this.deFromDate = new DevExpress.XtraEditors.DateEdit();
            this.gcBill = new DevExpress.XtraGrid.GridControl();
            this.gvBill = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnShowBill = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.deToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTuNgay
            // 
            this.txtTuNgay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTuNgay.AutoSize = true;
            this.txtTuNgay.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuNgay.Location = new System.Drawing.Point(60, 36);
            this.txtTuNgay.Name = "txtTuNgay";
            this.txtTuNgay.Size = new System.Drawing.Size(96, 25);
            this.txtTuNgay.TabIndex = 0;
            this.txtTuNgay.Text = "Từ ngày:";
            // 
            // txtNgayDen
            // 
            this.txtNgayDen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNgayDen.AutoSize = true;
            this.txtNgayDen.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayDen.Location = new System.Drawing.Point(759, 38);
            this.txtNgayDen.Name = "txtNgayDen";
            this.txtNgayDen.Size = new System.Drawing.Size(109, 25);
            this.txtNgayDen.TabIndex = 4;
            this.txtNgayDen.Text = "Đến ngày:";
            // 
            // deToDate
            // 
            this.deToDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deToDate.EditValue = null;
            this.deToDate.Location = new System.Drawing.Point(863, 27);
            this.deToDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deToDate.Name = "deToDate";
            this.deToDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deToDate.Properties.Appearance.Options.UseFont = true;
            this.deToDate.Properties.AutoHeight = false;
            this.deToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deToDate.Size = new System.Drawing.Size(225, 51);
            this.deToDate.TabIndex = 5;
            // 
            // deFromDate
            // 
            this.deFromDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deFromDate.EditValue = null;
            this.deFromDate.Location = new System.Drawing.Point(163, 26);
            this.deFromDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deFromDate.Name = "deFromDate";
            this.deFromDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deFromDate.Properties.Appearance.Options.UseFont = true;
            this.deFromDate.Properties.AutoHeight = false;
            this.deFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFromDate.Size = new System.Drawing.Size(225, 50);
            this.deFromDate.TabIndex = 6;
            // 
            // gcBill
            // 
            this.gcBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcBill.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcBill.Location = new System.Drawing.Point(-1, 99);
            this.gcBill.MainView = this.gvBill;
            this.gcBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcBill.Name = "gcBill";
            this.gcBill.Size = new System.Drawing.Size(1165, 501);
            this.gcBill.TabIndex = 7;
            this.gcBill.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBill});
            // 
            // gvBill
            // 
            this.gvBill.GridControl = this.gcBill;
            this.gvBill.Name = "gvBill";
            this.gvBill.Click += new System.EventHandler(this.gvBill_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRemove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.ImageOptions.Image")));
            this.btnRemove.Location = new System.Drawing.Point(598, 25);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(134, 56);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnShowBill
            // 
            this.btnShowBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnShowBill.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnShowBill.ImageOptions.Image")));
            this.btnShowBill.Location = new System.Drawing.Point(428, 25);
            this.btnShowBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowBill.Name = "btnShowBill";
            this.btnShowBill.Size = new System.Drawing.Size(134, 56);
            this.btnShowBill.TabIndex = 9;
            this.btnShowBill.Text = "Xem";
            this.btnShowBill.Click += new System.EventHandler(this.btnShowBill_Click);
            // 
            // fBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 602);
            this.Controls.Add(this.btnShowBill);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gcBill);
            this.Controls.Add(this.deFromDate);
            this.Controls.Add(this.deToDate);
            this.Controls.Add(this.txtNgayDen);
            this.Controls.Add(this.txtTuNgay);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fBill";
            this.Text = "Doanh thu";
            ((System.ComponentModel.ISupportInitialize)(this.deToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTuNgay;
        private System.Windows.Forms.Label txtNgayDen;
        private DevExpress.XtraEditors.DateEdit deToDate;
        private DevExpress.XtraEditors.DateEdit deFromDate;
        private DevExpress.XtraGrid.GridControl gcBill;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBill;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.SimpleButton btnShowBill;
    }
}