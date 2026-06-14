namespace FastBite.App.Views
{
    partial class OrderView
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
            this.pnlTop          = new System.Windows.Forms.Panel();
            this.lblHeader       = new System.Windows.Forms.Label();
            this.toolStrip       = new System.Windows.Forms.ToolStrip();
            this.tsbAdd          = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit         = new System.Windows.Forms.ToolStripButton();
            this.tsbView         = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete       = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh      = new System.Windows.Forms.ToolStripButton();
            this.pnlFilters      = new System.Windows.Forms.Panel();
            this.lblFilterIcon   = new System.Windows.Forms.Label();
            this.lblStatusFilter = new System.Windows.Forms.Label();
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.dgvOrders       = new System.Windows.Forms.DataGridView();
            this.pnlBottom       = new System.Windows.Forms.Panel();
            this.lblCount        = new System.Windows.Forms.Label();
            this.lblLastAction   = new System.Windows.Forms.Label();

            this.pnlTop.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();

            // ── pnlTop ────────────────────────────────────
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.pnlTop.Controls.Add(this.lblHeader);
            this.pnlTop.Dock      = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Height    = 55;
            this.pnlTop.Name      = "pnlTop";

            // ── lblHeader ─────────────────────────────────
            this.lblHeader.AutoSize  = false;
            this.lblHeader.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font      = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Text      = "🧾  Orders";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeader.Name      = "lblHeader";

            // ── toolStrip ─────────────────────────────────
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.toolStrip.Dock      = System.Windows.Forms.DockStyle.None;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsbAdd, this.tsbEdit, this.tsbView,
                new System.Windows.Forms.ToolStripSeparator(),
                this.tsbDelete,
                new System.Windows.Forms.ToolStripSeparator(),
                this.tsbRefresh
            });
            this.toolStrip.Location = new System.Drawing.Point(0, 55);
            this.toolStrip.Name     = "toolStrip";
            this.toolStrip.Size     = new System.Drawing.Size(900, 35);

            // ── tsbAdd ────────────────────────────────────
            this.tsbAdd.Font         = new System.Drawing.Font("Segoe UI", 10F);
            this.tsbAdd.ForeColor    = System.Drawing.Color.FromArgb(39, 174, 96);
            this.tsbAdd.Text         = "  ➕ New Order  ";
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAdd.Name         = "tsbAdd";
            this.tsbAdd.Click       += new System.EventHandler(this.tsbAdd_Click);

            // ── tsbEdit ───────────────────────────────────
            this.tsbEdit.Font         = new System.Drawing.Font("Segoe UI", 10F);
            this.tsbEdit.ForeColor    = System.Drawing.Color.FromArgb(41, 128, 185);
            this.tsbEdit.Text         = "  ✏️ Edit  ";
            this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEdit.Name         = "tsbEdit";
            this.tsbEdit.Click       += new System.EventHandler(this.tsbEdit_Click);

            // ── tsbView ───────────────────────────────────
            this.tsbView.Font         = new System.Drawing.Font("Segoe UI", 10F);
            this.tsbView.ForeColor    = System.Drawing.Color.FromArgb(142, 68, 173);
            this.tsbView.Text         = "  👁️ View  ";
            this.tsbView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbView.Name         = "tsbView";
            this.tsbView.Click       += new System.EventHandler(this.tsbView_Click);

            // ── tsbDelete ─────────────────────────────────
            this.tsbDelete.Font         = new System.Drawing.Font("Segoe UI", 10F);
            this.tsbDelete.ForeColor    = System.Drawing.Color.FromArgb(192, 57, 43);
            this.tsbDelete.Text         = "  🗑️ Delete  ";
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDelete.Name         = "tsbDelete";
            this.tsbDelete.Click       += new System.EventHandler(this.tsbDelete_Click);

            // ── tsbRefresh ────────────────────────────────
            this.tsbRefresh.Font         = new System.Drawing.Font("Segoe UI", 10F);
            this.tsbRefresh.ForeColor    = System.Drawing.Color.FromArgb(44, 62, 80);
            this.tsbRefresh.Text         = "  🔄 Refresh  ";
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRefresh.Name         = "tsbRefresh";
            this.tsbRefresh.Click       += new System.EventHandler(this.tsbRefresh_Click);

            // ── pnlFilters ────────────────────────────────
            this.pnlFilters.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.pnlFilters.Controls.Add(this.lblFilterIcon);
            this.pnlFilters.Controls.Add(this.lblStatusFilter);
            this.pnlFilters.Controls.Add(this.cmbStatusFilter);
            this.pnlFilters.Dock      = System.Windows.Forms.DockStyle.None;
            this.pnlFilters.Location  = new System.Drawing.Point(0, 90);
            this.pnlFilters.Size      = new System.Drawing.Size(900, 50);
            this.pnlFilters.Name      = "pnlFilters";

            // ── lblFilterIcon ─────────────────────────────
            this.lblFilterIcon.AutoSize = true;
            this.lblFilterIcon.Font     = new System.Drawing.Font("Segoe UI", 12F);
            this.lblFilterIcon.Location = new System.Drawing.Point(10, 13);
            this.lblFilterIcon.Text     = "🔽";
            this.lblFilterIcon.Name     = "lblFilterIcon";

            // ── lblStatusFilter ───────────────────────────
            this.lblStatusFilter.AutoSize = true;
            this.lblStatusFilter.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatusFilter.Location = new System.Drawing.Point(38, 16);
            this.lblStatusFilter.Text     = "Filter by Status:";
            this.lblStatusFilter.Name     = "lblStatusFilter";

            // ── cmbStatusFilter ───────────────────────────
            this.cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusFilter.Font          = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatusFilter.Location      = new System.Drawing.Point(160, 13);
            this.cmbStatusFilter.Size          = new System.Drawing.Size(180, 26);
            this.cmbStatusFilter.Name          = "cmbStatusFilter";
            this.cmbStatusFilter.SelectedIndexChanged
                += new System.EventHandler(this.cmbStatusFilter_SelectedIndexChanged);

            // ── dgvOrders ─────────────────────────────────
            this.dgvOrders.Location = new System.Drawing.Point(0, 145);
            this.dgvOrders.Size     = new System.Drawing.Size(900, 430);
            this.dgvOrders.Name     = "dgvOrders";
            this.dgvOrders.Anchor   = System.Windows.Forms.AnchorStyles.Top
                                    | System.Windows.Forms.AnchorStyles.Bottom
                                    | System.Windows.Forms.AnchorStyles.Left
                                    | System.Windows.Forms.AnchorStyles.Right;
            this.dgvOrders.CellDoubleClick
                += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellDoubleClick);

            // ── pnlBottom ─────────────────────────────────
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.pnlBottom.Controls.Add(this.lblLastAction);
            this.pnlBottom.Controls.Add(this.lblCount);
            this.pnlBottom.Dock      = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Height    = 32;
            this.pnlBottom.Name      = "pnlBottom";

            // ── lblCount ──────────────────────────────────
            this.lblCount.AutoSize  = true;
            this.lblCount.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblCount.Location  = new System.Drawing.Point(10, 8);
            this.lblCount.Text      = "Showing 0 order(s)";
            this.lblCount.Name      = "lblCount";

            // ── lblLastAction ─────────────────────────────
            this.lblLastAction.AutoSize  = true;
            this.lblLastAction.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLastAction.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblLastAction.Location  = new System.Drawing.Point(400, 8);
            this.lblLastAction.Text      = "";
            this.lblLastAction.Name      = "lblLastAction";

            // ── OrderView (UserControl) ───────────────────
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.pnlBottom);
            this.Name  = "OrderView";
            this.Size  = new System.Drawing.Size(900, 620);
            this.Load += new System.EventHandler(this.OrderView_Load);

            this.pnlTop.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel              pnlTop;
        private System.Windows.Forms.Label              lblHeader;
        private System.Windows.Forms.ToolStrip          toolStrip;
        private System.Windows.Forms.ToolStripButton    tsbAdd;
        private System.Windows.Forms.ToolStripButton    tsbEdit;
        private System.Windows.Forms.ToolStripButton    tsbView;
        private System.Windows.Forms.ToolStripButton    tsbDelete;
        private System.Windows.Forms.ToolStripButton    tsbRefresh;
        private System.Windows.Forms.Panel              pnlFilters;
        private System.Windows.Forms.Label              lblFilterIcon;
        private System.Windows.Forms.Label              lblStatusFilter;
        private System.Windows.Forms.ComboBox           cmbStatusFilter;
        private System.Windows.Forms.DataGridView       dgvOrders;
        private System.Windows.Forms.Panel              pnlBottom;
        private System.Windows.Forms.Label              lblCount;
        private System.Windows.Forms.Label              lblLastAction;
    }
}
