using System.Xml.Serialization;

namespace LAB_4.Products
{
    public class Gamepads : Product
    {
        /// <summary>
        /// Количество клавиш
        /// </summary>
        [XmlElement(ElementName = "NumberOfKeys")]
        public int NumberOfKeys;
        /// <summary>
        /// Беспроводной ли геймпад
        /// </summary>
        [XmlElement(ElementName = "IsWireless")]
        public bool IsWireless;
        /// <summary>
        /// Есть ли аналоговые триггеры
        /// </summary>
        [XmlElement(ElementName = "AnalogTriggers")]
        public bool AnalogTriggers;
        /// <summary>
        /// Есть ли тачпад
        /// </summary>
        [XmlElement(ElementName = "Touchpad")]
        public bool Touchpad;

        public Gamepads(string name, string manufacturer, double price, string color,
            int numberOfKeys, bool isWireless, bool analogTriggers,
            bool touchpad) : base(name, manufacturer, price, color)
        {
            NumberOfKeys = numberOfKeys;
            IsWireless = isWireless;
            AnalogTriggers = analogTriggers;
            Touchpad = touchpad;
        }

        public Gamepads()
        {
            
        }
    }
}