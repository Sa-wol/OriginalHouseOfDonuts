using Microsoft.AspNetCore.Mvc;
using OriginalHouseOfDonuts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OriginalHouseOfDonuts.Data;

namespace OriginalHouseOfDonuts.Controllers
{
    /// <summary>
    /// Displays view that lists all products
    /// </summary>
    public class ProductController : Controller
    {
        private readonly ProductContext _productContext;
        public ProductController(ProductContext productContext)
        {
            _productContext = productContext;
        }
        
        /// <summary>
        /// Displays list of products
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Order()
        {
            List<Product> products = ((List<Product>)(from p in _productContext.Products
                                                      select p));
            return View(products);
        }
    }
}
