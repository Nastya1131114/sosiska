using System.Windows;
using sosiska.Model;
using sosiska;
//using Sosiska3.Forms.Worker;
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
    public class DishListViewModel : INotifyPropertyChanged
    {
        public DishListViewModel()
        {
            Dishes = MyDbContect.DefaultContext.Dishes.ToList();
        }
        private List<Dish> _dishes;
        public List<Dish> Dishes
        {
            get { return _dishes; }
            set
            {
                _dishes = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public Dish SelectedWorker { get; set; }
    }

}
