using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        protected ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var hotel = new HotelsDataModel();
            //hotel.Id = Guid.NewGuid().ToString();
            //hotel.Name = "THotesl";
            //hotel.Stars = 3;
            //hotel.Floors = 30;
            //hotel.Rooms = 300;

            //_context.Hotels.Add(hotel);
            //_context.SaveChanges

            return View();
        }
        [Authorize(Roles = "Administration, Admin")]
        public IActionResult Privacy()
        {
            var data = _context.Hotels.Where(h => h.Rooms > 10).ToList();
            ViewBag.Hotels = data;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
