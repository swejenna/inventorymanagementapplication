using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventorySystem_JennaHall
{
    public partial class ModifyProductForm : Form
    {
        private Inventory inventory;
        private Product product;
        private BindingList<Part> associatedParts;

        public ModifyProductForm(Inventory inventory, Product product)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.product = product;

            LoadProductData();
        }

        private void LoadProductData()
        {
            textProductID.Text = product.ProductID.ToString();
            textProductName.Text = product.Name;
            textProductInventory.Text = product.InStock.ToString();
            textProductPrice.Text = product.Price.ToString();
            textProductMin.Text = product.Min.ToString();
            textProductMax.Text = product.Max.ToString();

            //get associate parts
            associatedParts = new BindingList<Part>(product.AssociatedParts.ToList());

            //change data source of grid to already associated parts
            dgvAllParts.DataSource = inventory.AllParts;
            dgvAssociatedParts.DataSource = associatedParts;
        }

        private void addAssPartBtn_Click(object sender, EventArgs e)
        {
            if (dgvAllParts.CurrentRow == null)
            {
                MessageBox.Show("Please select a part to add.", "No part selected.");
                return;
            }

            int partID = Convert.ToInt32(dgvAllParts.CurrentRow.Cells["PartID"].Value);
            Part part = inventory.lookupPart(partID);

            if (part != null)
            {
                if (associatedParts.Any(p => p.PartID == part.PartID))
                {
                    MessageBox.Show("This part is already associated with the product.", "Part already associated.");
                    return;
                }

                associatedParts.Add(part);
            }
        }

        private void deleteAssPartBtn_Click(object sender, EventArgs e)
        {
            if (dgvAssociatedParts.CurrentRow == null)
            {
                MessageBox.Show("Please select a part to remove.", "No part selected.");
                return;
            }

            int partId = Convert.ToInt32(dgvAssociatedParts.CurrentRow.Cells["PartID"].Value);
            //First or FirstOrDefault**
            Part part = associatedParts.FirstOrDefault(p => p.PartID == partId);

            if (part != null)
            {
                associatedParts.Remove(part);
            }
        }

        private void saveProductBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textProductInventory.Text, out int inventoryVal) ||
                !decimal.TryParse(textProductPrice.Text, out decimal price) ||
                !int.TryParse(textProductMin.Text, out int min) ||
                !int.TryParse(textProductMax.Text, out int max))
            {
                MessageBox.Show("Please enter valid numeric values for Inventory, Price, Min, and/or Max.", "Invalid Input.");
                return;
            }

            if (min >= max)
            {
                MessageBox.Show("Min value must be less than Max.", "Invalid range.");
                return;
            }

            if (inventoryVal < min || inventoryVal > max)
            {
                MessageBox.Show("Inventory value must be between Min and Max.", "Invalid Inventory.");
                return;
            }

            //save new product info in inventory
            product.Name = textProductName.Text;
            product.InStock = inventoryVal;
            product.Price = price;
            product.Min = min;
            product.Max = max;

            //update associated parts
            //clear
            product.AssociatedParts.Clear();
            //loop through dgv and add to list
            foreach (var part in associatedParts)
            {
                product.AssociatedParts.Add(part);
            }

            //update product in inventory
            inventory.updateProduct(product.ProductID, product);

            Close();

        }

        private void cancelProductBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void partSearchBtn_Click(object sender, EventArgs e)
        {
            string searchWord = textPartSearch.Text.Trim();
            //check string and return all parts if empty
            if (string.IsNullOrEmpty(searchWord))
            {
                dgvAllParts.DataSource = inventory.AllParts;
                return;
            }
            //case insensitive search for part name
            var results = inventory.AllParts.Where(p => p.Name.Contains(searchWord, StringComparison.OrdinalIgnoreCase)).ToList();

            dgvAllParts.DataSource = results;
        }
    }
}