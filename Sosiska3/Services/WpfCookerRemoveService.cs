using sosiska;
using sosiska.Model;
using Sosiska3.Forms.WorkerForms;
using Sosiska3.ViewModels.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace Sosiska3.Services
{
    public class WpfCookerRemoveService : ICookerRemoveService
    {
        public bool Remove(Cooker cooker)
        {
            //показываем MessageBox с предложением удалить кукера
            //если пользователь нажал ок, то возвращаем труе, иначе фалсе
            if( MessageBox.Show($"Вы действительно хотите удалить сотрудника {cooker.CookerName}?", "подтверждение удаления", MessageBoxButton.YesNo) 
                == MessageBoxResult.Yes)
            {
                MyDbContect.DefaultContext.Cookers.Remove(cooker);
                MyDbContect.DefaultContext.SaveChanges();
                return true;
            }
            else
            {
                return false; 
            }
        }
    }
}
