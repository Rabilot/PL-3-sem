﻿using System.Xml.Serialization;

namespace LAB_4.Products
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

        public Speakers(TypeOfProduct type, string name, string manufacturer, double price, string color, int rms, 
            int numberOfSpeakers) : base(type, name, manufacturer, price, color)
        {
            RMS = rms;
            NumberOfSpeakers = numberOfSpeakers;
        }

        public Speakers()
        {
            
        }
    }
}