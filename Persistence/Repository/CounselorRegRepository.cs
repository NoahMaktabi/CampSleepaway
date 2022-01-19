using Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class CounselorRegRepository : IRepository<CounselorRegistry>
    {
        private readonly DataContext _context;

        public CounselorRegRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<CounselorRegistry>> FindAll()
        {
            return await _context.CounselorRegistries
                .AsNoTracking()
                .Include(c => c.Cabin)
                .Include(c => c.Counselor)
                .ToListAsync();
        }

        public async Task<CounselorRegistry> FindById(int id)
        {
            return await _context.CounselorRegistries
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<bool> Create(CounselorRegistry entity)
        {
            _context.CounselorRegistries.Add(entity);
            return await Save();
        }

        public async Task<bool> Update(CounselorRegistry entity)
        {
            _context.CounselorRegistries.Update(entity);
            return await Save();
        }

        public async Task<bool> Delete(CounselorRegistry entity)
        {
            var foundEntity = await _context.CounselorRegistries.FirstOrDefaultAsync(c => c.Id == entity.Id);
            if (foundEntity != null)
            {
                _context.CounselorRegistries.Remove(foundEntity);
            }

            return await Save();
        }

        public async Task<bool> Save()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}