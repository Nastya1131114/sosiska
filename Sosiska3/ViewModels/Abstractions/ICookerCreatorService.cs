using sosiska.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sosiska3.ViewModels.Abstractions
{
    /// <summary>
    /// интерфейс сервиса, который будет отвечать за создание кукеров
    /// </summary>
    public interface ICookerCreatorService
    {
        //описание метода, который будет возвращать кукера
        Cooker ? CreateCooker();
    }
}
