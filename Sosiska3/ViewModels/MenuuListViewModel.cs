using sosiska.Model;
using sosiska;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Sosiska3.ViewModels
{
    class MenuuListViewModel : INotifyPropertyChanged
    {
        public MenuuListViewModel()
        {
             //= MySosiskaContect.DefaultContext.Workers.Include(d => d.Categories).ToList();
             //= MySosiskaContect.DefaultContext.Categories.ToList();
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
