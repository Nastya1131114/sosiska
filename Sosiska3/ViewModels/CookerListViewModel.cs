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

        public CookerListViewModel(ICookerCreatorService cookerCreator, ICookerRemoveService cookerRemove, ICookerEditService cookerEdit)
        {
            Cookers = new ObservableCollection<Cooker>(
                MyDbContect.DefaultContext.Cookers.Include(d => d.Category)
                ); // сделать инклуд

            CookerCreatorService = cookerCreator;//создание 
            CookerRemoveService = cookerRemove;//удаление
            CookerEditService = cookerEdit;//редактирование 

            RemoveCommand = new RelayCommand((obj) =>//удаление 
                {
                    if (CookerRemoveService.Remove(SelectedCooker))
                    {
                        Cookers.Remove(SelectedCooker);
                    }
                },
                (obj) => SelectedCooker != null
            );

            AddCommand = new RelayCommand((obj) =>//добавление
            {
                Cooker? newCooker = CookerCreatorService.CreateCooker();
                if (newCooker != null)
                {
                    Cookers.Add(newCooker);
                }
            });

            EditCommand = new RelayCommand((obj) =>//редактирование
            {
                if (_selectedCooker != null)
                    return;
                Cooker? cookerEdit = CookerEditService.EditCooker(SelectedCooker);
            });

        }
        private ObservableCollection<Cooker> _cookers = null!;
        private object _selectedCooker;

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
        ICookerEditService CookerEditService { get; set; }



        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public Cooker ? SelectedCooker { get; set; }
        public RelayCommand AddCommand { get; set; }
        public RelayCommand RemoveCommand { get; set; }
        public RelayCommand EditCommand { get; set; }
    }
}
