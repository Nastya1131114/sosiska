using sosiska.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sosiska3.ViewModels.Abstractions
{
    public interface ICookerRemoveService
    {
        bool Remove(Cooker cooker);
    }
}
