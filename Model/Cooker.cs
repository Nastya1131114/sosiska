using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sosiska.Model
{

    public class Cooker
    {
        public int CookerId { get; set; }
        //public int DishID { get; set; } 
        public Category Category { get; set; }
        public Cooker Worker { get; set; }

    }
}
