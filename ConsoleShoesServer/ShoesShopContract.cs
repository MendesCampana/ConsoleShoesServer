using ConsoleShoesServer.Contracts;
using ConsoleShoesServer.ShopDataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShoesServer
{
    public class ShoesShopContract:IFactoryContract, IShoesContract, IShoesLoginContract,IAgeStatus, IShoesGender, IShoesSize
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

        public bool CheckLogin(string LogIn, string PassWord)
        {
            foreach (User key in context.Users)
            {
                if ((key.Login == LogIn) && (key.Password == PassWord))
                    return true;
            }
            return false;
        }

        public List<SizeDataService> GetSizes()
        {
            List<SizeDataService> tList = new List<SizeDataService>();
            foreach (Size item in context.Sizes)
            {
                tList.Add(new SizeDataService()
                {
                    Measure = item.Measure
                });
            }
            return tList;
        }

        public List<AgeStatusDataService> GetGetAgeStatus()
        {
            List<AgeStatusDataService> tList = new List<AgeStatusDataService>();
            foreach (AgeStatu item in context.AgeStatus)
            {
                tList.Add(new AgeStatusDataService()
                {
                    Name = item.StatusData
                });
            }
            return tList;
        }
        public List<GenderDataService> GetGender()
        {
            List<GenderDataService> tList = new List<GenderDataService>();
            foreach (Gender item in context.Genders)
            {
                tList.Add(new GenderDataService()
                {
                    Name = item.GenderData
                });
            }
            return tList;
        }      
    }
}
