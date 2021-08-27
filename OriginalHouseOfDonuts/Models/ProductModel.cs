using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OriginalHouseOfDonuts.Models
{
    public class ProductModel
    {
        private List<Product> products;

        public ProductModel()
        {
            this.products = new List<Product>()
            {
                new Product
                {
                    ProductId = 001,
                    ItemName = "Donut 1",
                    ItemPrice = 4.99,
                    Photo = "https://giphy.com/explore/sweet-donuts"
                },
                new Product
                {
                    ProductId = 002,
                    ItemName = "Donut 2",
                    ItemPrice = 4.99,
                    Photo = "https://giphy.com/explore/sweet-donuts"
                },
                new Product
                {
                    ProductId = 003,
                    ItemName = "Donut 2",
                    ItemPrice = 4.99,
                    Photo = "https://giphy.com/explore/sweet-donuts"
                }
            };
        }

        public List<Product> findAll()
        {
            return this.products;
        }

        public Product find(string id)
        {
            return this.products.Single(p => p.ProductId.Equals(id));
        }
    }
}
