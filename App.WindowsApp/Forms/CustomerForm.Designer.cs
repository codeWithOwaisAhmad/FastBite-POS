namespace App.WindowsApp.Forms
{
    partial class CustomerForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            txtId = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(txtName, 1, 0);
            tableLayoutPanel1.Controls.Add(txtPhone, 1, 1);
            tableLayoutPanel1.Controls.Add(txtEmail, 1, 2);
            tableLayoutPanel1.Controls.Add(txtAddress, 1, 3);
            tableLayoutPanel1.Controls.Add(txtId, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Font = new Font("Segoe UI", 9.75F);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.Size = new Size(593, 223);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 38);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(3, 38);
            label2.Name = "label2";
            label2.Size = new Size(82, 38);
            label2.TabIndex = 1;
            label2.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(3, 76);
            label3.Name = "label3";
            label3.Size = new Size(82, 38);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(3, 114);
            label4.Name = "label4";
            label4.Size = new Size(82, 66);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(3, 180);
            label5.Name = "label5";
            label5.Size = new Size(82, 43);
            label5.TabIndex = 4;
            label5.Text = "Id";
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(91, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(499, 25);
            txtName.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Location = new Point(91, 41);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(499, 25);
            txtPhone.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(91, 79);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(499, 25);
            txtEmail.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Dock = DockStyle.Fill;
            txtAddress.Location = new Point(91, 117);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(499, 60);
            txtAddress.TabIndex = 8;
            // 
            // txtId
            // 
            txtId.Dock = DockStyle.Fill;
            txtId.Location = new Point(91, 183);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(499, 25);
            txtId.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(180, 284);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(409, 61);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(332, 9);
            btnSave.Margin = new Padding(9);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(3);
            btnSave.Size = new Size(68, 40);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(236, 9);
            btnCancel.Margin = new Padding(9);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(3);
            btnCancel.Size = new Size(78, 40);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 353);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tableLayoutPanel1);
            Name = "CustomerForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private TextBox txtId;
    }
}