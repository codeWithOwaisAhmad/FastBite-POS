using FastBite.Core.Contracts;
using FastBite.Core.Models;
using FastBite.Core.Utilities;
using System;
using System.Windows.Forms;

namespace FastBite.App.Forms
{
    public partial class MenuItemForm : Form
    {
        private readonly IMenuItemService _service;
        private readonly MenuItemFormModeEnum _mode;
        private FoodItem _item;

        public MenuItemForm(MenuItemFormModeEnum mode, FoodItem item, IMenuItemService service)
        {
            InitializeComponent();

            _mode = mode;
            _item = item ?? new FoodItem();
            _service = service;

            cmbCategory.DataSource = Enum.GetValues(typeof(MenuCategoryEnum));
            cmbStatus.DataSource = Enum.GetValues(typeof(MenuItemStatusEnum));

            SetupMode();

            if (mode == MenuItemFormModeEnum.Edit || mode == MenuItemFormModeEnum.View)
                PopulateFields();
        }

        private void SetupMode()
        {
            switch (_mode)
            {
                case MenuItemFormModeEnum.Add:
                    this.Text = "Add Menu Item";
                    txtId.Visible = false;
                    lblId.Visible = false;
                    btnSave.Text = "Add Item";
                    break;
                case MenuItemFormModeEnum.Edit:
                    this.Text = "Edit Menu Item";
                    txtId.ReadOnly = true;
                    btnSave.Text = "Save Changes";
                    break;
                case MenuItemFormModeEnum.View:
                    this.Text = "View Menu Item";
                    txtId.ReadOnly = true;
                    txtName.ReadOnly = true;
                    nuPrice.Enabled = false;
                    cmbCategory.Enabled = false;
                    cmbStatus.Enabled = false;
                    btnSave.Visible = false;
                    break;
            }
        }

        private void PopulateFields()
        {
            txtId.Text = _item.Id;
            txtName.Text = _item.Name;
            nuPrice.Value = _item.Price;
            cmbCategory.SelectedItem = _item.Category;
            cmbStatus.SelectedItem = _item.Status;
        }

        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Item name is required.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }
            if (nuPrice.Value <= 0)
            {
                MessageBox.Show("Price must be greater than zero.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nuPrice.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData()) return;
            try
            {
                _item.Name = txtName.Text.Trim();
                _item.Price = nuPrice.Value;
                _item.Category = (MenuCategoryEnum)cmbCategory.SelectedItem;
                _item.Status = (MenuItemStatusEnum)cmbStatus.SelectedItem;

                if (_mode == MenuItemFormModeEnum.Add)
                {
                    _service.Add(_item);
                    MessageBox.Show("Menu item added successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (_mode == MenuItemFormModeEnum.Edit)
                {
                    bool updated = _service.Update(_item);
                    if (!updated)
                    {
                        MessageBox.Show("Item not found in database.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show("Menu item updated successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving menu item:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}