using CarApi.Dtos;
using CarApi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CarApi.Services
{
    public interface ICarService
    {
        public ValueTask<bool> CreateAsync(CarDto dto);
       
        public ValueTask<bool> DeleteASync(long CarId);
     

        public ValueTask<IList<Car>> GetAllAsync();

       
    }
}
