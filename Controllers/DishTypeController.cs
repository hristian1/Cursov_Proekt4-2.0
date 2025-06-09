
using Cursov_Proekt4.Data;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cursov_Proekt4.Controllers
{
    public class DishTypeController
    {
        private DishContext DB2 = new DishContext();

        public List<DishType> GetAllDishTypes()
        {
            return DB2.DishTypes.ToList();
        }
        public int GetDishTypeById(int id)
        {
            return DB2.DishTypes.Find(id).DishTypeId;
        }
    }
}
