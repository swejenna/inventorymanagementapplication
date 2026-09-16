namespace InventorySystem_JennaHall
{
    partial class ModifyProductForm
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
            cancelProductBtn = new Button();
            saveProductBtn = new Button();
            deleteAssPartBtn = new Button();
            addAssPartBtn = new Button();
            textPartSearch = new TextBox();
            partSearchBtn = new Button();
            associatedPartsLabel = new Label();
            allPartsLabel = new Label();
            dgvAssociatedParts = new DataGridView();
            dgvAllParts = new DataGridView();
            textProductMin = new TextBox();
            textProductMax = new TextBox();
            textProductPrice = new TextBox();
            textProductInventory = new TextBox();
            textProductName = new TextBox();
            textProductID = new TextBox();
            productMinLabel = new Label();
            productMaxLabel = new Label();
            productPriceLabel = new Label();
            productInventoryLabel = new Label();
            productNameLabel = new Label();
            modifyProductTitleLabel = new Label();
            productIDLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAssociatedParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAllParts).BeginInit();
            SuspendLayout();
            // 
            // cancelProductBtn
            // 
            cancelProductBtn.Location = new Point(1073, 589);
            cancelProductBtn.Name = "cancelProductBtn";
            cancelProductBtn.Size = new Size(83, 25);
            cancelProductBtn.TabIndex = 44;
            cancelProductBtn.Text = "Cancel";
            cancelProductBtn.UseVisualStyleBackColor = true;
            cancelProductBtn.Click += cancelProductBtn_Click;
            // 
            // saveProductBtn
            // 
            saveProductBtn.Location = new Point(954, 589);
            saveProductBtn.Name = "saveProductBtn";
            saveProductBtn.Size = new Size(83, 25);
            saveProductBtn.TabIndex = 43;
            saveProductBtn.Text = "Save";
            saveProductBtn.UseVisualStyleBackColor = true;
            saveProductBtn.Click += saveProductBtn_Click;
            // 
            // deleteAssPartBtn
            // 
            deleteAssPartBtn.Location = new Point(1089, 530);
            deleteAssPartBtn.Name = "deleteAssPartBtn";
            deleteAssPartBtn.Size = new Size(83, 25);
            deleteAssPartBtn.TabIndex = 42;
            deleteAssPartBtn.Text = "Delete";
            deleteAssPartBtn.UseVisualStyleBackColor = true;
            deleteAssPartBtn.Click += deleteAssPartBtn_Click;
            // 
            // addAssPartBtn
            // 
            addAssPartBtn.Location = new Point(1089, 287);
            addAssPartBtn.Name = "addAssPartBtn";
            addAssPartBtn.Size = new Size(83, 25);
            addAssPartBtn.TabIndex = 41;
            addAssPartBtn.Text = "Add";
            addAssPartBtn.UseVisualStyleBackColor = true;
            addAssPartBtn.Click += addAssPartBtn_Click;
            // 
            // textPartSearch
            // 
            textPartSearch.Location = new Point(994, 74);
            textPartSearch.Name = "textPartSearch";
            textPartSearch.Size = new Size(178, 25);
            textPartSearch.TabIndex = 40;
            // 
            // partSearchBtn
            // 
            partSearchBtn.Location = new Point(905, 73);
            partSearchBtn.Name = "partSearchBtn";
            partSearchBtn.Size = new Size(83, 25);
            partSearchBtn.TabIndex = 39;
            partSearchBtn.Text = "Search";
            partSearchBtn.UseVisualStyleBackColor = true;
            partSearchBtn.Click += partSearchBtn_Click;
            // 
            // associatedPartsLabel
            // 
            associatedPartsLabel.AutoSize = true;
            associatedPartsLabel.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold);
            associatedPartsLabel.Location = new Point(555, 335);
            associatedPartsLabel.Name = "associatedPartsLabel";
            associatedPartsLabel.Size = new Size(271, 20);
            associatedPartsLabel.TabIndex = 38;
            associatedPartsLabel.Text = "Parts associated with this Product";
            // 
            // allPartsLabel
            // 
            allPartsLabel.AutoSize = true;
            allPartsLabel.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold);
            allPartsLabel.Location = new Point(555, 87);
            allPartsLabel.Name = "allPartsLabel";
            allPartsLabel.Size = new Size(157, 20);
            allPartsLabel.TabIndex = 37;
            allPartsLabel.Text = "All candidate Parts";
            // 
            // dgvAssociatedParts
            // 
            dgvAssociatedParts.AllowUserToAddRows = false;
            dgvAssociatedParts.AllowUserToDeleteRows = false;
            dgvAssociatedParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAssociatedParts.Location = new Point(555, 358);
            dgvAssociatedParts.MultiSelect = false;
            dgvAssociatedParts.Name = "dgvAssociatedParts";
            dgvAssociatedParts.ReadOnly = true;
            dgvAssociatedParts.RowHeadersWidth = 45;
            dgvAssociatedParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssociatedParts.Size = new Size(617, 166);
            dgvAssociatedParts.TabIndex = 36;
            // 
            // dgvAllParts
            // 
            dgvAllParts.AllowUserToAddRows = false;
            dgvAllParts.AllowUserToDeleteRows = false;
            dgvAllParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllParts.Location = new Point(555, 115);
            dgvAllParts.MultiSelect = false;
            dgvAllParts.Name = "dgvAllParts";
            dgvAllParts.ReadOnly = true;
            dgvAllParts.RowHeadersWidth = 45;
            dgvAllParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllParts.Size = new Size(617, 166);
            dgvAllParts.TabIndex = 35;
            // 
            // textProductMin
            // 
            textProductMin.Location = new Point(306, 291);
            textProductMin.Name = "textProductMin";
            textProductMin.Size = new Size(64, 25);
            textProductMin.TabIndex = 34;
            // 
            // textProductMax
            // 
            textProductMax.Location = new Point(161, 291);
            textProductMax.Name = "textProductMax";
            textProductMax.Size = new Size(65, 25);
            textProductMax.TabIndex = 33;
            // 
            // textProductPrice
            // 
            textProductPrice.Location = new Point(161, 245);
            textProductPrice.Name = "textProductPrice";
            textProductPrice.Size = new Size(209, 25);
            textProductPrice.TabIndex = 32;
            // 
            // textProductInventory
            // 
            textProductInventory.Font = new Font("Segoe UI", 8.830189F);
            textProductInventory.Location = new Point(161, 193);
            textProductInventory.Name = "textProductInventory";
            textProductInventory.Size = new Size(209, 25);
            textProductInventory.TabIndex = 31;
            // 
            // textProductName
            // 
            textProductName.Location = new Point(161, 138);
            textProductName.Name = "textProductName";
            textProductName.Size = new Size(209, 25);
            textProductName.TabIndex = 30;
            // 
            // textProductID
            // 
            textProductID.Enabled = false;
            textProductID.Location = new Point(161, 87);
            textProductID.Name = "textProductID";
            textProductID.ReadOnly = true;
            textProductID.Size = new Size(209, 25);
            textProductID.TabIndex = 29;
            // 
            // productMinLabel
            // 
            productMinLabel.AutoSize = true;
            productMinLabel.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold);
            productMinLabel.Location = new Point(246, 296);
            productMinLabel.Name = "productMinLabel";
            productMinLabel.Size = new Size(41, 20);
            productMinLabel.TabIndex = 28;
            productMinLabel.Text = "Min";
            // 
            // productMaxLabel
            // 
            productMaxLabel.AutoSize = true;
            productMaxLabel.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold);
            productMaxLabel.Location = new Point(57, 292);
            productMaxLabel.Name = "productMaxLabel";
            productMaxLabel.Size = new Size(44, 20);
            productMaxLabel.TabIndex = 27;
            productMaxLabel.Text = "Max";
            // 
            // productPriceLabel
            // 
            productPriceLabel.AutoSize = true;
            productPriceLabel.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold);
            productPriceLabel.Location = new Point(59, 245);
            productPriceLabel.Name = "productPriceLabel";
            productPriceLabel.Size = new Size(48, 20);
            productPriceLabel.TabIndex = 26;
            productPriceLabel.Text = "Price";
            // 
            // productInventoryLabel
            // 
            productInventoryLabel.AutoSize = true;
            productInventoryLabel.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold);
            productInventoryLabel.Location = new Point(59, 193);
            productInventoryLabel.Name = "productInventoryLabel";
            productInventoryLabel.Size = new Size(85, 20);
            productInventoryLabel.TabIndex = 25;
            productInventoryLabel.Text = "Inventory";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold);
            productNameLabel.Location = new Point(59, 138);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(54, 20);
            productNameLabel.TabIndex = 24;
            productNameLabel.Text = "Name";
            // 
            // modifyProductTitleLabel
            // 
            modifyProductTitleLabel.AutoSize = true;
            modifyProductTitleLabel.Font = new Font("Franklin Gothic Medium Cond", 18.3396225F);
            modifyProductTitleLabel.Location = new Point(38, 25);
            modifyProductTitleLabel.Name = "modifyProductTitleLabel";
            modifyProductTitleLabel.Size = new Size(162, 34);
            modifyProductTitleLabel.TabIndex = 23;
            modifyProductTitleLabel.Text = "Modify Product";
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold);
            productIDLabel.Location = new Point(72, 87);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new Size(29, 20);
            productIDLabel.TabIndex = 45;
            productIDLabel.Text = "ID";
            // 
            // ModifyProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 626);
            Controls.Add(productIDLabel);
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
            Controls.Add(modifyProductTitleLabel);
            Name = "ModifyProductForm";
            Text = "Product";
            ((System.ComponentModel.ISupportInitialize)dgvAssociatedParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAllParts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelProductBtn;
        private Button saveProductBtn;
        private Button deleteAssPartBtn;
        private Button addAssPartBtn;
        private TextBox textPartSearch;
        private Button partSearchBtn;
        private Label associatedPartsLabel;
        private Label allPartsLabel;
        private DataGridView dgvAssociatedParts;
        private DataGridView dgvAllParts;
        private TextBox textProductMin;
        private TextBox textProductMax;
        private TextBox textProductPrice;
        private TextBox textProductInventory;
        private TextBox textProductName;
        private TextBox textProductID;
        private Label productMinLabel;
        private Label productMaxLabel;
        private Label productPriceLabel;
        private Label productInventoryLabel;
        private Label productNameLabel;
        private Label modifyProductTitleLabel;
        private Label productIDLabel;
    }
}