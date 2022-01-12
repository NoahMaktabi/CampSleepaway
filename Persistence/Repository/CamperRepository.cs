using Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class CamperRepository : IRepository<Camper>
    {
        private readonly DataContext _context;

        public CamperRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Camper>> FindAll()
        {
            return await _context.Campers
                .Include(c => c.Cabin)
                .Include(x => x.NextOfKins)
                .ToListAsync();
        }

        public async Task<Camper> FindById(int id)
        {
            return await _context.Campers
                .Include(c => c.Cabin)
                .Include(x => x.NextOfKins)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<bool> Create(Camper entity)
        {
            _context.Campers.Add(entity);
            return await Save();
        }

        public async Task<bool> Update(Camper entity)
        {
            _context.Campers.Update(entity);
            return await Save();
        }

        public async Task<bool> Delete(Camper entity)
        {
            var foundEntity = await _context.Campers.FirstOrDefaultAsync(c => c.Id == entity.Id);
            if (foundEntity != null)
            {
                _context.Campers.Remove(foundEntity);
            }

            return await Save();
        }

        public async Task<bool> Save()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}