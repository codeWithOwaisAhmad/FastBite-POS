using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App.WindowsApp.Forms
{
    public partial class ProductForm : Form
    {
        public ProductForm(ProductFormModeEnum mode, Product? p)
        {
            
            InitializeComponent();
            nuPrice.Maximum = Decimal.MaxValue;
            nuStock.Maximum = Int32.MaxValue;

            cmbCat.Items.Clear();
            cmbCat.DataSource = Enum.GetValues(typeof(ProductCategoryEnum));
            cmbCat.SelectedIndex = 0;

            cmbProductStatus.Items.Clear();
            cmbProductStatus.DataSource = Enum.GetValues(typeof(ProductStatusEnum));
            cmbProductStatus.SelectedIndex = 0;

            if (mode == ProductFormModeEnum.Edit)
            {
                btnSave.Text = "Update";
            } else if (mode == ProductFormModeEnum.View)
            {
                btnSave.Visible = false;
            }

            if (mode == ProductFormModeEnum.Edit || mode == ProductFormModeEnum.View)
            {
               
                txtId.Text = p.Id;
                txtName.Text = p.Name;
                cmbCat.SelectedItem = p.Category;
                cmbProductStatus.SelectedItem = p.Status;
                nuPrice.Value = p.Price;
                nuStock.Value = p.Stock;
                
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
