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
    public class WpfCookerEditService : ICookerEditService
    {
        //будем возвращать true, если объект редактировался и сохранялся, иначе false
        public bool EditCooker(Cooker cooker)
        {
                AddCooker editForm = new AddCooker(cooker);
                editForm.ShowDialog();
                return editForm.ViewModel.IsCookerSaved;
        }
    }
}


