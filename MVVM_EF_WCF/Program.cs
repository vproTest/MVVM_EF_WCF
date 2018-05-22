using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_EF_WCF
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (ServiceHost host = new ServiceHost(typeof(MovieService)))
                {
                    host.Open();
                    Console.WriteLine("Служба {0} {1} запущена.\nДля остановки нажмите любую клавишу...",
                        host.Description.Name, host.Description.Endpoints[0].Address.ToString());
                    Console.ReadKey(true);
                    Console.WriteLine("Служба {0} остановлена", host.Description.Name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
