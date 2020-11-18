using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace LAB_3
{
    [XmlInclude(typeof(Product))]
    [XmlInclude(typeof(Gamepads))]
    [XmlInclude(typeof(Wire))]
    [XmlInclude(typeof(Speakers))]
    [XmlInclude(typeof(TV))]
    [XmlInclude(typeof(Phone))]
    
    public class Store
    {
        [XmlArray("Products"), XmlArrayItem(typeof(Product), ElementName = "Product")]
        public List<Product> Products { get; set; }

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

        public List<Product> FindByPriceRange(double Min, double Max)
        {
            List<Product> products = new List<Product>();
            foreach (var prod in Products)
            {
                if (prod.Price > Min && prod.Price < Max)
                {
                    products.Add(prod);
                }
            }

            return products;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("StoreProducts: ");
            foreach (var product in Products)
            {
                stringBuilder.Append($"{product}\n");
            }

            return stringBuilder.ToString();
        }
        
    }
}