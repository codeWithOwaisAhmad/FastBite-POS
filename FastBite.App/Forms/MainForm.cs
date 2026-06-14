using FastBite.Core.Contracts;
using FastBite.Core.Services;
using FastBite.App.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FastBite.App.Forms
{
    public partial class MainForm : Form
    {
        // ─────────────────────────────────────────
        // CONNECTION STRING — one place, used by all services
        // Change "localhost" to your SQL Server name if needed
        // ─────────────────────────────────────────
        private readonly string _connStr =
            "Server=DESKTOP-S989LR5; Database=FastBitePOS;" +
            "Integrated Security=True; TrustServerCertificate=True;";

        // ─────────────────────────────────────────
        // SERVICES — created once, shared across all views
        // ─────────────────────────────────────────
        private readonly IMenuItemService  _menuItemService;
        private readonly ICustomerService  _customerService;
        private readonly IOrderService     _orderService;

        // ─────────────────────────────────────────
        // VIEW CACHE — create once, reuse on every click
        // ─────────────────────────────────────────
        private readonly Dictionary<Type, UserControl> _views
            = new Dictionary<Type, UserControl>();

        public MainForm()
        {
            InitializeComponent();

            // Create services with connection string (constructor injection)
            _menuItemService = new DBMenuItemService(_connStr);
            _customerService = new DBCustomerService(_connStr);
            _orderService    = new DBOrderService(_connStr);
        }

        // ─────────────────────────────────────────
        // FORM LOAD — show dashboard by default
        // ─────────────────────────────────────────
        private void MainForm_Load(object sender, EventArgs e)
        {
            SetActiveButton(btnDashboard);
            ShowView(() => new DashboardView(_orderService, _menuItemService));
            UpdateStatusBar("Welcome to FastBite POS", 0, "");
        }

        // ─────────────────────────────────────────
        // NAVIGATION BUTTON CLICKS
        // ─────────────────────────────────────────
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnDashboard);
            ShowView(() => new DashboardView(_orderService, _menuItemService));
            UpdateStatusBar("Dashboard", 0, "Viewing Dashboard");
        }

        private void btnMenuItems_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnMenuItems);
            ShowView(() => new MenuItemView(_menuItemService, this));
            UpdateStatusBar("Menu Items", 0, "Viewing Menu Items");
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnCustomers);
            ShowView(() => new CustomerView(_customerService, this));
            UpdateStatusBar("Customers", 0, "Viewing Customers");
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnOrders);
            ShowView(() => new OrderView(_orderService, _customerService, _menuItemService, this));
            UpdateStatusBar("Orders", 0, "Viewing Orders");
        }

        // ─────────────────────────────────────────
        // SHOW VIEW — generic factory with caching
        // Creates the view once, reuses it every click
        // ─────────────────────────────────────────
        private void ShowView<T>(Func<T> factory) where T : UserControl
        {
            var key = typeof(T);

            if (!_views.TryGetValue(key, out var view))
            {
                view           = factory();
                view.Dock      = DockStyle.Fill;
                _views[key]    = view;
            }

            if (!pnlContent.Controls.Contains(view))
            {
                pnlContent.Controls.Clear();
                pnlContent.Controls.Add(view);
            }

            view.BringToFront();
        }

        // ─────────────────────────────────────────
        // SET ACTIVE BUTTON — highlight selected nav button
        // ─────────────────────────────────────────
        private void SetActiveButton(Button active)
        {
            Color activeColor   = Color.FromArgb(230, 126, 34);   // orange
            Color inactiveColor = Color.FromArgb(44,  62,  80);   // dark blue

            foreach (Control ctrl in pnlSidebar.Controls)
            {
                if (ctrl is Button btn)
                    btn.BackColor = inactiveColor;
            }

            active.BackColor = activeColor;
        }

        // ─────────────────────────────────────────
        // STATUS BAR — bonus mark ✅
        // Called by views to update bottom status strip
        // ─────────────────────────────────────────
        public void UpdateStatusBar(string section, int recordCount, string lastAction)
        {
            lblSection.Text     = $"  📍 {section}";
            lblRecordCount.Text = recordCount > 0
                ? $"  Records: {recordCount}"
                : "";
            lblLastAction.Text  = string.IsNullOrEmpty(lastAction)
                ? ""
                : $"  Last Action: {lastAction}";
            lblDateTime.Text    = $"  {DateTime.Now:dd-MMM-yyyy  hh:mm tt}  ";
        }

        // ─────────────────────────────────────────
        // INVALIDATE VIEW CACHE — forces a view to reload
        // Called after Add/Edit/Delete so data refreshes
        // ─────────────────────────────────────────
        public void InvalidateView<T>() where T : UserControl
        {
            var key = typeof(T);
            if (_views.ContainsKey(key))
                _views.Remove(key);
        }
    }
}
