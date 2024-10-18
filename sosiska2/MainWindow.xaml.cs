using sosiska2;
using sosiska2.Forms.Worker;
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

namespace sosiska2
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

        //private void MenuItem_Click(object sender, RoutedEventArgs e)
        //{
        //    WorkerList worker = new WorkerList();
        //    worker.ShowDialog();
        //}
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            CookerWindow cooker = new CookerWindow();
            cooker.ShowDialog();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Category category = new Category();
            category.ShowDialog();  
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu(); 
            menu.ShowDialog();
        }
    }
}