using Domain;
using Persistence;
using Persistence.Repository;
using System.Threading.Tasks;
using Application.Extensions;

namespace Application
{
    public class NextOfKinHandler
    {
        private readonly NextOfKinRepository _repository;
        private readonly CamperRepository _camperRepository;
        public NextOfKinHandler(DataContext context)
        {
            _repository = new NextOfKinRepository(context);
            _camperRepository = new CamperRepository(context);
        }

        public async Task<string>GetAllNextOfKins()
        {
            var list = await _repository.FindAll();
            if (list.Count == 0) return "There are no next of kins registered";

            var str = string.Empty;
            list.ForEach(c =>
            {
                str += c.NextOfKinInfoString();
            });
            return str;
        }

        public async Task<string> GetNextOfKinById(int id)
        {
            var nextOfKin = await _repository.FindById(id);
            return nextOfKin == null ? "The next of kin was not found in the database" : nextOfKin.NextOfKinInfoString();
        }

        public async Task<string> AddNextOfKin(NextOfKin nextOfKin)
        {
            var result = await _repository.Create(nextOfKin);
            return result
                ? $"The next of kin {nextOfKin.Name} has been added to the database"
                : "There was a problem, the next of kin was not added to the database";
        }

        public async Task<string> AddCamperToNextOfKin(int camperId, int nextOfKinId)
        {
            var camper = await _camperRepository.FindById(camperId);
            if (camper == null) return "The camper was not found in the database";

            var nextOfKin = await _repository.FindById(nextOfKinId);
            if (nextOfKin == null) return "The next of kin was not found in the database";

            if (nextOfKin.Camper != null)
                return "The next of kin has already a camper assigned. This can not be changed!";

            nextOfKin.Camper = camper;
            var result = await _repository.Update(nextOfKin);
            return result
                ? "The camper has been added to the next of kin"
                : "There was a problem. The camper was not added to the next of kin";
        }

        public async Task<string> UpdateNextOfKin(NextOfKin nextOfKin)
        {
            var result = await _repository.Update(nextOfKin);
            return result
                ? $"The next of kin {nextOfKin.Name} has been updated in the database"
                : "There was a problem, the next of kin was not updated in the database";
        }

        public async Task<string> RemoveNextOfKin(int id)
        {
            var nextOfKin = await _repository.FindById(id);
            if (nextOfKin == null) return "The next of kin was not found in the database";
            var result = await _repository.Delete(nextOfKin);
            return result
                ? $"The next of kin {nextOfKin.Name} has been removed from the database"
                : "There was a problem, the next of kin was not removed from the database";
        }
    }
}