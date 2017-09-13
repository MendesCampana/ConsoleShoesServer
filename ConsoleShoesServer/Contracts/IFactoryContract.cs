using ConsoleShoesServer.ShopDataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShoesServer
{
    [ServiceContract]
    public interface IFactoryContract
    {
        [OperationContract]
        List<FactoryDataService> getFactories();
        [OperationContract]
        void addFactory(FactoryDataService tFactory);
    }
}
