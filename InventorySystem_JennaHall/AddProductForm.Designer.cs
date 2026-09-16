namespace InventorySystem_JennaHall
{
    partial class AddProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addProductTitleLabel = new Label();
            productIDLabel = new Label();
            productNameLabel = new Label();
            productInventoryLabel = new Label();
            productPriceLabel = new Label();
            productMaxLabel = new Label();
            productMinLabel = new Label();
            textProductID = new TextBox();
            textProductName = new TextBox();
            textProductInventory = new TextBox();
            textProductPrice = new TextBox();
            textProductMax = new TextBox();
            textProductMin = new TextBox();
            dgvAllParts = new DataGridView();
            dgvAssociatedParts = new DataGridView();
            allPartsLabel = new Label();
            associatedPartsLabel = new Label();
            partSearchBtn = new Button();
            textPartSearch = new TextBox();
            addAssPartBtn = new Button();
            deleteAssPartBtn = new Button();
            saveProductBtn = new Button();
            cancelProductBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAllParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAssociatedParts).BeginInit();
            SuspendLayout();
            // 
            // addProductTitleLabel
            // 
            addProductTitleLabel.AutoSize = true;
            addProductTitleLabel.Font = new Font("Franklin Gothic Medium Cond", 18.3396225F);
            addProductTitleLabel.Location = new Point(38, 25);
            addProductTitleLabel.Name = "addProductTitleLabel";
            addProductTitleLabel.Size = new Size(134, 34);
            addProductTitleLabel.TabIndex = 0;
            addProductTitleLabel.Text = "Add Product";
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold);
            productIDLabel.Location = new Point(72, 87);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new Size(29, 20);
            productIDLabel.TabIndex = 1;
            productIDLabel.Text = "ID";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold);
            productNameLabel.Location = new Point(70, 136);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(54, 20);
            productNameLabel.TabIndex = 2;
            productNameLabel.Text = "Name";
            // 
            // productInventoryLabel
            // 
            productInventoryLabel.AutoSize = true;
            productInventoryLabel.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold);
            productInventoryLabel.Location = new Point(70, 184);
            productInventoryLabel.Name = "productInventoryLabel";
            productInventoryLabel.Size = new Size(85, 20);
            productInventoryLabel.TabIndex = 3;
            productInventoryLabel.Text = "Inventory";
            // 
            // productPriceLabel
            // 
            productPriceLabel.AutoSize = true;
            productPriceLabel.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold);
            productPriceLabel.Location = new Point(72, 233);
            productPriceLabel.Name = "productPriceLabel";
            productPriceLabel.Size = new Size(48, 20);
            productPriceLabel.TabIndex = 4;
            productPriceLabel.Text = "Price";
            // 
            // productMaxLabel
            // 
            productMaxLabel.AutoSize = true;
            productMaxLabel.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold);
            productMaxLabel.Location = new Point(72, 283);
            productMaxLabel.Name = "productMaxLabel";
            productMaxLabel.Size = new Size(44, 20);
            productMaxLabel.TabIndex = 5;
            productMaxLabel.Text = "Max";
            // 
            // productMinLabel
            // 
            productMinLabel.AutoSize = true;
            productMinLabel.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold);
            productMinLabel.Location = new Point(249, 284);
            productMinLabel.Name = "productMinLabel";
            productMinLabel.Size = new Size(41, 20);
            productMinLabel.TabIndex = 6;
            productMinLabel.Text = "Min";
            // 
            // textProductID
            // 
            textProductID.Enabled = false;
            textProductID.Location = new Point(161, 87);
            textProductID.Name = "textProductID";
            textProductID.ReadOnly = true;
            textProductID.Size = new Size(209, 25);
            textProductID.TabIndex = 7;
            // 
            // textProductName
            // 
            textProductName.Location = new Point(161, 136);
            textProductName.Name = "textProductName";
            textProductName.Size = new Size(209, 25);
            textProductName.TabIndex = 8;
            // 
            // textProductInventory
            // 
            textProductInventory.Font = new Font("Segoe UI", 8.830189F);
            textProductInventory.Location = new Point(161, 184);
            textProductInventory.Name = "textProductInventory";
            textProductInventory.Size = new Size(209, 25);
            textProductInventory.TabIndex = 9;
            // 
            // textProductPrice
            // 
            textProductPrice.Location = new Point(161, 233);
            textProductPrice.Name = "textProductPrice";
            textProductPrice.Size = new Size(209, 25);
            textProductPrice.TabIndex = 10;
            // 
            // textProductMax
            // 
            textProductMax.Location = new Point(161, 282);
            textProductMax.Name = "textProductMax";
            textProductMax.Size = new Size(65, 25);
            textProductMax.TabIndex = 11;
            // 
            // textProductMin
            // 
            textProductMin.Location = new Point(306, 282);
            textProductMin.Name = "textProductMin";
            textProductMin.Size = new Size(64, 25);
            textProductMin.TabIndex = 12;
            // 
            // dgvAllParts
            // 
            dgvAllParts.AllowUserToAddRows = false;
            dgvAllParts.AllowUserToDeleteRows = false;
            dgvAllParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllParts.Location = new Point(568, 87);
            dgvAllParts.MultiSelect = false;
            dgvAllParts.Name = "dgvAllParts";
            dgvAllParts.ReadOnly = true;
            dgvAllParts.RowHeadersWidth = 45;
            dgvAllParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllParts.Size = new Size(604, 166);
            dgvAllParts.TabIndex = 13;
            // 
            // dgvAssociatedParts
            // 
            dgvAssociatedParts.AllowUserToAddRows = false;
            dgvAssociatedParts.AllowUserToDeleteRows = false;
            dgvAssociatedParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAssociatedParts.Location = new Point(568, 330);
            dgvAssociatedParts.MultiSelect = false;
            dgvAssociatedParts.Name = "dgvAssociatedParts";
            dgvAssociatedParts.ReadOnly = true;
            dgvAssociatedParts.RowHeadersWidth = 45;
            dgvAssociatedParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssociatedParts.Size = new Size(604, 166);
            dgvAssociatedParts.TabIndex = 14;
            // 
            // allPartsLabel
            // 
            allPartsLabel.AutoSize = true;
            allPartsLabel.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold);
            allPartsLabel.Location = new Point(568, 50);
            allPartsLabel.Name = "allPartsLabel";
            allPartsLabel.Size = new Size(157, 20);
            allPartsLabel.TabIndex = 15;
            allPartsLabel.Text = "All candidate Parts";
            // 
            // associatedPartsLabel
            // 
            associatedPartsLabel.AutoSize = true;
            associatedPartsLabel.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold);
            associatedPartsLabel.Location = new Point(568, 298);
            associatedPartsLabel.Name = "associatedPartsLabel";
            associatedPartsLabel.Size = new Size(271, 20);
            associatedPartsLabel.TabIndex = 16;
            associatedPartsLabel.Text = "Parts associated with this Product";
            // 
            // partSearchBtn
            // 
            partSearchBtn.Location = new Point(865, 56);
            partSearchBtn.Name = "partSearchBtn";
            partSearchBtn.Size = new Size(83, 25);
            partSearchBtn.TabIndex = 17;
            partSearchBtn.Text = "Search";
            partSearchBtn.UseVisualStyleBackColor = true;
            partSearchBtn.Click += partSearchBtn_Click;
            // 
            // textPartSearch
            // 
            textPartSearch.Location = new Point(966, 56);
            textPartSearch.Name = "textPartSearch";
            textPartSearch.Size = new Size(206, 25);
            textPartSearch.TabIndex = 18;
            // 
            // addAssPartBtn
            // 
            addAssPartBtn.Location = new Point(1089, 259);
            addAssPartBtn.Name = "addAssPartBtn";
            addAssPartBtn.Size = new Size(83, 25);
            addAssPartBtn.TabIndex = 19;
            addAssPartBtn.Text = "Add";
            addAssPartBtn.UseVisualStyleBackColor = true;
            addAssPartBtn.Click += addAssPartBtn_Click;
            // 
            // deleteAssPartBtn
            // 
            deleteAssPartBtn.Location = new Point(1089, 502);
            deleteAssPartBtn.Name = "deleteAssPartBtn";
            deleteAssPartBtn.Size = new Size(83, 25);
            deleteAssPartBtn.TabIndex = 20;
            deleteAssPartBtn.Text = "Delete";
            deleteAssPartBtn.UseVisualStyleBackColor = true;
            deleteAssPartBtn.Click += deleteAssPartBtn_Click;
            // 
            // saveProductBtn
            // 
            saveProductBtn.Location = new Point(966, 577);
            saveProductBtn.Name = "saveProductBtn";
            saveProductBtn.Size = new Size(83, 25);
            saveProductBtn.TabIndex = 21;
            saveProductBtn.Text = "Save";
            saveProductBtn.UseVisualStyleBackColor = true;
            saveProductBtn.Click += saveProductBtn_Click;
            // 
            // cancelProductBtn
            // 
            cancelProductBtn.Location = new Point(1089, 577);
            cancelProductBtn.Name = "cancelProductBtn";
            cancelProductBtn.Size = new Size(83, 25);
            cancelProductBtn.TabIndex = 22;
            cancelProductBtn.Text = "Cancel";
            cancelProductBtn.UseVisualStyleBackColor = true;
            cancelProductBtn.Click += cancelProductBtn_Click;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 626);
            Controls.Add(cancelProductBtn);
            Controls.Add(saveProductBtn);
            Controls.Add(deleteAssPartBtn);
            Controls.Add(addAssPartBtn);
            Controls.Add(textPartSearch);
            Controls.Add(partSearchBtn);
            Controls.Add(associatedPartsLabel);
            Controls.Add(allPartsLabel);
            Controls.Add(dgvAssociatedParts);
            Controls.Add(dgvAllParts);
            Controls.Add(textProductMin);
            Controls.Add(textProductMax);
            Controls.Add(textProductPrice);
            Controls.Add(textProductInventory);
            Controls.Add(textProductName);
            Controls.Add(textProductID);
            Controls.Add(productMinLabel);
            Controls.Add(productMaxLabel);
            Controls.Add(productPriceLabel);
            Controls.Add(productInventoryLabel);
            Controls.Add(productNameLabel);
            Controls.Add(productIDLabel);
            Controls.Add(addProductTitleLabel);
            Name = "AddProductForm";
            Text = "Product";
            Load += AddProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAllParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAssociatedParts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addProductTitleLabel;
        private Label productIDLabel;
        private Label productNameLabel;
        private Label productInventoryLabel;
        private Label productPriceLabel;
        private Label productMaxLabel;
        private Label productMinLabel;
        private TextBox textProductID;
        private TextBox textProductName;
        private TextBox textProductInventory;
        private TextBox textProductPrice;
        private TextBox textProductMax;
        private TextBox textProductMin;
        private DataGridView dgvAllParts;
        private DataGridView dgvAssociatedParts;
        private Label allPartsLabel;
        private Label associatedPartsLabel;
        private Button partSearchBtn;
        private TextBox textPartSearch;
        private Button addAssPartBtn;
        private Button deleteAssPartBtn;
        private Button saveProductBtn;
        private Button cancelProductBtn;
    }
}