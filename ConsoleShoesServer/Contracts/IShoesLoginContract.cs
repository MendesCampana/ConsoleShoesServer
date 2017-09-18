using ConsoleShoesServer.ShopDataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShoesServer.Contracts
{
    [ServiceContract]
    public interface IShoesLoginContract
    {
        [OperationContract]
        bool CheckLogin(string LogIn, string PassWord);
    }
}
