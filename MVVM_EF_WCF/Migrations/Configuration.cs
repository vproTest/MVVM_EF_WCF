namespace MVVM_EF_WCF.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;

    internal sealed class Configuration : DbMigrationsConfiguration<MoviesDb>
    {
        DirectoryInfo _directoryInfo;
        public Configuration()
        {
            //AutomaticMigrationsEnabled = true;
            _directoryInfo = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent; //получение папки с базой данных
            AppDomain.CurrentDomain.SetData("DataDirectory", Path.Combine(_directoryInfo.FullName, "App_Data")); //присвоение полученого пути свойству DataDirectory (дл€ относительного пути к базе)

        }

        protected override void Seed(MoviesDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


            using (MoviesDb movieDb = new MoviesDb())
            {

                Role admin = new Role { Name = "admin" };
                Role user = new Role { Name = "user" };

                movieDb.Roles.Add(admin);
                movieDb.Roles.Add(user);
                movieDb.SaveChanges();

                var md5 = new MD5CryptoServiceProvider();

                User Helg = new User
                {
                    Name = "Helg",
                    Password = md5.ComputeHash(Encoding.Default.GetBytes("123456")),
                    Role = admin

                };
                User Helga = new User
                {
                    Name = "Helga",
                    Password = md5.ComputeHash(Encoding.Default.GetBytes("123456")),
                    Role = user
                };
                movieDb.Users.Add(Helg);
                movieDb.Users.Add(Helga);
                movieDb.SaveChanges();


                Movie movie1 = new Movie
                {
                    Name = "“анго и кеш",
                    Picture = File.ReadAllBytes(Path.Combine(_directoryInfo.FullName, @"Images\image1.png")),
                    Rating = 9.2,
                    Year = 1989,
                    User = Helg
                };
                Movie movie2 = new Movie
                {
                    Name = "«аконопослушный гражданин",
                    Picture = File.ReadAllBytes(Path.Combine(_directoryInfo.FullName, @"Images\image2.jpg")),
                    Rating = 9.5,
                    Year = 2009,
                    User = Helg
                };
                movieDb.Movies.Add(movie1);
                movieDb.Movies.Add(movie2);
                movieDb.SaveChanges();
            }

        }
    }
    
}
