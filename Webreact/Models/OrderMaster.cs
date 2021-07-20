using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webreact.Models
{
    public class OrderMaster
    {
        public int OrderMasterId { get; set; }

        public int OrderNumber { get; set; }

        public int CustocmerId { get; set; }
        public Customer Customer  { get; set; }
        public string PaymentMethod { get; set; }

        public decimal Grandtotal { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
    }
}
