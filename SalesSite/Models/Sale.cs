using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSite.Models
{
    public class Sale
    {
        public int id { get; set; }
        [Required(ErrorMessage ="{0} is required")]
        public List<Product> Products { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        public DateTime PurchaseTime { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        public User User { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [Range(0,30000.000)]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Price { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public SaleStatus SaleStatus { get; set; }
        public Sale()
        {

        }
        public Sale(IEnumerable<Product> products,User user,double price)
        {
            this.Products = products.ToList();
            this.User = user;
            this.Price = price;
        }
    }
}
