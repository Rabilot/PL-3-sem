using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
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

        private void Initialized()
        {
            Store store = new Store();
            store.MakeStore();
            foreach (var product in store.Products)
            {
                storeItems.Items.Add(product.Name);
            }
        }

        public void UpdateInfo()
        {
            //MakeGift();
            selectedItemsInfo.Text = MakeStore().ToString();
            selectedItems.Text = selectedItems.Items.Count + "";
           
        }

        private Store MakeStore()
        {
            Store result = new Store();
            int count = selectedItems.Items.Count;
            //Console.WriteLine("ITEMS COUNT: " + count);
            StringBuilder r = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                string name = selectedItems.Items[i].ToString();
                r.Append("Loading #" + i);
                r.Append(name);
                //Console.WriteLine("Loading #" + i);
                //Console.WriteLine(name);
                Product item = StoreManager.FoundGiftItemByName(name);
                r.Append("is null: " + (item == null));
                //Console.WriteLine("is null: " + (item == null));
                result.Add(item);
            }
            Console.WriteLine(r.ToString());
            //selectedItemsInfo.Text = r.ToString();
            return result;
        }


        private void selectedItems_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string str = (string) e.Data.GetData(
                    DataFormats.StringFormat);

                selectedItems.Items.Add(str);
                UpdateInfo();
            }
        }

        private void storeItems_MouseDown(object sender, MouseEventArgs e)
        {
            if (storeItems.Items.Count == 0)
                return;

            int index = storeItems.IndexFromPoint(e.X, e.Y);
            if (index < 0)
                return;
            string s = storeItems.Items[index].ToString();
            DoDragDrop(s, DragDropEffects.All);
        }

        private void selectedItems_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedItems.Items.RemoveAt(selectedItems.SelectedIndex);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedItems.Items.Clear();
        }
    }
}