using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_EF_WCF
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public byte[] Picture { get; set; }
        public double Rating { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
