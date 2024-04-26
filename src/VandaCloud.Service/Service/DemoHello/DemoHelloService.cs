using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAD.CoreService.Service.DemoHello
{
    public class DemoHelloService : IDemoHelloService
    {
        public string GetHello()
        {
            return "Hello everyone!";
        }
    }
}
