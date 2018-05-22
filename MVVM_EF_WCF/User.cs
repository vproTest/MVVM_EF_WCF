using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_EF_WCF
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }      
        public byte[] Password { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public ICollection<Movie> Movies { get; set; }
      
    }
}
