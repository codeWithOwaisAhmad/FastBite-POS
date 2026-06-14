namespace FastBite.App.Forms
{
    partial class CustomerForm
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
            this.pnlHeader   = new System.Windows.Forms.Panel();
            this.lblTitle    = new System.Windows.Forms.Label();
            this.lblId       = new System.Windows.Forms.Label();
            this.txtId       = new System.Windows.Forms.TextBox();
            this.lblName     = new System.Windows.Forms.Label();
            this.txtName     = new System.Windows.Forms.TextBox();
            this.lblPhone    = new System.Windows.Forms.Label();
            this.txtPhone    = new System.Windows.Forms.TextBox();
            this.lblEmail    = new System.Windows.Forms.Label();
            this.txtEmail    = new System.Windows.Forms.TextBox();
            this.lblAddress  = new System.Windows.Forms.Label();
            this.txtAddress  = new System.Windows.Forms.TextBox();
            this.btnSave     = new System.Windows.Forms.Button();
            this.btnCancel   = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
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
            this.lblTitle.Text      = "👤  Customer";
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
            this.lblName.Text     = "Full Name *";
            this.lblName.Name     = "lblName";

            // ── txtName ───────────────────────────────────
            this.txtName.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Location = new System.Drawing.Point(30, 155);
            this.txtName.Size     = new System.Drawing.Size(340, 28);
            this.txtName.Name     = "txtName";

            // ── lblPhone ──────────────────────────────────
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhone.Location = new System.Drawing.Point(30, 196);
            this.lblPhone.Text     = "Phone Number *";
            this.lblPhone.Name     = "lblPhone";

            // ── txtPhone ──────────────────────────────────
            this.txtPhone.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.Location = new System.Drawing.Point(30, 216);
            this.txtPhone.Size     = new System.Drawing.Size(340, 28);
            this.txtPhone.Name     = "txtPhone";

            // ── lblEmail ──────────────────────────────────
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.Location = new System.Drawing.Point(30, 257);
            this.lblEmail.Text     = "Email (optional)";
            this.lblEmail.Name     = "lblEmail";

            // ── txtEmail ──────────────────────────────────
            this.txtEmail.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(30, 277);
            this.txtEmail.Size     = new System.Drawing.Size(340, 28);
            this.txtEmail.Name     = "txtEmail";

            // ── lblAddress ────────────────────────────────
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAddress.Location = new System.Drawing.Point(30, 318);
            this.lblAddress.Text     = "Address (optional)";
            this.lblAddress.Name     = "lblAddress";

            // ── txtAddress ────────────────────────────────
            this.txtAddress.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAddress.Location  = new System.Drawing.Point(30, 338);
            this.txtAddress.Size      = new System.Drawing.Size(340, 28);
            this.txtAddress.Name      = "txtAddress";

            // ── btnSave ───────────────────────────────────
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location  = new System.Drawing.Point(30, 395);
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
            this.btnCancel.Location  = new System.Drawing.Point(210, 395);
            this.btnCancel.Size      = new System.Drawing.Size(160, 38);
            this.btnCancel.Text      = "Cancel";
            this.btnCancel.Name      = "btnCancel";
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Click    += new System.EventHandler(this.btnCancel_Click);

            // ── CustomerForm ──────────────────────────────
            this.ClientSize      = new System.Drawing.Size(400, 460);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox     = false;
            this.MinimizeBox     = false;
            this.Name            = "CustomerForm";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text            = "Customer";

            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel    pnlHeader;
        private System.Windows.Forms.Label    lblTitle;
        private System.Windows.Forms.Label    lblId;
        private System.Windows.Forms.TextBox  txtId;
        private System.Windows.Forms.Label    lblName;
        private System.Windows.Forms.TextBox  txtName;
        private System.Windows.Forms.Label    lblPhone;
        private System.Windows.Forms.TextBox  txtPhone;
        private System.Windows.Forms.Label    lblEmail;
        private System.Windows.Forms.TextBox  txtEmail;
        private System.Windows.Forms.Label    lblAddress;
        private System.Windows.Forms.TextBox  txtAddress;
        private System.Windows.Forms.Button   btnSave;
        private System.Windows.Forms.Button   btnCancel;
    }
}
