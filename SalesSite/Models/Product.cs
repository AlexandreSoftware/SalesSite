using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSite.Models
{
    public class Product
    {
        public int id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public Seller Seller { get; set; }

        public string Imagespath { get; set; }
        public Product()
        {
        }
        public Product(int id,string name, int price, Seller seller)
        {
            this.id = id;
            this.Name = name;
            this.Price = price;
            this.Seller = seller;
            this.Imagespath = Seller.Name + this.Name;
        }
    }
}
