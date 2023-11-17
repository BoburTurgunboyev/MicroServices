using EmployeeApi.Dtos;
using EmployeeApi.Entities;

namespace EmployeeApi.Services
{
    public interface IEmployeeService
    {
        public ValueTask<bool> CreateAsync(EmployeeDto dto);

        public ValueTask<bool> DeleteASync(long EmployeeId);

        public ValueTask<IList<Employee>> GetAllAsync();
    }
}
