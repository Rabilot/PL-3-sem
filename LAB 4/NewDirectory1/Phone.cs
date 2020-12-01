using System.Xml.Serialization;

namespace LAB_3
{
    public class Phone : Product
    {
        /// <summary>
        /// Центральный процессор
        /// </summary>
        [XmlElement(ElementName = "CP")]
        public string CPU{ get; set;}
        /// Размер основной памяти
        /// </summary>
        [XmlElement(ElementName = "Storage")]
        public int Storage{ get; set;}
        /// <summary>
        /// Тип дисплея
        /// </summary>
        [XmlElement(ElementName = "DisplaySize")]
        public double DisplaySize { get; set; }
        /// <summary>
        /// Наличие NFC
        /// </summary>
        [XmlElement(ElementName = "NFC")]
        public bool NFC{ get; set;}

        public Phone(string name, string manufacturer, double price, string color, string cpu, int storage,
            double displaySize, bool nfc) : base(name, manufacturer, price, color)
        {
            CPU = cpu;
            Storage = storage;
            DisplaySize = displaySize;
            NFC = nfc;
        }

        public Phone()
        {
            
        }
    }
}