using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_EF_WCF
{
    public class MovieService : IServiceAdmin
    {       
        public void AddMovie(Movie movie, User user)
        {
            using (MoviesDb db = new MoviesDb())
            {
                db.Movies.Add(movie).User = user;
                db.SaveChanges();
            }
        }

        public void EditMovie(Movie movie)
        {
            using (MoviesDb db = new MoviesDb())
            {
                Movie editedMovie = db.Movies.FirstOrDefault(m => m.Id == movie.Id);
                if (editedMovie != null)
                {
                    editedMovie.Name = movie.Name;
                    editedMovie.Picture = movie.Picture;
                    editedMovie.Rating = movie.Rating;
                    editedMovie.Year = movie.Year;
                    db.SaveChanges();
                }
            }
        }

        public List<Movie> GetMovies()
        {
            List<Movie> movies = null;
            using (MoviesDb db = new MoviesDb())
            {
                movies = db.Movies.ToList();
            }
            return movies;
        }

        public User GetUser(string login, byte[] hash)
        {
            using (MoviesDb db = new MoviesDb())
            {  
                return db.Users.Include("Role").FirstOrDefault(u => u.Name == login && u.Password == hash);
            }
        }

        public void RemoveMovie(Movie movie)
        {            
            using (MoviesDb db = new MoviesDb())
            {             
                Movie removedMovie = db.Movies.FirstOrDefault(m => m.Id == movie.Id);
                if(removedMovie != null)
                {
                    db.Movies.Remove(removedMovie);
                    db.SaveChanges();
                }
            }
        }
    }
}
