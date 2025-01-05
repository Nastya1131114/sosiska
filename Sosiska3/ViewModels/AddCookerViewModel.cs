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
                    if( IsNewCooker) {
                        MyDbContect.DefaultContext.Cookers.Add(Cooker);
                    }
                    if (IsCookerMustBeSaved) {
                        MyDbContect.DefaultContext.SaveChanges(); // обрубается сохранения 
                        IsCookerSaved = true;
                    }
                    ExitManager.CloseForm();
                }
            );

            CancelCommand = new RelayCommand(
                (obj) =>
                {
                    if (IsCookerChanged) {
                        //за счет биндинга у нас изменились поля объекта, однако пользователь нажал отмену,
                        //поэтому нужно загрузить текущие значения полей объекта (более правильная альтренатива - перед редактированием делать копию)
                        MyDbContect.DefaultContext.Entry(Cooker).Reload();
                        OnPropertyChanged(null);
                    }

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
        
        public RelayCommand CancelCommand { get; set; }

        public bool IsCookerSaved { get; set; } = false;


        private bool IsCookerMustBeSaved
        {
            get
            {
                return IsCookerChanged || IsNewCooker;
            }
        }


        /// <summary>
        /// Свойство, определяющее состояние объекта (новый) или сушествующий.  
        /// </summary>
        private bool IsNewCooker
        {
            get
            {
                /// Если новый, у него будет состояние Detached в EntityFramework, что означает, что объект не присоединен к контексту
                return MyDbContect.DefaultContext.Entry(Cooker).State == EntityState.Detached;
            }
        }

        /// <summary>
        /// Свойство, показывающее, что объет изменен (либо отсутствует в БД)
        /// </summary>
        private bool IsCookerChanged
        {
            get
            {
                var cookerState = MyDbContect.DefaultContext.Entry(Cooker).State;
                return cookerState == EntityState.Modified;
            }
        }

    }
}
