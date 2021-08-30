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
        private readonly ProductContext ctx;

        public ProductController(ProductContext context)
        {
            ctx = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            int pageNum = id ?? 1;
            const int PageSize = 3;
            ViewData["CurrentPage"] = pageNum;

            int numProducts = await ProductDb.GetTotalProductsAsync(ctx);
            int totalPages = (int)Math.Ceiling((double)numProducts / PageSize);
            ViewData["MaxPage"] = totalPages;

            List<Product> products = await ProductDb.GetProductsAsync(ctx, PageSize, pageNum);

            // Send list of products to view to be displayed
            return View(products);
        }
    }
}