using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShoesServer
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShoesShopContract tContract = new ShoesShopContract();
            
            //Console.ReadLine();
            ServiceHost host = new ServiceHost(typeof(ShoesShopContract));
            host.Open();
            Console.WriteLine("...Host open...");
            Console.ReadKey();
        }
    }
}
