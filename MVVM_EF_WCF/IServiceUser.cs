using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_EF_WCF
{
    [ServiceContract]
    public interface IServiceUser
    {
        [OperationContract]
        List<Movie> GetMovies();

        [OperationContract]
        User GetUser(string login, byte[] hash);
    
    }
}
