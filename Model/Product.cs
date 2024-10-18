using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace sosiska.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public int NameProduct { get; set; }
        public ICollection<DishComponent> DishComponents { get; set; }
        public Product()
        {
            DishComponents = new List<DishComponent>();
        }

    }
}
