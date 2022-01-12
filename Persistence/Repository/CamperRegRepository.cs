using Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class CamperRegRepository : IRepository<CamperRegistry>
    {
        private readonly DataContext _context;

        public CamperRegRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<CamperRegistry>> FindAll()
        {
            return await _context.CamperRegistries
                .Include(c => c.Cabin)
                .Include(x => x.Camper)
                .ToListAsync();
        }

        public async Task<CamperRegistry> FindById(int id)
        {
            return await _context.CamperRegistries
                .Include(c => c.Cabin)
                .Include(x => x.Camper)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<bool> Create(CamperRegistry entity)
        {
            _context.CamperRegistries.Add(entity);
            return await Save();
        }

        public async Task<bool> Update(CamperRegistry entity)
        {
            _context.CamperRegistries.Update(entity);
            return await Save();
        }

        public async Task<bool> Delete(CamperRegistry entity)
        {
            var foundEntity = await _context.CamperRegistries.FirstOrDefaultAsync(c => c.Id == entity.Id);
            if (foundEntity != null)
            {
                _context.CamperRegistries.Remove(foundEntity);
            }

            return await Save();
        }

        public async Task<bool> Save()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}