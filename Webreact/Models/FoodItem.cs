﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webreact.Models
{
    public class FoodItem
    {
        [Key]
        public int FoodItemId { get; set; }

        public string FoodItemName { get; set; }

        public decimal FoodItemPrice { get; set; }



    }
}
