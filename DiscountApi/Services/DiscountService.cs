using DiscountApi.DataAccess;
using DiscountApi.Dtos;
using DiscountApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace DiscountApi.Services
{
    public class DiscountService : IDiscountService
    {
        private DbConent _dbConent;

        public DiscountService(DbConent dbConent)
        {
            _dbConent = dbConent;
        }
        public async ValueTask<bool> CreateAsync(DiscountDto dto)
        {

            Discount discount =new Discount()
            {
                Description = dto.Description,
                Name = dto.Name,
                

            };

            var result = await _dbConent.Discounts.AddAsync(discount);
            await _dbConent.SaveChangesAsync();
            if (result is not null)
            {
                return true;
            }
            return false;
        }

        public async  ValueTask<bool> DeleteASync(long DiscountId)
        {
            var result = await _dbConent.Discounts.FirstOrDefaultAsync(x => x.Id == DiscountId);

            var res = _dbConent.Discounts.Remove(result);
            await _dbConent.SaveChangesAsync();
            return res != null;
        }

        public async ValueTask<IList<Discount>> GetAllAsync()
        {
            return await _dbConent.Discounts.ToListAsync();
        }
    }
}
