namespace App.WindowsApp.Forms
{
    partial class CustomerPicker
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
            tlpCustomerPicker = new TableLayoutPanel();
            flpSearchBar = new FlowLayoutPanel();
            lblSearchText = new Label();
            txtSearchQuery = new TextBox();
            flpButtons = new FlowLayoutPanel();
            btnSelect = new Button();
            btnCancel = new Button();
            lsCustomers = new ListBox();
            tlpCustomerPicker.SuspendLayout();
            flpSearchBar.SuspendLayout();
            flpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tlpCustomerPicker
            // 
            tlpCustomerPicker.BackColor = Color.White;
            tlpCustomerPicker.ColumnCount = 1;
            tlpCustomerPicker.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCustomerPicker.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpCustomerPicker.Controls.Add(flpSearchBar, 0, 0);
            tlpCustomerPicker.Controls.Add(flpButtons, 0, 2);
            tlpCustomerPicker.Controls.Add(lsCustomers, 0, 1);
            tlpCustomerPicker.Location = new Point(0, 0);
            tlpCustomerPicker.Name = "tlpCustomerPicker";
            tlpCustomerPicker.RowCount = 3;
            tlpCustomerPicker.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tlpCustomerPicker.RowStyles.Add(new RowStyle(SizeType.Percent, 71.42857F));
            tlpCustomerPicker.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tlpCustomerPicker.Size = new Size(537, 354);
            tlpCustomerPicker.TabIndex = 0;
            // 
            // flpSearchBar
            // 
            flpSearchBar.Controls.Add(lblSearchText);
            flpSearchBar.Controls.Add(txtSearchQuery);
            flpSearchBar.Dock = DockStyle.Fill;
            flpSearchBar.Location = new Point(3, 3);
            flpSearchBar.Name = "flpSearchBar";
            flpSearchBar.Size = new Size(531, 44);
            flpSearchBar.TabIndex = 0;
            // 
            // lblSearchText
            // 
            lblSearchText.AutoSize = true;
            lblSearchText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchText.Location = new Point(3, 0);
            lblSearchText.Name = "lblSearchText";
            lblSearchText.Size = new Size(77, 15);
            lblSearchText.TabIndex = 0;
            lblSearchText.Text = "Search Query";
            // 
            // txtSearchQuery
            // 
            txtSearchQuery.Location = new Point(86, 3);
            txtSearchQuery.Name = "txtSearchQuery";
            txtSearchQuery.Size = new Size(307, 23);
            txtSearchQuery.TabIndex = 1;
            txtSearchQuery.TextChanged += txtSearchQuery_TextChanged;
            // 
            // flpButtons
            // 
            flpButtons.Controls.Add(btnSelect);
            flpButtons.Controls.Add(btnCancel);
            flpButtons.Dock = DockStyle.Fill;
            flpButtons.FlowDirection = FlowDirection.RightToLeft;
            flpButtons.Location = new Point(3, 305);
            flpButtons.Name = "flpButtons";
            flpButtons.Size = new Size(531, 46);
            flpButtons.TabIndex = 1;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(442, 9);
            btnSelect.Margin = new Padding(9);
            btnSelect.Name = "btnSelect";
            btnSelect.Padding = new Padding(3);
            btnSelect.Size = new Size(80, 29);
            btnSelect.TabIndex = 0;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(335, 9);
            btnCancel.Margin = new Padding(9);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(3);
            btnCancel.Size = new Size(89, 31);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lsCustomers
            // 
            lsCustomers.AccessibleName = "lsCustomers";
            lsCustomers.Dock = DockStyle.Fill;
            lsCustomers.FormattingEnabled = true;
            lsCustomers.Location = new Point(3, 53);
            lsCustomers.Name = "lsCustomers";
            lsCustomers.Size = new Size(531, 246);
            lsCustomers.TabIndex = 2;
            lsCustomers.DoubleClick += lsCustomers_DoubleClick;
            // 
            // CustomerPicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 357);
            Controls.Add(tlpCustomerPicker);
            Name = "CustomerPicker";
            Text = "CustomerPicker";
            tlpCustomerPicker.ResumeLayout(false);
            flpSearchBar.ResumeLayout(false);
            flpSearchBar.PerformLayout();
            flpButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpCustomerPicker;
        private FlowLayoutPanel flpSearchBar;
        private FlowLayoutPanel flpButtons;
        private Label lblSearchText;
        private TextBox txtSearchQuery;
        private Button btnSelect;
        private Button btnCancel;
        private ListBox lsCustomers;
    }
}