using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public override string ToString()
        {
            return this.Name + " P" + this.Price + " [" + this.Quantity + "]";
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            return (obj is string s && s.Equals(this.Name)) || (obj is Product p && p.Name.Equals(this.Name));
        }
        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
    }
}
