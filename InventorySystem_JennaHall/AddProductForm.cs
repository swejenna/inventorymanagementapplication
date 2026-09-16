using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventorySystem_JennaHall
{
    public partial class AddProductForm : Form
    {
        private Inventory inventory;
        private BindingList<Part> associatedParts = new BindingList<Part>();

        public AddProductForm(Inventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory;
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            dgvAllParts.DataSource = inventory.AllParts;
            dgvAssociatedParts.DataSource = associatedParts;
            // remember to create the getnextproductid for products
            textProductID.Text = GetNextProductId().ToString();
        }

        private int GetNextProductId()
        {
            if (inventory.Products.Count == 0)
            {
                return 1;
            }

            return inventory.Products.Max(p => p.ProductID) + 1;
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
            Part part = associatedParts.FirstOrDefault(p => p.PartID == partId);

            if (part != null)
            {
                associatedParts.Remove(part);
            }
        }

        private void saveProductBtn_Click(object sender, EventArgs e)
        {
            //convert inventroy text to int, verify whole  number
            if (!int.TryParse(textProductInventory.Text, out int inventoryVal))
            {
                //messagebox info - https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.messageboxicon?view=windowsdesktop-10.0
                MessageBox.Show("Inventory value mist be a whole number.", "Invalid Inventory.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //check price- can have decimal vals
            if (!decimal.TryParse(textProductPrice.Text, out decimal price))
            {
                MessageBox.Show("Price must be a valid number.", "Invalid Price.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //check min inventory val is whole num
            if (!int.TryParse(textProductMin.Text, out int min))
            {
                MessageBox.Show("Min value must be a whole number.", "Invalid Min.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //check max inventory val is whole num
            if (!int.TryParse(textProductMax.Text, out int max))
            {
                MessageBox.Show("Max value must be a whole number.", "Invalid Max.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //min less than max check
            if (min >= max)
            {
                MessageBox.Show("Min value must be less than Max.", "Invalid Min/Max.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //inventory in range check

            if ((inventoryVal < min || inventoryVal > max))
            {
                MessageBox.Show("Inventory value must be between Min and Max.", "Invalid Inventory.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //create new product
            Product product = new Product
            {
                ProductID = int.Parse(textProductID.Text),
                Name = textProductName.Text,
                InStock = inventoryVal,
                Price = price,
                Min = min,
                Max = max
            };
            //add associated parts to product
            foreach (Part part in associatedParts)
            {
                //addAssociatedPart method
                product.addAssociatedPart(part);
            }

            //add product to inventory (addProduct method from inventory)
            inventory.addProduct(product);

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
