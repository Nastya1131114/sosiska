using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sosiska.Model
{
    public class Menu
    {
        public int Id { get; set; }
        public int MenuId{ get; set; }
        public ICollection<Dish> Dishes { get; set; }
        public Menu()
        {
            Dishes = new List<Dish>();
        }
    }
}
