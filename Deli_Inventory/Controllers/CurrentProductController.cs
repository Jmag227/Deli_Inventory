using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deli_Inventory.Controllers
{
    public class CurrentProductController : Controller
    {
        private readonly ICurrentProduct repo;

        public CurrentProductController(ICurrentProduct repo)
        {
            this.repo = repo;
        }

        //GET: /<controller>/
        public IActionResult Index()
        {
            var products = repo.GetAllProducts();
            return View(products);
        }
    }
}
