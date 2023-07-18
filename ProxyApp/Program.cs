using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessModuleProxy _businessModule = new BusinessModuleProxy();
            _businessModule.Method();

            Console.ReadLine();
        }
    }
}
