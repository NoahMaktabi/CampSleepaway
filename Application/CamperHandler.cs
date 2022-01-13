using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Application.Extensions;
using Domain;
using Persistence.Repository;

namespace Application
{
    public class CamperHandler
    {
        private readonly CamperRepository _repository;

        public CamperHandler(CamperRepository repository)
        {
            _repository = repository;
        }

        public async Task<string>GetAllCampers()
        {
            var list = await _repository.FindAll();
            if (list.Count == 0) return "There are no campers registered";

            var str = string.Empty;
            list.ForEach(c =>
            {
                str += c.CamperInfoString();
            });
            return str;
        }

        public async Task<string> GetCamperById(int id)
        {
            var camper = await _repository.FindById(id);
            return camper == null ? "The camper was not found in the database" : camper.CamperInfoString();
        }

        public async Task<string> AddCamper(Camper camper)
        {
            var result = await _repository.Create(camper);
            return result
                ? $"The camper {camper.Name} has been added to the database"
                : "There was a problem, the camper was not added to the database";
        }

        public async Task<string> UpdateCamper(Camper camper)
        {
            var result = await _repository.Update(camper);
            return result
                ? $"The camper {camper.Name} has been updated in the database"
                : "There was a problem, the camper was not updated in the database";
        }

        public async Task<string> RemoveCamper(int id)
        {
            var camper = await _repository.FindById(id);
            if (camper == null) return "The camper was not found in the database";
            var result = await _repository.Delete(camper);
            return result
                ? $"The camper {camper.Name} has been removed from the database"
                : "There was a problem, the camper was not removed from the database";
        }
    }
}