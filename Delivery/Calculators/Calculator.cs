using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Companies;
using Delivery.Consumable;

namespace Delivery.Calculators
{
    public class Calculator
    {
        private ICalculator[] _concreteCalculators;

        public Calculator(ICalculator[] concreteCalculators)
        {
            _concreteCalculators = concreteCalculators;
        }

        public int PriceCalculator(Company company) 
        {
            foreach (var concreteCalculator in _concreteCalculators)
            {
                if (concreteCalculator.IsSuitable(company))
                {
                    return concreteCalculator.PriceCalculator(company);
                }
            }

            throw new ArgumentException("Неизвестная компания");
        }
    }
}
