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
        public DbSet<Product> Products { get; set; }

        public DbSet<Cooker> Cookers { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Category> Grades  { get; set; }
        public DbSet<Client>  Clients {get; set; }
        public DbSet<DishOrder> DishOrders  { get; set; }
        public DbSet<Order> Orders { get; set; }
        //public DbSet<>  { get; set; }
}


}
