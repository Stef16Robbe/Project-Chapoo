using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class RestaurantMenuItem
    {
        public int MenuItemId { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public bool Vat { get; set; }
        public string Comment { get; set; }
    }
}