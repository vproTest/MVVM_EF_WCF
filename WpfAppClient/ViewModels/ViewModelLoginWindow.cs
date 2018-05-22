using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfAppClient
{
    public class ViewModelLoginWindow : INotifyPropertyChanged
    {
        string _login = "Helg";
        string _password = "123456";       
        public string Login
        {
            get { return _login; }
            set
            {
                if(_login != value)
                {
                    _login = value;
                    OnPropertyChanged("Login");
                }
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged("Password");
                }
            }
        }

        public Action CloseAction { get; set; }

        #region Commands
        MyCommand _passwordChangedCommand;
        public MyCommand PasswordChangedCommand
        {
            get
            {
                return _passwordChangedCommand ??
                    (_passwordChangedCommand = new MyCommand(e =>
                        {
                            PasswordBox passwordBox = e as PasswordBox;
                            if (passwordBox != null)
                            {
                                Password = passwordBox.Password;
                            }
                        }
                    ));
            }
        }

        MyCommand _passwordTextBoxChangedCommand;
        public MyCommand PasswordTextBoxChangedCommand
        {
            get
            {
                return _passwordTextBoxChangedCommand ??
                    (_passwordTextBoxChangedCommand = new MyCommand(e =>
                    {
                        TextBox textBox = e as TextBox;
                        if (textBox != null)
                        {
                            Password = textBox.Text;
                        }
                    }));
            }
        }


        MyCommand _cancelCommand;
        public MyCommand CancelCommand
        {
            get
            {
                return _cancelCommand ??
                    (_cancelCommand = new MyCommand(e =>
                    {
                        CloseAction();
                    }));
            }
        }


        MyCommand _loginCommand;
        public MyCommand LoginCommand
        {
            get
            {
                return _loginCommand ??
                    (_loginCommand = new MyCommand(async e =>
                    {
                        using (ServiceReference1.ServiceAdminClient proxy = new ServiceReference1.ServiceAdminClient())
                        {
                            var md5 = new MD5CryptoServiceProvider();
                            byte[] hash = md5.ComputeHash(Encoding.Default.GetBytes(Password.Trim()));
                            ServiceReference1.User user = await proxy.GetUserAsync(Login.Trim(), hash);                           
                            if (user != null)
                            {
                                MainWindow mainWindow = new MainWindow(user);
                                mainWindow.Show();
                                CloseAction();
                            }
                            else
                            {
                                MessageBox.Show("Ошибка логина и/или пароля", "Ошибка аутентификации", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                        }
                    }, 
                    ce => !string.IsNullOrWhiteSpace(Login.Trim()) && !string.IsNullOrWhiteSpace(Password.Trim())));
            }
        }
        #endregion

        private void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}
