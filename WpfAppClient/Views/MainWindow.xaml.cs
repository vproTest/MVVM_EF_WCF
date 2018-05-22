using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppClient.ServiceReference1;

namespace WpfAppClient
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {     
        public MainWindow(User user)
        {
            InitializeComponent();          
                       
            Loaded += async (s, e) =>
            {               
                Title = user.Name;  
                if(!user.Role.Name.Equals("admin"))
                {
                    GridAdmin.Visibility = Visibility.Collapsed;
                }
                await Task.Factory.StartNew(() => Dispatcher.Invoke(()=> this.DataContext = new ViewModelMainWindow(new DialogService(), user))); 
            };
        }
    }
}
