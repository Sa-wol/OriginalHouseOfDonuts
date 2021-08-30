using Microsoft.EntityFrameworkCore;
using OriginalHouseOfDonuts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OriginalHouseOfDonuts.Data
{
    public class ProductDb
    {
        public async static Task<List<Product>> GetProductsAsync(ProductContext _context, int pageSize, int pageNum)
        {
            return
                await (from p in _context.Products
                       orderby p.ItemName ascending
                       select p)
                       .Skip(pageSize * (pageNum - 1))
                       .Take(pageSize)
                       .ToListAsync();
        }

        public async static Task<int> GetTotalProductsAsync(ProductContext _context)
        {
            return await (from p in _context.Products
                          select p).CountAsync();
        }
    }
}
