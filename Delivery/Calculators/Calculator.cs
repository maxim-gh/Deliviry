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
        public int PriceCaculator(Company company)
        {
            if(company is GoldSecret)
            {
                var denseBox = new DenseBox();
                if (GoldSecret.FragileGoods == true)
                {
                    return company.OrderСost + denseBox.Price + denseBox.Filler.Price;
                }
                return company.OrderСost + denseBox.Price;
            }
            if(company is MagicColor)
            {
                var colorBox = new ColorBox();
                var coloredRibbon = new ColoredRibbon();
                if(colorBox.Ribbon == true)
                {
                    return company.OrderСost + colorBox.Price + coloredRibbon.Price;
                }
                return company.OrderСost + colorBox.Price;
            }
            var regularBox = new RegularBox();
            return company.OrderСost + regularBox.Price;
        }
    }
}
