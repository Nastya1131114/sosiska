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
    public class AddCookerViewModel : INotifyPropertyChanged
    {
        public Cooker Cooker { get; set; }
        public IExitManager ExitManager { get; }

        public AddCookerViewModel(Cooker newCooker, IExitManager exitManager)
        {
            Cooker = newCooker;
            ExitManager = exitManager;
            Categories = MyDbContect.DefaultContext.Categories.ToList(); //мейби так 

            SaveCommand = new RelayCommand(
                (obj) =>
                {
                    MyDbContect.DefaultContext.Cookers.Add(Cooker);
                    MyDbContect.DefaultContext.SaveChanges(); // обрубается сохранения 
                    ExitManager.CloseForm();
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
