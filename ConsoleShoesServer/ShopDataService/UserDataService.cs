using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShoesServer.ShopDataService
{
    [DataContract]
    public class UserDataService
    {
        [DataMember]
        public string Name { set; get; }
        [DataMember]
        public string PassWord { set; get; }
    }
}
