using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KhadijehRashid_C968
{
    public partial class AddPartForm : Form
    {
        private Inventory inventory;
        public AddPartForm(Inventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory;
        }

        private void rdoInHouse_CheckedChanged(object sender, EventArgs e)
        {
            lblMachineID.Text = "Machine ID";
            txtMachineID.Clear();
        }

        private void rdoOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            lblMachineID.Text = "Company Name";
            txtMachineID.Clear();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddPartForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSavePart_Click(object sender, EventArgs e)
        {
            string name = txtPartName.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a part name.");
                return;
            }

            int inStock;

            if (!int.TryParse(txtInventory.Text, out inStock))
            {
                MessageBox.Show("Please enter a valid inventory number.");
                return;
            }

            decimal price;

            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            int min;

            if (!int.TryParse(txtMin.Text, out min))
            {
                MessageBox.Show("Please enter a valid minimum number.");
                return;
            }

            int max;

            if (!int.TryParse(txtMax.Text, out max))
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

            int nextPartID = 1;

            foreach (Part existingPart in inventory.AllParts)
            {
                if (existingPart.PartID >= nextPartID)
                {
                    nextPartID = existingPart.PartID + 1;
                }
            }

            if (rdoInHouse.Checked)
            {
                int machineID;

                if (!int.TryParse(txtMachineID.Text, out machineID))
                {
                    MessageBox.Show("Please enter a valid Machine ID.");
                    return;
                }

                Inhouse part = new Inhouse();

                part.PartID = nextPartID;
                part.Name = name;
                part.InStock = inStock;
                part.Price = price;
                part.Min = min;
                part.Max = max;
                part.MachineID = machineID;

                inventory.AddPart(part);
            }
            else
            {
                string companyName = txtMachineID.Text;

                if (string.IsNullOrWhiteSpace(companyName))
                {
                    MessageBox.Show("Please enter a company name.");
                    return;
                }

                Outsourced part = new Outsourced();

                part.PartID = nextPartID;
                part.Name = name;
                part.InStock = inStock;
                part.Price = price;
                part.Min = min;
                part.Max = max;
                part.CompanyName = companyName;

                inventory.AddPart(part);
            }

            this.Close();
        }

        private void btnCancelPart_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
