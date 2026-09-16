using System;
using System.Collections.Generic;
using System.Text;
//Binding list
using System.ComponentModel;

namespace InventorySystem_JennaHall
{
    public class Inventory
    {
        public BindingList<Product> Products { get; set; }
        public BindingList<Part> AllParts { get; set; }

        //inventory list
        public Inventory()
        {
            Products = new BindingList<Product>();
            AllParts = new BindingList<Part>();
        }

        //methods for products
        public void addProduct(Product product)
        {
            Products.Add(product);
        }
        public bool removeProduct(int productID)
        {
            Product productToRemove = lookupProduct(productID);
            if (productToRemove != null)
            {
                Products.Remove(productToRemove);
                return true;
            }
            return false;
        }
        public Product lookupProduct(int productID)
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    return product;
                }
            }
            return null;
        }
        public void updateProduct(int productID, Product newProduct)
        {
            Product existingProduct = lookupProduct(productID);
            if (existingProduct != null)
            {
                int index = Products.IndexOf(existingProduct);
                Products[index] = newProduct;
            }
        }

        //methods for parts
        public void addPart(Part part)
        {
            AllParts.Add(part);
        }

        public bool deletePart(int PartID)
        {
            Part part = lookupPart(PartID);

            if (part != null)
            {
                AllParts.Remove(part);
                return true;
            }
            return false;
        }

        public Part lookupPart(int PartID)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == PartID)
                {
                    return part;
                }
            }
            return null;
        }

        public void updatePart(int PartID, Part newPart)
        {
            Part existingPart = lookupPart(PartID);
            if (existingPart != null)
            {
                int index = AllParts.IndexOf(existingPart);
                AllParts[index] = newPart;
            }
        }
        
        //helper methods

        
    }
}
