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
        public Cooker? EditCooker(Cooker cooker)
        {
                AddCooker editForm = new AddCooker();//cooker);
                editForm.ShowDialog();
                if (editForm.ViewModel.IsCookerSaved)
                {
                    return editForm.ViewModel.Cooker;
                }
                return null;
        }
    }
}


