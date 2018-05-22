using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppClient
{
    public class DialogService : IDialogService
    {
        public string FilePath { get; set; }
        public bool OpenFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            { Filter = "Image Files(*.jpg, *.jpeg, *.png, *.bmp) | *.jpg; *.jpeg; *.png; *.bmp;" };
            if(openFileDialog.ShowDialog() == true)
            {
                FilePath = openFileDialog.FileName;
                return true;
            }
            return false;
        }

        public void ShowMessage(string message, string caption, MessageBoxButton button, MessageBoxImage image)
        {
            MessageBox.Show(message, caption, button, image);
        }
    }
}
