using Microsoft.AspNetCore.Mvc;
using PosApp.Services;

namespace PosApp.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View(InMemoryDatabase.Products);
        }
    }
}