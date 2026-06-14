namespace FastBite.App.Forms
{
    partial class MenuItemForm
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
            this.lblId        = new System.Windows.Forms.Label();
            this.txtId        = new System.Windows.Forms.TextBox();
            this.lblName      = new System.Windows.Forms.Label();
            this.txtName      = new System.Windows.Forms.TextBox();
            this.lblCategory  = new System.Windows.Forms.Label();
            this.cmbCategory  = new System.Windows.Forms.ComboBox();
            this.lblPrice     = new System.Windows.Forms.Label();
            this.nuPrice      = new System.Windows.Forms.NumericUpDown();
            this.lblStatus    = new System.Windows.Forms.Label();
            this.cmbStatus    = new System.Windows.Forms.ComboBox();
            this.btnSave      = new System.Windows.Forms.Button();
            this.btnCancel    = new System.Windows.Forms.Button();
            this.pnlHeader    = new System.Windows.Forms.Panel();
            this.lblTitle     = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuPrice)).BeginInit();
            this.SuspendLayout();

            // ── pnlHeader ─────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock     = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height   = 55;
            this.pnlHeader.Name     = "pnlHeader";

            // ── lblTitle ──────────────────────────────────
            this.lblTitle.AutoSize  = false;
            this.lblTitle.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Text      = "🍔  Menu Item";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Name      = "lblTitle";

            // ── lblId ─────────────────────────────────────
            this.lblId.AutoSize = true;
            this.lblId.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.lblId.Location = new System.Drawing.Point(30, 75);
            this.lblId.Text     = "ID";
            this.lblId.Name     = "lblId";

            // ── txtId ─────────────────────────────────────
            this.txtId.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.txtId.Location  = new System.Drawing.Point(30, 95);
            this.txtId.Size      = new System.Drawing.Size(340, 28);
            this.txtId.ReadOnly  = true;
            this.txtId.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.txtId.Name      = "txtId";

            // ── lblName ───────────────────────────────────
            this.lblName.AutoSize = true;
            this.lblName.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.lblName.Location = new System.Drawing.Point(30, 135);
            this.lblName.Text     = "Item Name *";
            this.lblName.Name     = "lblName";

            // ── txtName ───────────────────────────────────
            this.txtName.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Location = new System.Drawing.Point(30, 155);
            this.txtName.Size     = new System.Drawing.Size(340, 28);
            this.txtName.Name     = "txtName";

            // ── lblCategory ───────────────────────────────
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCategory.Location = new System.Drawing.Point(30, 198);
            this.lblCategory.Text     = "Category *";
            this.lblCategory.Name     = "lblCategory";

            // ── cmbCategory ───────────────────────────────
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font          = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.Location      = new System.Drawing.Point(30, 218);
            this.cmbCategory.Size          = new System.Drawing.Size(160, 28);
            this.cmbCategory.Name          = "cmbCategory";

            // ── lblPrice ──────────────────────────────────
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPrice.Location = new System.Drawing.Point(210, 198);
            this.lblPrice.Text     = "Price (Rs.) *";
            this.lblPrice.Name     = "lblPrice";

            // ── nuPrice ───────────────────────────────────
            this.nuPrice.Font          = new System.Drawing.Font("Segoe UI", 10F);
            this.nuPrice.Location      = new System.Drawing.Point(210, 218);
            this.nuPrice.Size          = new System.Drawing.Size(160, 28);
            this.nuPrice.Maximum       = 999999;
            this.nuPrice.Minimum       = 0;
            this.nuPrice.DecimalPlaces = 2;
            this.nuPrice.Name          = "nuPrice";

            // ── lblStatus ─────────────────────────────────
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatus.Location = new System.Drawing.Point(30, 261);
            this.lblStatus.Text     = "Status *";
            this.lblStatus.Name     = "lblStatus";

            // ── cmbStatus ─────────────────────────────────
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font          = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatus.Location      = new System.Drawing.Point(30, 281);
            this.cmbStatus.Size          = new System.Drawing.Size(160, 28);
            this.cmbStatus.Name          = "cmbStatus";

            // ── btnSave ───────────────────────────────────
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location  = new System.Drawing.Point(30, 340);
            this.btnSave.Size      = new System.Drawing.Size(160, 38);
            this.btnSave.Text      = "Save";
            this.btnSave.Name      = "btnSave";
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Click    += new System.EventHandler(this.btnSave_Click);

            // ── btnCancel ─────────────────────────────────
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location  = new System.Drawing.Point(210, 340);
            this.btnCancel.Size      = new System.Drawing.Size(160, 38);
            this.btnCancel.Text      = "Cancel";
            this.btnCancel.Name      = "btnCancel";
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Click    += new System.EventHandler(this.btnCancel_Click);

            // ── MenuItemForm ──────────────────────────────
            this.ClientSize  = new System.Drawing.Size(400, 410);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.nuPrice);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox     = false;
            this.MinimizeBox     = false;
            this.Name            = "MenuItemForm";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text            = "Menu Item";

            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nuPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel          pnlHeader;
        private System.Windows.Forms.Label          lblTitle;
        private System.Windows.Forms.Label          lblId;
        private System.Windows.Forms.TextBox        txtId;
        private System.Windows.Forms.Label          lblName;
        private System.Windows.Forms.TextBox        txtName;
        private System.Windows.Forms.Label          lblCategory;
        private System.Windows.Forms.ComboBox       cmbCategory;
        private System.Windows.Forms.Label          lblPrice;
        private System.Windows.Forms.NumericUpDown  nuPrice;
        private System.Windows.Forms.Label          lblStatus;
        private System.Windows.Forms.ComboBox       cmbStatus;
        private System.Windows.Forms.Button         btnSave;
        private System.Windows.Forms.Button         btnCancel;
    }
}
