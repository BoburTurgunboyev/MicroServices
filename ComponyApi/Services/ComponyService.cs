using ComponyApi.DataAccess;
using ComponyApi.Dtos;
using ComponyApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace ComponyApi.Services
{
    public class ComponyService : IComponyService
    {
        private DbConent _dbConent;

        public ComponyService(DbConent dbConent )
        {
            _dbConent = dbConent;
        }
        public async ValueTask<bool> CreateAsync(ComponyDto dto)
        {
            Compony compony = new Compony()
            {
               CompName = dto.CompName,
               Location = dto.Location,
               

            };

            var result = await _dbConent.Componys.AddAsync(compony);
            await _dbConent.SaveChangesAsync();
            if (result is not null)
            {
                return true;
            }
            return false;
        }

        public async ValueTask<bool> DeleteASync(long ComponyId)
        {
            var result = await _dbConent.Componys.FirstOrDefaultAsync(x => x.Id == ComponyId);

            var res = _dbConent.Componys.Remove(result);
            await _dbConent.SaveChangesAsync();
            return res != null;
        }

        public async ValueTask<IList<Compony>> GetAllAsync()
        {
            return await _dbConent.Componys.ToListAsync();
        }
    }
}
