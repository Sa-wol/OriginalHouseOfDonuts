using Microsoft.AspNetCore.Mvc;
using OriginalHouseOfDonuts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OriginalHouseOfDonuts.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace OriginalHouseOfDonuts.Controllers
{
    /// <summary>
    /// Displays view that lists all products
    /// </summary>
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ProductModel productModel = new ProductModel();
            ViewBag.products = productModel.findAll();
            return View();
        }
    }
}