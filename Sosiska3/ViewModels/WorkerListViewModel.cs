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
    public class WorkerListViewModel : INotifyPropertyChanged
    {
        public WorkerListViewModel()
        {
            Workers = MySosiskaContect.DefaultContext.Workers.Include(d=>d.Categories).ToList();
        }
        private List<Worker> _workers;
        public List<Worker> Workers
        {
            get { return _workers; }
            set
            {
                _workers = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public Worker SelectedWorker { get; set; }
    }
}
