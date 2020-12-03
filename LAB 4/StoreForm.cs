using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using LAB_4.Products;

namespace LAB_4
{
    public partial class StoreForm : Form
    {
        public StoreForm()
        {
            InitializeComponent();
            Initialized();
        }
        void Initialized()
        {
            Store store = new Store();
            store.MakeStore();
            //listBox1.Items.Add()
            foreach (var product in store.Products)
            {
                
                listBox1.Items.Add(product.Name);
            }
        }
        
        /*
        static void WritePriceRange(Store store)
        {
            Console.WriteLine("Write minimal and maximal price: ");
            try
            {
                var min = Convert.ToDouble(Console.ReadLine());
                var max = Convert.ToDouble(Console.ReadLine());
                List<Product> products = store.FindByPriceRange(min, max);
                foreach (var product in products)
                {
                    Console.WriteLine(product);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Try again: ");
                WritePriceRange(store);
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

        static Store DeserializeStore(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Store));
            try
            {
                FileStream fileStream = new FileStream(path, FileMode.Open);
                Store store = (Store) serializer.Deserialize(fileStream);
                fileStream.Close();
                return store;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File {path} not found!");
                return new Store();
            }
        }

        static void Serialize(Store store)
        {
            if (store.IsEmpty()) return;
            XmlSerializer serializer = new XmlSerializer(typeof(Store));
            FileStream fileStream = new FileStream("database.xml", FileMode.OpenOrCreate);
            serializer.Serialize(fileStream, store);
            fileStream.Close();
        }*/
    }
}