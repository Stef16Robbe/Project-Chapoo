using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Paycheck
    {
        public Table table { get; set; }
        public float totalCost { get; set; }
        public float tipAmount { get; set; }
        public float orderCost { get; set; }
    }
}
