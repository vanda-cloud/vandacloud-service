using DAD.CoreService.Service.DemoHello;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAD.CoreService.Service.Demo
{
    public class DemoService : IDemoService
    {
        private readonly IDemoHelloService demoHelloService;

        public DemoService(IDemoHelloService demoHelloService)
        {
            this.demoHelloService = demoHelloService;
        }

        public string Welcome()
        {
            return demoHelloService.GetHello() + " Welcome to Vanda-Cloud Development Project.";
        }
    }
}
