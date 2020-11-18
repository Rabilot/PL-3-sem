using System.Collections.Generic;
using System.Diagnostics.PerformanceData;

namespace LAB_3
{
    public class Store
    {
        public List<Product> Products;

        public Store()
        {
            Products = new List<Product>();
        }

        public void Add(Product product)
        {
            Products.Add(product);
        }

        public void Remove(int index)
        {
            Products.RemoveAt(index);
        }

        public void Remove(Product product)
        {
            Products.Remove(product);
        }

        public Product FindByName(string name)
        {
            return Products.Find(product => product.Name == name);
        }

        public bool IsEmpty()
        {
            return Products.Count == 0;
        }
        
        
        
    }
}