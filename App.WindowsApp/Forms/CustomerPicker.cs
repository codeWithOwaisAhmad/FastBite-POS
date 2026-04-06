using App.Core.Contracts;
using App.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace App.WindowsApp.Forms
{
    public partial class CustomerPicker : Form
    {
        private readonly ICustomerService _customerService;
        private BindingSource _bindingSource;
        public Customer SelectedCustomer { get; private set; }
        public CustomerPicker(ICustomerService service)
        {
            InitializeComponent();
            _bindingSource = new BindingSource();
            lsCustomers.DataSource = _bindingSource;
            _customerService = service;
            LoadCustomers(string.Empty);
        }
        public void LoadCustomers(string query)
        {
            var customers = string.IsNullOrWhiteSpace(query) ?
                _customerService.GetAll() : _customerService.Search(query);
            _bindingSource.DataSource = customers;

            lsCustomers.DisplayMember = "Name";
            lsCustomers.ValueMember = "Id";

        }

        private void txtSearchQuery_TextChanged(object sender, EventArgs e)
        {
            LoadCustomers(txtSearchQuery.Text);
        }
        private void SelectCustomer()
        {
            if (lsCustomers.SelectedItems != null && lsCustomers.SelectedItem is Customer)
            {
                SelectedCustomer = (Customer)lsCustomers.SelectedItem;
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Please select a customer.", "Customer Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectCustomer();
        }

        private void lsCustomers_DoubleClick(object sender, EventArgs e)
        {
            SelectCustomer();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
