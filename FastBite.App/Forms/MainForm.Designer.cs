namespace FastBite.App.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlSidebar      = new System.Windows.Forms.Panel();
            this.btnDashboard    = new System.Windows.Forms.Button();
            this.btnMenuItems    = new System.Windows.Forms.Button();
            this.btnCustomers    = new System.Windows.Forms.Button();
            this.btnOrders       = new System.Windows.Forms.Button();
            this.pnlLogo         = new System.Windows.Forms.Panel();
            this.lblAppName      = new System.Windows.Forms.Label();
            this.lblTagline      = new System.Windows.Forms.Label();
            this.pnlContent      = new System.Windows.Forms.Panel();
            this.statusStrip1    = new System.Windows.Forms.StatusStrip();
            this.lblSection      = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRecordCount  = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLastAction   = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSpacer       = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDateTime     = new System.Windows.Forms.ToolStripStatusLabel();

            this.pnlSidebar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // ── pnlSidebar ──────────────────────────────
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.pnlSidebar.Controls.Add(this.btnOrders);
            this.pnlSidebar.Controls.Add(this.btnCustomers);
            this.pnlSidebar.Controls.Add(this.btnMenuItems);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.pnlLogo);
            this.pnlSidebar.Dock     = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name     = "pnlSidebar";
            this.pnlSidebar.Size     = new System.Drawing.Size(200, 680);

            // ── pnlLogo ──────────────────────────────────
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(30, 45, 60);
            this.pnlLogo.Controls.Add(this.lblTagline);
            this.pnlLogo.Controls.Add(this.lblAppName);
            this.pnlLogo.Dock     = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Size     = new System.Drawing.Size(200, 90);
            this.pnlLogo.Name     = "pnlLogo";

            // ── lblAppName ────────────────────────────────
            this.lblAppName.AutoSize  = false;
            this.lblAppName.Dock      = System.Windows.Forms.DockStyle.None;
            this.lblAppName.Font      = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.lblAppName.Location  = new System.Drawing.Point(0, 15);
            this.lblAppName.Size      = new System.Drawing.Size(200, 35);
            this.lblAppName.Text      = "🍔 FastBite";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAppName.Name      = "lblAppName";

            // ── lblTagline ────────────────────────────────
            this.lblTagline.AutoSize  = false;
            this.lblTagline.Dock      = System.Windows.Forms.DockStyle.None;
            this.lblTagline.Font      = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTagline.ForeColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.lblTagline.Location  = new System.Drawing.Point(0, 52);
            this.lblTagline.Size      = new System.Drawing.Size(200, 20);
            this.lblTagline.Text      = "Point of Sale System";
            this.lblTagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTagline.Name      = "lblTagline";

            // ── NAV BUTTON HELPER ─────────────────────────
            System.Drawing.Font navFont    = new System.Drawing.Font("Segoe UI", 11F);
            System.Drawing.Color navFore   = System.Drawing.Color.White;
            System.Drawing.Color navBack   = System.Drawing.Color.FromArgb(44, 62, 80);
            System.Drawing.Color navHover  = System.Drawing.Color.FromArgb(52, 73, 94);
            System.Windows.Forms.FlatButtonAppearance fba;

            // ── btnDashboard ──────────────────────────────
            this.btnDashboard.Dock      = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font      = navFont;
            this.btnDashboard.ForeColor = navFore;
            this.btnDashboard.BackColor = navBack;
            this.btnDashboard.Text      = "📊  Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Padding   = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDashboard.Height    = 52;
            this.btnDashboard.Name      = "btnDashboard";
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.Click    += new System.EventHandler(this.btnDashboard_Click);

            // ── btnMenuItems ──────────────────────────────
            this.btnMenuItems.Dock      = System.Windows.Forms.DockStyle.Top;
            this.btnMenuItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuItems.Font      = navFont;
            this.btnMenuItems.ForeColor = navFore;
            this.btnMenuItems.BackColor = navBack;
            this.btnMenuItems.Text      = "🍔  Menu Items";
            this.btnMenuItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuItems.Padding   = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenuItems.Height    = 52;
            this.btnMenuItems.Name      = "btnMenuItems";
            this.btnMenuItems.FlatAppearance.BorderSize = 0;
            this.btnMenuItems.Click    += new System.EventHandler(this.btnMenuItems_Click);

            // ── btnCustomers ──────────────────────────────
            this.btnCustomers.Dock      = System.Windows.Forms.DockStyle.Top;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font      = navFont;
            this.btnCustomers.ForeColor = navFore;
            this.btnCustomers.BackColor = navBack;
            this.btnCustomers.Text      = "👤  Customers";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.Padding   = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCustomers.Height    = 52;
            this.btnCustomers.Name      = "btnCustomers";
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.Click    += new System.EventHandler(this.btnCustomers_Click);

            // ── btnOrders ─────────────────────────────────
            this.btnOrders.Dock      = System.Windows.Forms.DockStyle.Top;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font      = navFont;
            this.btnOrders.ForeColor = navFore;
            this.btnOrders.BackColor = navBack;
            this.btnOrders.Text      = "🧾  Orders";
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Padding   = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnOrders.Height    = 52;
            this.btnOrders.Name      = "btnOrders";
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.Click    += new System.EventHandler(this.btnOrders_Click);

            // ── pnlContent ────────────────────────────────
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.pnlContent.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location  = new System.Drawing.Point(200, 0);
            this.pnlContent.Name      = "pnlContent";

            // ── statusStrip1 ──────────────────────────────
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.statusStrip1.ForeColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.lblSection,
                this.lblRecordCount,
                this.lblLastAction,
                this.lblSpacer,
                this.lblDateTime
            });
            this.statusStrip1.Name = "statusStrip1";

            // ── lblSection ────────────────────────────────
            this.lblSection.ForeColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.lblSection.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSection.Name      = "lblSection";
            this.lblSection.Text      = "  FastBite POS";

            // ── lblRecordCount ────────────────────────────
            this.lblRecordCount.ForeColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.lblRecordCount.Name      = "lblRecordCount";
            this.lblRecordCount.Text      = "";

            // ── lblLastAction ─────────────────────────────
            this.lblLastAction.ForeColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.lblLastAction.Name      = "lblLastAction";
            this.lblLastAction.Text      = "";

            // ── lblSpacer ─────────────────────────────────
            this.lblSpacer.Name   = "lblSpacer";
            this.lblSpacer.Spring = true;   // pushes datetime to far right

            // ── lblDateTime ───────────────────────────────
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.lblDateTime.Name      = "lblDateTime";
            this.lblDateTime.Text      = "";

            // ── MainForm ──────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(1100, 680);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.statusStrip1);
            this.MinimumSize         = new System.Drawing.Size(1000, 620);
            this.Name                = "MainForm";
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text                = "FastBite POS — Back Office";
            this.Load               += new System.EventHandler(this.MainForm_Load);

            this.pnlSidebar.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // ── Controls ──────────────────────────────────────
        private System.Windows.Forms.Panel              pnlSidebar;
        private System.Windows.Forms.Panel              pnlLogo;
        private System.Windows.Forms.Label              lblAppName;
        private System.Windows.Forms.Label              lblTagline;
        private System.Windows.Forms.Button             btnDashboard;
        private System.Windows.Forms.Button             btnMenuItems;
        private System.Windows.Forms.Button             btnCustomers;
        private System.Windows.Forms.Button             btnOrders;
        private System.Windows.Forms.Panel              pnlContent;
        private System.Windows.Forms.StatusStrip        statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSection;
        private System.Windows.Forms.ToolStripStatusLabel lblRecordCount;
        private System.Windows.Forms.ToolStripStatusLabel lblLastAction;
        private System.Windows.Forms.ToolStripStatusLabel lblSpacer;
        private System.Windows.Forms.ToolStripStatusLabel lblDateTime;
    }
}
