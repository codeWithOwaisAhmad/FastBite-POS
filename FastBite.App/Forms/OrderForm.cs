using FastBite.Core.Contracts;
using FastBite.Core.Models;
using FastBite.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FastBite.App.Forms
{
    public partial class OrderForm : Form
    {
        private readonly IOrderService    _orderService;
        private readonly ICustomerService _customerService;
        private readonly IMenuItemService _menuItemService;
        private readonly OrderFormModeEnum _mode;

        private Order             _order;
        private List<FoodItem>    _allMenuItems;
        private List<OrderItem>   _orderItems = new List<OrderItem>();

        public OrderForm(OrderFormModeEnum mode, Order order,
            IOrderService orderService,
            ICustomerService customerService,
            IMenuItemService menuItemService)
        {
            InitializeComponent();

            _mode            = mode;
            _order           = order ?? new Order();
            _orderService    = orderService;
            _customerService = customerService;
            _menuItemService = menuItemService;
        }

        // ─────────────────────────────────────────
        // FORM LOAD
        // ─────────────────────────────────────────
        private void OrderForm_Load(object sender, EventArgs e)
        {
            // Load menu items for the picker combo
            _allMenuItems = _menuItemService.GetAll()
                .Where(m => m.Status == MenuItemStatusEnum.Available)
                .ToList();

            cmbMenuItem.DataSource    = _allMenuItems;
            cmbMenuItem.DisplayMember = "Name";
            cmbMenuItem.ValueMember   = "Id";

            // Bind enums
            cmbStatus.DataSource        = Enum.GetValues(typeof(OrderStatusEnum));
            cmbPaymentMethod.DataSource = Enum.GetValues(typeof(PaymentMethodEnum));

            SetupItemsGrid();
            SetupMode();

            if (_mode == OrderFormModeEnum.Edit || _mode == OrderFormModeEnum.View)
                PopulateFields();
            else
            {
                // Add mode — set defaults
                dtpOrderDate.Value          = DateTime.Now;
                cmbStatus.SelectedItem      = OrderStatusEnum.Pending;
                cmbPaymentMethod.SelectedItem = PaymentMethodEnum.Cash;
            }

            RefreshItemsGrid();
            RefreshTotal();
        }

        // ─────────────────────────────────────────
        // SETUP ORDER ITEMS GRID
        // ─────────────────────────────────────────
        private void SetupItemsGrid()
        {
            dgvOrderItems.AutoGenerateColumns = false;
            dgvOrderItems.AllowUserToAddRows  = false;
            dgvOrderItems.ReadOnly            = true;
            dgvOrderItems.SelectionMode       = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderItems.RowHeadersVisible   = false;
            dgvOrderItems.BackgroundColor     = Color.White;
            dgvOrderItems.BorderStyle         = BorderStyle.None;
            dgvOrderItems.Font                = new Font("Segoe UI", 10F);
            dgvOrderItems.RowTemplate.Height  = 30;

            dgvOrderItems.Columns.Clear();
            dgvOrderItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MenuItemName",
                HeaderText       = "Item",
                Width            = 200
            });
            dgvOrderItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UnitPrice",
                HeaderText       = "Unit Price",
                Width            = 110,
                DefaultCellStyle = new DataGridViewCellStyle
                    { Format = "N2", Alignment = DataGridViewContentAlignment.MiddleRight }
            });
            dgvOrderItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantity",
                HeaderText       = "Qty",
                Width            = 60,
                DefaultCellStyle = new DataGridViewCellStyle
                    { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            // Calculated Total column — not a direct property, uses unbound column
            var totalCol = new DataGridViewTextBoxColumn
            {
                HeaderText = "Total",
                Width = 110,
                DefaultCellStyle = new DataGridViewCellStyle
                { Alignment = DataGridViewContentAlignment.MiddleRight }
            };
            dgvOrderItems.Columns.Add(totalCol);

            // Style header
            dgvOrderItems.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            dgvOrderItems.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvOrderItems.ColumnHeadersDefaultCellStyle.Font      = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvOrderItems.EnableHeadersVisualStyles               = false;
            dgvOrderItems.ColumnHeadersHeight                     = 35;

            dgvOrderItems.CellFormatting += DgvOrderItems_CellFormatting;
            dgvOrderItems.DataError += (s, e) => e.ThrowException = false;
        }

        // ─────────────────────────────────────────
        // CELL FORMATTING — fill Total column
        // ─────────────────────────────────────────
        private void DgvOrderItems_CellFormatting(object sender,
            DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.RowIndex >= _orderItems.Count) return;
            if (dgvOrderItems.Columns[e.ColumnIndex].HeaderText == "Total")
            {
                try
                {
                    var item = _orderItems[e.RowIndex];
                    e.Value = item.Total().ToString("N2");
                    e.FormattingApplied = true;
                }
                catch { }
            }
        }

        // ─────────────────────────────────────────
        // SETUP MODE
        // ─────────────────────────────────────────
        private void SetupMode()
        {
            switch (_mode)
            {
                case OrderFormModeEnum.Add:
                    this.Text        = "New Order";
                    lblOrderId.Visible = false;
                    txtOrderId.Visible = false;
                    btnSave.Text     = "Place Order";
                    break;

                case OrderFormModeEnum.Edit:
                    this.Text        = "Edit Order";
                    txtOrderId.ReadOnly = true;
                    btnSave.Text     = "Save Changes";
                    break;

                case OrderFormModeEnum.View:
                    this.Text              = "View Order";
                    txtOrderId.ReadOnly    = true;
                    txtCustomerName.ReadOnly = true;
                    dtpOrderDate.Enabled   = false;
                    cmbStatus.Enabled      = false;
                    cmbPaymentMethod.Enabled = false;
                    pnlAddItem.Visible     = false;
                    btnRemoveItem.Visible  = false;
                    btnSave.Visible        = false;
                    break;
            }
        }

        // ─────────────────────────────────────────
        // POPULATE FIELDS — for Edit / View
        // ─────────────────────────────────────────
        private void PopulateFields()
        {
            // Load full order with items from DB
            _order = _orderService.GetById(_order.Id);

            txtOrderId.Text              = _order.Id;
            txtCustomerName.Text         = _order.CustomerName;
            dtpOrderDate.Value           = _order.OrderDate;
            cmbStatus.SelectedItem       = _order.Status;
            cmbPaymentMethod.SelectedItem = _order.PaymentMethod;

            // Copy items into local list
            _orderItems = new List<OrderItem>(_order.Items);
        }

        // ─────────────────────────────────────────
        // PICK CUSTOMER BUTTON
        // ─────────────────────────────────────────
        private void btnPickCustomer_Click(object sender, EventArgs e)
        {
            if (_mode == OrderFormModeEnum.View) return;

            using (var picker = new CustomerPickerForm(_customerService))
            {
                if (picker.ShowDialog() == DialogResult.OK && picker.SelectedCustomer != null)
                {
                    _order.CustomerId   = picker.SelectedCustomer.Id;
                    _order.CustomerName = picker.SelectedCustomer.Name;
                    txtCustomerName.Text = picker.SelectedCustomer.Name;
                }
            }
        }

        // ─────────────────────────────────────────
        // ADD ITEM BUTTON
        // ─────────────────────────────────────────
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (cmbMenuItem.SelectedItem == null) return;

            FoodItem selected = cmbMenuItem.SelectedItem as FoodItem;
            int      qty      = (int)nuQuantity.Value;

            // If item already in order, increase quantity
            var existing = _orderItems.FirstOrDefault(i => i.MenuItemId == selected.Id);
            if (existing != null)
            {
                existing.Quantity += qty;
            }
            else
            {
                _orderItems.Add(new OrderItem
                {
                    MenuItemId   = selected.Id,
                    MenuItemName = selected.Name,
                    UnitPrice    = selected.Price,
                    Quantity     = qty
                });
            }

            RefreshItemsGrid();
            RefreshTotal();
        }

        // ─────────────────────────────────────────
        // REMOVE ITEM BUTTON
        // ─────────────────────────────────────────
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvOrderItems.CurrentRow == null) return;

            int idx = dgvOrderItems.CurrentRow.Index;
            if (idx >= 0 && idx < _orderItems.Count)
            {
                string name = _orderItems[idx].MenuItemName;
                var confirm = MessageBox.Show(
                    $"Remove '{name}' from this order?",
                    "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    _orderItems.RemoveAt(idx);
                    RefreshItemsGrid();
                    RefreshTotal();
                }
            }
        }

        // ─────────────────────────────────────────
        // REFRESH ITEMS GRID
        // ─────────────────────────────────────────
        private void RefreshItemsGrid()
        {
            dgvOrderItems.DataSource = null;
            dgvOrderItems.DataSource = _orderItems;
        }

        // ─────────────────────────────────────────
        // REFRESH TOTAL LABEL
        // ─────────────────────────────────────────
        private void RefreshTotal()
        {
            decimal total  = _orderItems.Sum(i => i.Total());
            lblTotal.Text  = $"Total:  Rs. {total:N2}";
        }

        // ─────────────────────────────────────────
        // VALIDATE DATA
        // ─────────────────────────────────────────
        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(_order.CustomerId))
            {
                MessageBox.Show("Please select a customer for this order.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (_orderItems.Count == 0)
            {
                MessageBox.Show("Please add at least one item to the order.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // ─────────────────────────────────────────
        // SAVE BUTTON
        // ─────────────────────────────────────────
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData()) return;

            try
            {
                _order.OrderDate      = dtpOrderDate.Value;
                _order.Status         = (OrderStatusEnum)cmbStatus.SelectedItem;
                _order.PaymentMethod  = (PaymentMethodEnum)cmbPaymentMethod.SelectedItem;
                _order.Items          = _orderItems;

                if (_mode == OrderFormModeEnum.Add)
                {
                    _orderService.Add(_order);
                    MessageBox.Show("Order placed successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (_mode == OrderFormModeEnum.Edit)
                {
                    _orderService.Update(_order);
                    MessageBox.Show("Order updated successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving order:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─────────────────────────────────────────
        // CANCEL BUTTON
        // ─────────────────────────────────────────
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
