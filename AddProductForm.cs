using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KhadijehRashid_C968
{
    public partial class AddProductForm : Form
    {
        private Inventory inventory;

        private Product product;
        public AddProductForm(Inventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory;

            product = new Product();

            dataGridViewCandidateParts.DataSource = inventory.AllParts;
            dataGridViewAssociatedParts.DataSource = product.AssociatedParts;

            int nextProductID = 1;

            foreach (Product existingProduct in inventory.Products)
            {
                if (existingProduct.ProductID >= nextProductID)
                {
                    nextProductID = existingProduct.ProductID + 1;
                }
            }

            txtProductID.Text = nextProductID.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dataGridViewCandidateParts.CurrentRow == null)
            {
                MessageBox.Show("Please select a part to add.");
                return;
            }

            Part selectedPart = dataGridViewCandidateParts.CurrentRow.DataBoundItem as Part;

            if (selectedPart == null)
            {
                MessageBox.Show("Please select a valid part.");
                return;
            }

            if (product.LookupAssociatedPart(selectedPart.PartID) != null)
            {
                MessageBox.Show("This part is already associated with the product.");
                return;
            }

            product.AddAssociatedPart(selectedPart);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAssociatedParts.CurrentRow == null)
            {
                MessageBox.Show("Please select a part to remove.");
                return;
            }

            Part selectedPart = dataGridViewAssociatedParts.CurrentRow.DataBoundItem as Part;

            if (selectedPart == null)
            {
                MessageBox.Show("Please select a valid part.");
                return;
            }

            product.RemoveAssociatedPart(selectedPart);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtProductName.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a product name.");
                return;
            }

            int inStock;

            if (!int.TryParse(txtProductInventory.Text, out inStock))
            {
                MessageBox.Show("Please enter a valid inventory number.");
                return;
            }

            decimal price;

            if (!decimal.TryParse(txtProductPrice.Text, out price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            int min;

            if (!int.TryParse(txtProductMin.Text, out min))
            {
                MessageBox.Show("Please enter a valid minimum number.");
                return;
            }

            int max;

            if (!int.TryParse(txtProductMax.Text, out max))
            {
                MessageBox.Show("Please enter a valid maximum number.");
                return;
            }

            if (min > max)
            {
                MessageBox.Show("Minimum cannot be greater than maximum.");
                return;
            }

            if (inStock < min || inStock > max)
            {
                MessageBox.Show("Inventory must be between the minimum and maximum.");
                return;
            }

            product.ProductID = int.Parse(txtProductID.Text);
            product.Name = name;
            product.InStock = inStock;
            product.Price = price;
            product.Min = min;
            product.Max = max;

            inventory.AddProduct(product);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchCandidateParts_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchCandidateParts.Text.Trim();

            foreach (Part part in inventory.AllParts)
            {
                if (part.PartID.ToString() == searchText ||
                    part.Name.Equals(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    int rowIndex = inventory.AllParts.IndexOf(part);

                    dataGridViewCandidateParts.CurrentCell =
                        dataGridViewCandidateParts.Rows[rowIndex].Cells[0];

                    dataGridViewCandidateParts.Rows[rowIndex].Selected = true;

                    return;
                }
            }

            MessageBox.Show("Part not found.");
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
