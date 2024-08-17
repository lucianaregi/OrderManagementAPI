using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Domain.Entities
{
   
    public class Order
    {
        public int OrderId { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public double GetTotal()
        {
            return Quantity * Price;
        }
    }

    

    

}
