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
using sosiska.Model;

namespace Sosiska3.Forms
{
    /// <summary>
    /// Логика взаимодействия для Worker.xaml
    /// </summary>
    public partial class WorkerList : Window
    {
        public WorkerList()
        {
            InitializeComponent();
            DataContext = new Worker()
            {
                Surname = "sdffdsfds" 
            };

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
