namespace App.WindowsApp.Views
{
    partial class DashboardView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.flpKpi = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSales = new System.Windows.Forms.Panel();
            this.lblSalesV = new System.Windows.Forms.Label();
            this.lblSalesT = new System.Windows.Forms.Label();
            this.pnlOrders = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblOrdersT = new System.Windows.Forms.Label();
            this.lblOrdersV = new System.Windows.Forms.Label();
            this.pnlRevenue = new System.Windows.Forms.Panel();
            this.lblRevenueV = new System.Windows.Forms.Label();
            this.lblRevenueT = new System.Windows.Forms.Label();
            this.pnlLowStock = new System.Windows.Forms.Panel();
            this.lblLowStock = new System.Windows.Forms.Label();
            this.lvlowStock = new System.Windows.Forms.ListView();
            this.colProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlRecentOrders = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colOrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRecentOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tblDashboard.SuspendLayout();
            this.flpKpi.SuspendLayout();
            this.pnlSales.SuspendLayout();
            this.pnlOrders.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlRevenue.SuspendLayout();
            this.pnlLowStock.SuspendLayout();
            this.pnlRecentOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblDashboard
            // 
            this.tblDashboard.ColumnCount = 1;
            this.tblDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDashboard.Controls.Add(this.flpKpi, 0, 0);
            this.tblDashboard.Controls.Add(this.pnlLowStock, 0, 1);
            this.tblDashboard.Controls.Add(this.pnlRecentOrders, 0, 2);
            this.tblDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDashboard.Location = new System.Drawing.Point(0, 0);
            this.tblDashboard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tblDashboard.Name = "tblDashboard";
            this.tblDashboard.RowCount = 3;
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDashboard.Size = new System.Drawing.Size(652, 427);
            this.tblDashboard.TabIndex = 0;
            // 
            // flpKpi
            // 
            this.flpKpi.Controls.Add(this.pnlSales);
            this.flpKpi.Controls.Add(this.pnlOrders);
            this.flpKpi.Controls.Add(this.pnlRevenue);
            this.flpKpi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpKpi.Location = new System.Drawing.Point(2, 2);
            this.flpKpi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpKpi.Name = "flpKpi";
            this.flpKpi.Size = new System.Drawing.Size(648, 74);
            this.flpKpi.TabIndex = 0;
            // 
            // pnlSales
            // 
            this.pnlSales.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlSales.Controls.Add(this.lblSalesV);
            this.pnlSales.Controls.Add(this.lblSalesT);
            this.pnlSales.Location = new System.Drawing.Point(2, 2);
            this.pnlSales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(133, 65);
            this.pnlSales.TabIndex = 0;
            // 
            // lblSalesV
            // 
            this.lblSalesV.AutoSize = true;
            this.lblSalesV.Location = new System.Drawing.Point(75, 18);
            this.lblSalesV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalesV.Name = "lblSalesV";
            this.lblSalesV.Size = new System.Drawing.Size(25, 13);
            this.lblSalesV.TabIndex = 1;
            this.lblSalesV.Text = "100";
            // 
            // lblSalesT
            // 
            this.lblSalesT.AutoSize = true;
            this.lblSalesT.Location = new System.Drawing.Point(11, 18);
            this.lblSalesT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalesT.Name = "lblSalesT";
            this.lblSalesT.Size = new System.Drawing.Size(33, 13);
            this.lblSalesT.TabIndex = 0;
            this.lblSalesT.Text = "Sales";
            // 
            // pnlOrders
            // 
            this.pnlOrders.Controls.Add(this.flowLayoutPanel1);
            this.pnlOrders.Location = new System.Drawing.Point(139, 2);
            this.pnlOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(133, 65);
            this.pnlOrders.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel1.Controls.Add(this.lblOrdersT);
            this.flowLayoutPanel1.Controls.Add(this.lblOrdersV);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(133, 65);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblOrdersT
            // 
            this.lblOrdersT.AutoSize = true;
            this.lblOrdersT.Location = new System.Drawing.Point(2, 0);
            this.lblOrdersT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrdersT.Name = "lblOrdersT";
            this.lblOrdersT.Size = new System.Drawing.Size(38, 13);
            this.lblOrdersT.TabIndex = 0;
            this.lblOrdersT.Text = "Orders";
            // 
            // lblOrdersV
            // 
            this.lblOrdersV.AutoSize = true;
            this.lblOrdersV.Location = new System.Drawing.Point(44, 0);
            this.lblOrdersV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrdersV.Name = "lblOrdersV";
            this.lblOrdersV.Size = new System.Drawing.Size(19, 13);
            this.lblOrdersV.TabIndex = 1;
            this.lblOrdersV.Text = "50";
            // 
            // pnlRevenue
            // 
            this.pnlRevenue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlRevenue.Controls.Add(this.lblRevenueV);
            this.pnlRevenue.Controls.Add(this.lblRevenueT);
            this.pnlRevenue.Location = new System.Drawing.Point(276, 2);
            this.pnlRevenue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlRevenue.Name = "pnlRevenue";
            this.pnlRevenue.Size = new System.Drawing.Size(133, 65);
            this.pnlRevenue.TabIndex = 2;
            // 
            // lblRevenueV
            // 
            this.lblRevenueV.AutoSize = true;
            this.lblRevenueV.Location = new System.Drawing.Point(79, 18);
            this.lblRevenueV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRevenueV.Name = "lblRevenueV";
            this.lblRevenueV.Size = new System.Drawing.Size(31, 13);
            this.lblRevenueV.TabIndex = 1;
            this.lblRevenueV.Text = "1200";
            // 
            // lblRevenueT
            // 
            this.lblRevenueT.AutoSize = true;
            this.lblRevenueT.Location = new System.Drawing.Point(20, 18);
            this.lblRevenueT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRevenueT.Name = "lblRevenueT";
            this.lblRevenueT.Size = new System.Drawing.Size(51, 13);
            this.lblRevenueT.TabIndex = 0;
            this.lblRevenueT.Text = "Revenue";
            // 
            // pnlLowStock
            // 
            this.pnlLowStock.Controls.Add(this.lblLowStock);
            this.pnlLowStock.Controls.Add(this.lvlowStock);
            this.pnlLowStock.Location = new System.Drawing.Point(2, 80);
            this.pnlLowStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlLowStock.Name = "pnlLowStock";
            this.pnlLowStock.Size = new System.Drawing.Size(648, 164);
            this.pnlLowStock.TabIndex = 1;
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Location = new System.Drawing.Point(2, 12);
            this.lblLowStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(58, 13);
            this.lblLowStock.TabIndex = 1;
            this.lblLowStock.Text = "Low Stock";
            this.lblLowStock.Click += new System.EventHandler(this.lblLowStock_Click);
            // 
            // lvlowStock
            // 
            this.lvlowStock.BackColor = System.Drawing.Color.White;
            this.lvlowStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvlowStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProduct,
            this.colStock});
            this.lvlowStock.FullRowSelect = true;
            this.lvlowStock.GridLines = true;
            this.lvlowStock.HideSelection = false;
            this.lvlowStock.Location = new System.Drawing.Point(2, 27);
            this.lvlowStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvlowStock.Name = "lvlowStock";
            this.lvlowStock.Size = new System.Drawing.Size(645, 125);
            this.lvlowStock.TabIndex = 0;
            this.lvlowStock.UseCompatibleStateImageBehavior = false;
            this.lvlowStock.View = System.Windows.Forms.View.Details;
            this.lvlowStock.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // colProduct
            // 
            this.colProduct.Text = "Product";
            // 
            // colStock
            // 
            this.colStock.Text = "Stock";
            // 
            // pnlRecentOrders
            // 
            this.pnlRecentOrders.Controls.Add(this.listView1);
            this.pnlRecentOrders.Controls.Add(this.label1);
            this.pnlRecentOrders.Location = new System.Drawing.Point(2, 254);
            this.pnlRecentOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlRecentOrders.Name = "pnlRecentOrders";
            this.pnlRecentOrders.Size = new System.Drawing.Size(648, 150);
            this.pnlRecentOrders.TabIndex = 2;
            this.pnlRecentOrders.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRecentOrders_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recent Orders";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colOrderID,
            this.colRecentOrder});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(17, 45);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(608, 80);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblDashboard);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(652, 427);
            this.tblDashboard.ResumeLayout(false);
            this.flpKpi.ResumeLayout(false);
            this.pnlSales.ResumeLayout(false);
            this.pnlSales.PerformLayout();
            this.pnlOrders.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.pnlRevenue.ResumeLayout(false);
            this.pnlRevenue.PerformLayout();
            this.pnlLowStock.ResumeLayout(false);
            this.pnlLowStock.PerformLayout();
            this.pnlRecentOrders.ResumeLayout(false);
            this.pnlRecentOrders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblDashboard;
        private System.Windows.Forms.FlowLayoutPanel flpKpi;
        private System.Windows.Forms.Panel pnlSales;
        private System.Windows.Forms.Panel pnlOrders;
        private System.Windows.Forms.Label lblSalesV;
        private System.Windows.Forms.Label lblSalesT;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblOrdersT;
        private System.Windows.Forms.Panel pnlRevenue;
        private System.Windows.Forms.Label lblOrdersV;
        private System.Windows.Forms.Label lblRevenueV;
        private System.Windows.Forms.Label lblRevenueT;
        private System.Windows.Forms.Panel pnlLowStock;
        private System.Windows.Forms.Panel pnlRecentOrders;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.ListView lvlowStock;
        private System.Windows.Forms.ColumnHeader colProduct;
        private System.Windows.Forms.ColumnHeader colStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.ColumnHeader colOrderID;
        private System.Windows.Forms.ColumnHeader colRecentOrder;
    }
}
