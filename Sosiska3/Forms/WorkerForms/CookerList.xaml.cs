using Microsoft.Data.SqlClient;
using sosiska.Model;
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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Sosiska3.Forms.WorkerForms
{
    /// <summary>
    /// Логика взаимодействия для WorkerShowList.xaml
    /// </summary>
    public partial class CookerList : Window
    {
        public CookerList()
        {
            InitializeComponent();
            DataContext = new CookerListViewModel();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            AddCooker addCooker = new AddCooker();
            addCooker.ShowDialog();

            DataContext = new CookerListViewModel();

        }
    }
}
