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
            //DbContext context = new DbContext();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string ConnectionString = @"Server=.\\SQLEXPRESS;Database= Sosiska; Trusted_Connection=True; TrustServerCertificate=True";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Workers (Surname, Name, MiddleName, Datatime) value (@Surname, @Name, @MiddleName, @Datatime)");
                command.Connection = conn;
                command.Parameters.AddWithValue("Surname", TextBox.Text);
            }
            //using (var context = new MyDbContect())
            //{
            //    var worker = new Worker();
            //    Surname = " ";
            //    Name = " ";
            //    MiddleName = "";
            //    DataTime = " ";
            //};
            //context.SaveChanges();

        }
    }
}
