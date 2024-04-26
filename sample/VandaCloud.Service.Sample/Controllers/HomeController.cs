using DAD.CoreService.Service.Demo;
using DAD.CoreService.Service.DemoHello;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using VandaCloud.Service.Sample.Models;

namespace VandaCloud.Service.Sample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDemoService _demoService;
        private readonly IDemoHelloService _demoHelloService;

        public HomeController(ILogger<HomeController> logger, IDemoService demoService, IDemoHelloService demoHelloService)
        {
            _logger = logger;
            _demoService = demoService;
            _demoHelloService = demoHelloService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    
        // Call global function from VandaCloud.Service package
        [HttpGet]
        public string GetWelcome()
        {
            return _demoService.Welcome();
        }

        // Call global function from VandaCloud.Service package
        [HttpGet]
        public string GetHello() 
        {
            return _demoHelloService.GetHello();
        }
    }
}
