using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_EF_WCF
{
    [ServiceContract]
    interface IServiceAdmin : IServiceUser
    {
        [OperationContract]
        void AddMovie(Movie movie, User user);
        [OperationContract]
        void EditMovie(Movie movie);
        [OperationContract]
        void RemoveMovie(Movie movie);
    }
}
