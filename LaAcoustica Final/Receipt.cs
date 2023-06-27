using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaAcoustica_Final
{
    internal class Receipt
    {
        public string Invoice { get; set; }
        public string Date { get; set; }
        public string Product { get; set; }
        public string Price { get; set; }
        public int Quantity { get; set; }
        public string Total { get; set; }
        public int ItemCount { get; set; }
    }
}
