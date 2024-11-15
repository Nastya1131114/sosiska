using System.Windows;
using sosiska.Model;
using sosiska;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sosiska3.ViewModels
{
    class OrderListViewModel : INotifyPropertyChanged
    {
        public OrderListViewModel()
        {
            Orders = MySosiskaContect.DefaultContext.Orders.Include(d => d.Clients).ToList();// Clients 
            Clients = MySosiskaContect.DefaultContext.Clients.ToList();
            //Dishes = MySosiskaContect.DefaultContext.Dishes.ToList();
        //    DishOrders = MySosiskaContect.DefaultContext.DishOrders.ToList();
        }
        //private List <Client> _clients;
        //private List<Client> Clients
        //{
        //    get { return _clients; }
        //    set
        //    { 
        //        _clients = value; 
        //        OnPropertyChanged();
        //    }
        //}
        private List<Order> _orders;
        public List<Order> Orders
        {
            get { return _orders; }
            set
            {
                _orders = value;
                OnPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        public List<Client> Clients { get; set; }
        //public List<Dish> Dishes { get; set; } 
        //public List<DishOrder> DishOrders { get; set; }
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public Worker SelectedWorker { get; set; }
    }
}