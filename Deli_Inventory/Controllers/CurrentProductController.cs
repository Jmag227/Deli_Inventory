using Deli_Inventory.Models;
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
        public IActionResult ViewCurrentProduct(int id)
        {
            var product = repo.GetProduct(id);

            return View(product);
        }

        public IActionResult UpdateCurrentProduct(int id)
        {
            CurrentProduct prod = repo.GetProduct(id);

            if (prod == null)
            {
                return View("ProductNotFound");
            }

            return View(prod);
        }

        public IActionResult UpdateCuProductToDatabase(CurrentProduct product)
        {
            repo.UpdateCurrentProduct(product);

            return RedirectToAction("ViewCurrentProduct", new { id = product.Id });
        }





    }
}
