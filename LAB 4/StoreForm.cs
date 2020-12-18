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
        private Store store = new Store();
        public StoreForm()
        {
            InitializeComponent();
            store = Initialized();
        }

        private Store Initialized()
        {
            store = new Store();
            store.MakeStore();
            foreach (var product in store.Products)
            {
                storeItems.Items.Add(product.Name);
            }

            return store;
        }

        public void UpdateInfo()
        {
            selectedItemsInfo.Text = MakeStore().ToString();
            
        }

        private Store MakeStore()
        {
            Store result = new Store();
            double finalPrice = 0;
            int count = selectedItems.Items.Count;
            StringBuilder r = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                string name = selectedItems.Items[i].ToString();
                Product item = store.FindByName(name);
                result.Add(item);
            }

            foreach (var product in result.Products)
            {
                finalPrice += product.Price;
            }

            priceLabel.Text = $"Price: {finalPrice}";
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