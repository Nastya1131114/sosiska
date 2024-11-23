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

namespace Sosiska3.Forms.WorkerForms
{
    /// <summary>
    /// Логика взаимодействия для AddWorker.xaml
    /// </summary>
    public partial class AddWorker : Window
    {
        public AddWorker()
        {
            InitializeComponent();
            Worker tmp = new Worker();
            DataContext = new AddWorkerViewModel(tmp);
            //DbContext context = new DbContext();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
