using EmployeeApi.DataAccess;
using EmployeeApi.Dtos;
using EmployeeApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApi.Services
{
    public class EmployeeService : IEmployeeService
    {

        private DbConent _dbConent;

        public EmployeeService(DbConent dbConent)
        {
            _dbConent = dbConent;
        }
        public async ValueTask<bool> CreateAsync(EmployeeDto dto)
        {
            Employee employee = new Employee()
            {
               FirstName = dto.FirstName,
               LastName = dto.LastName,
               Password = dto.Password,


            };

            var result = await _dbConent.Employees.AddAsync(employee);
            await _dbConent.SaveChangesAsync();
            if (result is not null)
            {
                return true;
            }
            return false;
        }

        public async ValueTask<bool> DeleteASync(long EmployeeId)
        {
            var result = await _dbConent.Employees.FirstOrDefaultAsync(x => x.Id == EmployeeId);

            var res = _dbConent.Employees.Remove(result);
            await _dbConent.SaveChangesAsync();
            return res != null;
        }

        public async ValueTask<IList<Employee>> GetAllAsync()
        {
            return await _dbConent.Employees.ToListAsync();
        }
    }
}
