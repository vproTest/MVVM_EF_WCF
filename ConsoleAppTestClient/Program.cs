using ConsoleAppTestClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ConsoleAppTestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = GetUser("Helg", "123456");
        }

        static void TestGetMovies()
        {
            using (ServiceReference1.ServiceAdminClient client = new ServiceReference1.ServiceAdminClient())
            {
                List<ServiceReference1.Movie> movies = client.GetMovies().ToList();
                foreach (ServiceReference1.Movie movie in movies)
                {
                    Console.WriteLine(movie.Name);
                }
                Console.ReadKey(true);
            }
        }

        static User GetUser(string login, string password)
        {
            using (ServiceReference1.ServiceAdminClient client = new ServiceReference1.ServiceAdminClient())
            {             

                User user = null;
                try
                {
                    var md5 = new MD5CryptoServiceProvider();
                    user = client.GetUser(login, md5.ComputeHash(Encoding.Default.GetBytes(password)));
                }
                catch (Exception ex)
                {
                    Exception inner = ex.InnerException;
                }
                return user;
            }
        }
    }
}
