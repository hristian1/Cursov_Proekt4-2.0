﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursov_Proekt4
{
    public class Dish
    {
        public int Id { get; set; }
        public string DishName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Weight { get; set; }
        public int DishTypeId { get; set; }
        public DishType DishType { get; set; }
    }
}
