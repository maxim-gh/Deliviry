using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Consumables
{ 
    public class DenseBox : Consumables
    {
        public override int Price => 30;
        public Filler Filler { get; }
    }
}
