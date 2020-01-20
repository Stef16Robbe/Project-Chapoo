using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Table
    {
        public int TableId { get; set; }//TableNumber
        public bool Free { get; set; } //Check if table is free
        public int OrderId { get; set; }
    }
}
