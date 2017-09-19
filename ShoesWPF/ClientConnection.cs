using ShoesWPF.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesWPF
{
    public static class ClientConnection
    {
        private static ShoesLoginContractClient _client = new ShoesLoginContractClient();
        public static ShoesLoginContractClient Client
        {
            set
            {
                _client = value;
            }
            get
            {
                return _client;
            }
        }
        
    }
}
