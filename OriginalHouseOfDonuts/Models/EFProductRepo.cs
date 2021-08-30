using OriginalHouseOfDonuts.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OriginalHouseOfDonuts.Models
{
    public class EFProductRepo : IProductRepo
    {
        private ProductContext _context;

        public EFProductRepo(ProductContext ctx)
        {
            _context = ctx;
        }

        public IQueryable<Product> Products => _context.Products;
    }
}
