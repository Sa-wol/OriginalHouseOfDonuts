using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OriginalHouseOfDonuts.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string ItemTitle { get; set; }

        public double ItemPrice { get; set; }

        public string Category { get; set; }
    }
}
