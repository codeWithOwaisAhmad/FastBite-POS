using FastBite.Core.Contracts;
using FastBite.Core.Models;
using FastBite.Core.Utilities;
using FastBite.App.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FastBite.App.Views
{
    public partial class OrderView : UserControl
    {
        private readonly IOrderService    _orderService;
        private readonly ICustomerService _customerService;
        private readonly IMenuItemService _menuItemService;
        private readonly MainForm         _mainForm;
        private BindingSource             _bindingSource = new BindingSource();

        public OrderView(IOrderService orderService,
            ICustomerService customerService,
            IMenuItemService menuItemService,
            MainForm mainForm)
        {
            InitializeComponent();
            _orderService    = orderService;
            _customerService = customerService;
            _menuItemService = menuItemService;
            _mainForm        = mainForm;

            SetupGrid();
            SetupFilters();
        }

        // ─────────────────────────────────────────
        // SETUP GRID — columns + sorting ✅
        // ─────────────────────────────────────────
        private void SetupGrid()
        {
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.DataSource          = _bindingSource;
            dgvOrders.SelectionMode       = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.AllowUserToAddRows  = false;
            dgvOrders.ReadOnly            = true;
            dgvOrders.RowHeadersVisible   = false;
            dgvOrders.BackgroundColor     = Color.White;
            dgvOrders.BorderStyle         = BorderStyle.None;
            dgvOrders.Font                = new Font("Segoe UI", 10F);
            dgvOrders.RowTemplate.Height  = 32;

            dgvOrders.Columns.Clear();
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText       = "Order ID",
                Width            = 120,
                SortMode         = DataGridViewColumnSortMode.Automatic
            });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CustomerName",
                HeaderText       = "Customer",
                Width            = 180,
                SortMode         = DataGridViewColumnSortMode.Automatic
            });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "OrderDate",
                HeaderText       = "Order Date",
                Width            = 160,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd-MMM-yyyy  hh:mm tt" },
                SortMode         = DataGridViewColumnSortMode.Automatic
            });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText       = "Status",
                Width            = 120,
                SortMode         = DataGridViewColumnSortMode.Automatic
            });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PaymentMethod",
                HeaderText       = "Payment",
                Width            = 100,
                SortMode         = DataGridViewColumnSortMode.Automatic
            });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalAmount",
                HeaderText       = "Total (Rs.)",
                Width            = 120,
                DefaultCellStyle = new DataGridViewCellStyle
                    { Format = "N2", Alignment = DataGridViewContentAlignment.MiddleRight },
                SortMode         = DataGridViewColumnSortMode.Automatic
            });

            // Style header
            dgvOrders.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            dgvOrders.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvOrders.ColumnHeadersDefaultCellStyle.Font      = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvOrders.EnableHeadersVisualStyles               = false;
            dgvOrders.ColumnHeadersHeight                     = 38;

            // Color rows by status
            dgvOrders.RowPrePaint += DgvOrders_RowPrePaint;
        }

        // ─────────────────────────────────────────
        // COLOR ROWS BY STATUS
        // ─────────────────────────────────────────
        private void DgvOrders_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var order = dgvOrders.Rows[e.RowIndex].DataBoundItem as Order;
            if (order == null) return;

            switch (order.Status)
            {
                case OrderStatusEnum.Completed:
                    dgvOrders.Rows[e.RowIndex].DefaultCellStyle.BackColor =
                        Color.FromArgb(213, 245, 227);   // light green
                    break;
                case OrderStatusEnum.Cancelled:
                    dgvOrders.Rows[e.RowIndex].DefaultCellStyle.BackColor =
                        Color.FromArgb(250, 219, 216);   // light red
                    break;
                case OrderStatusEnum.Pending:
                    dgvOrders.Rows[e.RowIndex].DefaultCellStyle.BackColor =
                        Color.FromArgb(254, 249, 219);   // light yellow
                    break;
                default:
                    dgvOrders.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    break;
            }
        }

        // ─────────────────────────────────────────
        // SETUP FILTERS
        // ─────────────────────────────────────────
        private void SetupFilters()
        {
            cmbStatusFilter.Items.Clear();
            cmbStatusFilter.Items.Add("All Orders");
            foreach (var s in Enum.GetValues(typeof(OrderStatusEnum)))
                cmbStatusFilter.Items.Add(s);
            cmbStatusFilter.SelectedIndex = 0;
        }

        // ─────────────────────────────────────────
        // LOAD DATA
        // ─────────────────────────────────────────
        private void LoadData()
        {
            try
            {
                List<Order> orders;

                if (cmbStatusFilter.SelectedItem is OrderStatusEnum status)
                    orders = _orderService.GetByStatus(status);
                else
                    orders = _orderService.GetAll();

                _bindingSource.DataSource = orders;
                lblCount.Text = $"Showing {orders.Count} order(s)";
                _mainForm.UpdateStatusBar("Orders", orders.Count, lblLastAction.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading orders:\n{ex.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─────────────────────────────────────────
        // USER CONTROL LOAD
        // ─────────────────────────────────────────
        private void OrderView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // ─────────────────────────────────────────
        // TOOLBAR — ADD NEW ORDER
        // ─────────────────────────────────────────
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            using (var form = new OrderForm(OrderFormModeEnum.Add, null,
                _orderService, _customerService, _menuItemService))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SetLastAction("New order placed");
                    LoadData();
                }
            }
        }

        // ─────────────────────────────────────────
        // TOOLBAR — EDIT
        // ─────────────────────────────────────────
        private void tsbEdit_Click(object sender, EventArgs e)
        {
            Order selected = _bindingSource.Current as Order;
            if (selected == null)
            {
                MessageBox.Show("Please select an order to edit.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var form = new OrderForm(OrderFormModeEnum.Edit, selected,
                _orderService, _customerService, _menuItemService))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SetLastAction($"Order {selected.Id} updated");
                    LoadData();
                }
            }
        }

        // ─────────────────────────────────────────
        // TOOLBAR — VIEW
        // ─────────────────────────────────────────
        private void tsbView_Click(object sender, EventArgs e)
        {
            Order selected = _bindingSource.Current as Order;
            if (selected == null)
            {
                MessageBox.Show("Please select an order to view.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var form = new OrderForm(OrderFormModeEnum.View, selected,
                _orderService, _customerService, _menuItemService))
                form.ShowDialog();
        }

        // ─────────────────────────────────────────
        // TOOLBAR — DELETE
        // ─────────────────────────────────────────
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            Order selected = _bindingSource.Current as Order;
            if (selected == null)
            {
                MessageBox.Show("Please select an order to delete.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"Delete order {selected.Id} for '{selected.CustomerName}'?\nThis cannot be undone.",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _orderService.Delete(selected.Id);
                    SetLastAction($"Order {selected.Id} deleted");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting order:\n{ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ─────────────────────────────────────────
        // TOOLBAR — REFRESH
        // ─────────────────────────────────────────
        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            cmbStatusFilter.SelectedIndex = 0;
            SetLastAction("Refreshed");
            LoadData();
        }

        // ─────────────────────────────────────────
        // FILTER CHANGE
        // ─────────────────────────────────────────
        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
            => LoadData();

        // ─────────────────────────────────────────
        // DOUBLE CLICK — VIEW ORDER
        // ─────────────────────────────────────────
        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
            _mainForm.UpdateStatusBar("Orders", _bindingSource.Count, action);
        }
    }
}
