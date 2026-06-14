using FastBite.Core.Contracts;
using FastBite.Core.Models;
using FastBite.App.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FastBite.App.Views
{
    public partial class CustomerView : UserControl
    {
        private readonly ICustomerService _service;
        private readonly MainForm         _mainForm;
        private BindingSource             _bindingSource = new BindingSource();

        public CustomerView(ICustomerService service, MainForm mainForm)
        {
            InitializeComponent();
            _service  = service;
            _mainForm = mainForm;

            SetupGrid();
        }

        // ─────────────────────────────────────────
        // SETUP GRID — columns + sorting ✅
        // ─────────────────────────────────────────
        private void SetupGrid()
        {
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.DataSource          = _bindingSource;
            dgvCustomers.SelectionMode       = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.AllowUserToAddRows  = false;
            dgvCustomers.ReadOnly            = true;
            dgvCustomers.RowHeadersVisible   = false;
            dgvCustomers.BackgroundColor     = Color.White;
            dgvCustomers.BorderStyle         = BorderStyle.None;
            dgvCustomers.Font                = new Font("Segoe UI", 10F);
            dgvCustomers.RowTemplate.Height  = 32;

            dgvCustomers.Columns.Clear();
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText       = "ID",
                Width            = 110,
                SortMode         = DataGridViewColumnSortMode.Automatic
            });
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText       = "Full Name",
                Width            = 200,
                SortMode         = DataGridViewColumnSortMode.Automatic
            });
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Phone",
                HeaderText       = "Phone",
                Width            = 160,
                SortMode         = DataGridViewColumnSortMode.Automatic
            });
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Email",
                HeaderText       = "Email",
                Width            = 200,
                SortMode         = DataGridViewColumnSortMode.Automatic
            });
            dgvCustomers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Address",
                HeaderText       = "Address",
                Width            = 220,
                SortMode         = DataGridViewColumnSortMode.Automatic
            });

            // Style header
            dgvCustomers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            dgvCustomers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCustomers.ColumnHeadersDefaultCellStyle.Font      = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvCustomers.EnableHeadersVisualStyles               = false;
            dgvCustomers.ColumnHeadersHeight                     = 38;
        }

        // ─────────────────────────────────────────
        // LOAD DATA
        // ─────────────────────────────────────────
        private void LoadData()
        {
            try
            {
                List<Customer> customers = _service.GetAll();
                _bindingSource.DataSource = customers;
                lblCount.Text = $"Showing {customers.Count} customer(s)";
                _mainForm.UpdateStatusBar("Customers", customers.Count, lblLastAction.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers:\n{ex.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─────────────────────────────────────────
        // APPLY SEARCH FILTER
        // ─────────────────────────────────────────
        private void ApplyFilter()
        {
            try
            {
                string query = txtSearch.Text.Trim();

                List<Customer> results = string.IsNullOrEmpty(query)
                    ? _service.GetAll()
                    : _service.Search(query);

                _bindingSource.DataSource = results;
                lblCount.Text = $"Showing {results.Count} customer(s)";
                _mainForm.UpdateStatusBar("Customers", results.Count, lblLastAction.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching customers:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─────────────────────────────────────────
        // USER CONTROL LOAD
        // ─────────────────────────────────────────
        private void CustomerView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // ─────────────────────────────────────────
        // TOOLBAR — ADD
        // ─────────────────────────────────────────
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            using (var form = new CustomerForm(CustomerFormModeEnum.Add, null, _service))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SetLastAction("Customer added");
                    LoadData();
                }
            }
        }

        // ─────────────────────────────────────────
        // TOOLBAR — EDIT
        // ─────────────────────────────────────────
        private void tsbEdit_Click(object sender, EventArgs e)
        {
            Customer selected = _bindingSource.Current as Customer;
            if (selected == null)
            {
                MessageBox.Show("Please select a customer to edit.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var form = new CustomerForm(CustomerFormModeEnum.Edit, selected, _service))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SetLastAction($"'{selected.Name}' updated");
                    LoadData();
                }
            }
        }

        // ─────────────────────────────────────────
        // TOOLBAR — VIEW
        // ─────────────────────────────────────────
        private void tsbView_Click(object sender, EventArgs e)
        {
            Customer selected = _bindingSource.Current as Customer;
            if (selected == null)
            {
                MessageBox.Show("Please select a customer to view.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var form = new CustomerForm(CustomerFormModeEnum.View, selected, _service))
                form.ShowDialog();
        }

        // ─────────────────────────────────────────
        // TOOLBAR — DELETE
        // ─────────────────────────────────────────
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            Customer selected = _bindingSource.Current as Customer;
            if (selected == null)
            {
                MessageBox.Show("Please select a customer to delete.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete '{selected.Name}'?\nThis cannot be undone.",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _service.Delete(selected.Id);
                    SetLastAction($"'{selected.Name}' deleted");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting customer:\n{ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ─────────────────────────────────────────
        // TOOLBAR — REFRESH
        // ─────────────────────────────────────────
        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            SetLastAction("Refreshed");
            LoadData();
        }

        // ─────────────────────────────────────────
        // SEARCH EVENT
        // ─────────────────────────────────────────
        private void txtSearch_TextChanged(object sender, EventArgs e) => ApplyFilter();

        // ─────────────────────────────────────────
        // DOUBLE CLICK ROW — open view form
        // ─────────────────────────────────────────
        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                tsbView_Click(sender, e);
        }

        // ─────────────────────────────────────────
        // HELPER
        // ─────────────────────────────────────────
        private void SetLastAction(string action)
        {
            lblLastAction.Text = action;
            _mainForm.UpdateStatusBar("Customers", _bindingSource.Count, action);
        }
    }
}
