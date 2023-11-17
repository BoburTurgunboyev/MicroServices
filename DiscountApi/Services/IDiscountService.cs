using DiscountApi.Dtos;
using DiscountApi.Entities;

namespace DiscountApi.Services
{
    public interface IDiscountService
    {
        public ValueTask<bool> CreateAsync(DiscountDto dto);

        public ValueTask<bool> DeleteASync(long DiscountId);


        public ValueTask<IList<Discount>> GetAllAsync();
    }
}
