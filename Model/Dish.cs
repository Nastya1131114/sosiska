using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sosiska.Model
{
    public class Dish
    {
        //todo: добавить категории
        //todo: сделать многие ко многим с меню
        public int DishId { get; set; }
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
        public string DishName { get; set; }
        public int DishCost { get; set; }
        public ICollection<DishComponent > DishComponents { get; set; }
        public Dish()
        {
            DishComponents = new List<DishComponent>();
        }

    }
}
