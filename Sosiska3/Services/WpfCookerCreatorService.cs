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
    public class WpfCookerCreatorService : ICookerCreatorService
    {
        public Cooker? CreateCooker()
        {
            AddCooker newCookerForm = new AddCooker();
            newCookerForm.ShowDialog();
            if (newCookerForm.ViewModel.IsCookerSaved)
            {
                return newCookerForm.ViewModel.Cooker;
            }
            return null;
        }
    }
}
