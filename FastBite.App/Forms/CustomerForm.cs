using FastBite.Core.Contracts;
using FastBite.Core.Models;
using System;
using System.Windows.Forms;

namespace FastBite.App.Forms
{
    public partial class CustomerForm : Form
    {
        private readonly ICustomerService     _service;
        private readonly CustomerFormModeEnum _mode;
        private Customer _customer;

        public CustomerForm(CustomerFormModeEnum mode, Customer customer, ICustomerService service)
        {
            InitializeComponent();

            _mode     = mode;
            _customer = customer ?? new Customer();
            _service  = service;

            SetupMode();

            if (mode == CustomerFormModeEnum.Edit || mode == CustomerFormModeEnum.View)
                PopulateFields();
        }

        // ─────────────────────────────────────────
        // SETUP MODE
        // ─────────────────────────────────────────
        private void SetupMode()
        {
            switch (_mode)
            {
                case CustomerFormModeEnum.Add:
                    this.Text      = "Add Customer";
                    lblId.Visible  = false;
                    txtId.Visible  = false;
                    btnSave.Text   = "Add Customer";
                    break;

                case CustomerFormModeEnum.Edit:
                    this.Text      = "Edit Customer";
                    txtId.ReadOnly = true;
                    btnSave.Text   = "Save Changes";
                    break;

                case CustomerFormModeEnum.View:
                    this.Text            = "View Customer";
                    txtId.ReadOnly       = true;
                    txtName.ReadOnly     = true;
                    txtPhone.ReadOnly    = true;
                    txtEmail.ReadOnly    = true;
                    txtAddress.ReadOnly  = true;
                    btnSave.Visible      = false;
                    break;
            }
        }

        // ─────────────────────────────────────────
        // POPULATE FIELDS
        // ─────────────────────────────────────────
        private void PopulateFields()
        {
            txtId.Text      = _customer.Id;
            txtName.Text    = _customer.Name;
            txtPhone.Text   = _customer.Phone;
            txtEmail.Text   = _customer.Email;
            txtAddress.Text = _customer.Address;
        }

        // ─────────────────────────────────────────
        // VALIDATE DATA
        // ─────────────────────────────────────────
        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Customer name is required.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Phone number is required.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
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
                _customer.Name    = txtName.Text.Trim();
                _customer.Phone   = txtPhone.Text.Trim();
                _customer.Email   = txtEmail.Text.Trim();
                _customer.Address = txtAddress.Text.Trim();

                if (_mode == CustomerFormModeEnum.Add)
                {
                    _service.Add(_customer);
                    MessageBox.Show("Customer added successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (_mode == CustomerFormModeEnum.Edit)
                {
                    _service.Update(_customer);
                    MessageBox.Show("Customer updated successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving customer:\n{ex.Message}",
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
