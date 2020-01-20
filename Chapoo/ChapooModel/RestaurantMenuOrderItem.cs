using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class RestaurantMenuOrderItem
    {
        public int orderId { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public int Table { get; set; }
        public DateTime dateOfOrder { get; set; }
    }
}
