using System;
using System.Linq;
using System.Threading.Tasks;
using Application.Extensions;
using Domain;
using Persistence;
using Persistence.Repository;

namespace Application
{
    public class VisitHandler
    {
        private readonly VisitRepository _repository;
        private readonly CamperRepository _camperRepository;
        private readonly NextOfKinRepository _nextOfKinRepository;
        public VisitHandler(DataContext context)
        {
            _repository = new VisitRepository(context);
            _camperRepository = new CamperRepository(context);
            _nextOfKinRepository = new NextOfKinRepository(context);
        }

        public async Task<string> GetAllVisits()
        {
            var list = await _repository.FindAll();
            return list.Aggregate(string.Empty, (current, visit) => current + visit.VisitInfoString());
        }

        public async Task<string> GetVisitById(int id)
        {
            var visit = await _repository.FindById(id);
            return visit == null ? "The visit was not found in the database" : visit.VisitInfoString();
        }

        public async Task<string> RegisterVisit(int camperId, int nextOfKinId, int visitLength)
        {
            var camper = await _camperRepository.FindById(camperId);
            if (camper == null)
                return "The camper was not found in the database";

            var nextOfKin = await _nextOfKinRepository.FindById(nextOfKinId);
            if (nextOfKin == null)
                return "The visitor was not found as a registered next of kin";

            var camperVisitor = camper.NextOfKins.FirstOrDefault(v => v.Id == nextOfKinId);
            if (camperVisitor == null)
                return
                    "The visitor is not allowed to visit this camper because the visitor is not registered as a next of kin for this camper";

            if (visitLength > 3)
                return "The length of the visit can not be longer than 3 hours";

            var time = DateTime.Now.TimeOfDay;
            if (time.Hours is < 10 or >= 20)
                return "The visit is not possible at this time. Visit hours are between 10 A.M and 8 P.M!";

            var visit = new Visit
            {
                Camper = camper,
                Visitor = nextOfKin,
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddHours(visitLength),
            };
            var str = string.Empty;
            if (visit.EndTime.Hour >= 20)
            {
                visit.EndTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 19, 59, 59);
                str =
                    "The time the visit ends is changed to 7:59 P.M because visit hours are between 10 A.M and 8 P.M!";
            }

            var result = await _repository.Create(visit);
            if (!result) return "There was a problem with registering the visit.";

            str += "\nThe visit has been registered. Here is the info: \n";
            str += visit.VisitInfoString();
            return str;

        }
    }
}