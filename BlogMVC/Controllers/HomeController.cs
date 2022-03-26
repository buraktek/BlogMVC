using BlogMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BlogMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private BlogContext context = new BlogContext();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var blogs = context.Blogs
                                .Select(t => new BlogModel()
                                {
                                    Id = t.Id,
                                    Baslik = t.Baslik.Length > 100 ? t.Baslik.Substring(0, 100) + "..." : t.Baslik,
                                    Aciklama = t.Aciklama,
                                    EklemeTarihi = t.EklemeTarihi,
                                    Anasayfa = t.Anasayfa,
                                    Onay = t.Onay,
                                    Resim = t.Resim
                                })
                                .Where(t => t.Onay == true && t.Anasayfa == true);

            return View(blogs.ToList());
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