using FastBite.Core.Contracts;
using FastBite.Core.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FastBite.App.Forms
{
    public class CustomerPickerForm : Form
    {
        private readonly ICustomerService _service;
        public Customer SelectedCustomer { get; private set; }

        // ── Controls ──────────────────────────────
        private TextBox         txtSearch;
        private DataGridView    dgvCustomers;
        private Button          btnSelect;
        private Button          btnCancel;
        private Label           lblTitle;
        private Panel           pnlHeader;
        private BindingSource   _bindingSource = new BindingSource();

        public CustomerPickerForm(ICustomerService service)
        {
            _service = service;
            BuildUI();
            LoadCustomers();
        }

        // ─────────────────────────────────────────
        // BUILD UI — all in code, no Designer file
        // ─────────────────────────────────────────
        private void BuildUI()
        {
            // Form settings
            this.Text            = "Select Customer";
            this.ClientSize      = new Size(560, 460);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition   = FormStartPosition.CenterParent;
            this.MaximizeBox     = false;
            this.MinimizeBox     = false;

            // Header
            pnlHeader           = new Panel();
            pnlHeader.BackColor = Color.FromArgb(44, 62, 80);
            pnlHeader.Dock      = DockStyle.Top;
            pnlHeader.Height    = 50;

            lblTitle            = new Label();
            lblTitle.AutoSize   = false;
            lblTitle.Dock       = DockStyle.Fill;
            lblTitle.Font       = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitle.ForeColor  = Color.White;
            lblTitle.Text       = "👤  Pick a Customer";
            lblTitle.TextAlign  = ContentAlignment.MiddleCenter;
            pnlHeader.Controls.Add(lblTitle);

            // Search box
            txtSearch                 = new TextBox();
            txtSearch.Font            = new Font("Segoe UI", 10F);
            txtSearch.PlaceholderText = "🔍  Search by name or phone...";
            txtSearch.Location        = new Point(10, 60);
            txtSearch.Size            = new Size(535, 28);
            txtSearch.TextChanged    += (s, e) => ApplySearch();

            // Grid
            dgvCustomers                    = new DataGridView();
            dgvCustomers.Location           = new Point(10, 98);
            dgvCustomers.Size               = new Size(535, 290);
            dgvCustomers.DataSource         = _bindingSource;
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.SelectionMode      = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.ReadOnly           = true;
            dgvCustomers.RowHeadersVisible  = false;
            dgvCustomers.BackgroundColor    = Color.White;
            dgvCustomers.BorderStyle        = BorderStyle.None;
            dgvCustomers.Font               = new Font("Segoe UI", 10F);
            dgvCustomers.RowTemplate.Height = 30;

            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
                { DataPropertyName = "Id",    HeaderText = "ID",    Width = 110 });
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
                { DataPropertyName = "Name",  HeaderText = "Name",  Width = 200 });
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
                { DataPropertyName = "Phone", HeaderText = "Phone", Width = 160 });

            dgvCustomers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            dgvCustomers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCustomers.ColumnHeadersDefaultCellStyle.Font      = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvCustomers.EnableHeadersVisualStyles               = false;
            dgvCustomers.ColumnHeadersHeight                     = 35;
            dgvCustomers.CellDoubleClick += (s, e) => SelectAndClose();

            // Select button
            btnSelect           = new Button();
            btnSelect.BackColor = Color.FromArgb(39, 174, 96);
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.Font      = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSelect.ForeColor = Color.White;
            btnSelect.Location  = new Point(310, 400);
            btnSelect.Size      = new Size(115, 38);
            btnSelect.Text      = "✅ Select";
            btnSelect.FlatAppearance.BorderSize = 0;
            btnSelect.Click    += (s, e) => SelectAndClose();

            // Cancel button
            btnCancel           = new Button();
            btnCancel.BackColor = Color.FromArgb(192, 57, 43);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font      = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location  = new Point(435, 400);
            btnCancel.Size      = new Size(110, 38);
            btnCancel.Text      = "Cancel";
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Click    += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };

            this.Controls.Add(pnlHeader);
            this.Controls.Add(txtSearch);
            this.Controls.Add(dgvCustomers);
            this.Controls.Add(btnSelect);
            this.Controls.Add(btnCancel);
        }

        // ─────────────────────────────────────────
        // LOAD ALL CUSTOMERS
        // ─────────────────────────────────────────
        private void LoadCustomers()
        {
            try
            {
                _bindingSource.DataSource = _service.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─────────────────────────────────────────
        // SEARCH FILTER
        // ─────────────────────────────────────────
        private void ApplySearch()
        {
            try
            {
                string q = txtSearch.Text.Trim();
                _bindingSource.DataSource = string.IsNullOrEmpty(q)
                    ? _service.GetAll()
                    : _service.Search(q);
            }
            catch { }
        }

        // ─────────────────────────────────────────
        // SELECT AND CLOSE
        // ─────────────────────────────────────────
        private void SelectAndClose()
        {
            SelectedCustomer = _bindingSource.Current as Customer;
            if (SelectedCustomer == null)
            {
                MessageBox.Show("Please select a customer from the list.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
