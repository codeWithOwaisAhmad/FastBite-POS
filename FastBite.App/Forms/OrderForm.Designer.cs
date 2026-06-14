namespace FastBite.App.Forms
{
    partial class OrderForm
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
            this.pnlHeader        = new System.Windows.Forms.Panel();
            this.lblTitle         = new System.Windows.Forms.Label();
            this.pnlLeft          = new System.Windows.Forms.Panel();
            this.lblOrderId       = new System.Windows.Forms.Label();
            this.txtOrderId       = new System.Windows.Forms.TextBox();
            this.lblCustomer      = new System.Windows.Forms.Label();
            this.txtCustomerName  = new System.Windows.Forms.TextBox();
            this.btnPickCustomer  = new System.Windows.Forms.Button();
            this.lblOrderDate     = new System.Windows.Forms.Label();
            this.dtpOrderDate     = new System.Windows.Forms.DateTimePicker();
            this.lblStatus        = new System.Windows.Forms.Label();
            this.cmbStatus        = new System.Windows.Forms.ComboBox();
            this.lblPayment       = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.pnlRight         = new System.Windows.Forms.Panel();
            this.lblItemsHeader   = new System.Windows.Forms.Label();
            this.pnlAddItem       = new System.Windows.Forms.Panel();
            this.lblMenuItem      = new System.Windows.Forms.Label();
            this.cmbMenuItem      = new System.Windows.Forms.ComboBox();
            this.lblQty           = new System.Windows.Forms.Label();
            this.nuQuantity       = new System.Windows.Forms.NumericUpDown();
            this.btnAddItem       = new System.Windows.Forms.Button();
            this.dgvOrderItems    = new System.Windows.Forms.DataGridView();
            this.btnRemoveItem    = new System.Windows.Forms.Button();
            this.lblTotal         = new System.Windows.Forms.Label();
            this.btnSave          = new System.Windows.Forms.Button();
            this.btnCancel        = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlAddItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
            this.SuspendLayout();

            // ── pnlHeader ─────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock   = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 55;
            this.pnlHeader.Name   = "pnlHeader";

            // ── lblTitle ──────────────────────────────────
            this.lblTitle.AutoSize  = false;
            this.lblTitle.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Text      = "🧾  Order";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Name      = "lblTitle";

            // ── pnlLeft ───────────────────────────────────
            this.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeft.Controls.Add(this.lblOrderId);
            this.pnlLeft.Controls.Add(this.txtOrderId);
            this.pnlLeft.Controls.Add(this.lblCustomer);
            this.pnlLeft.Controls.Add(this.txtCustomerName);
            this.pnlLeft.Controls.Add(this.btnPickCustomer);
            this.pnlLeft.Controls.Add(this.lblOrderDate);
            this.pnlLeft.Controls.Add(this.dtpOrderDate);
            this.pnlLeft.Controls.Add(this.lblStatus);
            this.pnlLeft.Controls.Add(this.cmbStatus);
            this.pnlLeft.Controls.Add(this.lblPayment);
            this.pnlLeft.Controls.Add(this.cmbPaymentMethod);
            this.pnlLeft.Location = new System.Drawing.Point(10, 65);
            this.pnlLeft.Size     = new System.Drawing.Size(310, 460);
            this.pnlLeft.Name     = "pnlLeft";

            // ── lblOrderId ────────────────────────────────
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.lblOrderId.Location = new System.Drawing.Point(10, 12);
            this.lblOrderId.Text     = "Order ID";
            this.lblOrderId.Name     = "lblOrderId";

            // ── txtOrderId ────────────────────────────────
            this.txtOrderId.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.txtOrderId.Location  = new System.Drawing.Point(10, 30);
            this.txtOrderId.Size      = new System.Drawing.Size(285, 26);
            this.txtOrderId.ReadOnly  = true;
            this.txtOrderId.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.txtOrderId.Name      = "txtOrderId";

            // ── lblCustomer ───────────────────────────────
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCustomer.Location = new System.Drawing.Point(10, 68);
            this.lblCustomer.Text     = "Customer *";
            this.lblCustomer.Name     = "lblCustomer";

            // ── txtCustomerName ───────────────────────────
            this.txtCustomerName.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCustomerName.Location  = new System.Drawing.Point(10, 88);
            this.txtCustomerName.Size      = new System.Drawing.Size(190, 26);
            this.txtCustomerName.ReadOnly  = true;
            this.txtCustomerName.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.txtCustomerName.PlaceholderText = "No customer selected";
            this.txtCustomerName.Name      = "txtCustomerName";

            // ── btnPickCustomer ───────────────────────────
            this.btnPickCustomer.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnPickCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPickCustomer.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPickCustomer.ForeColor = System.Drawing.Color.White;
            this.btnPickCustomer.Location  = new System.Drawing.Point(208, 86);
            this.btnPickCustomer.Size      = new System.Drawing.Size(88, 30);
            this.btnPickCustomer.Text      = "Pick 👤";
            this.btnPickCustomer.Name      = "btnPickCustomer";
            this.btnPickCustomer.FlatAppearance.BorderSize = 0;
            this.btnPickCustomer.Click    += new System.EventHandler(this.btnPickCustomer_Click);

            // ── lblOrderDate ──────────────────────────────
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.lblOrderDate.Location = new System.Drawing.Point(10, 128);
            this.lblOrderDate.Text     = "Order Date";
            this.lblOrderDate.Name     = "lblOrderDate";

            // ── dtpOrderDate ──────────────────────────────
            this.dtpOrderDate.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpOrderDate.Location = new System.Drawing.Point(10, 148);
            this.dtpOrderDate.Size     = new System.Drawing.Size(285, 26);
            this.dtpOrderDate.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Name     = "dtpOrderDate";

            // ── lblStatus ─────────────────────────────────
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatus.Location = new System.Drawing.Point(10, 188);
            this.lblStatus.Text     = "Status";
            this.lblStatus.Name     = "lblStatus";

            // ── cmbStatus ─────────────────────────────────
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font          = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatus.Location      = new System.Drawing.Point(10, 208);
            this.cmbStatus.Size          = new System.Drawing.Size(285, 26);
            this.cmbStatus.Name          = "cmbStatus";

            // ── lblPayment ────────────────────────────────
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPayment.Location = new System.Drawing.Point(10, 248);
            this.lblPayment.Text     = "Payment Method";
            this.lblPayment.Name     = "lblPayment";

            // ── cmbPaymentMethod ──────────────────────────
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.Font          = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPaymentMethod.Location      = new System.Drawing.Point(10, 268);
            this.cmbPaymentMethod.Size          = new System.Drawing.Size(285, 26);
            this.cmbPaymentMethod.Name          = "cmbPaymentMethod";

            // ── pnlRight ──────────────────────────────────
            this.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRight.Controls.Add(this.lblItemsHeader);
            this.pnlRight.Controls.Add(this.pnlAddItem);
            this.pnlRight.Controls.Add(this.dgvOrderItems);
            this.pnlRight.Controls.Add(this.btnRemoveItem);
            this.pnlRight.Controls.Add(this.lblTotal);
            this.pnlRight.Location = new System.Drawing.Point(330, 65);
            this.pnlRight.Size     = new System.Drawing.Size(530, 460);
            this.pnlRight.Name     = "pnlRight";

            // ── lblItemsHeader ────────────────────────────
            this.lblItemsHeader.AutoSize  = false;
            this.lblItemsHeader.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblItemsHeader.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblItemsHeader.Location  = new System.Drawing.Point(10, 10);
            this.lblItemsHeader.Size      = new System.Drawing.Size(200, 28);
            this.lblItemsHeader.Text      = "Order Items";
            this.lblItemsHeader.Name      = "lblItemsHeader";

            // ── pnlAddItem ────────────────────────────────
            this.pnlAddItem.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.pnlAddItem.Controls.Add(this.lblMenuItem);
            this.pnlAddItem.Controls.Add(this.cmbMenuItem);
            this.pnlAddItem.Controls.Add(this.lblQty);
            this.pnlAddItem.Controls.Add(this.nuQuantity);
            this.pnlAddItem.Controls.Add(this.btnAddItem);
            this.pnlAddItem.Location = new System.Drawing.Point(5, 40);
            this.pnlAddItem.Size     = new System.Drawing.Size(518, 60);
            this.pnlAddItem.Name     = "pnlAddItem";

            // ── lblMenuItem ───────────────────────────────
            this.lblMenuItem.AutoSize = true;
            this.lblMenuItem.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMenuItem.Location = new System.Drawing.Point(5, 8);
            this.lblMenuItem.Text     = "Item";
            this.lblMenuItem.Name     = "lblMenuItem";

            // ── cmbMenuItem ───────────────────────────────
            this.cmbMenuItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMenuItem.Font          = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMenuItem.Location      = new System.Drawing.Point(5, 30);
            this.cmbMenuItem.Size          = new System.Drawing.Size(270, 26);
            this.cmbMenuItem.Name          = "cmbMenuItem";

            // ── lblQty ────────────────────────────────────
            this.lblQty.AutoSize = true;
            this.lblQty.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.lblQty.Location = new System.Drawing.Point(285, 8);
            this.lblQty.Text     = "Qty";
            this.lblQty.Name     = "lblQty";

            // ── nuQuantity ────────────────────────────────
            this.nuQuantity.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.nuQuantity.Location = new System.Drawing.Point(285, 30);
            this.nuQuantity.Size     = new System.Drawing.Size(65, 26);
            this.nuQuantity.Minimum  = 1;
            this.nuQuantity.Maximum  = 99;
            this.nuQuantity.Value    = 1;
            this.nuQuantity.Name     = "nuQuantity";

            // ── btnAddItem ────────────────────────────────
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location  = new System.Drawing.Point(360, 28);
            this.btnAddItem.Size      = new System.Drawing.Size(148, 30);
            this.btnAddItem.Text      = "➕ Add to Order";
            this.btnAddItem.Name      = "btnAddItem";
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.Click    += new System.EventHandler(this.btnAddItem_Click);

            // ── dgvOrderItems ─────────────────────────────
            this.dgvOrderItems.Location = new System.Drawing.Point(5, 105);
            this.dgvOrderItems.Size     = new System.Drawing.Size(518, 270);
            this.dgvOrderItems.Name     = "dgvOrderItems";

            // ── btnRemoveItem ─────────────────────────────
            this.btnRemoveItem.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemoveItem.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItem.Location  = new System.Drawing.Point(5, 382);
            this.btnRemoveItem.Size      = new System.Drawing.Size(148, 30);
            this.btnRemoveItem.Text      = "🗑️ Remove Item";
            this.btnRemoveItem.Name      = "btnRemoveItem";
            this.btnRemoveItem.FlatAppearance.BorderSize = 0;
            this.btnRemoveItem.Click    += new System.EventHandler(this.btnRemoveItem_Click);

            // ── lblTotal ──────────────────────────────────
            this.lblTotal.AutoSize  = false;
            this.lblTotal.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblTotal.Location  = new System.Drawing.Point(280, 378);
            this.lblTotal.Size      = new System.Drawing.Size(240, 36);
            this.lblTotal.Text      = "Total:  Rs. 0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotal.Name      = "lblTotal";

            // ── btnSave ───────────────────────────────────
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location  = new System.Drawing.Point(490, 538);
            this.btnSave.Size      = new System.Drawing.Size(180, 40);
            this.btnSave.Text      = "Place Order";
            this.btnSave.Name      = "btnSave";
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Click    += new System.EventHandler(this.btnSave_Click);

            // ── btnCancel ─────────────────────────────────
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location  = new System.Drawing.Point(680, 538);
            this.btnCancel.Size      = new System.Drawing.Size(180, 40);
            this.btnCancel.Text      = "Cancel";
            this.btnCancel.Name      = "btnCancel";
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Click    += new System.EventHandler(this.btnCancel_Click);

            // ── OrderForm ─────────────────────────────────
            this.ClientSize      = new System.Drawing.Size(875, 595);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox     = false;
            this.MinimizeBox     = false;
            this.Name            = "OrderForm";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text            = "Order";
            this.Load           += new System.EventHandler(this.OrderForm_Load);

            this.pnlHeader.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlAddItem.ResumeLayout(false);
            this.pnlAddItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel             pnlHeader;
        private System.Windows.Forms.Label             lblTitle;
        private System.Windows.Forms.Panel             pnlLeft;
        private System.Windows.Forms.Label             lblOrderId;
        private System.Windows.Forms.TextBox           txtOrderId;
        private System.Windows.Forms.Label             lblCustomer;
        private System.Windows.Forms.TextBox           txtCustomerName;
        private System.Windows.Forms.Button            btnPickCustomer;
        private System.Windows.Forms.Label             lblOrderDate;
        private System.Windows.Forms.DateTimePicker    dtpOrderDate;
        private System.Windows.Forms.Label             lblStatus;
        private System.Windows.Forms.ComboBox          cmbStatus;
        private System.Windows.Forms.Label             lblPayment;
        private System.Windows.Forms.ComboBox          cmbPaymentMethod;
        private System.Windows.Forms.Panel             pnlRight;
        private System.Windows.Forms.Label             lblItemsHeader;
        private System.Windows.Forms.Panel             pnlAddItem;
        private System.Windows.Forms.Label             lblMenuItem;
        private System.Windows.Forms.ComboBox          cmbMenuItem;
        private System.Windows.Forms.Label             lblQty;
        private System.Windows.Forms.NumericUpDown     nuQuantity;
        private System.Windows.Forms.Button            btnAddItem;
        private System.Windows.Forms.DataGridView      dgvOrderItems;
        private System.Windows.Forms.Button            btnRemoveItem;
        private System.Windows.Forms.Label             lblTotal;
        private System.Windows.Forms.Button            btnSave;
        private System.Windows.Forms.Button            btnCancel;
    }
}
