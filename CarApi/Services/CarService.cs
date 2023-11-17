using CarApi.DataAccess;
using CarApi.Dtos;
using CarApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarApi.Services
{
    public class CarService : ICarService
    {
        private DbConent _dbConent;

        public CarService(DbConent dbConent)
        {
            _dbConent = dbConent;
        }
        public async ValueTask<bool> CreateAsync(CarDto dto)
        {
            Car car = new Car()
            {
                CarName = dto.CarName,
                Brent = dto.Brent,

            };

            var result = await _dbConent.Cars.AddAsync(car);
            await _dbConent.SaveChangesAsync();
            if(result is not null)
            {
                return true;
            }
            return false;

            
        }

        public async ValueTask<bool> DeleteASync(long CarId)
        {
            var result = await _dbConent.Cars.FirstOrDefaultAsync(x =>x.Id == CarId);

            var res=_dbConent.Cars.Remove(result);
            await _dbConent.SaveChangesAsync();
            return res != null;
        }

        public async ValueTask<IList<Car>> GetAllAsync()
        {
            return await _dbConent.Cars.ToListAsync();
        }
    }
}
