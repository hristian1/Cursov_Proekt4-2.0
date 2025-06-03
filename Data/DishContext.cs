using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Cursov_Proekt4.Data
{
    public class DishContext : DbContext
    { 
        public DishContext() : base("Delivery")
        { }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<DishType> DishTypes { get; set; }
    


    }
}
