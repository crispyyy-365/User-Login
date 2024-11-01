using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Order
    {
        private int _count {  get; set; } = 0;
        public int _orderId {  get; set; }
        public string CustomerName { get; set; }

        public Order (string customerName)
        {
            customerName = CustomerName;
            _orderId = ++_count;
        }
        OrderStatus Status { get; set; }
    }
}