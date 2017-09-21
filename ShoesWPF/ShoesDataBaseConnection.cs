using ShoesWPF.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesWPF
{
    public static class ShoesDataBaseConnection
    {
        private static ShoesContractClient _shoes = new ShoesContractClient();
        private static FactoryContractClient _factory = new FactoryContractClient();
        public static FactoryContractClient Factory
        {
            set
            {
                _factory = value;
            }
            get
            {
                return _factory;
            }
        }
        public static ShoesContractClient Shoes
        {
            set
            {               
                _shoes = value;
            }
            get
            {
                return _shoes;
            }
        }
    }
}
