using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sosiska.Model
{
    public class DishOrder
    {
        public int DishOrderID { get; set; }

        public int OrderID { get; set; }
        public Order Order { get; set; }

        public int DishId { get; set; }
        public Dish Dish { get; set; }
        public double Amount { get; set; } // сумма
    }
}
