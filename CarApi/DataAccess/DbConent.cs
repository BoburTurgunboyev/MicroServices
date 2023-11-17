using CarApi.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace CarApi.DataAccess
{
    public class DbConent:DbContext
    {
        public DbConent(DbContextOptions<DbConent> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }    
    }

    
}
