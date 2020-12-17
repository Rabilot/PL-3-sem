using System.Collections.Generic;

namespace LAB_4
{
    public class StoreManager
    {
        public static List<Product> Products;
        
        public static Product FoundGiftItemByName(string name)
        {   
            for (int i = 0; i < Products.Count; i++)
            {
                Product product = Products[i];
                if (product.Name.Equals(name))
                    return product;
            }

            return null;
        }
    }
}