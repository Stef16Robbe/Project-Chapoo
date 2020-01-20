using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class RestaurantMenuOrder
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public string Name { get; set; }

        public string Comment { get; set; }

        public int Count { get; set; }

        public bool ReadyForServe{ get; set; }

        public bool MenuOrderServed { get; set; }

        public DateTime TimeOfOrder { get; set; }

        public int ActiveUser { get; set; }

        public int TableId { get; set; }

    }
}
