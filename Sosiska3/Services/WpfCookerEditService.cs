using sosiska.Model;
using Sosiska3.Forms.WorkerForms;
using Sosiska3.ViewModels.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Sosiska3.Services
{
    public class WpfCookerEditService : ICookerEditService
    {
        public Cooker ? EditCooker()
        {
            //EditCooker editCooker = new EditCooker();
            EditCooker newCookerForm = new EditCooker(); //должна открыться форма для добавления, в которой изменяются данные для выбранного кукера 

            newCookerForm.ShowDialog();
            if (newCookerForm.ViewModel.IsCookerSaved)
            {
                return newCookerForm.ViewModel.Cooker;
            }
            return null;
        }
    }
}
