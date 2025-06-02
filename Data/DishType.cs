using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursov_Proekt4
{
    public class DishType
    {
        public int Id { get; set; }
        public int DishTypeId { get; set; }
        public string DishName { get; set; }
        public ICollection<Dish> Dishes { get; set; }
    }
}
