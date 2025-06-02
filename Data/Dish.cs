using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursov_Proekt4
{
    public class Dish
    {
        public int Id { get; set; }
        public DishType DishTypeId { get; set; }

        public string DishesName { get; set; }
        public DishType DishName { get; set; }

        public string Description { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }
        public DishType DishType { get; set; }
    }
}
