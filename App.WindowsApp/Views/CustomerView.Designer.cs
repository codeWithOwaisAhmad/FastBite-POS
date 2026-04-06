namespace App.WindowsApp.Views
{
    partial class CustomerView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerView));
            miniToolStrip = new ToolStrip();
            Add = new ToolStripButton();
            tsbEdit = new ToolStripButton();
            tsbView = new ToolStripButton();
            tsbDelete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbRefresh = new ToolStripButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            toolStrip1 = new ToolStrip();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblCount = new Label();
            pnlCustomerData = new Panel();
            dgvCustomers = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pnlCustomerData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // miniToolStrip
            // 
            miniToolStrip.AccessibleName = "New item selection";
            miniToolStrip.AccessibleRole = AccessibleRole.ButtonDropDown;
            miniToolStrip.AutoSize = false;
            miniToolStrip.CanOverflow = false;
            miniToolStrip.Dock = DockStyle.None;
            miniToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            miniToolStrip.Location = new Point(289, 14);
            miniToolStrip.Name = "miniToolStrip";
            miniToolStrip.Size = new Size(570, 47);
            miniToolStrip.TabIndex = 0;
            miniToolStrip.ItemClicked += toolStrip1_ItemClicked;
            // 
            // Add
            // 
            Add.AccessibleName = "tsbAdd";
            Add.Image = (Image)resources.GetObject("Add.Image");
            Add.ImageTransparentColor = Color.Magenta;
            Add.Name = "Add";
            Add.Size = new Size(49, 22);
            Add.Text = "Add";
            Add.Click += Add_Click;
            // 
            // tsbEdit
            // 
            tsbEdit.AccessibleName = "tsbEdit";
            tsbEdit.Image = (Image)resources.GetObject("tsbEdit.Image");
            tsbEdit.ImageTransparentColor = Color.Magenta;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Size = new Size(47, 22);
            tsbEdit.Text = "Edit";
            tsbEdit.Click += tsbEdit_Click;
            // 
            // tsbView
            // 
            tsbView.AccessibleName = "tsbView";
            tsbView.Image = (Image)resources.GetObject("tsbView.Image");
            tsbView.ImageTransparentColor = Color.Magenta;
            tsbView.Name = "tsbView";
            tsbView.Size = new Size(52, 22);
            tsbView.Text = "View";
            tsbView.Click += tsbView_Click;
            // 
            // tsbDelete
            // 
            tsbDelete.Image = (Image)resources.GetObject("tsbDelete.Image");
            tsbDelete.ImageTransparentColor = Color.Magenta;
            tsbDelete.Name = "tsbDelete";
            tsbDelete.Size = new Size(60, 22);
            tsbDelete.Text = "Delete";
            tsbDelete.ToolTipText = "tsbDelete";
            tsbDelete.Click += tsbDelete_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // tsbRefresh
            // 
            tsbRefresh.Image = (Image)resources.GetObject("tsbRefresh.Image");
            tsbRefresh.ImageTransparentColor = Color.Magenta;
            tsbRefresh.Name = "tsbRefresh";
            tsbRefresh.Size = new Size(66, 22);
            tsbRefresh.Tag = "tsbRefresh";
            tsbRefresh.Text = "Refresh";
            tsbRefresh.Click += tsbRefresh_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Window;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(toolStrip1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(pnlCustomerData, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.63529F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.9604845F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 78.40423F));
            tableLayoutPanel1.Size = new Size(570, 318);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.ControlLightLight;
            toolStrip1.Items.AddRange(new ToolStripItem[] { Add, tsbEdit, tsbView, tsbDelete, toolStripSeparator1, tsbRefresh });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(570, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.Window;
            flowLayoutPanel1.Controls.Add(lblSearch);
            flowLayoutPanel1.Controls.Add(txtSearch);
            flowLayoutPanel1.Controls.Add(lblCount);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 43);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(564, 22);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Dock = DockStyle.Fill;
            lblSearch.Location = new Point(3, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(42, 15);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(51, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(301, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Dock = DockStyle.Fill;
            lblCount.Location = new Point(358, 0);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(49, 15);
            lblCount.TabIndex = 2;
            lblCount.Text = "Count:0";
            // 
            // pnlCustomerData
            // 
            pnlCustomerData.Controls.Add(dgvCustomers);
            pnlCustomerData.Location = new Point(3, 71);
            pnlCustomerData.Name = "pnlCustomerData";
            pnlCustomerData.Size = new Size(564, 234);
            pnlCustomerData.TabIndex = 2;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.BackgroundColor = Color.White;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colPhone, colEmail, colAddress });
            dgvCustomers.Location = new Point(5, 5);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(559, 226);
            dgvCustomers.TabIndex = 0;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colPhone
            // 
            colPhone.HeaderText = "Phone";
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colAddress
            // 
            colAddress.HeaderText = "Address";
            colAddress.Name = "colAddress";
            colAddress.ReadOnly = true;
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "CustomerView";
            Size = new Size(570, 318);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            pnlCustomerData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip miniToolStrip;
        private ToolStripButton Add;
        private ToolStripButton tsbEdit;
        private ToolStripButton tsbView;
        private ToolStripButton tsbDelete;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbRefresh;
        private TableLayoutPanel tableLayoutPanel1;
        private ToolStrip toolStrip1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblCount;
        private Panel pnlCustomerData;
        private DataGridView dgvCustomers;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colAddress;
    }
}
