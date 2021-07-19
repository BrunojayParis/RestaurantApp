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

        public int CustomerId { get; set; }

        public string PaymentMethod { get; set; }

        public decimal Grandtotal { get; set; }
    }
}
