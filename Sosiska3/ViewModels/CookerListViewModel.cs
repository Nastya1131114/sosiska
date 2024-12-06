using Microsoft.EntityFrameworkCore;
using sosiska;
using sosiska.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Sosiska3.ViewModels
{
    public class CookerListViewModel : INotifyPropertyChanged
    {
        public CookerListViewModel()
        {
            Cookers = MyDbContect.DefaultContext.Cookers.Include(d => d.Category).ToList(); // сделать инклуд
        }
        private List<Cooker> _cookers;
        public List<Cooker> Cookers
        {
            get { return _cookers; }
            set
            {
                _cookers = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public Cooker SelectedWorker { get; set; }
    }
}
