using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce
{
    public class ProductBuilder
    {
        private Product product;
        public ProductBuilder()
        {
            this.product = new Product();
        }
        public ProductBuilder Name(string name)
        {
            this.product.Name = name;
            return this;
        }
        public ProductBuilder Price(double price)
        {
            this.product.Price = price;
            return this;
        }
        public ProductBuilder Quantity(int quantity)
        {
            this.product.Quantity = quantity;
            return this;
        }
        public Product Build()
        {
            return this.product;
        }
    }
}
