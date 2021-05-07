using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delivery.Companies;

namespace Delivery.Consumable
{ 
    public class DenseBox : Consumables
    {
        public override int Price => 30;
        public Filler Filler { get; }
    }
}
