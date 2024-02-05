using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            ProductBuilder builder = new ProductBuilder();
            //Add Products
            products.Add(builder.Name("Nike Shoes").Price(1930.13).Quantity(90).Build());
            builder = new ProductBuilder();
            products.Add(builder.Name("Nike Bag").Price(5330.13).Quantity(12).Build());
            builder = new ProductBuilder();
            products.Add(builder.Name("Bag").Price(3453).Quantity(15).Build());
            //Add Products to Inventory
            Inventory inventory = new Inventory();
            foreach(var item in products)
            {
                inventory.AddInventoryProduct(item);
            }
            
            Console.WriteLine(inventory);

            Customer rhuel = new Customer("Rhuel", "09099153546", PaymentMethod.DebitCard, 10000);
            Order order = new Order();
            order.AddOrder(rhuel, products[0]);
            order.AddOrder(rhuel, products[2]);

            Console.WriteLine(rhuel.PlaceOrder(order));
            Console.ReadKey();
            
        }
    }
}
