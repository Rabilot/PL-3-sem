using System.Xml.Serialization;

namespace LAB_3
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

        public Wire(string name, string manufacturer, double price, string color,
            double length, string typeIn, string typeOut) : base(name, manufacturer, price, color)
        {
            Length = length;
            TypeIn = typeIn;
            TypeOut = typeOut;
        }
    }
}