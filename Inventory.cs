using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Xml.Serialization;

namespace KhadijehRashid_C968
{
    public class Inventory
    {
        public BindingList<Part> AllParts {  get; set; }
        public BindingList<Product> Products { get; set; }
        public Inventory()
        {
            AllParts = new BindingList<Part>();
            Products = new BindingList<Product>();
        }

        public void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void RemovePart(int partID)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID == partID)
                {
                    AllParts.RemoveAt(i);
                    return;
                }
            }
        }

        public void RemoveProduct(int productID)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == productID)
                {
                    Products.RemoveAt(i);
                    return;
                }
            }
        }

        public Part? LookupPart(int partID)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }

        public Product? LookupProduct(int productID)
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

        public void UpdatePart(Part part)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID == part.PartID)
                {
                    AllParts[i] = part;
                }
            }
        }

        public void UpdateProduct(Product product)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == product.ProductID)
                {
                    Products[i] = product;
                }
            }
        }
    }
}
