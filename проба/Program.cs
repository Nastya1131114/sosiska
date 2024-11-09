using Microsoft.Data.SqlClient;
using sosiska;
using sosiska.Model;

namespace проба
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SqlConnection sqlConnection = new SqlConnection("Server=.\\SQLEXPRESS;Database= Sosiska; Trusted_Connection=True; TrustServerCertificate=True;");


            //sqlConnection.Open();

            //SqlCommand cmd = sqlConnection.CreateCommand();
            //cmd.CommandText = "select * from categories";
            //var reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    Console.WriteLine(reader["categoryname"] + " " + reader["id"]);
            //}

            MySosiskaContect mySosiskaContect = new MySosiskaContect();
            MySosiskaContect mySosiskaContect2 = new MySosiskaContect();
            
            var categories  = mySosiskaContect.Categories.ToArray();// перебор в массиве
            foreach (var category in categories)
            {
                Console.WriteLine(category.CategoryName + " " + category.Id);
            }

            var cat = new Category()
            {
                CategoryName = "не спать"
            };
            mySosiskaContect.Categories.Add(cat);   
            mySosiskaContect.SaveChanges();
        }
    }
}
