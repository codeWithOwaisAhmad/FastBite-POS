using FastBite.Core.Contracts;
using FastBite.Core.Models;
using FastBite.Core.Utilities;
using FastBite.App.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FastBite.App.Views
{
    public partial class MenuItemView : UserControl
    {
        private readonly IMenuItemService _service;
        private readonly MainForm _mainForm;
        private BindingSource _bindingSource = new BindingSource();

        public MenuItemView(IMenuItemService service, MainForm mainForm)
        {
            InitializeComponent();
            _service = service;
            _mainForm = mainForm;
            SetupGrid();
            SetupFilters();
        }

        private void SetupGrid()
        {
            dgvMenuItems.AutoGenerateColumns = false;
            dgvMenuItems.DataSource = _bindingSource;
            dgvMenuItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMenuItems.AllowUserToAddRows = false;
            dgvMenuItems.ReadOnly = true;
            dgvMenuItems.RowHeadersVisible = false;
            dgvMenuItems.BackgroundColor = Color.White;
            dgvMenuItems.BorderStyle = BorderStyle.None;
            dgvMenuItems.Font = new Font("Segoe UI", 10F);
            dgvMenuItems.RowTemplate.Height = 32;

            dgvMenuItems.Columns.Clear();
            dgvMenuItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Width = 110,
                SortMode = DataGridViewColumnSortMode.Automatic
            });
            dgvMenuItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Item Name",
                Width = 220,
                SortMode = DataGridViewColumnSortMode.Automatic
            });
            dgvMenuItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Category",
                HeaderText = "Category",
                Width = 120,
                SortMode = DataGridViewColumnSortMode.Automatic
            });
            dgvMenuItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "Price (Rs.)",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle
                { Format = "N2", Alignment = DataGridViewContentAlignment.MiddleRight },
                SortMode = DataGridViewColumnSortMode.Automatic
            });
            dgvMenuItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Status",
                Width = 120,
                SortMode = DataGridViewColumnSortMode.Automatic
            });

            dgvMenuItems.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            dgvMenuItems.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMenuItems.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvMenuItems.EnableHeadersVisualStyles = false;
            dgvMenuItems.ColumnHeadersHeight = 38;
        }

        private void SetupFilters()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("All Categories");
            foreach (var cat in Enum.GetValues(typeof(MenuCategoryEnum)))
                cmbCategory.Items.Add(cat);
            cmbCategory.SelectedIndex = 0;

            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("All Status");
            foreach (var st in Enum.GetValues(typeof(MenuItemStatusEnum)))
                cmbStatus.Items.Add(st);
            cmbStatus.SelectedIndex = 0;
        }

        private async void LoadDataAsync()
        {
            try
            {
                SetLoadingState(true);
                List<FoodItem> items = await _service.GetAllAsync();
                ApplyFilter(items);
                _mainForm.UpdateStatusBar("Menu Items", items.Count, "Data loaded");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading menu items:\n{ex.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SetLoadingState(false);
            }
        }

        private void SetLoadingState(bool isLoading)
        {
            lblLoading.Visible = isLoading;
            toolStrip.Enabled = !isLoading;
            dgvMenuItems.Enabled = !isLoading;
            txtSearch.Enabled = !isLoading;
            cmbCategory.Enabled = !isLoading;
            cmbStatus.Enabled = !isLoading;
        }

        private void ApplyFilter(List<FoodItem> allItems = null)
        {
            string searchText = txtSearch.Text.Trim();

            MenuCategoryEnum? selectedCategory = null;
            if (cmbCategory.SelectedItem is MenuCategoryEnum cat)
                selectedCategory = cat;

            MenuItemStatusEnum? selectedStatus = null;
            if (cmbStatus.SelectedItem is MenuItemStatusEnum st)
                selectedStatus = st;

            var results = _service.Search(searchText, selectedCategory, selectedStatus);
            _bindingSource.DataSource = results;
            lblCount.Text = $"Showing {results.Count} item(s)";
            _mainForm.UpdateStatusBar("Menu Items", results.Count, lblLastAction.Text);
        }

        private void MenuItemView_Load(object sender, EventArgs e)
        {
            LoadDataAsync();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            using (var form = new MenuItemForm(MenuItemFormModeEnum.Add, null, _service))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SetLastAction("Item added");
                    LoadDataAsync();
                }
            }
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            FoodItem selected = _bindingSource.Current as FoodItem;
            if (selected == null)
            {
                MessageBox.Show("Please select a menu item to edit.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var form = new MenuItemForm(MenuItemFormModeEnum.Edit, selected, _service))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SetLastAction($"'{selected.Name}' updated");
                    LoadDataAsync();
                }
            }
        }

        private void tsbView_Click(object sender, EventArgs e)
        {
            FoodItem selected = _bindingSource.Current as FoodItem;
            if (selected == null)
            {
                MessageBox.Show("Please select a menu item to view.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var form = new MenuItemForm(MenuItemFormModeEnum.View, selected, _service))
                form.ShowDialog();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            FoodItem selected = _bindingSource.Current as FoodItem;
            if (selected == null)
            {
                MessageBox.Show("Please select a menu item to delete.",
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
                    bool deleted = _service.Delete(selected.Id);
                    if (deleted)
                    {
                        SetLastAction($"'{selected.Name}' deleted");
                        LoadDataAsync();
                    }
                    else
                    {
                        MessageBox.Show("Item could not be deleted.",
                            "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting item:\n{ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            cmbCategory.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            SetLastAction("Refreshed");
            LoadDataAsync();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) => ApplyFilter();
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilter();
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilter();

        private void dgvMenuItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                tsbView_Click(sender, e);
        }

        private void SetLastAction(string action)
        {
            lblLastAction.Text = action;
            _mainForm.UpdateStatusBar("Menu Items", _bindingSource.Count, action);
        }
    }
}