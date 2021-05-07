using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Company
{
    public class SimpleFirm : Company
    {
        public override bool Priority => false;
        public override int OrderСost { get; }
        public override Consumables Consumables { get => new RegularBox(); set { } }
        public SimpleFirm(int orderСost)
        {
            OrderСost = orderСost;
        }
    }
}
