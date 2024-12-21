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

        public CookerListViewModel(ICookerCreatorService cookerCreator, ICookerRemoveService cookerRemove)
        {
            Cookers = new ObservableCollection<Cooker>( 
                MyDbContect.DefaultContext.Cookers.Include(d => d.Category)
                ); // сделать инклуд

            CookerCreatorService = cookerCreator;
            CookerRemoveService = cookerRemove;

            RemoveCommand = new RelayCommand((obj) =>
                {
                    if (CookerRemoveService.Remove(SelectedCooker))
                    {
                        Cookers.Remove(SelectedCooker);
                    }
                }, 
                (obj) => SelectedCooker != null
            );

            AddCommand = new RelayCommand( (obj) =>
            {
                Cooker ? newCooker = CookerCreatorService.CreateCooker();
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
        ICookerCreatorService CookerCreatorService { get; set; }
        ICookerRemoveService CookerRemoveService { get; set; }



        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public Cooker ? SelectedCooker { get; set; }
        public RelayCommand AddCommand { get; set; }
        public RelayCommand RemoveCommand { get; set; }
    }
}
