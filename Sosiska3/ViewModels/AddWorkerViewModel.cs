using sosiska.Model;
using sosiska;
using System;
using Sosiska3.Forms.WorkerForms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Sosiska3.ViewModels
{
    public class AddWorkerViewModel : INotifyPropertyChanged
    {
        public Worker Worker { get; set; }

        public AddWorkerViewModel(Worker newWorker)
        {
            Worker = newWorker;
            Categories = MyDbContect.DefaultContext.Categories.ToList(); //мейби так 

            SaveCommand = new RelayCommand(
                (obj) =>
                {
                    MyDbContect.DefaultContext.Workers.Add(Worker);
                    MyDbContect.DefaultContext.SaveChanges(); // обрубается сохранения 
                }

            );
        }
        public List<Category> Categories { get; set; } 
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public RelayCommand SaveCommand { get; set; }

    }
}
