using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Companies;
using Delivery.Consumable;

namespace Delivery
{
    public class Storage : Order
    {
        private Order[] _orders;
        public Storage(string deliveryAddress, string receiverName, Company company)
            :base(deliveryAddress, receiverName, company)
        {
            _orders = new Order[] { };
        }
        public void AddOrder(Order order)
        {
            Array.Resize(ref _orders, _orders.Length + 1);
            _orders[_orders.Length - 1] = order;
        }
    }
}
