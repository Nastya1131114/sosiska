using Sosiska3.Forms;
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
            WorkerList worker = new WorkerList();
            worker.ShowDialog();
        }
        private void Menu_Click1(object sender, RoutedEventArgs e)
        {
            

        }

        private void Order(object sender, RoutedEventArgs e)
        {
            OrderPagexaml orderPage = new OrderPagexaml();  
            orderPage.ShowsNavigationUI = true;
        }
    }
}