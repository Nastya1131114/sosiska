using Microsoft.EntityFrameworkCore;
using sosiska;
using sosiska.Model;
using Sosiska3.ViewModels.Abstractions;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Sosiska3.ViewModels
{
    public class CookerListViewModel : INotifyPropertyChanged
    {
        public CookerListViewModel(ICookerCreatorService cookerCreator)
        {
            Cookers = new ObservableCollection<Cooker>( 
                MyDbContect.DefaultContext.Cookers.Include(d => d.Category)
                ); // сделать инклуд

            CookerCreator = cookerCreator;

            AddCommand = new RelayCommand( (obj) =>
            {
                Cooker ? newCooker = CookerCreator.CreateCooker();
                if(newCooker != null)
                {
                    Cookers.Add(newCooker);
                }
            });
        }
        private ObservableCollection<Cooker> _cookers = null!;
        public ObservableCollection<Cooker>  Cookers
        {
            get { return _cookers; }
            set
            {
                _cookers = value;
                OnPropertyChanged();
            }
        }

        ICookerCreatorService CookerCreator { get; set; }


        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public Cooker ? SelectedWorker { get; set; }
        public RelayCommand AddCommand { get; set; }
    }
}
