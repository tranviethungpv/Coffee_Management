namespace GUI
{
    partial class fStatistic
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
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel1 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.categoryWithPriceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffee_ManagementDataSet1 = new GUI.Coffee_ManagementDataSet1();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffee_ManagementDataSet = new GUI.Coffee_ManagementDataSet();
            this.billTableAdapter = new GUI.Coffee_ManagementDataSetTableAdapters.BillTableAdapter();
            this.categoryWithPriceTableAdapter = new GUI.Coffee_ManagementDataSet1TableAdapters.CategoryWithPriceTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryWithPriceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffee_ManagementDataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffee_ManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chartControl2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 635);
            this.panel1.TabIndex = 0;
            // 
            // chartControl2
            // 
            this.chartControl2.DataSource = this.categoryWithPriceBindingSource;
            this.chartControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl2.Location = new System.Drawing.Point(0, 0);
            this.chartControl2.Name = "chartControl2";
            series1.ArgumentDataMember = "Name";
            pieSeriesLabel1.TextPattern = "{A} {VP:p2}";
            series1.Label = pieSeriesLabel1;
            series1.Name = "Series 1";
            series1.ValueDataMembersSerializable = "TotalPrice";
            series1.View = pieSeriesView1;
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl2.SeriesTemplate.ArgumentDataMember = "Name";
            this.chartControl2.SeriesTemplate.ColorDataMember = "Name";
            this.chartControl2.SeriesTemplate.ToolTipHintDataMember = "Name";
            this.chartControl2.SeriesTemplate.ValueDataMembersSerializable = "TotalPrice";
            this.chartControl2.Size = new System.Drawing.Size(815, 635);
            this.chartControl2.TabIndex = 0;
            // 
            // categoryWithPriceBindingSource
            // 
            this.categoryWithPriceBindingSource.DataMember = "CategoryWithPrice";
            this.categoryWithPriceBindingSource.DataSource = this.coffee_ManagementDataSet1;
            // 
            // coffee_ManagementDataSet1
            // 
            this.coffee_ManagementDataSet1.DataSetName = "Coffee_ManagementDataSet1";
            this.coffee_ManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chartControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(815, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 635);
            this.panel2.TabIndex = 1;
            // 
            // chartControl1
            // 
            this.chartControl1.DataSource = this.billBindingSource;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            series2.ArgumentDataMember = "CheckIn";
            series2.Name = "Tiền";
            series2.ValueDataMembersSerializable = "TotalPrice";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControl1.Size = new System.Drawing.Size(654, 635);
            this.chartControl1.TabIndex = 0;
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataMember = "Bill";
            this.billBindingSource.DataSource = this.coffee_ManagementDataSet;
            // 
            // coffee_ManagementDataSet
            // 
            this.coffee_ManagementDataSet.DataSetName = "Coffee_ManagementDataSet";
            this.coffee_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billTableAdapter
            // 
            this.billTableAdapter.ClearBeforeFill = true;
            // 
            // categoryWithPriceTableAdapter
            // 
            this.categoryWithPriceTableAdapter.ClearBeforeFill = true;
            // 
            // fStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 635);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fStatistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.fStatistic_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryWithPriceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffee_ManagementDataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffee_ManagementDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private Coffee_ManagementDataSet coffee_ManagementDataSet;
        private System.Windows.Forms.BindingSource billBindingSource;
        private Coffee_ManagementDataSetTableAdapters.BillTableAdapter billTableAdapter;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private Coffee_ManagementDataSet1 coffee_ManagementDataSet1;
        private System.Windows.Forms.BindingSource categoryWithPriceBindingSource;
        private Coffee_ManagementDataSet1TableAdapters.CategoryWithPriceTableAdapter categoryWithPriceTableAdapter;
    }
}