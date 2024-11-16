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

namespace Sosiska3.Forms.Client
{
    /// <summary>
    /// Логика взаимодействия для OrderList.xaml
    /// </summary>
    public partial class OrderList : Window
    {
        public OrderList()
        {
            InitializeComponent();
            DataContext = new OrderListViewModel();
        }

        private void DGridMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.Close();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            this.Close();
            NewOrder newOrder = new NewOrder();
            newOrder.ShowDialog();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow main = new MainWindow();
            main.ShowDialog();
        }

    }
}
