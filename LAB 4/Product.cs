using System;
using System.Text;
using System.Xml.Serialization;

namespace LAB_4
{
    public class Product
    {
        /// <summary>
        /// Название продукта.
        /// </summary>
        [XmlElement(ElementName = "Name")]
        public string Name { get; set;}
        /// <summary>
        ///  Производитель.
        /// </summary>
        [XmlElement(ElementName = "Manufacturer")]
        public string Manufacturer{ get; set;}
        
        /// <summary>
        /// Цена
        /// </summary>
        [XmlElement(ElementName = "Price")]
        public double Price{ get; set;}
        /// <summary>
        /// Цвет
        /// </summary>
        [XmlElement(ElementName = "Color")]
        public string Color { get; set; }

        public TypeOfProduct Type { get; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Product: \n");
            stringBuilder.Append(
                $"Name: {Name}\nManufacturer: {Manufacturer}\nWeight: " +
                $"Price: {Price}\nColor: {Color}\n");
            return stringBuilder.ToString();
        }

        public Product(TypeOfProduct type, string name, string manufacturer, double price, string color)
        {
            if (price < 0)
            {
                throw new Exception("Invalid price!");
            }

            Type = type;
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            Color = color;
        }

        public Product()
        {
            
        }
    }
}