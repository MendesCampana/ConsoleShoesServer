using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShoesServer.ShopDataService
{
    [DataContract]
    public class GenderDataService
    {
        [DataMember]
        public string Name { get; set; }
    }
}
