using OrderManagement.Domain.Entities;
using OrderManagement.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Infrastructure.Email
{
    
    public class EmailNotificationService : INotificationService
    {
        public void NotifyCustomer(Order order)
        {
            Console.WriteLine("Email sent for Order Id: " + order.OrderId);
        }
    }
}
