
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Core.Services;
using App.WindowsApp.Views;


namespace App.WindowsApp.Forms
{
    public partial class MainForm : Form
    {
        InMemoryProductService _productService = new InMemoryProductService();
        InMemoryCustomerService _customerService = new InMemoryCustomerService();
        private readonly Dictionary<Type, UserControl> _views = new Dictionary<Type, UserControl>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void btnSync_Click(object sender, EventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.pnlContent.Controls.Clear();
            this.pnlContent.Controls.Add(new ProductView(_productService));

            ShowView(() => new ProductView(_productService));
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.pnlContent.Controls.Clear();
            this.pnlContent.Controls.Add(new DashboardView());

            ShowView(() => new DashboardView());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ShowView(() => new CustomerView(_customerService));
        }

        private void ShowView<T>(Func<T> factory) where T : UserControl
        {
            var key = typeof(T);
            if (!_views.TryGetValue(key, out var view))
            {
                view = factory();
                view.Dock = DockStyle.Fill;
                _views[key] = view;
            }

            if (!pnlContent.Controls.Contains(view))
            {
                pnlContent.Controls.Clear();
                pnlContent.Controls.Add(view);
            }

            view.BringToFront();
        }
    }
}
