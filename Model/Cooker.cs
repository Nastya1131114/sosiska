using Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sosiska.Model
{

    public class Cooker
    {
        public int CookerId { get; set; }
        public string CookerSurname { get; set; }
        public string CookerName { get; set; }
        public string CookerMiddleName { get; set; }
        public DateTime CookerBirthday { get; set; }

        public Category? Category { get; set; }
        //public Cooker Worker { get; set; }

    }
}

