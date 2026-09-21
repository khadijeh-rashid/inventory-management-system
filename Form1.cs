namespace KhadijehRashid_C968
{
    public partial class Form1 : Form
    {
        private Inventory inventory = new Inventory();
        public Form1()
        {
            InitializeComponent();

            dataGridViewParts.DataSource = inventory.AllParts;
            dataGridViewProducts.DataSource = inventory.Products;
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            AddPartForm addPartForm = new AddPartForm(inventory);
            addPartForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnModifyPart_Click(object sender, EventArgs e)
        {
            if (dataGridViewParts.CurrentRow == null)
            {
                MessageBox.Show("Please select a valid part.");
                return;
            }

            Part selectedPart = dataGridViewParts.CurrentRow.DataBoundItem as Part;

            if (selectedPart == null)
            {
                MessageBox.Show("Please select a valid part.");
                return;
            }

            ModifyPartForm modifyPartForm = new ModifyPartForm(selectedPart, inventory);
            modifyPartForm.ShowDialog();
        }

        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            if (dataGridViewParts.CurrentRow == null)
            {
                MessageBox.Show("Please select a part to delete");
                return;
            }

            Part selectedPart = dataGridViewParts.CurrentRow.DataBoundItem as Part;

            if (selectedPart == null)
            {
                MessageBox.Show("Please select a valid part.");
                return;
            }

            foreach (Product product in inventory.Products)
            {
                if (product.LookupAssociatedPart(selectedPart.PartID) != null)
                {
                    MessageBox.Show("This part is associated with a product and cannot be deleted");
                    return;
                }
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this part?",
                "Confirm Delete",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                inventory.RemovePart(selectedPart.PartID);
            }
        }

        private void btnSearchParts_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchParts.Text.Trim();

            foreach (Part part in inventory.AllParts)
            {
                if (part.PartID.ToString() == searchText || part.Name.Equals(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    dataGridViewParts.CurrentCell = dataGridViewParts.Rows[inventory.AllParts.IndexOf(part)].Cells[0];
                    dataGridViewParts.Rows[inventory.AllParts.IndexOf(part)].Selected = true;
                    return;
                }
            }

            MessageBox.Show("Part not found.");
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm(inventory);
            addProductForm.ShowDialog();
        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.CurrentRow == null)
            {
                MessageBox.Show("Please select a product to modify.");
                return;
            }

            Product selectedProduct = dataGridViewProducts.CurrentRow.DataBoundItem as Product;

            if (selectedProduct == null)
            {
                MessageBox.Show("Please select a valid product.");
                return;
            }

            ModifyProductForm modifyProductForm =
                new ModifyProductForm(selectedProduct, inventory);

            modifyProductForm.ShowDialog();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.CurrentRow == null)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            Product selectedProduct = dataGridViewProducts.CurrentRow.DataBoundItem as Product;

            if (selectedProduct == null)
            {
                MessageBox.Show("Please select a valid product.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this product?",
                "Confirm Delete",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                inventory.RemoveProduct(selectedProduct.ProductID);
            }
        }

        private void btnSearchProducts_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchProducts.Text.Trim();

            foreach (Product product in inventory.Products)
            {
                if (product.ProductID.ToString() == searchText ||
                    product.Name.Equals(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    int rowIndex = inventory.Products.IndexOf(product);

                    dataGridViewProducts.CurrentCell =
                        dataGridViewProducts.Rows[rowIndex].Cells[0];

                    dataGridViewProducts.Rows[rowIndex].Selected = true;

                    return;
                }
            }

            MessageBox.Show("Product not found.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
