using BellmanFordAlgo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BellmanFordAlgo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var values = new List<Models.Values>();
            //values.Add(new Values()
            //{
            //    Key = "BTC/USDT",
            //    Value = 62980
            //});
            //values.Add(new Values()
            //{
            //    Key = "ETH/USDT",
            //    Value = 2454.80M
            //});

            ////values.Add(new Values()
            ////{
            ////    Key = "BTC/ETH",
            ////    Value = 25.66M
            ////});
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
    }
}
