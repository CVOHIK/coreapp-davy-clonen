using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicStore.Data;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly StoreContext _context;

        public HomeController(StoreContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var albums = _context.Albums.OrderBy(a => Guid.NewGuid()).Take(6);   
            return View(albums);
        }

       

      

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
