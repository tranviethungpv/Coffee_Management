namespace GUI
{
    partial class fMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.listView_Food_fMain = new System.Windows.Forms.ListView();
            this.columnHeader_nameFood_listView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Amount_listView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Price_listView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_finalPrice_listView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_FoodandCategory_fMain = new System.Windows.Forms.Panel();
            this.textEdit_finalPrice_fMain = new DevExpress.XtraEditors.TextEdit();
            this.label_currentChoosing_fMain = new DevExpress.XtraEditors.LabelControl();
            this.label_Discount_fMain = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_Choosen_fMain = new DevExpress.XtraEditors.LabelControl();
            this.btn_Pay_fMain = new DevExpress.XtraEditors.SimpleButton();
            this.btn_SwitchTable_fMain = new DevExpress.XtraEditors.SimpleButton();
            this.btn_AddFood_fMain = new DevExpress.XtraEditors.SimpleButton();
            this.spinEdit_Discount_fMain = new DevExpress.XtraEditors.SpinEdit();
            this.spinEdit_Amount_fMain = new DevExpress.XtraEditors.SpinEdit();
            this.lookUpEdit_chooseTable_fMain = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit_chooseFood_fMain = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit_chooseCategory_fMain = new DevExpress.XtraEditors.LookUpEdit();
            this.flowLayoutPanel_Table_fMain = new System.Windows.Forms.FlowLayoutPanel();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.panel_FoodandCategory_fMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_finalPrice_fMain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_Discount_fMain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_Amount_fMain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_chooseTable_fMain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_chooseFood_fMain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_chooseCategory_fMain.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_Food_fMain
            // 
            this.listView_Food_fMain.AllowDrop = true;
            this.listView_Food_fMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Food_fMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_nameFood_listView,
            this.columnHeader_Amount_listView,
            this.columnHeader_Price_listView,
            this.columnHeader_finalPrice_listView});
            this.listView_Food_fMain.HideSelection = false;
            this.listView_Food_fMain.Location = new System.Drawing.Point(9, 108);
            this.listView_Food_fMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listView_Food_fMain.Name = "listView_Food_fMain";
            this.listView_Food_fMain.Size = new System.Drawing.Size(961, 257);
            this.listView_Food_fMain.TabIndex = 0;
            this.listView_Food_fMain.UseCompatibleStateImageBehavior = false;
            this.listView_Food_fMain.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_nameFood_listView
            // 
            this.columnHeader_nameFood_listView.Text = "Tên Món";
            this.columnHeader_nameFood_listView.Width = 336;
            // 
            // columnHeader_Amount_listView
            // 
            this.columnHeader_Amount_listView.Text = "Số Lượng";
            this.columnHeader_Amount_listView.Width = 144;
            // 
            // columnHeader_Price_listView
            // 
            this.columnHeader_Price_listView.Text = "Đơn Giá";
            this.columnHeader_Price_listView.Width = 206;
            // 
            // columnHeader_finalPrice_listView
            // 
            this.columnHeader_finalPrice_listView.Text = "Thành Tiền";
            this.columnHeader_finalPrice_listView.Width = 269;
            // 
            // panel_FoodandCategory_fMain
            // 
            this.panel_FoodandCategory_fMain.Controls.Add(this.textEdit_finalPrice_fMain);
            this.panel_FoodandCategory_fMain.Controls.Add(this.label_currentChoosing_fMain);
            this.panel_FoodandCategory_fMain.Controls.Add(this.label_Discount_fMain);
            this.panel_FoodandCategory_fMain.Controls.Add(this.labelControl_Choosen_fMain);
            this.panel_FoodandCategory_fMain.Controls.Add(this.btn_Pay_fMain);
            this.panel_FoodandCategory_fMain.Controls.Add(this.btn_SwitchTable_fMain);
            this.panel_FoodandCategory_fMain.Controls.Add(this.btn_AddFood_fMain);
            this.panel_FoodandCategory_fMain.Controls.Add(this.spinEdit_Discount_fMain);
            this.panel_FoodandCategory_fMain.Controls.Add(this.spinEdit_Amount_fMain);
            this.panel_FoodandCategory_fMain.Controls.Add(this.lookUpEdit_chooseTable_fMain);
            this.panel_FoodandCategory_fMain.Controls.Add(this.lookUpEdit_chooseFood_fMain);
            this.panel_FoodandCategory_fMain.Controls.Add(this.lookUpEdit_chooseCategory_fMain);
            this.panel_FoodandCategory_fMain.Controls.Add(this.listView_Food_fMain);
            this.panel_FoodandCategory_fMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_FoodandCategory_fMain.Location = new System.Drawing.Point(0, 0);
            this.panel_FoodandCategory_fMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_FoodandCategory_fMain.Name = "panel_FoodandCategory_fMain";
            this.panel_FoodandCategory_fMain.Size = new System.Drawing.Size(992, 532);
            this.panel_FoodandCategory_fMain.TabIndex = 1;
            // 
            // textEdit_finalPrice_fMain
            // 
            this.textEdit_finalPrice_fMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textEdit_finalPrice_fMain.Location = new System.Drawing.Point(564, 421);
            this.textEdit_finalPrice_fMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textEdit_finalPrice_fMain.Name = "textEdit_finalPrice_fMain";
            this.textEdit_finalPrice_fMain.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit_finalPrice_fMain.Properties.Appearance.Options.UseFont = true;
            this.textEdit_finalPrice_fMain.Size = new System.Drawing.Size(155, 28);
            this.textEdit_finalPrice_fMain.TabIndex = 12;
            // 
            // label_currentChoosing_fMain
            // 
            this.label_currentChoosing_fMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_currentChoosing_fMain.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_currentChoosing_fMain.Appearance.Options.UseFont = true;
            this.label_currentChoosing_fMain.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.label_currentChoosing_fMain.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.ImageOptions.Image")));
            this.label_currentChoosing_fMain.Location = new System.Drawing.Point(83, 398);
            this.label_currentChoosing_fMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.label_currentChoosing_fMain.Name = "label_currentChoosing_fMain";
            this.label_currentChoosing_fMain.Size = new System.Drawing.Size(111, 28);
            this.label_currentChoosing_fMain.TabIndex = 9;
            this.label_currentChoosing_fMain.Text = "Đang Chọn";
            // 
            // label_Discount_fMain
            // 
            this.label_Discount_fMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Discount_fMain.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Discount_fMain.Appearance.Options.UseFont = true;
            this.label_Discount_fMain.Location = new System.Drawing.Point(290, 424);
            this.label_Discount_fMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.label_Discount_fMain.Name = "label_Discount_fMain";
            this.label_Discount_fMain.Size = new System.Drawing.Size(67, 21);
            this.label_Discount_fMain.TabIndex = 11;
            this.label_Discount_fMain.Text = "Giảm Giá";
            // 
            // labelControl_Choosen_fMain
            // 
            this.labelControl_Choosen_fMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl_Choosen_fMain.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl_Choosen_fMain.Appearance.Options.UseFont = true;
            this.labelControl_Choosen_fMain.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl_Choosen_fMain.ImageOptions.Image = global::GUI.Properties.Resources.check_1_icon;
            this.labelControl_Choosen_fMain.Location = new System.Drawing.Point(83, 435);
            this.labelControl_Choosen_fMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl_Choosen_fMain.Name = "labelControl_Choosen_fMain";
            this.labelControl_Choosen_fMain.Size = new System.Drawing.Size(97, 28);
            this.labelControl_Choosen_fMain.TabIndex = 10;
            this.labelControl_Choosen_fMain.Text = "Có Người";
            // 
            // btn_Pay_fMain
            // 
            this.btn_Pay_fMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Pay_fMain.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pay_fMain.Appearance.Options.UseFont = true;
            this.btn_Pay_fMain.Location = new System.Drawing.Point(778, 398);
            this.btn_Pay_fMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Pay_fMain.Name = "btn_Pay_fMain";
            this.btn_Pay_fMain.Size = new System.Drawing.Size(159, 71);
            this.btn_Pay_fMain.TabIndex = 8;
            this.btn_Pay_fMain.Text = "Thanh Toán";
            this.btn_Pay_fMain.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // btn_SwitchTable_fMain
            // 
            this.btn_SwitchTable_fMain.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SwitchTable_fMain.Appearance.Options.UseFont = true;
            this.btn_SwitchTable_fMain.Location = new System.Drawing.Point(778, 12);
            this.btn_SwitchTable_fMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_SwitchTable_fMain.Name = "btn_SwitchTable_fMain";
            this.btn_SwitchTable_fMain.Size = new System.Drawing.Size(170, 46);
            this.btn_SwitchTable_fMain.TabIndex = 7;
            this.btn_SwitchTable_fMain.Text = "Chuyển";
            this.btn_SwitchTable_fMain.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btn_AddFood_fMain
            // 
            this.btn_AddFood_fMain.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddFood_fMain.Appearance.Options.UseFont = true;
            this.btn_AddFood_fMain.Location = new System.Drawing.Point(351, 34);
            this.btn_AddFood_fMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_AddFood_fMain.Name = "btn_AddFood_fMain";
            this.btn_AddFood_fMain.Size = new System.Drawing.Size(156, 54);
            this.btn_AddFood_fMain.TabIndex = 6;
            this.btn_AddFood_fMain.Text = "Thêm Món";
            this.btn_AddFood_fMain.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // spinEdit_Discount_fMain
            // 
            this.spinEdit_Discount_fMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.spinEdit_Discount_fMain.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit_Discount_fMain.Location = new System.Drawing.Point(373, 421);
            this.spinEdit_Discount_fMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.spinEdit_Discount_fMain.Name = "spinEdit_Discount_fMain";
            this.spinEdit_Discount_fMain.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinEdit_Discount_fMain.Properties.Appearance.Options.UseFont = true;
            this.spinEdit_Discount_fMain.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit_Discount_fMain.Size = new System.Drawing.Size(134, 28);
            this.spinEdit_Discount_fMain.TabIndex = 5;
            // 
            // spinEdit_Amount_fMain
            // 
            this.spinEdit_Amount_fMain.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEdit_Amount_fMain.Location = new System.Drawing.Point(585, 48);
            this.spinEdit_Amount_fMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.spinEdit_Amount_fMain.Name = "spinEdit_Amount_fMain";
            this.spinEdit_Amount_fMain.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinEdit_Amount_fMain.Properties.Appearance.Options.UseFont = true;
            this.spinEdit_Amount_fMain.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit_Amount_fMain.Size = new System.Drawing.Size(134, 28);
            this.spinEdit_Amount_fMain.TabIndex = 4;
            // 
            // lookUpEdit_chooseTable_fMain
            // 
            this.lookUpEdit_chooseTable_fMain.Location = new System.Drawing.Point(778, 64);
            this.lookUpEdit_chooseTable_fMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lookUpEdit_chooseTable_fMain.Name = "lookUpEdit_chooseTable_fMain";
            this.lookUpEdit_chooseTable_fMain.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEdit_chooseTable_fMain.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit_chooseTable_fMain.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_chooseTable_fMain.Properties.NullText = "-- Chọn bàn --";
            this.lookUpEdit_chooseTable_fMain.Size = new System.Drawing.Size(170, 28);
            this.lookUpEdit_chooseTable_fMain.TabIndex = 3;
            // 
            // lookUpEdit_chooseFood_fMain
            // 
            this.lookUpEdit_chooseFood_fMain.Location = new System.Drawing.Point(47, 63);
            this.lookUpEdit_chooseFood_fMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lookUpEdit_chooseFood_fMain.Name = "lookUpEdit_chooseFood_fMain";
            this.lookUpEdit_chooseFood_fMain.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEdit_chooseFood_fMain.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit_chooseFood_fMain.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_chooseFood_fMain.Properties.NullText = "-- Chọn món --";
            this.lookUpEdit_chooseFood_fMain.Size = new System.Drawing.Size(217, 28);
            this.lookUpEdit_chooseFood_fMain.TabIndex = 2;
            // 
            // lookUpEdit_chooseCategory_fMain
            // 
            this.lookUpEdit_chooseCategory_fMain.Location = new System.Drawing.Point(47, 19);
            this.lookUpEdit_chooseCategory_fMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lookUpEdit_chooseCategory_fMain.Name = "lookUpEdit_chooseCategory_fMain";
            this.lookUpEdit_chooseCategory_fMain.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEdit_chooseCategory_fMain.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit_chooseCategory_fMain.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_chooseCategory_fMain.Properties.NullText = "-- Chọn danh mục --";
            this.lookUpEdit_chooseCategory_fMain.Size = new System.Drawing.Size(217, 28);
            this.lookUpEdit_chooseCategory_fMain.TabIndex = 1;
            this.lookUpEdit_chooseCategory_fMain.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged);
            // 
            // flowLayoutPanel_Table_fMain
            // 
            this.flowLayoutPanel_Table_fMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Table_fMain.Location = new System.Drawing.Point(992, 0);
            this.flowLayoutPanel_Table_fMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flowLayoutPanel_Table_fMain.Name = "flowLayoutPanel_Table_fMain";
            this.flowLayoutPanel_Table_fMain.Size = new System.Drawing.Size(281, 532);
            this.flowLayoutPanel_Table_fMain.TabIndex = 2;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "check-1-icon.png");
            this.imageList.Images.SetKeyName(1, "Check-2-icon.png");
            // 
            // fMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 532);
            this.Controls.Add(this.flowLayoutPanel_Table_fMain);
            this.Controls.Add(this.panel_FoodandCategory_fMain);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.Image = global::GUI.Properties.Resources.rsz_1172719c1774ee6ad29e6969a5c3d6ba7;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn hình chính";
            this.panel_FoodandCategory_fMain.ResumeLayout(false);
            this.panel_FoodandCategory_fMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_finalPrice_fMain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_Discount_fMain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit_Amount_fMain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_chooseTable_fMain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_chooseFood_fMain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_chooseCategory_fMain.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_Food_fMain;
        private System.Windows.Forms.Panel panel_FoodandCategory_fMain;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_chooseCategory_fMain;
        private DevExpress.XtraEditors.TextEdit textEdit_finalPrice_fMain;
        private DevExpress.XtraEditors.LabelControl label_Discount_fMain;
        private DevExpress.XtraEditors.LabelControl labelControl_Choosen_fMain;
        private DevExpress.XtraEditors.LabelControl label_currentChoosing_fMain;
        private DevExpress.XtraEditors.SimpleButton btn_Pay_fMain;
        private DevExpress.XtraEditors.SimpleButton btn_SwitchTable_fMain;
        private DevExpress.XtraEditors.SimpleButton btn_AddFood_fMain;
        private DevExpress.XtraEditors.SpinEdit spinEdit_Discount_fMain;
        private DevExpress.XtraEditors.SpinEdit spinEdit_Amount_fMain;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_chooseTable_fMain;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_chooseFood_fMain;
        private System.Windows.Forms.ColumnHeader columnHeader_nameFood_listView;
        private System.Windows.Forms.ColumnHeader columnHeader_Amount_listView;
        private System.Windows.Forms.ColumnHeader columnHeader_Price_listView;
        private System.Windows.Forms.ColumnHeader columnHeader_finalPrice_listView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Table_fMain;
        private System.Windows.Forms.ImageList imageList;
    }
}