using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Companies;

namespace Delivery.Consumable
{
    public class ColoredRibbon : Consumables
    {
        public override int Price => 15;
        public Color Color { get; }
        public ColoredRibbon() { }
        public ColoredRibbon(Color color)
        {
            Color = color;
        }
    }
}
