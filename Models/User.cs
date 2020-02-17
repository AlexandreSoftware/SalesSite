using System.Collections.Generic;

namespace SalesSite.Models
{
    public class User
    {
        public HashSet<Product> WishList;
        public HashSet<Product> ShoppingCart;
        public List<Review> Reviews;
    }
}