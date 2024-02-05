using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce
{
    internal class Inventory
    {
        public List<Product> Products { get; set; }
        public Inventory()
        {
            Products = new List<Product>();
        }

        public void AddInventoryProduct(Product product)
        {
            Products.Add(product);
        }
        public void RemoveInventoryProduct(Product product) 
        {
            Products.Remove(product);
        }
        public override string ToString()
        {
            string s = "";
           foreach(var item in Products)
            {
                s += item.ToString();
                s += '\n';
            }
            return s;
        }
    }
}
