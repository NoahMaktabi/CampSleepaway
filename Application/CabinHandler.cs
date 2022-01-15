using System.Threading.Tasks;
using Application.Extensions;
using Domain;
using Persistence;
using Persistence.Repository;

namespace Application
{
    public class CabinHandler
    {
        private readonly CabinRepository _repository;
        private readonly CounselorRepository _counselorRepository;
        private readonly CamperRepository _camperRepository;

        public CabinHandler(DataContext context)
        {
            _repository = new CabinRepository(context);
            _counselorRepository = new CounselorRepository(context);
            _camperRepository = new CamperRepository(context);
        }

        public async Task<string> GetAllCabins()
        {
            var list = await _repository.FindAll();
            if (list.Count == 0) return "There are no cabins registered.";

            var str = string.Empty;
            list.ForEach(c =>
            {
                str += c.CabinInfoString();
            });
            return str;
        }

        public async Task<string> AddCabin(Cabin cabin)
        {
            var result = await _repository.Create(cabin);
            return result
                ? $"The cabin {cabin.Name} was added to the database."
                : "There was a problem, the cabin was not added to the database.";
        }

        public async Task<string> AddCamperToCabin(int cabinId, Camper camper)
        {
            var cabin = await _repository.FindById(cabinId);
            if (cabin == null) return 
                "The cabin was not found in the database";

            if (cabin.Campers.Count >= 4)
                return "The cabin already has 4 campers. You can not add more campers to this cabin.";

            if (camper.Cabin != null)
                return "The camper already has a registered cabin!";

            if (cabin.Counselor == null)
                return
                    "The cabin does not have a registered counselor. You have to register a counselor first before adding campers";
            //camper.Cabin = cabin;
            //await _camperRepository.Update(camper);

            cabin.Campers.Add(camper);
            var result = await _repository.Update(cabin);
            return result
                ? $"The camper {camper.Name} has been added to the cabin."
                : "There was a problem, the camper was not added to the cabin.";
        }

        public async Task<string> AddCounselorToCabin(int cabinId, Counselor counselor)
        {
            var cabin = await _repository.FindById(cabinId);
            if (cabin == null) return 
                "The cabin was not found in the database";

            if (cabin.Counselor != null)
                return
                    "The cabin already has a registered counselor. If you wish to change the counselor then choose another alternativ from the menu!";

            cabin.Counselor = counselor;

            var result = await _repository.Update(cabin);

            return result
                ? $"The counselor {counselor.Name} has been added to the cabin."
                : "There was a problem, the counselor was not added to the cabin.";
        }
    }
}