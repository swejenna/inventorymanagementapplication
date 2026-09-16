using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventorySystem_JennaHall
{
    public partial class AddPartForm : Form
    {
        private Inventory inventory;
        public AddPartForm(Inventory inventory)
        {
            InitializeComponent();

            this.inventory = inventory;

            rdoInHouse.Checked = true;
        }

        private void AddPartForm_Load(object sender, EventArgs e)
        {
            textPartID.Text = GetNextPartId().ToString();
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
                MessageBox.Show("Min must be less than Max.", "Invalid Inventory range.");
                return;
            }

            if (result < min || result > max)
            {
                MessageBox.Show("Inventory must be between the Min and Max values.", "Invalid Inventory value.");
                return;
            }

            if (rdoInHouse.Checked)
            {
                if (!int.TryParse(textMachineID.Text, out int machineId))
                {
                    MessageBox.Show("Machine ID must be a whole number.", "Invalid Machine ID.");
                    return;
                }

                Inhouse part = new Inhouse
                {
                    PartID = int.Parse(textPartID.Text),
                    Name = textPartName.Text,
                    InStock = result,
                    Price = price,
                    Min = min,
                    Max = max,
                    MachineID = machineId
                };

                inventory.addPart(part);
            }
            else
            {
                Outsourced part = new Outsourced
                {
                    PartID = int.Parse(textPartID.Text),
                    Name = textPartName.Text,
                    InStock = result,
                    Price = price,
                    Min = min,
                    Max = max,
                    CompanyName = textCompanyName.Text
                };

                inventory.addPart(part);
            }

            Close();
        }

        private void btnCancelPart_Click(object sender, EventArgs e)
        {
            Close();
        }

        //helper
        private int GetNextPartId()
        {
            if (inventory.AllParts.Count == 0)
            {
                return 1;
            }

            return inventory.AllParts.Max(p => p.PartID) + 1;
        }

    }
}
