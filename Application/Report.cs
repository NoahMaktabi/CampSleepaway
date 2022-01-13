using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore.Internal;
using Persistence.Repository;

namespace Application
{
    public class Report
    {
        private readonly CamperRepository _camperRepository;

        public Report(CamperRepository camperRepository)
        {
            _camperRepository = camperRepository;
        }

        public async Task<string> GetAllCampersByCabin()
        {
            var groupedCampers = (await _camperRepository.FindAll()).GroupBy(x => x.CabinId);
            var result = "";
            foreach (var cabinGroup in groupedCampers)
            {
                result += $"\t\tCabin number: {cabinGroup.Key}\n---------------\n";
                var cabinCamper = cabinGroup.FirstOrDefault(c => c.CabinId == cabinGroup.Key);
                if (cabinCamper != null && cabinCamper.Cabin.Counselor == null)
                {
                    result += $"Cabin number {cabinGroup.Key} does not have a counselor!!\n";
                }
                result = cabinGroup.Aggregate(result, (current, camper) => current + GetCamperInfo(camper));
            }
            return result;
        }

        public async Task<string> GetAllCampersByCounselor()
        {
            var groupedCampers = (await _camperRepository.FindAll()).GroupBy(x => x.Cabin.Counselor);
            var result = "";
            foreach (var counselorGroup in groupedCampers)
            {
                result += $"\t\tCounselor name: {counselorGroup.Key.Name}\n\t\tCabin number: {counselorGroup.Key.CabinId}\n---------------\n";
                result = counselorGroup.Aggregate(result, (current, camper) => current + GetCamperInfo(camper));
            }
            return result;
        }

        private static string GetCamperInfo(Camper camper)
        {
            var result = $"Camper name: {camper.Name}.\nPhone: {camper.PhoneNumber}\nBirthday: {camper.DateOfBirth.ToLongDateString()}\n";
            result += $"Next of kin:\n";
            foreach (var camperNextOfKin in camper.NextOfKins)
            {
                result += $"\tName: {camperNextOfKin.Name}\n";
                result += $"\tAddress: {camperNextOfKin.Address}\n";
                result += $"\tPhone: {camperNextOfKin.PhoneNumber}\n----------------\n";
            }
            return result;
        }
         
    }
}