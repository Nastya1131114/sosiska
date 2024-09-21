using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sosiska.Model
{
    internal class Cooker
    {
        public int CookerId { get; set; }
        public int WorkerId { get; set; }
        public Category Category { get; set; }
    }
}
