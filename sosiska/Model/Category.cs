using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sosiska.Model
{
    internal class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Cooker>Cookers { get; set; }
        public Category() 
        { 
            Cookers= new List<Cooker>();
        }
    }
}
