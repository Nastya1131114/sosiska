using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sosiska.Model
{
    public class Client
    {
        public int ClientId { get; set; } 
        public string ClientName { get; set; }
        public ICollection<Order> Orders { get; set; }
        public Client() 
        {
            Orders = new List<Order>();
        }
    }
}
