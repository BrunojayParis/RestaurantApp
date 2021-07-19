using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webreact.Models
{
    public class OrderDetails
    {
        [Key]
        public int OrderMasterId { get; set; }

        public int FoodItemId { get; set; }

        public decimal FoodItemPrice { get; set; }

        public int Quantity { get; set; }

    }
}
