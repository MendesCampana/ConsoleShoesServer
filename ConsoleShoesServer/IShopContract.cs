using ConsoleShoesServer.ShopService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShoesServer
{

    [ServiceContract]
    public interface IShopContract
    {
        [OperationContract]
        IEnumerable<FactoryService> getFactories();
        [OperationContract]
        void addFactory(FactoryService tFactory);
    }
}
