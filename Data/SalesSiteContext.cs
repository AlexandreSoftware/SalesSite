using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesSite.Models
{
    public class SalesSiteContext : DbContext
    {
        public SalesSiteContext (DbContextOptions<SalesSiteContext> options)
            : base(options)
        {
        }

        public DbSet<SalesSite.Models.Account> Account { get; set; }
    }
}
