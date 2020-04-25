using Masny.Core;
using System;

namespace Masny.Patterns.Structural.Proxy
{
    interface IService
    {
        void Request();
    }

    class Service : IService
    {
        public void Request()
        {
            Console.WriteLine($"Called {nameof(Service)}.{nameof(Request)}()");
        }
    }

    class Proxy : IService
    {
        private Service _service;

        public void Request()
        {
            if (_service == null)
            {
                _service = new Service();
            }

            _service.Request();
        }
    }

    public class ProxyPattern : IExample
    {
        public void Start()
        {
            var proxy = new Proxy();
            proxy.Request();
        }
    }
}
