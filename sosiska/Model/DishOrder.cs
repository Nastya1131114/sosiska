using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sosiska.Model
{
    internal class DishOrder
    {
        public int DishOrderID { get; set; }
        public int OrderID { get; set; }
        public Dish Dish { get; set; }
        public double Amount { get; set; }
    }
}
