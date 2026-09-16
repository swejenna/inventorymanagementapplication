namespace InventorySystem_JennaHall
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            partsLabel = new Label();
            textPartSearch = new TextBox();
            btnPartSearch = new Button();
            dgvParts = new DataGridView();
            btnAddPart = new Button();
            btnModPart = new Button();
            btnDelPart = new Button();
            dgvProducts = new DataGridView();
            productsLabel = new Label();
            textProductSearch = new TextBox();
            btnProductSearch = new Button();
            btnAddProduct = new Button();
            btnModProduct = new Button();
            btnDelProduct = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Franklin Gothic Medium Cond", 18.3396225F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(12, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(315, 34);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Inventory Management System";
            // 
            // partsLabel
            // 
            partsLabel.AutoSize = true;
            partsLabel.Font = new Font("Franklin Gothic Book", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 0);
            partsLabel.Location = new Point(24, 83);
            partsLabel.Name = "partsLabel";
            partsLabel.Size = new Size(55, 23);
            partsLabel.TabIndex = 1;
            partsLabel.Text = "Parts";
            // 
            // textPartSearch
            // 
            textPartSearch.Location = new Point(263, 86);
            textPartSearch.Name = "textPartSearch";
            textPartSearch.Size = new Size(198, 22);
            textPartSearch.TabIndex = 2;
            // 
            // btnPartSearch
            // 
            btnPartSearch.Location = new Point(467, 83);
            btnPartSearch.Name = "btnPartSearch";
            btnPartSearch.Size = new Size(83, 25);
            btnPartSearch.TabIndex = 3;
            btnPartSearch.Text = "Search Parts";
            btnPartSearch.UseVisualStyleBackColor = true;
            btnPartSearch.Click += btnPartSearch_Click;
            // 
            // dgvParts
            // 
            dgvParts.AllowUserToAddRows = false;
            dgvParts.AllowUserToDeleteRows = false;
            dgvParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParts.Location = new Point(24, 149);
            dgvParts.MultiSelect = false;
            dgvParts.Name = "dgvParts";
            dgvParts.ReadOnly = true;
            dgvParts.RowHeadersWidth = 45;
            dgvParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParts.Size = new Size(526, 225);
            dgvParts.TabIndex = 4;
            // 
            // btnAddPart
            // 
            btnAddPart.Location = new Point(244, 380);
            btnAddPart.Name = "btnAddPart";
            btnAddPart.Size = new Size(83, 25);
            btnAddPart.TabIndex = 5;
            btnAddPart.Text = "Add";
            btnAddPart.UseVisualStyleBackColor = true;
            btnAddPart.Click += btnAddPart_Click;
            // 
            // btnModPart
            // 
            btnModPart.Location = new Point(358, 380);
            btnModPart.Name = "btnModPart";
            btnModPart.Size = new Size(83, 25);
            btnModPart.TabIndex = 6;
            btnModPart.Text = "Modify";
            btnModPart.UseVisualStyleBackColor = true;
            btnModPart.Click += btnModPart_Click;
            // 
            // btnDelPart
            // 
            btnDelPart.Location = new Point(467, 380);
            btnDelPart.Name = "btnDelPart";
            btnDelPart.Size = new Size(83, 25);
            btnDelPart.TabIndex = 7;
            btnDelPart.Text = "Delete";
            btnDelPart.UseVisualStyleBackColor = true;
            btnDelPart.Click += btnDelPart_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(635, 149);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 45;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(526, 225);
            dgvProducts.TabIndex = 8;
            // 
            // productsLabel
            // 
            productsLabel.AutoSize = true;
            productsLabel.Font = new Font("Franklin Gothic Book", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productsLabel.Location = new Point(635, 83);
            productsLabel.Name = "productsLabel";
            productsLabel.Size = new Size(85, 23);
            productsLabel.TabIndex = 9;
            productsLabel.Text = "Products";
            // 
            // textProductSearch
            // 
            textProductSearch.Location = new Point(782, 83);
            textProductSearch.Name = "textProductSearch";
            textProductSearch.Size = new Size(198, 22);
            textProductSearch.TabIndex = 10;
            // 
            // btnProductSearch
            // 
            btnProductSearch.Location = new Point(986, 81);
            btnProductSearch.Name = "btnProductSearch";
            btnProductSearch.Size = new Size(83, 25);
            btnProductSearch.TabIndex = 11;
            btnProductSearch.Text = "Search Products";
            btnProductSearch.UseVisualStyleBackColor = true;
            btnProductSearch.Click += btnProductSearch_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(867, 380);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(83, 25);
            btnAddProduct.TabIndex = 12;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnModProduct
            // 
            btnModProduct.Location = new Point(974, 380);
            btnModProduct.Name = "btnModProduct";
            btnModProduct.Size = new Size(83, 25);
            btnModProduct.TabIndex = 13;
            btnModProduct.Text = "Modify";
            btnModProduct.UseVisualStyleBackColor = true;
            btnModProduct.Click += btnModProduct_Click;
            // 
            // btnDelProduct
            // 
            btnDelProduct.Location = new Point(1078, 380);
            btnDelProduct.Name = "btnDelProduct";
            btnDelProduct.Size = new Size(83, 25);
            btnDelProduct.TabIndex = 14;
            btnDelProduct.Text = "Delete";
            btnDelProduct.UseVisualStyleBackColor = true;
            btnDelProduct.Click += btnDelProduct_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1078, 547);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(83, 25);
            btnExit.TabIndex = 15;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 626);
            Controls.Add(btnExit);
            Controls.Add(btnDelProduct);
            Controls.Add(btnModProduct);
            Controls.Add(btnAddProduct);
            Controls.Add(btnProductSearch);
            Controls.Add(textProductSearch);
            Controls.Add(productsLabel);
            Controls.Add(dgvProducts);
            Controls.Add(btnDelPart);
            Controls.Add(btnModPart);
            Controls.Add(btnAddPart);
            Controls.Add(dgvParts);
            Controls.Add(btnPartSearch);
            Controls.Add(textPartSearch);
            Controls.Add(partsLabel);
            Controls.Add(titleLabel);
            Font = new Font("Times New Roman", 8.830189F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "MainForm";
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)dgvParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label partsLabel;
        private TextBox textPartSearch;
        private Button btnPartSearch;
        private DataGridView dgvParts;
        private Button btnAddPart;
        private Button btnModPart;
        private Button btnDelPart;
        private DataGridView dgvProducts;
        private Label productsLabel;
        private TextBox textProductSearch;
        private Button btnProductSearch;
        private Button btnAddProduct;
        private Button btnModProduct;
        private Button btnDelProduct;
        private Button btnExit;
    }
}
