using App.Core.Contracts;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.WindowsApp.Forms;
using App.Core.Models;

namespace App.WindowsApp.Views

{
    public partial class ProductView : UserControl
    {
        private IProductService _service;
        BindingSource _dgvBindingSource = new BindingSource();
        public ProductView(IProductService _ser)
        {
            _service = _ser;
            InitializeComponent();
            dgvProducts.DataSource = _dgvBindingSource;
        }

        private void tblProducts_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ProductView_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("--All--");
            cmbCategory.Items.AddRange(Enum.GetNames(typeof(ProductCategoryEnum)));
            cmbCategory.SelectedIndex = 0;

            cmbStock.Items.Clear();
            cmbStock.Items.Add("--All--");
            cmbStock.Items.AddRange(Enum.GetNames(typeof(ProductStatusEnum)));
            cmbStock.SelectedIndex = 0;

            if (_service == null)
                return;
            _service.GetAll();
            _dgvBindingSource.DataSource = _service.GetAll();

        }
        private void tbAdd_Click(object sender, EventArgs e)
        {
            ProductForm prodFOrm = new ProductForm(ProductFormModeEnum.Add, null);
            prodFOrm.ShowDialog();
        }
        private void tbEdit_Click(object sender, EventArgs e) 
        {
            Product? selectedProduct = _dgvBindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm prodFOrm = new ProductForm(ProductFormModeEnum.Edit, selectedProduct);
                prodFOrm.ShowDialog();
            }

            
        }

        private void tbView_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvBindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm prodFOrm = new ProductForm(ProductFormModeEnum.View, selectedProduct);
                prodFOrm.ShowDialog();
            }
        }

        private void tbDelete_Click(object sender, EventArgs e)
        {

        }

        private void tbRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
