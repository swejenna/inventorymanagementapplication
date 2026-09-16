using System;
using System.Collections.Generic;
using System.Text;
//binding list <t>
using System.ComponentModel;

namespace InventorySystem_JennaHall
{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        //associated parts list
        public Product()
        {
            AssociatedParts = new BindingList<Part>();
        }

        //methods
        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int partID)
        {
            Part partToRemove = lookupAssociatedPart(partID);

            if (partToRemove != null)
            {
                AssociatedParts.Remove(partToRemove);
                return true;
            }
            return false;
        }

        public Part lookupAssociatedPart(int partID)
        {
            foreach (Part parts in AssociatedParts)
            {
                if (parts.PartID == partID)
                {
                    return parts;
                }
            }
            return null;
        }

    }
}
