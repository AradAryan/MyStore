using System;
using Application;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Application.ViewModels;

namespace MyStore.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProduct Product;
        public ProductController(IProduct product)
        {
            Product = product;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var result = Product.GetProducts();
            return Json(result);
        }

        [HttpPost]
        public IActionResult SaveProduct(ProductVM product)
        {
            var result = Product.SaveProduct(product);
            return Json(result);
        }
    }
}
