using ConsoleShoesServer.Contracts;
using ConsoleShoesServer.ShopDataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShoesServer
{
    public class ShoesShopContract:IFactoryContract, IShoesContract
    {
        ShoesDB context = new ShoesDB();

        public void addFactory(FactoryDataService tFactory)
        {
            if(!context.Factories.Any(x=>x.FactoryName==tFactory.Name))
            {
                context.Factories.Add(new Factory() { FactoryName = tFactory.Name });
                context.SaveChanges();
            }
        }
        public List<FactoryDataService> getFactories()
        {
            List<FactoryDataService> tempCollection = new List<FactoryDataService>();
            foreach (Factory key in context.Factories)
                tempCollection.Add(new FactoryDataService() { Name = key.FactoryName });
            return tempCollection;
        }

        public void addShoe(ShoesDataService tShoe)
        {
            context.Shoes.Add(new Sho() { ModelName = tShoe.ModelName,
                                          IncomePrice = tShoe.IncomePrice,
                                          Amount = tShoe.Amount,
                                          ImagePath = tShoe.ImagePath,
                                          Size = new Size() { Measure = tShoe.ModelSize.Measure },
                                          Gender = new Gender() { GenderData = tShoe.GenderData.Name },
                                          Factory = new Factory() { FactoryName = tShoe.Manufacturer.Name },
                                          AgeStatu = new AgeStatu() { StatusData = tShoe.AgeData.Name}
                                          });
            context.SaveChanges();
        }

        public List<ShoesDataService> getAllShoes()
        {
            List<ShoesDataService> tList = new List<ShoesDataService>();
            foreach(Sho item in context.Shoes)
            {
                tList.Add(new ShoesDataService()
                {
                    ModelName = item.ModelName,
                    IncomePrice = item.IncomePrice,
                    Amount = item.Amount,
                    ImagePath = item.ImagePath,
                    ModelSize = new SizeDataService() { Measure = item.Size.Measure },
                    Manufacturer = new FactoryDataService() { Name = item.Factory.FactoryName },
                    GenderData = new GenderDataService() { Name = item.Gender.GenderData },
                    AgeData = new AgeStatusDataService() { Name = item.AgeStatu.StatusData }
                });
            }
            return tList;
        }

       
    }
}
