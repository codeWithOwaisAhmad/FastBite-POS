namespace App.WindowsApp.Forms

{
    partial class MainForm
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
            pnlHeader = new Panel();
            flpRight = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            lblUser = new Label();
            flpLeft = new FlowLayoutPanel();
            pbLogo = new PictureBox();
            pnlContent = new Panel();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            pnlSidebar = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnDashboard = new Button();
            btnProducts = new Button();
            btnOrders = new Button();
            btnReports = new Button();
            btnSync = new Button();
            btnLogs = new Button();
            btnSettings = new Button();
            btnCustomer = new Button();
            pnlHeader.SuspendLayout();
            flpRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            flpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlContent.SuspendLayout();
            statusStrip1.SuspendLayout();
            pnlSidebar.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(flpRight);
            pnlHeader.Controls.Add(flpLeft);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(2, 2, 2, 2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1066, 50);
            pnlHeader.TabIndex = 0;
            // 
            // flpRight
            // 
            flpRight.Controls.Add(pictureBox2);
            flpRight.Controls.Add(lblUser);
            flpRight.Dock = DockStyle.Right;
            flpRight.Location = new Point(971, 0);
            flpRight.Margin = new Padding(2, 2, 2, 2);
            flpRight.Name = "flpRight";
            flpRight.Size = new Size(95, 50);
            flpRight.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.User;
            pictureBox2.Location = new Point(2, 2);
            pictureBox2.Margin = new Padding(2, 2, 2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 33);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Dock = DockStyle.Right;
            lblUser.Location = new Point(48, 0);
            lblUser.Margin = new Padding(2, 0, 2, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(43, 37);
            lblUser.TabIndex = 2;
            lblUser.Text = "Admin";
            lblUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flpLeft
            // 
            flpLeft.Controls.Add(pbLogo);
            flpLeft.Dock = DockStyle.Left;
            flpLeft.Location = new Point(0, 0);
            flpLeft.Margin = new Padding(2, 2, 2, 2);
            flpLeft.Name = "flpLeft";
            flpLeft.Size = new Size(155, 50);
            flpLeft.TabIndex = 0;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.BuildingStore;
            pbLogo.Location = new Point(2, 2);
            pbLogo.Margin = new Padding(2, 2, 2, 2);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(39, 33);
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(label1);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(156, 50);
            pnlContent.Margin = new Padding(2, 2, 2, 2);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(910, 393);
            pnlContent.TabIndex = 2;
            pnlContent.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 443);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 11, 0);
            statusStrip1.Size = new Size(1066, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(1054, 17);
            lblStatus.Spring = true;
            lblStatus.Text = "Ready";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            lblStatus.Click += lblStatus_Click;
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(flowLayoutPanel1);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 50);
            pnlSidebar.Margin = new Padding(2, 2, 2, 2);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(156, 393);
            pnlSidebar.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnDashboard);
            flowLayoutPanel1.Controls.Add(btnProducts);
            flowLayoutPanel1.Controls.Add(btnCustomer);
            flowLayoutPanel1.Controls.Add(btnOrders);
            flowLayoutPanel1.Controls.Add(btnReports);
            flowLayoutPanel1.Controls.Add(btnSync);
            flowLayoutPanel1.Controls.Add(btnLogs);
            flowLayoutPanel1.Controls.Add(btnSettings);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(156, 393);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.Image = Properties.Resources.Dashboard;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(2, 2);
            btnDashboard.Margin = new Padding(2, 2, 2, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(124, 45);
            btnDashboard.TabIndex = 7;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnProducts
            // 
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProducts.Image = Properties.Resources.Products;
            btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducts.Location = new Point(2, 51);
            btnProducts.Margin = new Padding(2, 2, 2, 2);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(110, 43);
            btnProducts.TabIndex = 8;
            btnProducts.Text = "Products";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnOrders
            // 
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOrders.Image = Properties.Resources.Orders;
            btnOrders.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrders.Location = new Point(2, 147);
            btnOrders.Margin = new Padding(2, 2, 2, 2);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(110, 45);
            btnOrders.TabIndex = 9;
            btnOrders.Text = "Orders";
            btnOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnOrders.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnReports
            // 
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReports.Image = Properties.Resources.Report;
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(2, 196);
            btnReports.Margin = new Padding(2, 2, 2, 2);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(110, 45);
            btnReports.TabIndex = 10;
            btnReports.Text = "Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnSync
            // 
            btnSync.FlatAppearance.BorderSize = 0;
            btnSync.FlatStyle = FlatStyle.Flat;
            btnSync.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSync.Image = Properties.Resources.Sync;
            btnSync.ImageAlign = ContentAlignment.MiddleLeft;
            btnSync.Location = new Point(2, 245);
            btnSync.Margin = new Padding(2, 2, 2, 2);
            btnSync.Name = "btnSync";
            btnSync.Size = new Size(110, 45);
            btnSync.TabIndex = 11;
            btnSync.Text = "Sync";
            btnSync.TextAlign = ContentAlignment.MiddleLeft;
            btnSync.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSync.UseVisualStyleBackColor = true;
            btnSync.Click += btnSync_Click;
            // 
            // btnLogs
            // 
            btnLogs.FlatAppearance.BorderSize = 0;
            btnLogs.FlatStyle = FlatStyle.Flat;
            btnLogs.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogs.Image = Properties.Resources.Logs;
            btnLogs.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogs.Location = new Point(2, 294);
            btnLogs.Margin = new Padding(2, 2, 2, 2);
            btnLogs.Name = "btnLogs";
            btnLogs.Size = new Size(110, 45);
            btnLogs.TabIndex = 12;
            btnLogs.Text = "Logs";
            btnLogs.TextAlign = ContentAlignment.MiddleLeft;
            btnLogs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogs.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSettings.Image = Properties.Resources.Settings;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(2, 343);
            btnSettings.Margin = new Padding(2, 2, 2, 2);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(110, 45);
            btnSettings.TabIndex = 13;
            btnSettings.Text = "Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnCustomer
            // 
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomer.Image = Properties.Resources.Orders;
            btnCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomer.Location = new Point(2, 98);
            btnCustomer.Margin = new Padding(2);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(110, 45);
            btnCustomer.TabIndex = 14;
            btnCustomer.Text = "Customer";
            btnCustomer.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 465);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Controls.Add(statusStrip1);
            Controls.Add(pnlHeader);
            Margin = new Padding(2, 2, 2, 2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            pnlHeader.ResumeLayout(false);
            flpRight.ResumeLayout(false);
            flpRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            flpLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.FlowLayoutPanel flpLeft;
        private System.Windows.Forms.FlowLayoutPanel flpRight;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Button btnCustomer;
    }
}