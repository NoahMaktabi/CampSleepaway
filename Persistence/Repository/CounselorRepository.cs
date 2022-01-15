using Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class CounselorRepository : IRepository<Counselor>
    {
        private readonly DataContext _context;

        public CounselorRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Counselor>> FindAll()
        {
            return await _context.Counselors
                .ToListAsync();
        }

        public async Task<Counselor> FindById(int id)
        {
            return await _context.Counselors
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<bool> Create(Counselor entity)
        {
            _context.Counselors.Add(entity);
            return await Save();
        }

        public async Task<bool> Update(Counselor entity)
        {
            _context.Counselors.Update(entity);
            return await Save();
        }

        public async Task<bool> Delete(Counselor entity)
        {
            var foundEntity = await _context.Counselors.FirstOrDefaultAsync(c => c.Id == entity.Id);
            if (foundEntity != null)
            {
                _context.Counselors.Remove(foundEntity);
            }

            return await Save();
        }

        public async Task<bool> Save()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}