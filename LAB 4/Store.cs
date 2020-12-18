using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.PerformanceData;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using LAB_4.Products;

namespace LAB_4
{
    [XmlInclude(typeof(Product))]
    [XmlInclude(typeof(Products.Gamepads))]
    [XmlInclude(typeof(Products.Wire))]
    [XmlInclude(typeof(Products.Speakers))]
    [XmlInclude(typeof(Products.TV))]
    [XmlInclude(typeof(Products.Phone))]
    
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
            //if (min < 0 || max < min) throw new InvalidPriceException();
            return Products.Where(product => product.Price > min && product.Price < max).ToList();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("StoreProducts: \r\n");
            foreach (var product in Products)
            {
                stringBuilder.Append($"{product}\r\n");
            }

            return stringBuilder.ToString();
        }

        public int NumberOfPhones()
        {
            return Products.OfType<Products.Phone>().Cast<Product>().Count();
        }
        
        public void MakeStore()
        {
            Phone phone = new Phone(TypeOfProduct.Phone,"Redmi Note 9 Pro", "Xiaomi", 699.0, "Gray", 
                "Qualcomm Snapdragon 720G", 128, 6.67, true);
            Products.Add(phone);
            TV tv = new TV(TypeOfProduct.TV,"MI TV 4S", "Xiaomi", 1022.76, "Gray", "VA",
                50.0, true);
            Products.Add(tv);
            Speakers speakers = new Speakers(TypeOfProduct.Speakers,"Mi Pocket Speaker 2", "Xiaomi", 55.84,
                "Black", 5, 1);
            Products.Add(speakers);
            Gamepads gamepads = new Gamepads(TypeOfProduct.Gamepads,"Flying Chi Black Samurai X8pro", "Xiaomi",
                150.0, "Black", 14, true, true, false);
            Products.Add(gamepads);
            Wire wire = new Wire(TypeOfProduct.Wire,"USB Type-C", "Xiaomi", 13.0, "White",
                0.3, "USB Type-A", "USB Type-C");
            Products.Add(wire);
        }

    }
}