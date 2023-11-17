using ComponyApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace ComponyApi.DataAccess
{
    public class DbConent:DbContext
    {
        public DbConent(DbContextOptions<DbConent> options) : base(options)
        {
        }

        public DbSet<Compony> Componys { get; set; } 
    }
}
