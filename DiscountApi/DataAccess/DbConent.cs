using DiscountApi.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DiscountApi.DataAccess
{
    public class DbConent:DbContext
    {
        public DbConent(DbContextOptions<DbConent> options) : base(options)
        {
        }

        public DbSet<Discount> Discounts { get; set; }
    }
}
    
