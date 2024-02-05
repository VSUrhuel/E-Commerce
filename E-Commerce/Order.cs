using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce
{
    internal class Order
    {
        Dictionary<Customer, List<Product>> orders;
        public Order()
        {
            this.orders = new Dictionary<Customer, List<Product>>();  
        }
        public void AddOrder(Customer c, Product p)
        {
            if (orders.ContainsKey(c))
            {
                orders[c].Add(p);
            }
            else
            {
                orders.Add(c, new List<Product>());
                orders[c].Add(p);
            }
        }
        public void RemoveOrder(Customer c, Product p) 
        {
            if(orders.ContainsKey(c))
            {
                orders[c].Remove(p);
            }
        }
        public double GetPrice(Customer c)
        {
            double price = 0;
            if(orders.ContainsKey(c))
            {
                foreach(Product p in orders[c])
                {
                    price += p.Price;
                }
            }
            return price;
        }

        
    }
}
