using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTest.Models {
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public string CustomerID { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCountry { get; set; }
        public string ShipCity { get; set; }
    }
}
