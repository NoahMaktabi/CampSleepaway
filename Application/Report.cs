using System.Linq;
using System.Threading.Tasks;
using Application.Extensions;
using Domain;
using Microsoft.EntityFrameworkCore.Internal;
using Persistence;
using Persistence.Repository;

namespace Application
{
    public class Report
    {
        private readonly CamperRepository _camperRepository;

        public Report(DataContext context)
        {
            _camperRepository = new CamperRepository(context);
        }

        public async Task<string> GetAllCampersByCabin()
        {
            var groupedCampers = (await _camperRepository.FindAll())
                .Where(c => c.Cabin != null)
                .GroupBy(x => x.CabinId);
            var result = "";
            foreach (var cabinGroup in groupedCampers)
            {
                result += $"\t\tCabin number: {cabinGroup.Key}\n---------------\n";
                var cabinCamper = cabinGroup.FirstOrDefault(c => c.CabinId == cabinGroup.Key);
                if (cabinCamper != null && cabinCamper.Cabin.Counselor == null)
                {
                    result += $"Cabin number {cabinGroup.Key} does not have a counselor!!\n";
                }
                result = cabinGroup.Aggregate(result, (current, camper) => current + camper.CamperInfoString());
            }

            var campersWithNoCabins = (await _camperRepository.FindAll())
                .Where(c => c.Cabin == null).ToList();
            if (campersWithNoCabins.Count == 0) return result;

            result += "\n--------\nCampers that are not assigned to cabins: \n";
            campersWithNoCabins.ForEach(c =>
            {
                result += c.CamperInfoString();
            });

            return result;
        }

        public async Task<string> GetAllCampersByCounselor()
        {
            var groupedCampers = (await _camperRepository.FindAll())
                .Where(c => c.Cabin != null)
                .GroupBy(x => x.Cabin.Counselor);
            var result = "";
            foreach (var counselorGroup in groupedCampers)
            {
                result += $"\t\tCounselor name: {counselorGroup.Key.Name}\n---------------\n";
                result = counselorGroup.Aggregate(result, (current, camper) => current + camper.CamperInfoString());
            }

            var campersWithNoCabins = (await _camperRepository.FindAll())
                .Where(c => c.Cabin == null).ToList();
            if (campersWithNoCabins.Count == 0) return result;

            result += "\n--------\nCampers that are not assigned to cabins or counselors: \n";
            campersWithNoCabins.ForEach(c =>
            {
                result += c.CamperInfoString();
            });

            return result;
        }
    }
}