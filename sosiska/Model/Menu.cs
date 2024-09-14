using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sosiska.Model
{
    internal class Menu
    {
        public int MenuId { get; set; }
        public ICollection<Dish> Dishes { get; set; }
        public Menu()
        {
            Dishes = new List<Dish>();
        }
    }
}
