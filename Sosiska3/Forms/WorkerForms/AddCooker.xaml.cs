using Microsoft.EntityFrameworkCore;
using sosiska;
using Sosiska3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Data.SqlClient;
using sosiska.Model;
using Sosiska3.ViewModels.Abstractions;



namespace Sosiska3.Forms.WorkerForms
{
    /// <summary>
    /// Логика взаимодействия для AddWorker.xaml
    /// </summary>
    public partial class AddCooker  : Window, IExitManager
    {
        public AddCooker()
        {
            InitializeComponent();
            Cooker p = new Cooker();
            DataContext = new AddCookerViewModel(p, this);
            //DbContext context = new DbContext();
        }

        public void CloseForm()
        {
            Close();
        }

        public void CookerBack(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
