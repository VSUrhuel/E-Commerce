using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce
{
    internal class Customer
    {
        public PaymentMethod paymentMethod {  get; set; }
        public string Name { get; set; }
        public double CardBalance { get; set; }
        public string ContactInfo { get; set; }
        public Customer(string name,  string contactInfo, PaymentMethod payment, double money)
        {
            this.Name = name;
            this.ContactInfo = contactInfo;
            this.paymentMethod = payment;
            if (payment.ToString() == "DebitCard")
                this.CardBalance = money;
            else
                this.CardBalance = 0;
        }
        public bool PlaceOrder(Order order)
        {
            if (paymentMethod == PaymentMethod.DebitCard)
            {
                if (order.GetPrice(this) < this.CardBalance)
                {
                    CardBalance -= order.GetPrice(this);
                    return true;
                }
            }
            else if(paymentMethod.ToString() == "COD")
                return true;
            return false;
        }
        public override string ToString()
        {
            return this.Name + " Contact Info: " + this.ContactInfo;
        }
    }
}
