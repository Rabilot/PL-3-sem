using System.Xml.Serialization;

namespace LAB_3
{
    public class Speakers : Product

    {
        /// <summary>
        /// Номинальная мощность
        /// </summary>
        [XmlElement(ElementName = "RMS")]
        public int RMS { get; set; }
        /// <summary>
        /// Количество динамиков
        /// </summary>
        [XmlElement(ElementName = "NumberOfSpeakers")]
        public int NumberOfSpeakers { get; set; }

        public Speakers(string name, string manufacturer, double price, string color, int rms, 
            int numberOfSpeakers) : base(name, manufacturer, price, color)
        {
            RMS = rms;
            NumberOfSpeakers = numberOfSpeakers;
        }

        public Speakers()
        {
            
        }
    }
}