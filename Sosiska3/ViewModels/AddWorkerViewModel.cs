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
using Model;
using Sosiska3.ViewModels.Abstractions;

namespace Sosiska3.ViewModels
{
    public class AddWorkerViewModel : INotifyPropertyChanged
    {
        public Cooker Worker { get; set; }
        public IExitManager ExitManager { get; }

        public AddWorkerViewModel(Cooker newWorker, IExitManager exitManager)
        {
            Worker = newWorker;
            ExitManager = exitManager;
            Positions = MyDbContect.DefaultContext.Positions.ToList(); //мейби так 

            SaveCommand = new RelayCommand(
                (obj) =>
                {
                    MyDbContect.DefaultContext.Workers.Add(Worker);
                    MyDbContect.DefaultContext.SaveChanges(); // обрубается сохранения 
                    ExitManager.CloseForm();
                }

            );
        }
        public List<Position> Positions { get; set; } 
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public RelayCommand SaveCommand { get; set; }

    }
}
