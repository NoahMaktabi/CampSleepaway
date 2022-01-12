using Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class NextOfKinRepository : IRepository<NextOfKin>
    {
        private readonly DataContext _context;

        public NextOfKinRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<NextOfKin>> FindAll()
        {
            return await _context.NextOfKins
                .Include(c => c.Camper)
                .ToListAsync();
        }

        public async Task<NextOfKin> FindById(int id)
        {
            return await _context.NextOfKins
                .Include(c => c.Camper)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<bool> Create(NextOfKin entity)
        {
            _context.NextOfKins.Add(entity);
            return await Save();
        }

        public async Task<bool> Update(NextOfKin entity)
        {
            _context.NextOfKins.Update(entity);
            return await Save();
        }

        public async Task<bool> Delete(NextOfKin entity)
        {
            var foundEntity = await _context.NextOfKins.FirstOrDefaultAsync(c => c.Id == entity.Id);
            if (foundEntity != null)
            {
                _context.NextOfKins.Remove(foundEntity);
            }

            return await Save();
        }

        public async Task<bool> Save()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}