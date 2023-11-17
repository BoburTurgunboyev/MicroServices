using ComponyApi.Dtos;
using ComponyApi.Entities;

namespace ComponyApi.Services
{
    public interface IComponyService
    {

        public ValueTask<bool> CreateAsync(ComponyDto dto);

        public ValueTask<bool> DeleteASync(long ComponyId);


        public ValueTask<IList<Compony>> GetAllAsync();
    }
}
