using Microsoft.AspNetCore.Mvc;
using StoreApp.Data.Abstract;
using StoreApp.Web.Models;
using System.Diagnostics;

namespace StoreApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public int pageSize = 3;
        private readonly ILogger<HomeController> _logger;
        private readonly IStoreRepository _repository;
        public HomeController(ILogger<HomeController> logger, IStoreRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index(int page=1)
        {
            var products = _repository
                .Products
                .Skip((page-1)*pageSize)
                .Select(p=> new ProductViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Description = p.Description,
                Category = p.Category
            }).Take(pageSize);
            return View(new ProductListViewModel
            {
                Products = products,
                PageInfo=new PageInfo
                {
                    ItemsPerPage = pageSize,
                    TotalItems=_repository.Products.Count()
                }
            });
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
