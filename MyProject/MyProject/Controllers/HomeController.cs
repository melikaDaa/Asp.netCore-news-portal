using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyProject.Areas.Admin.Data;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DBCtx _context;


        public HomeController(ILogger<HomeController> logger,DBCtx context)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
           
                return View(await _context.News.Include("Category").Include("Author").ToListAsync());

        }
        [HttpGet]
        public async Task<IActionResult> Index(string NewsSerach)
        {
            ViewData["GetNewsDetails"] = NewsSerach;
            var newsquery = from x in _context.News select x;
            if (!String.IsNullOrEmpty(NewsSerach))
            {
                newsquery = newsquery.Where(x => x.NewsDesc.Contains(NewsSerach) || x.NewsName.Contains(NewsSerach));
            }
            return View(await newsquery.AsNoTracking().ToListAsync());
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
