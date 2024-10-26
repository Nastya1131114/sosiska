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
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
        public Client() 
        {
            Orders = new List<Order>();
        }
    }
}
