using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OriginalHouseOfDonuts.Models
{
    public interface IProductRepo
    {
        IQueryable<Product> Products { get; }
    }
}
