using System.Threading.Tasks;
using Application.Extensions;
using Domain;
using Persistence;
using Persistence.Repository;

namespace Application
{
    public class CounselorHandler
    {
        private readonly CounselorRepository _repository;
        public CounselorHandler(DataContext context)
        {
            _repository = new CounselorRepository(context);
        }

        public async Task<string> GetAllCounselors()
        {
            var list = await _repository.FindAll();
            if (list.Count == 0) return "There are no cabins registered.";

            var str = string.Empty;
            list.ForEach(c =>
            {
                str += c.CounselorInfoString();
            });
            return str;
        }

        public async Task<string> GetCounselorById(int id)
        {
            var counselor = await _repository.FindById(id);
            return counselor == null ? "The counselor was not found in the database" : counselor.CounselorInfoString();
        }

        public async Task<string> AddNewCounselor(Counselor counselor)
        {
            var result = await _repository.Create(counselor);
            return result
                ? $"The counselor {counselor.Name} has been added."
                : "There was a problem. The counselor was not added to the database";
        }

        public async Task<string> UpdateCounselor(Counselor counselor)
        {
            var result = await _repository.Update(counselor);
            return result
                ? $"The counselor {counselor.Name} has been updated in the database"
                : "There was a problem, the counselor was not updated in the database";
        }

        public async Task<string> RemoveCounselor(int id)
        {
            var counselor = await _repository.FindById(id);
            if (counselor == null) return "The camper was not found in the database";
            var result = await _repository.Delete(counselor);
            return result
                ? $"The counselor {counselor.Name} has been removed from the database"
                : "There was a problem, the counselor was not removed from the database";
        }
    }
}