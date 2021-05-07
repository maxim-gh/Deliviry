using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Company
{
    public abstract class  Company
    {
        public abstract int OrderСost { get; }
        public abstract Consumables Consumables { get; set; }
        public abstract bool Priority { get; }
    }
}
