using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.PerformanceData;
using System.IO;
using System.Linq;
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
            try
            {
                return Products.Find(product => product.Name == name);
            }
            catch (Exception)
            {
                Console.WriteLine($"Product with name {name} not found!");
                return new Product();
            }
        }

        public bool IsEmpty()
        {
            return Products.Count == 0;
        }

        public List<Product> FindByPriceRange(double min, double max)
        {
            return Products.Where(product => product.Price > min && product.Price < max).ToList();
        }
        

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("StoreProducts: \n");
            foreach (var product in Products)
            {
                stringBuilder.Append($"{product}\n");
            }

            return stringBuilder.ToString();
        }

        public int NumberOfPhones()
        {
            return Products.OfType<Phone>().Cast<Product>().Count();
        }

    }
}