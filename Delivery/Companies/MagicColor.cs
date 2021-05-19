using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Consumable;

namespace Delivery.Companies
{
    public class MagicColor : Company
    {
        public override bool Priority => false;
        public bool Ribbon { get; }
        public ColorBox ColorBox { get; }
        public ColoredRibbon ColoredRibbon { get; }
        public override int OrderСost { get; }

        public MagicColor(int orderСost, ColorBox colorBox, bool ribbon)
        {
            OrderСost = orderСost;
            ColorBox = colorBox;
            Ribbon = ribbon;
        }
        public MagicColor(int orderСost, ColorBox colorBox, bool ribbon, ColoredRibbon coloredRibbon)
        {
            OrderСost = orderСost;
            ColorBox = colorBox;
            Ribbon = ribbon;
            ColoredRibbon = coloredRibbon;
        }
    }
}
