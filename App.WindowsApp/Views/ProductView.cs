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

        private void ProductView_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.AddRange(
                Enum.GetValues(typeof(ProductCategoryEnum))
                    .Cast<object>()
                    .ToArray()
            );
            cmbCategory.Items.Add("--All--");
            cmbCategory.SelectedIndex = 0;

            cmbStock.Items.Clear();
            cmbStock.Items.AddRange(
                Enum.GetValues(typeof(ProductStatusEnum))
                    .Cast<object>()
                    .ToArray()
            );
            cmbStock.Items.Add("--All--");
            cmbStock.SelectedIndex = 0;

            if (_service == null)
                return;

            RefreshGrid();
        }

        private void tbAdd_Click(object sender, EventArgs e)
        {
            ProductForm prodFOrm = new ProductForm(ProductFormModeEnum.Add, null, _service);
            prodFOrm.ShowDialog();
            RefreshGrid();
        }

        private void tbEdit_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvBindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm prodFOrm = new ProductForm(ProductFormModeEnum.Edit, selectedProduct, _service);
                prodFOrm.ShowDialog();
                RefreshGrid();
            }
        }

        private void tbView_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvBindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm prodFOrm = new ProductForm(ProductFormModeEnum.View, selectedProduct, _service);
                prodFOrm.ShowDialog();
            }
        }

        private void tbDelete_Click(object sender, EventArgs e)
        {

        }

        private void tbRefresh_Click(object sender, EventArgs e)
        {

        }

        private void RefreshGrid()
        {
            if (_service == null)
                return;

            string searchText = txtSearch.Text;

            ProductCategoryEnum? selectedCategory = null;
            if (cmbCategory.SelectedItem != null &&
                !cmbCategory.SelectedItem.ToString().Equals("--All--"))
            {
                selectedCategory = (ProductCategoryEnum)cmbCategory.SelectedItem;
            }

            ProductStatusEnum? selectedStatus = null;
            if (cmbStock.SelectedItem != null &&
                !cmbStock.SelectedItem.ToString().Equals("--All--"))
            {
                selectedStatus = (ProductStatusEnum)cmbStock.SelectedItem;
            }

            _dgvBindingSource.DataSource =
                _service.Search(searchText, selectedCategory, selectedStatus);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void cmbCategory_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void cmbStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}