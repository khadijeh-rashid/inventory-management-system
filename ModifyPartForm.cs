using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KhadijehRashid_C968
{
    public partial class ModifyPartForm : Form
    {
        private Part part;
        private Inventory inventory;
        public ModifyPartForm(Part part, Inventory inventory)
        {
            InitializeComponent();
            this.part = part;
            this.inventory = inventory;
        }

        private void ModifyPartForm_Load(object sender, EventArgs e)
        {
            txtPartID.Text = part.PartID.ToString();
            txtPartName.Text = part.Name;
            txtInventory.Text = part.InStock.ToString();
            txtPrice.Text = part.Price.ToString();
            txtMin.Text = part.Min.ToString();
            txtMax.Text = part.Max.ToString();

            if (part is Inhouse inhousePart)
            {
                rdoInHouse.Checked = true;
                lblMachineID.Text = "Machine ID";
                txtMachineID.Text = inhousePart.MachineID.ToString();
            }
            else if (part is Outsourced outsourcedPart)
            {
                rdoOutsourced.Checked = true;
                lblMachineID.Text = "Company Name";
                txtMachineID.Text = outsourcedPart.CompanyName;
            }
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

            if (rdoInHouse.Checked)
            {
                int machineID;

                if (!int.TryParse(txtMachineID.Text, out machineID))
                {
                    MessageBox.Show("Please enter a valid Machine ID.");
                    return;
                }

                Inhouse updatedPart = new Inhouse();

                updatedPart.PartID = part.PartID;
                updatedPart.Name = name;
                updatedPart.InStock = inStock;
                updatedPart.Price = price;
                updatedPart.Min = min;
                updatedPart.Max = max;
                updatedPart.MachineID = machineID;

                inventory.UpdatePart(updatedPart);
            }
            else if (rdoOutsourced.Checked)
            {
                string companyName = txtMachineID.Text;

                if (string.IsNullOrWhiteSpace(companyName))
                {
                    MessageBox.Show("Please enter a company name.");
                    return;
                }

                Outsourced updatedPart = new Outsourced();

                updatedPart.PartID = part.PartID;
                updatedPart.Name = name;
                updatedPart.InStock = inStock;
                updatedPart.Price = price;
                updatedPart.Min = min;
                updatedPart.Max = max;
                updatedPart.CompanyName = companyName;

                inventory.UpdatePart(updatedPart);
            }

            this.Close();
        }

        private void btnCancelPart_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
