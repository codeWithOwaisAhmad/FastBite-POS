using System.Windows.Forms.DataVisualization.Charting;

namespace FastBite.App.Views
{
    partial class DashboardView
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
            // ── Top header ────────────────────────────────
            this.pnlTop         = new System.Windows.Forms.Panel();
            this.lblHeader      = new System.Windows.Forms.Label();
            this.btnRefresh     = new System.Windows.Forms.Button();

            // ── Stat cards row ────────────────────────────
            this.pnlCards       = new System.Windows.Forms.Panel();

            this.pnlRevenue     = new System.Windows.Forms.Panel();
            this.lblRevenueIcon = new System.Windows.Forms.Label();
            this.lblRevenueLbl  = new System.Windows.Forms.Label();
            this.lblRevenueValue = new System.Windows.Forms.Label();

            this.pnlOrders      = new System.Windows.Forms.Panel();
            this.lblOrdersIcon  = new System.Windows.Forms.Label();
            this.lblOrdersLbl   = new System.Windows.Forms.Label();
            this.lblOrdersValue = new System.Windows.Forms.Label();

            this.pnlMenuItems   = new System.Windows.Forms.Panel();
            this.lblMenuIcon    = new System.Windows.Forms.Label();
            this.lblMenuLbl     = new System.Windows.Forms.Label();
            this.lblMenuItemsValue = new System.Windows.Forms.Label();

            this.pnlPending     = new System.Windows.Forms.Panel();
            this.lblPendingIcon = new System.Windows.Forms.Label();
            this.lblPendingLbl  = new System.Windows.Forms.Label();
            this.lblPendingValue = new System.Windows.Forms.Label();

            // ── Charts ────────────────────────────────────
            this.chartBar       = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPie       = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartLine      = new System.Windows.Forms.DataVisualization.Charting.Chart();

            this.pnlTop.SuspendLayout();
            this.pnlCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLine)).BeginInit();
            this.SuspendLayout();

            // ── pnlTop ────────────────────────────────────
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.pnlTop.Controls.Add(this.lblHeader);
            this.pnlTop.Controls.Add(this.btnRefresh);
            this.pnlTop.Dock   = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Height = 55;
            this.pnlTop.Name   = "pnlTop";

            // ── lblHeader ─────────────────────────────────
            this.lblHeader.AutoSize  = false;
            this.lblHeader.Font      = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location  = new System.Drawing.Point(0, 0);
            this.lblHeader.Size      = new System.Drawing.Size(750, 55);
            this.lblHeader.Text      = "📊  Dashboard";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeader.Name      = "lblHeader";

            // ── btnRefresh ────────────────────────────────
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location  = new System.Drawing.Point(760, 10);
            this.btnRefresh.Size      = new System.Drawing.Size(120, 34);
            this.btnRefresh.Text      = "🔄 Refresh";
            this.btnRefresh.Name      = "btnRefresh";
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Click    += new System.EventHandler(this.btnRefresh_Click);

            // ── pnlCards ──────────────────────────────────
            this.pnlCards.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.pnlCards.Controls.Add(this.pnlRevenue);
            this.pnlCards.Controls.Add(this.pnlOrders);
            this.pnlCards.Controls.Add(this.pnlMenuItems);
            this.pnlCards.Controls.Add(this.pnlPending);
            this.pnlCards.Location  = new System.Drawing.Point(0, 55);
            this.pnlCards.Size      = new System.Drawing.Size(900, 110);
            this.pnlCards.Name      = "pnlCards";

            // ── HELPER: build stat card ───────────────────
            void BuildCard(
                System.Windows.Forms.Panel panel,
                System.Windows.Forms.Label iconLbl,
                System.Windows.Forms.Label titleLbl,
                System.Windows.Forms.Label valueLbl,
                int x, string icon, string title,
                System.Drawing.Color accent)
            {
                panel.BackColor   = System.Drawing.Color.White;
                panel.Location    = new System.Drawing.Point(x, 10);
                panel.Size        = new System.Drawing.Size(204, 88);
                panel.BorderStyle = System.Windows.Forms.BorderStyle.None;

                // Left accent bar
                var bar       = new System.Windows.Forms.Panel();
                bar.BackColor = accent;
                bar.Location  = new System.Drawing.Point(0, 0);
                bar.Size      = new System.Drawing.Size(6, 88);
                panel.Controls.Add(bar);

                iconLbl.AutoSize  = false;
                iconLbl.Font      = new System.Drawing.Font("Segoe UI", 22F);
                iconLbl.ForeColor = accent;
                iconLbl.Location  = new System.Drawing.Point(14, 18);
                iconLbl.Size      = new System.Drawing.Size(48, 48);
                iconLbl.Text      = icon;
                iconLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                titleLbl.AutoSize  = false;
                titleLbl.Font      = new System.Drawing.Font("Segoe UI", 9F);
                titleLbl.ForeColor = System.Drawing.Color.Gray;
                titleLbl.Location  = new System.Drawing.Point(68, 16);
                titleLbl.Size      = new System.Drawing.Size(130, 20);
                titleLbl.Text      = title;

                valueLbl.AutoSize  = false;
                valueLbl.Font      = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
                valueLbl.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
                valueLbl.Location  = new System.Drawing.Point(66, 36);
                valueLbl.Size      = new System.Drawing.Size(132, 40);
                valueLbl.Text      = "—";

                panel.Controls.Add(iconLbl);
                panel.Controls.Add(titleLbl);
                panel.Controls.Add(valueLbl);
                this.pnlCards.Controls.Add(panel);
            }

            BuildCard(pnlRevenue,   lblRevenueIcon,  lblRevenueLbl,  lblRevenueValue,
                10,  "💰", "Total Revenue",   System.Drawing.Color.FromArgb(39, 174, 96));
            BuildCard(pnlOrders,    lblOrdersIcon,   lblOrdersLbl,   lblOrdersValue,
                224, "🧾", "Total Orders",    System.Drawing.Color.FromArgb(41, 128, 185));
            BuildCard(pnlMenuItems, lblMenuIcon,     lblMenuLbl,     lblMenuItemsValue,
                438, "🍔", "Menu Items",      System.Drawing.Color.FromArgb(230, 126, 34));
            BuildCard(pnlPending,   lblPendingIcon,  lblPendingLbl,  lblPendingValue,
                652, "⏳", "Pending Orders",  System.Drawing.Color.FromArgb(231, 76, 60));

            // ── chartBar — Revenue by Category ───────────
            this.chartBar.Location   = new System.Drawing.Point(0, 170);
            this.chartBar.Size       = new System.Drawing.Size(440, 240);
            this.chartBar.Name       = "chartBar";
            this.chartBar.BackColor  = System.Drawing.Color.White;

            // ── chartPie — Orders by Status ───────────────
            this.chartPie.Location   = new System.Drawing.Point(450, 170);
            this.chartPie.Size       = new System.Drawing.Size(440, 240);
            this.chartPie.Name       = "chartPie";
            this.chartPie.BackColor  = System.Drawing.Color.White;

            // ── chartLine — Daily Revenue ─────────────────
            this.chartLine.Location  = new System.Drawing.Point(0, 418);
            this.chartLine.Size      = new System.Drawing.Size(890, 190);
            this.chartLine.Name      = "chartLine";
            this.chartLine.BackColor = System.Drawing.Color.White;
            this.chartLine.Anchor    = System.Windows.Forms.AnchorStyles.Top
                                     | System.Windows.Forms.AnchorStyles.Left
                                     | System.Windows.Forms.AnchorStyles.Right
                                     | System.Windows.Forms.AnchorStyles.Bottom;

            // ── DashboardView ─────────────────────────────
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlCards);
            this.Controls.Add(this.chartBar);
            this.Controls.Add(this.chartPie);
            this.Controls.Add(this.chartLine);
            this.Name   = "DashboardView";
            this.Size   = new System.Drawing.Size(900, 620);
            this.Load  += new System.EventHandler(this.DashboardView_Load);

            this.pnlTop.ResumeLayout(false);
            this.pnlCards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLine)).EndInit();
            this.ResumeLayout(false);
        }

        // ── Control declarations ───────────────────────────
        private System.Windows.Forms.Panel  pnlTop;
        private System.Windows.Forms.Label  lblHeader;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel  pnlCards;

        private System.Windows.Forms.Panel  pnlRevenue;
        private System.Windows.Forms.Label  lblRevenueIcon;
        private System.Windows.Forms.Label  lblRevenueLbl;
        private System.Windows.Forms.Label  lblRevenueValue;

        private System.Windows.Forms.Panel  pnlOrders;
        private System.Windows.Forms.Label  lblOrdersIcon;
        private System.Windows.Forms.Label  lblOrdersLbl;
        private System.Windows.Forms.Label  lblOrdersValue;

        private System.Windows.Forms.Panel  pnlMenuItems;
        private System.Windows.Forms.Label  lblMenuIcon;
        private System.Windows.Forms.Label  lblMenuLbl;
        private System.Windows.Forms.Label  lblMenuItemsValue;

        private System.Windows.Forms.Panel  pnlPending;
        private System.Windows.Forms.Label  lblPendingIcon;
        private System.Windows.Forms.Label  lblPendingLbl;
        private System.Windows.Forms.Label  lblPendingValue;

        private System.Windows.Forms.DataVisualization.Charting.Chart chartBar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPie;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLine;
    }
}
