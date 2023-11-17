using EmployeeApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApi.DataAccess
{
    public class DbConent:DbContext
    {
        public DbConent(DbContextOptions<DbConent> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
