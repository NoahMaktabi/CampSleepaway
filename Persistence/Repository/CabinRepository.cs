using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repository
{
    public class CabinRepository : IRepository<Cabin>
    {
        private readonly DataContext _context;

        public CabinRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Cabin>> FindAll()
        {
            return await _context.Cabins
                .Include(c => c.Counselor)
                .Include(c => c.Campers)
                .ToListAsync();
        }

        public async Task<Cabin> FindById(int id)
        {
            return await _context.Cabins
                .Include(c => c.Counselor)
                .Include(c => c.Campers)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<bool> Create(Cabin entity)
        {
            _context.Cabins.Add(entity);
            return await Save();
        }

        public async Task<bool> Update(Cabin entity)
        {
            _context.Cabins.Update(entity);
            return await Save();
        }

        public async Task<bool> Delete(Cabin entity)
        {
            var foundEntity = await _context.Cabins.FirstOrDefaultAsync(c => c.Id == entity.Id);
            if (foundEntity != null)
            {
                _context.Cabins.Remove(foundEntity);
            }

            return await Save();
        }

        public async Task<bool> Save()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}