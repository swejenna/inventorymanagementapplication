using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Windows.Forms;

namespace InventorySystem_JennaHall
{
    public partial class ModifyPartForm : Form
    {
        private Inventory inventory;
        private Part part;
        public ModifyPartForm(Inventory inventory, Part part)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.part = part;

            LoadPartData();
        }

        private void LoadPartData()
        {
            //load part data into fields to be modified
            textPartID.Text = part.PartID.ToString();
            textPartName.Text = part.Name;
            textPartInventory.Text = part.InStock.ToString();
            textPartPriceCost.Text = part.Price.ToString();
            textPartMin.Text = part.Min.ToString();
            textPartMax.Text = part.Max.ToString();

            if (part is Inhouse inhousePart)
            {
                textMachineID.Text = inhousePart.MachineID.ToString();
                rdoInHouse.Checked = true;

            }
            else if (part is Outsourced outsourcedPart)
            {
                textCompanyName.Text = outsourcedPart.CompanyName;
                rdoOutSourced.Checked = true;
            }
        }

        private void btnSavePart_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textPartInventory.Text, out int result))
            {
                MessageBox.Show("Inventory must be a whole number.", "Invalid input for Inventory");
                textPartInventory.Focus();
                return;
            }

            if (!decimal.TryParse(textPartPriceCost.Text, out decimal price))
            {
                MessageBox.Show("Price must be a valid decimal number.", "Invalid input for Price");
                textPartPriceCost.Focus();
                return;
            }

            if (!int.TryParse(textPartMin.Text, out int min))
            {
                MessageBox.Show("Min must be a whole number.", "Invalid input for Min");
                textPartMin.Focus();
                return;
            }

            if (!int.TryParse(textPartMax.Text, out int max))
            {
                MessageBox.Show("Max must be a whole number.", "Invalid input for Max");
                textPartMax.Focus();
                return;
            }

            if (min >= max)
            {
                MessageBox.Show("Min value must be less than Max.", "Invalid range.");
                return;
            }

            if (result < min || result > max)
            {
                MessageBox.Show("Inventory value must be between Min and Max.", "Invalid Inventory.");
                return;
            }

            //part.Name = textPartName.Text;
            //part.InStock = result;
            //part.Price = price;
            //part.Min = min;
            //part.Max = max;


            Part updatedPart;

            if (rdoInHouse.Checked)
            {
                if (!int.TryParse(textMachineID.Text, out int machineID))
                {
                    MessageBox.Show("Machine ID must be a whole number.", "Invalid Machine ID");
                    textMachineID.Focus();
                    return;
                }

                //create new inhouse part with updated values
                updatedPart = new Inhouse
                {
                    PartID = part.PartID,
                    Name = textPartName.Text,
                    InStock = result,
                    Price = price,
                    Min = min,
                    Max = max,
                    MachineID = machineID
                };
            }
            else if (rdoOutSourced.Checked)
            {
                if (string.IsNullOrEmpty(textCompanyName.Text))
                {
                    MessageBox.Show("Please enter a Company Name.", "Invalid Company Name");
                    textCompanyName.Focus();
                    return;
                }
                //create new outsourced part with updated values
                updatedPart = new Outsourced
                {
                    PartID = part.PartID,
                    Name = textPartName.Text,
                    InStock = result,
                    Price = price,
                    Min = min,
                    Max = max,
                    CompanyName = textCompanyName.Text
                };
            }else
            {
                MessageBox.Show("Something is broken. Either In-House or Outsourced must be selected.", "Part Type Not Selected");
                return;
            }

            inventory.updatePart(updatedPart.PartID, updatedPart);

            Close();
        }

        private void btnCancelPart_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rdoOutSourced_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoOutSourced.Checked)
            {
                //show company name label and tb
                companyNameLabel.Visible = true;
                textCompanyName.Visible = true;
                //hide machine ID label and tb
                machineIDLabel.Visible = false;
                textMachineID.Visible = false;
            }
        }

        private void rdoInHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoInHouse.Checked)
            {
                //show machin ID label and tb
                machineIDLabel.Visible = true;
                textMachineID.Visible = true;
                //hide company name label and tb
                companyNameLabel.Visible = false;
                textCompanyName.Visible = false;
            }
        }
    }
}
