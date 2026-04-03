namespace App.WindowsApp.Forms
{
    partial class ProductForm
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
            label6 = new Label();
            txtName = new TextBox();
            cmbCat = new ComboBox();
            nuPrice = new NumericUpDown();
            nuStock = new NumericUpDown();
            cmbProductStatus = new ComboBox();
            txtId = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Cancel = new Button();
            btnSave = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nuPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nuStock).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(txtName, 1, 0);
            tableLayoutPanel1.Controls.Add(cmbCat, 1, 1);
            tableLayoutPanel1.Controls.Add(nuPrice, 1, 2);
            tableLayoutPanel1.Controls.Add(nuStock, 1, 3);
            tableLayoutPanel1.Controls.Add(cmbProductStatus, 1, 4);
            tableLayoutPanel1.Controls.Add(txtId, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(800, 321);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 50);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 7;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 100);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 8;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 150);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 9;
            label4.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 200);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 10;
            label5.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 250);
            label6.Name = "label6";
            label6.Size = new Size(18, 15);
            label6.TabIndex = 11;
            label6.Text = "ID";
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(163, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(634, 23);
            txtName.TabIndex = 0;
            // 
            // cmbCat
            // 
            cmbCat.Dock = DockStyle.Fill;
            cmbCat.FormattingEnabled = true;
            cmbCat.Location = new Point(163, 53);
            cmbCat.Name = "cmbCat";
            cmbCat.Size = new Size(634, 23);
            cmbCat.TabIndex = 1;
            cmbCat.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // nuPrice
            // 
            nuPrice.Dock = DockStyle.Fill;
            nuPrice.Location = new Point(163, 103);
            nuPrice.Name = "nuPrice";
            nuPrice.Size = new Size(634, 23);
            nuPrice.TabIndex = 2;
            // 
            // nuStock
            // 
            nuStock.Dock = DockStyle.Fill;
            nuStock.Location = new Point(163, 153);
            nuStock.Name = "nuStock";
            nuStock.Size = new Size(634, 23);
            nuStock.TabIndex = 3;
            // 
            // cmbProductStatus
            // 
            cmbProductStatus.Dock = DockStyle.Fill;
            cmbProductStatus.FormattingEnabled = true;
            cmbProductStatus.Location = new Point(163, 203);
            cmbProductStatus.Name = "cmbProductStatus";
            cmbProductStatus.Size = new Size(634, 23);
            cmbProductStatus.TabIndex = 4;
            // 
            // txtId
            // 
            txtId.Dock = DockStyle.Fill;
            txtId.Location = new Point(163, 253);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(634, 23);
            txtId.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(Cancel);
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 327);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 123);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(691, 3);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(106, 38);
            Cancel.TabIndex = 1;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Location = new Point(610, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 38);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tableLayoutPanel1);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductForm";
            FormClosing += ProductForm_FormClosing;
            Load += ProductForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nuPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nuStock).EndInit();
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
        private Label label6;
        private TextBox txtName;
        private ComboBox cmbCat;
        private NumericUpDown nuPrice;
        private NumericUpDown nuStock;
        private ComboBox cmbProductStatus;
        private TextBox txtId;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button Cancel;
        private Button btnSave;
    }
}