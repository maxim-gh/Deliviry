using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Consumable;

namespace Delivery.Companies
{
    public class Order
    {
        public string DeliveryAddress { get; }
        public string ReceiverName { get; }
        public Company Company { get; }
        public Order(string deliveryAddress, string receiverName, Company company)
        {
            DeliveryAddress = deliveryAddress;
            ReceiverName = receiverName;
            Company = company;
        }
    }
}
