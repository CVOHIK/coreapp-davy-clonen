using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicStore.Data;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class StoreController : Controller
    {
        private readonly StoreContext _context;

        public StoreController(StoreContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListGenres()
        {
            var genres = _context.Genres.OrderBy(a => a.Name);
            return View(genres);
        }

        public IActionResult Details(int id)
        {
            var album = _context.Albums.Include(a => a.Artist).Include(a => a.Genre).SingleOrDefault(a => a.AlbumID == id);       
            return View(album);
        }

        public IActionResult ListAlbums(int id)
        {
            var albums = _context.Albums.Include(a => a.Genre).Where(a => a.GenreID == id).OrderBy(a => a.Title);
            return View(albums);
        }
    }
}