using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SalesSite.Models
{
    public class Seller: Account
    {
        public HashSet<Product> Products;
        [Range(0,5)]
        public List<double> rating { get; set; }

        public Seller(HashSet<Product> products, List<double> rating)
        {
            Products = products;
            this.rating = rating;
        }
    }
}