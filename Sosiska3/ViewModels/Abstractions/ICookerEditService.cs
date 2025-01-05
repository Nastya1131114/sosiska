using sosiska.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sosiska3.ViewModels.Abstractions
{
    /// <summary>
    /// интерфейс сервиса, который будет отвечать за редактирование кукеров
    /// </summary>
    public interface ICookerEditService
    {
       Cooker? EditCooker(Cooker cooker);
        
    }
}
