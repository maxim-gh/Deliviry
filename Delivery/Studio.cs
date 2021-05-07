using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Companies;
using Delivery.Consumable;
using Delivery.Calculators;

namespace Delivery
{
    class Studio
    {
        private Storage _storage;
        private Calculator _calculator;
        public Studio(Storage storage, Calculator calculator)
        {
            _storage = storage;
            _calculator = calculator;
        }
        public int HandleOrder(Order order, Company company)
        {
            _storage.AddOrder(order);
            return _calculator.PriceCaculator(company);
        }
    }
}
