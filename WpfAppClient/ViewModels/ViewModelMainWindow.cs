using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppClient.ServiceReference1;

namespace WpfAppClient
{
    public class ViewModelMainWindow : INotifyPropertyChanged
    {
        ServiceAdminClient _proxy = new ServiceAdminClient();
        ObservableCollection<Movie> _movies;
        Movie _selectedMovie;
        IDialogService _idialogService;
        User _user;

#region Commads
        MyCommand _delCommand;
        public MyCommand DelCommand
        {
            get
            {
                return _delCommand ??
                    (_delCommand = new MyCommand(async e =>
                    {
                        if (SelectedMovie != null)
                        {                            
                            await _proxy.RemoveMovieAsync(SelectedMovie);                           
                            Refresh();
                        }
                    },
                    ce => Movies.Count > 0 && SelectedMovie != null));
            }
        }

        MyCommand _selectImage;
        public MyCommand SelectImage
        {
            get
            {
                return _selectImage ??
                   (_selectImage = new MyCommand(e =>
                   {
                       if(_idialogService.OpenFileDialog() == true)
                       {
                           if (SelectedMovie == null)
                           {                              
                               Movie movie = new Movie();                               
                               Movies.Add(movie);                             
                               SelectedMovie = movie;
                           }
                           SelectedMovie.Picture = File.ReadAllBytes(_idialogService.FilePath);                    
                       }
                   }));
            }
        }

        MyCommand _addCommand;
        public MyCommand AddCommand
        {
            get
            {
                return _addCommand ??
                    (_addCommand = new MyCommand(async e =>
                    {
                        await _proxy.AddMovieAsync(SelectedMovie, _user);
                        Refresh();                        
                    },
                    ce => SelectedMovie != null && (bool)ce == true));
            }
        }

        MyCommand _editCommand;
        public MyCommand EditCommand
        {
            get
            {
                return _editCommand ??
                    (_editCommand = new MyCommand(async e =>
                    {
                        await _proxy.EditMovieAsync(SelectedMovie);
                        _idialogService.ShowMessage(string.Format("Новые значения{0}Название: {1}{2}Год: {3}, Рейтинг: {4}",
                            Environment.NewLine, SelectedMovie.Name, Environment.NewLine, 
                            SelectedMovie.Year, SelectedMovie.Rating), "Выполнено обновление", System.Windows.MessageBoxButton.OK, 
                            System.Windows.MessageBoxImage.Information);
                    },
                    ce => SelectedMovie != null && (bool)ce == true));
            }
        }
#endregion

        public ViewModelMainWindow(IDialogService idialogService, User user)
        {
            _user = user;
            _idialogService = idialogService;
            Refresh();   
        }

        private void Refresh()
        {
            Movies = new ObservableCollection<Movie>(_proxy.GetMovies());          
        }

        public ObservableCollection<Movie> Movies
        {
            get { return _movies; }
            set
            {
                if(_movies != value)
                {
                    _movies = value;
                    OnPropertyChanged("Movies");
                }
            }
        }

        public Movie SelectedMovie
        {
            get { return _selectedMovie; }
            set
            {
                if(_selectedMovie != value)
                {
                    _selectedMovie = value;
                    OnPropertyChanged("SelectedMovie");
                }
            }
        }

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
