using OrderManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Domain.Services
{
    
    public interface IPaymentProcessor
    {
        void ProcessPayment(Order order);
    }
}
