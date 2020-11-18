using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace LAB_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Store store = MakeStore();
            Console.WriteLine(store);
            //WritePriceRange(store);
            store.Add(new Phone("Mi 10", "Xiaomi", 1760.00, "Blue", 
                "Qualcomm Snapdragon 865", 256, 6.67, true));
            Serialize(store);
            Console.WriteLine("NE GATOVA");
        }

        static void WritePriceRange(Store store)
        {
            Console.WriteLine("Write minimal and maximal price: ");
            double Min, Max;
            Min = Convert.ToDouble(Console.ReadLine());
            Max = Convert.ToDouble(Console.ReadLine());
            List<Product> products = store.FindByPriceRange(Min, Max);
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }

        static Store MakeStore()
        {
            Store store = new Store();
            Phone phone = new Phone("Redmi Note 9 Pro", "Xiaomi", 699.0, "Gray", 
                "Qualcomm Snapdragon 720G", 128, 6.67, true);
            store.Add(phone);
            TV tv = new TV("MI TV 4S", "Xiaomi", 1022.76, "Gray", "VA",
                50.0, true);
            store.Add(tv);
            Speakers speakers = new Speakers("Mi Pocket Speaker 2", "Xiaomi", 55.84,
                "Black", 5, 1);
            store.Add(speakers);
            Gamepads gamepads = new Gamepads("Flying Chi Black Samurai X8pro", "Xiaomi",
                150.0, "Black", 14, true, true, false);
            store.Add(gamepads);
            Wire wire = new Wire("USB Type-C", "Xiaomi", 13.0, "White",
                0.3, "USB Type-A", "USB Type-C");
            store.Add(wire);
            return store;
        }

        static Store DeserializeStore()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Store));
            FileStream fileStream = new FileStream(Directory.GetCurrentDirectory() + 
                                                   "\\database.xml", FileMode.OpenOrCreate);
            Store store = (Store) serializer.Deserialize(fileStream);
            fileStream.Close();
            return store;
        }

        static void Serialize(Store store)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Store));
            FileStream fileStream = new FileStream("database.xml", FileMode.OpenOrCreate);
            serializer.Serialize(fileStream, store); 
            fileStream.Close();
        }
    }
}