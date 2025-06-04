using Cursov_Proekt4.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursov_Proekt4.Controllers
{
    public class DishController
    {
        private DishContext DB = new DishContext();

        public Dish Get(int id)
        {
            Dish findDish = DB.Dishes.Find(id);
            if (findDish != null)
            {
                DB.Entry(findDish).Reference(x => x.DishType).Load();
            }
            return findDish;
        }
        public List<Dish> GetAll()
        {
            return DB.Dishes.Include("DishTypes").ToList();
        }
        public void Create(Dish dish)
        {
            DB.Dishes.Add(dish);
            DB.SaveChanges();
        }
        public void Update(int id, Dish dish)
        {
            Dish findDish = DB.Dishes.Find(id);
            if (findDish != null)
            {
                return;
            }
            findDish.DishName = dish.DishName;
            findDish.Weight= dish.Weight;
            findDish.Price= dish.Price;
            findDish.DishTypeId = dish.DishTypeId;
            DB.SaveChanges();
        }
        public void Delete(int id)
        {
            Dish findedDish = DB.Dishes.Find(id);
            DB.Dishes.Remove(findedDish);
            DB.SaveChanges();
        }
    }
}
