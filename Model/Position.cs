using sosiska.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Position
    {
        public int Id { get; set; }
        public string PositionName { get; set; }
        public ICollection<Cooker> Workers { get; set; }
        public Position()
        {
            Workers = new List<Cooker>();
        }
    }
}
