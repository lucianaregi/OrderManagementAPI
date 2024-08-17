using OrderManagement.Domain.Entities;
using OrderManagement.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Infrastructure.Payment
{
    
    public class PayPalPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(Order order)
        {
            Console.WriteLine("Payment processed via PayPal for Order Id: " + order.OrderId);
        }
    }
}
