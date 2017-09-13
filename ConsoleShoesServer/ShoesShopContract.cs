using ConsoleShoesServer.ShopService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShoesServer
{
    public class ShoesShopContract:IShopContract
    {
        ShoesDB context = new ShoesDB();

        public void addFactory(FactoryService tFactory)
        {
            if(!context.Factories.Any(x=>x.FactoryName==tFactory.Name))
            {
                context.Factories.Add(new Factory() { FactoryName = tFactory.Name });
                context.SaveChanges();
            }
        }

        public IEnumerable<FactoryService> getFactories()
        {
            List<FactoryService> tempCollection = new List<FactoryService>();
            foreach (Factory key in context.Factories)
                tempCollection.Add(new FactoryService() { Name = key.FactoryName });
            return tempCollection;
        }    
    }
}
