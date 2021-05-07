using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Company
{
    public class MagicColor : Company
    {
        public override bool Priority => false;
        public ColorBox ColorBox { get; }
        public override int OrderСost { get; }
        public override Consumables Consumables{get => new ColorBox(); set{}}
        public MagicColor(int orderСost, Consumables consumables)
        {
            OrderСost = orderСost;
            Consumables = consumables;
        }
    }
}
