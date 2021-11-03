using System;
using Application;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace MyStore.Controllers
{
    public class HomeController : BaseController
    {
        IProduct Product;
        public HomeController(IProduct product)
        {
            Product = product;
        }

        public IActionResult Index()
        {
            var result = Product.GetProducts();
            return Json(result);
        }

        public IActionResult SaveProduct()
        {
            var result = Product.SaveProduct();
            return Json(result);
        }
    }
}
