using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Consumable;

namespace Delivery.Companies
{
    public class GoldSecret : Company
    {
        public override bool Priority => true;
        public bool FragileGoods { get; set; }
        public override int OrderСost { get; }
        public GoldSecret(int orderСost, bool fragileGoods)
        {
            OrderСost = orderСost;
            FragileGoods = fragileGoods;
        }
    }
}
