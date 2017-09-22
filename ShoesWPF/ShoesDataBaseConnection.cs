//using ShoesWPF.ServiceReference;
using ShoesWPF.ServiceReferenceHome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesWPF
{
    public static class ShoesDataBaseConnection
    {
        private static AgeStatusClient _ageStatus = new AgeStatusClient();
        private static FactoryContractClient _factory = new FactoryContractClient();
        private static ShoesContractClient _shoes = new ShoesContractClient();    
        private static ShoesGenderClient _genderStatus = new ShoesGenderClient();
        private static ShoesSizeClient _sizes = new ShoesSizeClient();

        public static AgeStatusClient AgeStatus
        {
            set
            {
                _ageStatus = value;
            }
            get
            {
                return _ageStatus;
            }
        }
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
        public static ShoesGenderClient GenderStatus
        {
            set
            {
                _genderStatus = value;
            }
            get
            {
                return _genderStatus;
            }
        }
        public static ShoesSizeClient Sizes
        {
            set
            {
                _sizes = value;
            }
            get {
                return _sizes;
            }
        }
      
     

    }
}
