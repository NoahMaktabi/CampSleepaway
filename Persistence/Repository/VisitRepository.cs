using Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class VisitRepository : IRepository<Visit>
    {
        private readonly DataContext _context;

        public VisitRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Visit>> FindAll()
        {
            return await _context.Visits
                .Include(c => c.Camper)
                .ThenInclude(c => c.Cabin)
                .ThenInclude(c => c.Counselor)
                .Include(x => x.Visitor)
                .ToListAsync();
        }

        public async Task<Visit> FindById(int id)
        {
            return await _context.Visits
                .Include(c => c.Camper)
                .ThenInclude(c => c.Cabin)
                .ThenInclude(c => c.Counselor)
                .Include(x => x.Visitor)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<bool> Create(Visit entity)
        {
            _context.Visits.Add(entity);
            return await Save();
        }

        public async Task<bool> Update(Visit entity)
        {
            _context.Visits.Update(entity);
            return await Save();
        }

        public async Task<bool> Delete(Visit entity)
        {
            var foundEntity = await _context.Visits.FirstOrDefaultAsync(c => c.Id == entity.Id);
            if (foundEntity != null)
            {
                _context.Visits.Remove(foundEntity);
            }

            return await Save();
        }

        public async Task<bool> Save()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}