using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Companies;

namespace Delivery.Consumable
{
    public class ColorBox : Consumables
    {
        public override int Price => 40;
        public Color Color { get; }

        public ColorBox() { }
        public ColorBox(Color color)
        {
            Color = color;
        }
    }
}
