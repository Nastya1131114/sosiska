using Microsoft.EntityFrameworkCore;
using sosiska.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sosiska
{
    internal class MySosiskaContect : DbContext
    {

        public DbSet<Dish> Dishes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database= Sosiska; Trusted_Connection=True; TrustServerCertificate=True;");
        }
        public DbSet<Menu> Menus { get; set; }
    }
       

}
