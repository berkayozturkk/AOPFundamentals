using System;

namespace ProxyApp
{
    public class BusinessModuleProxy : IBusinessModule
    {
        private BusinessModule _realObjext;

        public BusinessModuleProxy()
        {
            _realObjext = new BusinessModule();
        }

        public void Method()
        {
            Console.WriteLine("Before method.");

            _realObjext.Method();

            Console.WriteLine("End method.");
        }
    }
}
