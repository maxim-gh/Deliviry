using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Consumables
{
    public class ColorBox : Consumables
    {
        public override int Price => 40;
        public Color Color { get; }
        public ColoredRibbon ColoredRibbon { get; }
        public ColorBox() { }
        public ColorBox(Color color)
        {
            Color = color;
        }
        public ColorBox(Color color, ColoredRibbon coloredRibbon)
        {
            Color = color;
            ColoredRibbon = coloredRibbon;
        }
    }
}
