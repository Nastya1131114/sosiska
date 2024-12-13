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
using System.Windows.Media.TextFormatting;
using System.Windows.Shapes;

namespace Sosiska3.Forms.Dish
{
    /// <summary>
    /// Логика взаимодействия для MenuuList.xaml
    /// </summary>
    public partial class MenuuList : Window
    {
        public MenuuList()
        {
            InitializeComponent();
            DataContext = new DishListViewModel();
        }

        private void DGridMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
