using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace sosiska.Model
{
    public class DishComponent
    {
        //todo: заменить поле ид на составной ключ
        public int Id { get; set; }
        public int DishId { get; set; }
        public Dish Dish { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public double Amount { get; set; }
    }
}
