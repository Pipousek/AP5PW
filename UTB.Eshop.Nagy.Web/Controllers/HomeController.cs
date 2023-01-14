using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UTB.Eshop.Nagy.Web.Models;
using UTB.Eshop.Nagy.Web.Models.Database;
using UTB.Eshop.Nagy.Web.Models.Database.Configuration;
using UTB.Eshop.Nagy.Web.Models.Entities;
using UTB.Eshop.Nagy.Web.Models.ViewModels;

namespace UTB.Eshop.Nagy.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        readonly EshopDbContext eshopDbContext;

        public HomeController(ILogger<HomeController> logger, EshopDbContext eshopDbContext)
        {
            _logger = logger;
            this.eshopDbContext = eshopDbContext;
        }

        public ActionResult SwitchLanguage()
        {
            if (!HttpContext.Request.Cookies.ContainsKey("first_request"))
            {
                HttpContext.Response.Cookies.Delete("first_request");
            }
            if (LanguageConfig.Language == "CZ")
            {
                HttpContext.Response.Cookies.Append("first_request", "EN");
                LanguageConfig.Language = "EN";
            }
            else
            {
                HttpContext.Response.Cookies.Append("first_request", "CZ");
                LanguageConfig.Language = "CZ";
            }
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            List<CarouselItem> carouselItems = eshopDbContext.CarouselItems.ToList();
            List<Product> products = eshopDbContext.Products.ToList();

            if (!HttpContext.Request.Cookies.ContainsKey("first_request"))
            {
                HttpContext.Response.Cookies.Append("first_request", "CZ");
            }
            else
            {
                string lang = HttpContext.Request.Cookies["first_request"];
                if (lang == "EN" || lang == "CZ")
                {
                    LanguageConfig.Language = lang;
                }
                else
                {
                    LanguageConfig.Language = "CZ";
                    HttpContext.Response.Cookies.Delete("first_request");
                    HttpContext.Response.Cookies.Append("first_request", "CZ");
                }

            }

            HomeIndexViewModel hiVM = new HomeIndexViewModel()
            {
                CarouselItems = carouselItems,
                Products = products
            };
            return View(hiVM);
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



        public IActionResult Description(int id)
        {
            Product product = eshopDbContext.Products.FirstOrDefault(o => o.ID == id);
            if (product != null)
            {
                return View(product);
            }
            return NotFound();
        }
    }
}
