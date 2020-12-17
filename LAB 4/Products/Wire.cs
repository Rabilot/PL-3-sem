using System.Xml.Serialization;

namespace LAB_4.Products
{
    public class Wire : Product
    {
        /// <summary>
        /// Длина провода
        /// </summary>
        [XmlElement(ElementName = "Length")]
        public double Length;
        /// <summary>
        /// Входной разъём
        /// </summary>
        [XmlElement(ElementName = "TypeIn")]
        public string TypeIn;
        /// <summary>
        /// Выходной разъём
        /// </summary>
        [XmlElement(ElementName = "TypeOut")]
        public string TypeOut;

        public Wire(TypeOfProduct type, string name, string manufacturer, double price, string color,
            double length, string typeIn, string typeOut) : base(type, name, manufacturer, price, color)
        {
            Length = length;
            TypeIn = typeIn;
            TypeOut = typeOut;
        }

        public Wire()
        {
            
        }
    }
}