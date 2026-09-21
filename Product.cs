using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace KhadijehRashid_C968
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min {  get; set; }
        public int Max { get; set; }
        public BindingList<Part> AssociatedParts { get; set; }

        public Product()
        {
            AssociatedParts = new BindingList<Part>();
        }

        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public void RemoveAssociatedPart(Part part)
        {
            AssociatedParts.Remove(part);
        }

        public Part? LookupAssociatedPart(int partID)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {  
                    return part; 
                }
            }
            return null;
        }
    }
}
