namespace FastBite.App.Views
{
    partial class CustomerView
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
            this.pnlTop        = new System.Windows.Forms.Panel();
            this.lblHeader     = new System.Windows.Forms.Label();
            this.toolStrip     = new System.Windows.Forms.ToolStrip();
            this.tsbAdd        = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit       = new System.Windows.Forms.ToolStripButton();
            this.tsbView       = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete     = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh    = new System.Windows.Forms.ToolStripButton();
            this.pnlFilters    = new System.Windows.Forms.Panel();
            this.lblSearchIcon = new System.Windows.Forms.Label();
            this.txtSearch     = new System.Windows.Forms.TextBox();
            this.dgvCustomers  = new System.Windows.Forms.DataGridView();
            this.pnlBottom     = new System.Windows.Forms.Panel();
            this.lblCount      = new System.Windows.Forms.Label();
            this.lblLastAction = new System.Windows.Forms.Label();

            this.pnlTop.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
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
            this.lblHeader.Text      = "👤  Customers";
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
            this.tsbAdd.Text         = "  ➕ Add Customer  ";
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
            this.pnlFilters.Controls.Add(this.lblSearchIcon);
            this.pnlFilters.Controls.Add(this.txtSearch);
            this.pnlFilters.Dock      = System.Windows.Forms.DockStyle.None;
            this.pnlFilters.Location  = new System.Drawing.Point(0, 90);
            this.pnlFilters.Size      = new System.Drawing.Size(900, 50);
            this.pnlFilters.Name      = "pnlFilters";

            // ── lblSearchIcon ─────────────────────────────
            this.lblSearchIcon.AutoSize = true;
            this.lblSearchIcon.Font     = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSearchIcon.Location = new System.Drawing.Point(10, 14);
            this.lblSearchIcon.Text     = "🔍";
            this.lblSearchIcon.Name     = "lblSearchIcon";

            // ── txtSearch ─────────────────────────────────
            this.txtSearch.Font            = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location        = new System.Drawing.Point(38, 14);
            this.txtSearch.Size            = new System.Drawing.Size(260, 26);
            this.txtSearch.PlaceholderText = "Search by name or phone...";
            this.txtSearch.Name            = "txtSearch";
            this.txtSearch.TextChanged    += new System.EventHandler(this.txtSearch_TextChanged);

            // ── dgvCustomers ──────────────────────────────
            this.dgvCustomers.Location = new System.Drawing.Point(0, 145);
            this.dgvCustomers.Size     = new System.Drawing.Size(900, 430);
            this.dgvCustomers.Name     = "dgvCustomers";
            this.dgvCustomers.Anchor   = System.Windows.Forms.AnchorStyles.Top
                                       | System.Windows.Forms.AnchorStyles.Bottom
                                       | System.Windows.Forms.AnchorStyles.Left
                                       | System.Windows.Forms.AnchorStyles.Right;
            this.dgvCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellDoubleClick);

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
            this.lblCount.Text      = "Showing 0 customer(s)";
            this.lblCount.Name      = "lblCount";

            // ── lblLastAction ─────────────────────────────
            this.lblLastAction.AutoSize  = true;
            this.lblLastAction.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLastAction.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblLastAction.Location  = new System.Drawing.Point(400, 8);
            this.lblLastAction.Text      = "";
            this.lblLastAction.Name      = "lblLastAction";

            // ── CustomerView (UserControl) ────────────────
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.pnlBottom);
            this.Name  = "CustomerView";
            this.Size  = new System.Drawing.Size(900, 620);
            this.Load += new System.EventHandler(this.CustomerView_Load);

            this.pnlTop.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
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
        private System.Windows.Forms.Label              lblSearchIcon;
        private System.Windows.Forms.TextBox            txtSearch;
        private System.Windows.Forms.DataGridView       dgvCustomers;
        private System.Windows.Forms.Panel              pnlBottom;
        private System.Windows.Forms.Label              lblCount;
        private System.Windows.Forms.Label              lblLastAction;
    }
}
