using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Consumable;

namespace Delivery.Companies
{
    public class SimpleFirm : Company
    {
        public override bool Priority => false;
        public override int OrderСost { get; }
        public SimpleFirm() { }
        public SimpleFirm(int orderСost)
        {
            OrderСost = orderСost;
        }
    }
}
