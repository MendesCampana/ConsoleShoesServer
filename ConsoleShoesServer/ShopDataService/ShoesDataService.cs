using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShoesServer.ShopDataService
{
    [DataContract]
    public class ShoesDataService
    {
        [DataMember]
        public string ModelName { get; set; }
        [DataMember]
        public decimal IncomePrice { get; set; }
        [DataMember]
        public int Amount { get; set; }
        [DataMember]
        public string ImagePath { get; set; }
        [DataMember]
        public SizeDataService ModelSize { get; set; }
        [DataMember]
        public FactoryDataService Manufacturer { get; set; }
        [DataMember]
        public GenderDataService GenderData { get; set; }
        [DataMember]
        public AgeStatusDataService AgeData { get; set; }
    }
}
