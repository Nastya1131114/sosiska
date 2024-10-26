using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sosiska.Model
{
    public class Worker
    {
        public int WorkerId { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public DateTime Birthday { get; set; }

        public virtual ICollection<Category> Categories { get; set; } = new List<Category>();
       // public Cooker? Cooker { get; set; } ВОЗМОЖНО УБРАТЬ   
    }
}
