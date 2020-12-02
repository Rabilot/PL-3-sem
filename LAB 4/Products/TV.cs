using System.Xml.Serialization;

namespace LAB_4.Products
{
    public class TV : Product
    {
        /// <summary>
        /// Тип экрана
        /// </summary>
        [XmlElement(ElementName = "ScreenType")]
        public string ScreenType { get; set; }
        /// <summary>
        /// Размер экрана
        /// </summary>
        [XmlElement(ElementName = "ScreenSize")]
        public double ScreenSize { get; set; }
        /// <summary>
        /// Наличие HDR
        /// </summary>
        [XmlElement(ElementName = "HDR")]
        public bool HDR { get; set; }

        public TV(string name, string manufacturer, double price, string color, string screenType, double screenSize,
            bool hdr) : base(name, manufacturer, price, color)
        {
            ScreenType = screenType;
            ScreenSize = screenSize;
            HDR = hdr;
        }

        public TV()
        {
            
        }
    }
}