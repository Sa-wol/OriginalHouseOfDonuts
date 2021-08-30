using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OriginalHouseOfDonuts.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string ItemName { get; set; }

        public double ItemPrice { get; set; }

        public string Category { get; set; }
    }
}
