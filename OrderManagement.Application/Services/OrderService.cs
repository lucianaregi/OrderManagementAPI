using OrderManagement.Domain.Entities;
using OrderManagement.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Application.Services
{
    
    public class OrderService
    {
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly INotificationService _notificationService;

        public OrderService(IPaymentProcessor paymentProcessor, INotificationService notificationService)
        {
            _paymentProcessor = paymentProcessor;
            _notificationService = notificationService;
        }

        public void CreateOrder(Order order)
        {
            Console.WriteLine("Order created with Id: " + order.OrderId);

            _paymentProcessor.ProcessPayment(order);
            _notificationService.NotifyCustomer(order);
        }
    }

}
