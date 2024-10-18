using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sosiska.Model
{
    public class Order
    {
        public int OrderId { get; set; } 
        public int ClientId { get; set; }
        public Client Client { get; set; }
        //public Dish Dish { get; set; }  // убрать если что отсюда 

    }
}
