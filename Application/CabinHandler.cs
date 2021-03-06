using System;
using System.Linq;
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
        private readonly CamperRegRepository _camperRegRepository;
        private readonly CounselorRegRepository _counselorRegRepository;

        public CabinHandler(DataContext context)
        {
            _repository = new CabinRepository(context);
            _counselorRepository = new CounselorRepository(context);
            _camperRegRepository = new CamperRegRepository(context);
            _counselorRegRepository = new CounselorRegRepository(context);
        }

        /// <summary>
        /// The method gets all cabins from the db and returns a string with info about the cabins
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Provided a valid cabinId. The method will return a string with info about the cabin
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<string> GetCabinById(int id)
        {
            var cabin = await _repository.FindById(id);
            return cabin == null ? "The cabin was not found in the database" : cabin.CabinInfoString();
        }

        /// <summary>
        /// Provided a cabin instance, the method will add the cabin to the db and return a string with info about the operation.
        /// </summary>
        /// <param name="cabin"></param>
        /// <returns></returns>
        public async Task<string> AddCabin(Cabin cabin)
        {
            var result = await _repository.Create(cabin);
            return result
                ? $"The cabin {cabin.Name} was added to the database."
                : "There was a problem, the cabin was not added to the database.";
        }

        /// <summary>
        /// Provided a cabinId and a camper instance. The method will add the camper to the cabin. It will check if there is 4 or more campers in the cabin before adding a new camper. 
        /// </summary>
        /// <param name="cabinId"></param>
        /// <param name="camper"></param>
        /// <returns>A string with info about the operation</returns>
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

            cabin.Campers.Add(camper);

            var successfulRegistry = await RegisterCamper(camper, cabin);
            if (!successfulRegistry) return "The registration was not successful!";

            var result = await _repository.Update(cabin);
            return result
                ? $"The camper {camper.Name} has been added to the cabin."
                : "There was a problem, the camper was not added to the cabin.";
        }

        /// <summary>
        /// Provided a cabinId and a counselor instance. The method will add the counselor to the cabin. It will check if there is already a counselor in the cabin before adding a new counselor. 
        /// </summary>
        /// <param name="cabinId"></param>
        /// <param name="counselor"></param>
        /// <returns>A string with info about the operation</returns>
        public async Task<string> AddCounselorToCabin(int cabinId, Counselor counselor)
        {
            var cabin = await _repository.FindById(cabinId);
            if (cabin == null) return 
                "The cabin was not found in the database";

            if (cabin.Counselor != null)
                return
                    "The cabin already has a registered counselor. If you wish to change the counselor then choose another alternativ from the menu!";
            counselor.AssignedToCabin = true;
            var counselorUpdatedSuccess = await _counselorRepository.Update(counselor);
            if (!counselorUpdatedSuccess) return "There was a problem updating the counselor. Try again later";

            cabin.Counselor = counselor;

            var successfulRegistry = await RegisterCounselor(counselor, cabin);
            if (!successfulRegistry) return "The registration was not successful!";

            var result = await _repository.Update(cabin);

            return result
                ? $"The counselor {counselor.Name} has been added to the cabin."
                : "There was a problem, the counselor was not added to the cabin.";
        }


        public async Task<string> ChangeCabinCounselor(int cabinId, Counselor counselor)
        {
            var cabin = await _repository.FindById(cabinId);
            if (cabin == null) return 
                "The cabin was not found in the database";

            if (cabin.Counselor == null)
                return
                    "The cabin does not have a counselor. Choose to assign a counselor to the cabin instead of change!";
            var oldCounselor = cabin.Counselor;
            oldCounselor.AssignedToCabin = false;
            var counselorUpdatedSuccess = await _counselorRepository.Update(oldCounselor);
            if (!counselorUpdatedSuccess) return "There was a problem updating the counselor. Try again later";

            counselor.AssignedToCabin = true;
            cabin.Counselor = counselor;

            var successfulRegistry = await RegisterCounselor(counselor, cabin);
            if (!successfulRegistry) return "The registration was not successful!";

            await RegisterChangedCounselor(oldCounselor, cabinId);

            var result = await _repository.Update(cabin);

            return result
                ? $"The counselor {counselor.Name} has been added to the cabin."
                : "There was a problem, the counselor was not added to the cabin.";
        }

        public async Task<string> CheckOutCamper(int camperId, int cabinId)
        {
            var cabin = await _repository.FindById(cabinId);
            if (cabin == null) return 
                "The cabin was not found in the database";
            var camper = cabin.Campers.FirstOrDefault(c => c.Id == camperId);
            if (camper == null) return "The camper was not found in this cabin";
            await RegisterCamperCheckOut(cabin, camper);

            cabin.Campers.Remove(camper);
            var result = await _repository.Update(cabin);
            return result
                ? "The camper has been checked out"
                : "There was a problem. No changes has been made";
        }

        private async Task<bool> RegisterCamper(Camper camper, Cabin cabin)
        {
            var registry = new CamperRegistry
            {
                Camper = camper,
                Cabin = cabin,
                CheckIn = DateTime.Now,
                CheckOut = DateTime.Now.AddMonths(3),
            };
            return await _camperRegRepository.Create(registry);
        }

        private async Task<bool> RegisterCounselor(Counselor counselor, Cabin cabin)
        {
            var registry = new CounselorRegistry
            {
                Cabin = cabin,
                Counselor = counselor,
                AssignmentStart = DateTime.Now,
                AssignmentEnd = DateTime.Now.AddMonths(3),
            };
            return await _counselorRegRepository.Create(registry);
        }

        private async Task<bool> RegisterChangedCounselor(Counselor counselor, int cabinId)
        {
            var list = await _counselorRegRepository.FindAll();
            var registry = list.FirstOrDefault(c =>
                c.CabinId == cabinId && c.CounselorId == counselor.Id && c.AssignmentEnd > DateTime.Now);
            if (registry == null) return false;

            registry.AssignmentEnd = DateTime.Now;
            registry.Notes = "The counselor has been changed to another";
            return await _counselorRegRepository.Update(registry);
        }

        private async Task<bool> RegisterCamperCheckOut(Cabin cabin, Camper camper)
        {
            var list = await _camperRegRepository.FindAll();
            var registry = list.FirstOrDefault(r =>
                r.CabinId == cabin.Id && r.CamperId == camper.Id && r.CheckOut > DateTime.Now);
            if (registry == null) return false;

            registry.CheckOut = DateTime.Now;
            return await _camperRegRepository.Update(registry);
        }


    }
}