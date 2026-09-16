namespace InventorySystem_JennaHall
{
    partial class AddPartForm
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
            addPartTitleLabel = new Label();
            partIDLabel = new Label();
            textPartID = new TextBox();
            partNameLabel = new Label();
            textPartName = new TextBox();
            partInventoryLabel = new Label();
            partPriceCostLabel = new Label();
            textPartPriceCost = new TextBox();
            partMinLabel = new Label();
            textPartMin = new TextBox();
            partMaxLabel = new Label();
            textPartMax = new TextBox();
            grpPartType = new GroupBox();
            rdoOutSourced = new RadioButton();
            rdoInHouse = new RadioButton();
            machineIDLabel = new Label();
            companyNameLabel = new Label();
            textMachineID = new TextBox();
            textCompanyName = new TextBox();
            btnSavePart = new Button();
            btnCancelPart = new Button();
            textPartInventory = new TextBox();
            grpPartType.SuspendLayout();
            SuspendLayout();
            // 
            // addPartTitleLabel
            // 
            addPartTitleLabel.AutoSize = true;
            addPartTitleLabel.Font = new Font("Franklin Gothic Medium Cond", 18.3396225F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addPartTitleLabel.Location = new Point(12, 12);
            addPartTitleLabel.Name = "addPartTitleLabel";
            addPartTitleLabel.Size = new Size(98, 34);
            addPartTitleLabel.TabIndex = 0;
            addPartTitleLabel.Text = "Add Part";
            // 
            // partIDLabel
            // 
            partIDLabel.AutoSize = true;
            partIDLabel.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 0);
            partIDLabel.Location = new Point(156, 88);
            partIDLabel.Name = "partIDLabel";
            partIDLabel.Size = new Size(29, 20);
            partIDLabel.TabIndex = 1;
            partIDLabel.Text = "ID";
            // 
            // textPartID
            // 
            textPartID.Enabled = false;
            textPartID.Location = new Point(196, 87);
            textPartID.Name = "textPartID";
            textPartID.ReadOnly = true;
            textPartID.Size = new Size(198, 25);
            textPartID.TabIndex = 2;
            // 
            // partNameLabel
            // 
            partNameLabel.AutoSize = true;
            partNameLabel.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold);
            partNameLabel.Location = new Point(131, 132);
            partNameLabel.Name = "partNameLabel";
            partNameLabel.Size = new Size(54, 20);
            partNameLabel.TabIndex = 3;
            partNameLabel.Text = "Name";
            // 
            // textPartName
            // 
            textPartName.Location = new Point(196, 132);
            textPartName.Name = "textPartName";
            textPartName.Size = new Size(198, 25);
            textPartName.TabIndex = 6;
            // 
            // partInventoryLabel
            // 
            partInventoryLabel.AutoSize = true;
            partInventoryLabel.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold);
            partInventoryLabel.Location = new Point(100, 184);
            partInventoryLabel.Name = "partInventoryLabel";
            partInventoryLabel.Size = new Size(85, 20);
            partInventoryLabel.TabIndex = 5;
            partInventoryLabel.Text = "Inventory";
            // 
            // partPriceCostLabel
            // 
            partPriceCostLabel.AutoSize = true;
            partPriceCostLabel.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold);
            partPriceCostLabel.Location = new Point(86, 233);
            partPriceCostLabel.Name = "partPriceCostLabel";
            partPriceCostLabel.Size = new Size(99, 20);
            partPriceCostLabel.TabIndex = 7;
            partPriceCostLabel.Text = "Price / Cost";
            // 
            // textPartPriceCost
            // 
            textPartPriceCost.Location = new Point(196, 232);
            textPartPriceCost.Name = "textPartPriceCost";
            textPartPriceCost.Size = new Size(198, 25);
            textPartPriceCost.TabIndex = 8;
            // 
            // partMinLabel
            // 
            partMinLabel.AutoSize = true;
            partMinLabel.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold);
            partMinLabel.Location = new Point(327, 288);
            partMinLabel.Name = "partMinLabel";
            partMinLabel.Size = new Size(41, 20);
            partMinLabel.TabIndex = 9;
            partMinLabel.Text = "Min";
            // 
            // textPartMin
            // 
            textPartMin.Location = new Point(374, 282);
            textPartMin.Name = "textPartMin";
            textPartMin.Size = new Size(110, 25);
            textPartMin.TabIndex = 10;
            // 
            // partMaxLabel
            // 
            partMaxLabel.AutoSize = true;
            partMaxLabel.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold);
            partMaxLabel.Location = new Point(141, 283);
            partMaxLabel.Name = "partMaxLabel";
            partMaxLabel.Size = new Size(44, 20);
            partMaxLabel.TabIndex = 11;
            partMaxLabel.Text = "Max";
            // 
            // textPartMax
            // 
            textPartMax.Location = new Point(196, 283);
            textPartMax.Name = "textPartMax";
            textPartMax.Size = new Size(110, 25);
            textPartMax.TabIndex = 12;
            // 
            // grpPartType
            // 
            grpPartType.Controls.Add(rdoOutSourced);
            grpPartType.Controls.Add(rdoInHouse);
            grpPartType.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold);
            grpPartType.Location = new Point(196, 12);
            grpPartType.Name = "grpPartType";
            grpPartType.Size = new Size(299, 58);
            grpPartType.TabIndex = 13;
            grpPartType.TabStop = false;
            // 
            // rdoOutSourced
            // 
            rdoOutSourced.AutoSize = true;
            rdoOutSourced.Location = new Point(146, 25);
            rdoOutSourced.Name = "rdoOutSourced";
            rdoOutSourced.Size = new Size(117, 24);
            rdoOutSourced.TabIndex = 1;
            rdoOutSourced.TabStop = true;
            rdoOutSourced.Text = "Outsourced";
            rdoOutSourced.UseVisualStyleBackColor = true;
            rdoOutSourced.CheckedChanged += rdoOutSourced_CheckedChanged;
            // 
            // rdoInHouse
            // 
            rdoInHouse.AutoSize = true;
            rdoInHouse.Checked = true;
            rdoInHouse.Location = new Point(9, 26);
            rdoInHouse.Name = "rdoInHouse";
            rdoInHouse.Size = new Size(99, 24);
            rdoInHouse.TabIndex = 0;
            rdoInHouse.TabStop = true;
            rdoInHouse.Text = "In-House";
            rdoInHouse.UseVisualStyleBackColor = true;
            rdoInHouse.CheckedChanged += rdoInHouse_CheckedChanged;
            // 
            // machineIDLabel
            // 
            machineIDLabel.AutoSize = true;
            machineIDLabel.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold);
            machineIDLabel.Location = new Point(84, 328);
            machineIDLabel.Name = "machineIDLabel";
            machineIDLabel.Size = new Size(101, 20);
            machineIDLabel.TabIndex = 14;
            machineIDLabel.Text = "Machine ID";
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold);
            companyNameLabel.Location = new Point(50, 374);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new Size(135, 20);
            companyNameLabel.TabIndex = 15;
            companyNameLabel.Text = "Company Name";
            companyNameLabel.Visible = false;
            // 
            // textMachineID
            // 
            textMachineID.Location = new Point(196, 328);
            textMachineID.Name = "textMachineID";
            textMachineID.Size = new Size(110, 25);
            textMachineID.TabIndex = 16;
            // 
            // textCompanyName
            // 
            textCompanyName.Location = new Point(196, 374);
            textCompanyName.Name = "textCompanyName";
            textCompanyName.Size = new Size(110, 25);
            textCompanyName.TabIndex = 17;
            textCompanyName.Visible = false;
            // 
            // btnSavePart
            // 
            btnSavePart.Location = new Point(601, 413);
            btnSavePart.Name = "btnSavePart";
            btnSavePart.Size = new Size(83, 25);
            btnSavePart.TabIndex = 18;
            btnSavePart.Text = "Save";
            btnSavePart.UseVisualStyleBackColor = true;
            btnSavePart.Click += btnSavePart_Click;
            // 
            // btnCancelPart
            // 
            btnCancelPart.Location = new Point(705, 413);
            btnCancelPart.Name = "btnCancelPart";
            btnCancelPart.Size = new Size(83, 25);
            btnCancelPart.TabIndex = 19;
            btnCancelPart.Text = "Cancel";
            btnCancelPart.UseVisualStyleBackColor = true;
            btnCancelPart.Click += btnCancelPart_Click;
            // 
            // textPartInventory
            // 
            textPartInventory.Location = new Point(196, 183);
            textPartInventory.Name = "textPartInventory";
            textPartInventory.Size = new Size(198, 25);
            textPartInventory.TabIndex = 20;
            // 
            // AddPartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textPartInventory);
            Controls.Add(btnCancelPart);
            Controls.Add(btnSavePart);
            Controls.Add(textCompanyName);
            Controls.Add(textMachineID);
            Controls.Add(companyNameLabel);
            Controls.Add(machineIDLabel);
            Controls.Add(grpPartType);
            Controls.Add(textPartMax);
            Controls.Add(partMaxLabel);
            Controls.Add(textPartMin);
            Controls.Add(partMinLabel);
            Controls.Add(textPartPriceCost);
            Controls.Add(partPriceCostLabel);
            Controls.Add(partInventoryLabel);
            Controls.Add(textPartName);
            Controls.Add(partNameLabel);
            Controls.Add(textPartID);
            Controls.Add(partIDLabel);
            Controls.Add(addPartTitleLabel);
            Name = "AddPartForm";
            Text = "Part";
            Load += AddPartForm_Load;
            grpPartType.ResumeLayout(false);
            grpPartType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addPartTitleLabel;
        private Label partIDLabel;
        private TextBox textPartID;
        private Label partNameLabel;
        private TextBox textPartName;
        private Label partInventoryLabel;
        private Label partPriceCostLabel;
        private TextBox textPartPriceCost;
        private Label partMinLabel;
        private TextBox textPartMin;
        private Label partMaxLabel;
        private TextBox textPartMax;
        private GroupBox grpPartType;
        private RadioButton rdoOutSourced;
        private RadioButton rdoInHouse;
        private Label machineIDLabel;
        private Label companyNameLabel;
        private TextBox textMachineID;
        private TextBox textCompanyName;
        private Button btnSavePart;
        private Button btnCancelPart;
        private TextBox textPartInventory;
    }
}