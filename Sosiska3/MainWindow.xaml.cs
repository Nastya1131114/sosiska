using Sosiska3.Forms;
using Sosiska3.Forms.Client;
using Sosiska3.Forms.Dish;
using Sosiska3.Forms.Worker;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sosiska3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            WorkerShowList workershow = new WorkerShowList();
            workershow.ShowDialog();
        }
        private void Menu_Click1(object sender, RoutedEventArgs e)
        {
            MenuuList menus = new MenuuList();
            menus.ShowDialog();
        }

        private void OrderList(object sender, RoutedEventArgs e)
        {
            this.Hide();
            OrderList order = new OrderList();
            order.ShowDialog();
        }
    }
}