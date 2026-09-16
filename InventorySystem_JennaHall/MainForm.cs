namespace InventorySystem_JennaHall
{
    public partial class MainForm : Form
    {
        private Inventory inventory = new Inventory();

        public MainForm()
        {
            InitializeComponent();
            dgvParts.DataSource = inventory.AllParts;
            dgvProducts.DataSource = inventory.Products;
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            //open AddPartForm
            AddPartForm form = new AddPartForm(inventory);
            form.ShowDialog();
        }

        private void btnModPart_Click(object sender, EventArgs e)
        {
            //check if row is selected 
            if (dgvParts.CurrentRow == null)
            {
                MessageBox.Show("Please select a part to modify.");
                return;
            }
            //get part id
            int partId = Convert.ToInt32(dgvParts.CurrentRow.Cells["PartID"].Value);
            //lookup part in inventory
            Part selectedPart = inventory.lookupPart(partId);
            //pass + open part data in ModifyPartForm
            if (selectedPart != null)
            {
                //REMEMBER ******* you suck at remembering jenna****** add params to ModifyPartForm construct to pass inventory and selectedPArt
                ModifyPartForm form = new ModifyPartForm(inventory, selectedPart);
                form.ShowDialog();
            }

        }

        private void btnDelPart_Click(object sender, EventArgs e)
        {
            //select part -> find part -> is associated with prod? Y -> refuse delete N -> confirm delete -> Y -> delete (deletePart()) N -> cancel delete
            //check if row is selected
            if (dgvParts.CurrentRow == null)
            {
                MessageBox.Show("Please select a part to delete.");
                return;
            }

            int partId = Convert.ToInt32(dgvParts.CurrentRow.Cells["PartID"].Value);
            Part selectedPart = inventory.lookupPart(partId);

            //is associated with product?
            if (selectedPart != null) 
            {
                bool isAssociated = inventory.Products.Any(p => p.AssociatedParts.Contains(selectedPart));
                if (isAssociated)
                {
                    MessageBox.Show("This part is associated with a product and cannot be deleted.");
                    return;
                }
                //confirm delete
                DialogResult result = MessageBox.Show("Are you sure you want to delete this part?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    inventory.deletePart(partId);
                    dgvParts.DataSource = inventory.AllParts;
                }
            }


        }

        private void btnPartSearch_Click(object sender, EventArgs e)
        {
            string searchWord = textPartSearch.Text.Trim();
            //check string and return all parts if empty
            if (string.IsNullOrEmpty(searchWord))
            {
                dgvParts.DataSource = inventory.AllParts;
                return;
            }
            //case insensitive search for part name
            var results = inventory.AllParts.Where(p => p.Name.Contains(searchWord, StringComparison.OrdinalIgnoreCase)).ToList();

            dgvParts.DataSource = results;

        }

        //same as parts but for products

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm form = new AddProductForm(inventory);
            form.ShowDialog();
        }

        private void btnModProduct_Click(object sender, EventArgs e)
        {
            //same as parts but for products
            if (dgvProducts.CurrentRow == null)
            {
                MessageBox.Show("Please select a product to modify.");
                return;
            }

            int productId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["ProductID"].Value);
            Product selectedProduct = inventory.lookupProduct(productId);

            if (selectedProduct != null)
            {
                //remember to update this as well to pass inventory and selectedProduct to ModifyProductForm
                ModifyProductForm form = new ModifyProductForm(inventory, selectedProduct);
                form.ShowDialog();
            }
        }

        private void btnDelProduct_Click(object sender, EventArgs e)
        {
            //same as parts but for products
            //select part -> find part -> is associated with prod? Y -> refuse delete N -> confirm delete -> Y -> delete (deletePart()) N -> cancel delete
            if (dgvProducts.CurrentRow == null)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            int productId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["ProductID"].Value);
            Product selectedProduct = inventory.lookupProduct(productId);

            if (selectedProduct != null) 
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    inventory.removeProduct(productId);
                    dgvProducts.DataSource = inventory.Products;
                }
            }

        }

        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            string searchWord = textProductSearch.Text.Trim();
            //check string and return all parts if empty
            if (string.IsNullOrEmpty(searchWord))
            {
                dgvProducts.DataSource = inventory.Products;
                return;
            }
            //case insensitive search for part name
            var results = inventory.Products.Where(p => p.Name.Contains(searchWord, StringComparison.OrdinalIgnoreCase)).ToList();

            dgvProducts.DataSource = results;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
