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

namespace Sosiska3.Forms.Worker
{
    /// <summary>
    /// Логика взаимодействия для AddWorker.xaml
    /// </summary>
    public partial class AddWorker : Window
    {
        public AddWorker()
        {
            InitializeComponent();
            DataContext = new WorkerListViewModel();
            //MyDbContext context = new MyDbContext();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new MyDbContect())
            {
                var worker = new Worker();
                Surname = " ";
                Name = " ";
                MiddleName = "";
                DataTime = " ";
            };
            context.SaveChanges();

        }
    }
}
