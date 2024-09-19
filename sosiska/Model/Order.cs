using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sosiska.Model
{
    internal class Order
    {
        public int Id { get; set; } 
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public Dish Dish { get; set; }  // ??
        public Menu Menu { get; set; } //??
    }
}
