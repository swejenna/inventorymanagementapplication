namespace InventorySystem_JennaHall
{
    partial class ModifyPartForm
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
            grpPartType = new GroupBox();
            rdoOutSourced = new RadioButton();
            rdoInHouse = new RadioButton();
            textCompanyName = new TextBox();
            textMachineID = new TextBox();
            companyNameLabel = new Label();
            machineIDLabel = new Label();
            textPartMax = new TextBox();
            partMaxLabel = new Label();
            textPartMin = new TextBox();
            partMinLabel = new Label();
            textPartPriceCost = new TextBox();
            partPriceCostLabel = new Label();
            partInventoryLabel = new Label();
            textPartName = new TextBox();
            partNameLabel = new Label();
            textPartID = new TextBox();
            partIDLabel = new Label();
            btnCancelPart = new Button();
            btnSavePart = new Button();
            textPartInventory = new TextBox();
            grpPartType.SuspendLayout();
            SuspendLayout();
            // 
            // addPartTitleLabel
            // 
            addPartTitleLabel.AutoSize = true;
            addPartTitleLabel.Font = new Font("Franklin Gothic Medium Cond", 18.3396225F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addPartTitleLabel.Location = new Point(12, 9);
            addPartTitleLabel.Name = "addPartTitleLabel";
            addPartTitleLabel.Size = new Size(126, 34);
            addPartTitleLabel.TabIndex = 1;
            addPartTitleLabel.Text = "Modify Part";
            // 
            // grpPartType
            // 
            grpPartType.Controls.Add(rdoOutSourced);
            grpPartType.Controls.Add(rdoInHouse);
            grpPartType.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold);
            grpPartType.Location = new Point(211, 9);
            grpPartType.Name = "grpPartType";
            grpPartType.Size = new Size(299, 58);
            grpPartType.TabIndex = 14;
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
            // textCompanyName
            // 
            textCompanyName.Location = new Point(210, 376);
            textCompanyName.Name = "textCompanyName";
            textCompanyName.Size = new Size(110, 25);
            textCompanyName.TabIndex = 33;
            textCompanyName.Visible = false;
            // 
            // textMachineID
            // 
            textMachineID.Location = new Point(210, 330);
            textMachineID.Name = "textMachineID";
            textMachineID.Size = new Size(110, 25);
            textMachineID.TabIndex = 32;
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold);
            companyNameLabel.Location = new Point(64, 376);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new Size(135, 20);
            companyNameLabel.TabIndex = 31;
            companyNameLabel.Text = "Company Name";
            companyNameLabel.Visible = false;
            // 
            // machineIDLabel
            // 
            machineIDLabel.AutoSize = true;
            machineIDLabel.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold);
            machineIDLabel.Location = new Point(98, 330);
            machineIDLabel.Name = "machineIDLabel";
            machineIDLabel.Size = new Size(101, 20);
            machineIDLabel.TabIndex = 30;
            machineIDLabel.Text = "Machine ID";
            // 
            // textPartMax
            // 
            textPartMax.Location = new Point(210, 285);
            textPartMax.Name = "textPartMax";
            textPartMax.Size = new Size(110, 25);
            textPartMax.TabIndex = 29;
            // 
            // partMaxLabel
            // 
            partMaxLabel.AutoSize = true;
            partMaxLabel.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold);
            partMaxLabel.Location = new Point(155, 285);
            partMaxLabel.Name = "partMaxLabel";
            partMaxLabel.Size = new Size(44, 20);
            partMaxLabel.TabIndex = 28;
            partMaxLabel.Text = "Max";
            // 
            // textPartMin
            // 
            textPartMin.Location = new Point(388, 284);
            textPartMin.Name = "textPartMin";
            textPartMin.Size = new Size(110, 25);
            textPartMin.TabIndex = 27;
            // 
            // partMinLabel
            // 
            partMinLabel.AutoSize = true;
            partMinLabel.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold);
            partMinLabel.Location = new Point(341, 290);
            partMinLabel.Name = "partMinLabel";
            partMinLabel.Size = new Size(41, 20);
            partMinLabel.TabIndex = 26;
            partMinLabel.Text = "Min";
            // 
            // textPartPriceCost
            // 
            textPartPriceCost.Location = new Point(210, 234);
            textPartPriceCost.Name = "textPartPriceCost";
            textPartPriceCost.Size = new Size(198, 25);
            textPartPriceCost.TabIndex = 25;
            // 
            // partPriceCostLabel
            // 
            partPriceCostLabel.AutoSize = true;
            partPriceCostLabel.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold);
            partPriceCostLabel.Location = new Point(100, 235);
            partPriceCostLabel.Name = "partPriceCostLabel";
            partPriceCostLabel.Size = new Size(99, 20);
            partPriceCostLabel.TabIndex = 24;
            partPriceCostLabel.Text = "Price / Cost";
            // 
            // partInventoryLabel
            // 
            partInventoryLabel.AutoSize = true;
            partInventoryLabel.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold);
            partInventoryLabel.Location = new Point(114, 186);
            partInventoryLabel.Name = "partInventoryLabel";
            partInventoryLabel.Size = new Size(85, 20);
            partInventoryLabel.TabIndex = 22;
            partInventoryLabel.Text = "Inventory";
            // 
            // textPartName
            // 
            textPartName.Location = new Point(210, 133);
            textPartName.Name = "textPartName";
            textPartName.Size = new Size(198, 25);
            textPartName.TabIndex = 21;
            // 
            // partNameLabel
            // 
            partNameLabel.AutoSize = true;
            partNameLabel.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold);
            partNameLabel.Location = new Point(145, 134);
            partNameLabel.Name = "partNameLabel";
            partNameLabel.Size = new Size(54, 20);
            partNameLabel.TabIndex = 20;
            partNameLabel.Text = "Name";
            // 
            // textPartID
            // 
            textPartID.Enabled = false;
            textPartID.Location = new Point(210, 89);
            textPartID.Name = "textPartID";
            textPartID.ReadOnly = true;
            textPartID.Size = new Size(198, 25);
            textPartID.TabIndex = 19;
            // 
            // partIDLabel
            // 
            partIDLabel.AutoSize = true;
            partIDLabel.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 0);
            partIDLabel.Location = new Point(170, 90);
            partIDLabel.Name = "partIDLabel";
            partIDLabel.Size = new Size(29, 20);
            partIDLabel.TabIndex = 18;
            partIDLabel.Text = "ID";
            // 
            // btnCancelPart
            // 
            btnCancelPart.Location = new Point(705, 413);
            btnCancelPart.Name = "btnCancelPart";
            btnCancelPart.Size = new Size(83, 25);
            btnCancelPart.TabIndex = 35;
            btnCancelPart.Text = "Cancel";
            btnCancelPart.UseVisualStyleBackColor = true;
            btnCancelPart.Click += btnCancelPart_Click;
            // 
            // btnSavePart
            // 
            btnSavePart.Location = new Point(601, 413);
            btnSavePart.Name = "btnSavePart";
            btnSavePart.Size = new Size(83, 25);
            btnSavePart.TabIndex = 34;
            btnSavePart.Text = "Save";
            btnSavePart.UseVisualStyleBackColor = true;
            btnSavePart.Click += btnSavePart_Click;
            // 
            // textPartInventory
            // 
            textPartInventory.Location = new Point(210, 185);
            textPartInventory.Name = "textPartInventory";
            textPartInventory.Size = new Size(198, 25);
            textPartInventory.TabIndex = 23;
            // 
            // ModifyPartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelPart);
            Controls.Add(btnSavePart);
            Controls.Add(textCompanyName);
            Controls.Add(textMachineID);
            Controls.Add(companyNameLabel);
            Controls.Add(machineIDLabel);
            Controls.Add(textPartMax);
            Controls.Add(partMaxLabel);
            Controls.Add(textPartMin);
            Controls.Add(partMinLabel);
            Controls.Add(textPartPriceCost);
            Controls.Add(partPriceCostLabel);
            Controls.Add(textPartInventory);
            Controls.Add(partInventoryLabel);
            Controls.Add(textPartName);
            Controls.Add(partNameLabel);
            Controls.Add(textPartID);
            Controls.Add(partIDLabel);
            Controls.Add(grpPartType);
            Controls.Add(addPartTitleLabel);
            Name = "ModifyPartForm";
            Text = "Part";
            grpPartType.ResumeLayout(false);
            grpPartType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addPartTitleLabel;
        private GroupBox grpPartType;
        private RadioButton rdoOutSourced;
        private RadioButton rdoInHouse;
        private TextBox textCompanyName;
        private TextBox textMachineID;
        private Label companyNameLabel;
        private Label machineIDLabel;
        private TextBox textPartMax;
        private Label partMaxLabel;
        private TextBox textPartMin;
        private Label partMinLabel;
        private TextBox textPartPriceCost;
        private Label partPriceCostLabel;
        private TextBox textPartInventory;
        private Label partInventoryLabel;
        private TextBox textPartName;
        private Label partNameLabel;
        private TextBox textPartID;
        private Label partIDLabel;
        private Button btnCancelPart;
        private Button btnSavePart;
    }
}