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

            var nextOfKin = await _nextOfKinRepository.FindById(nextOfKinId);

            var success = ValidateInput(camper, nextOfKin, visitLength, out var errorMsg);
            if (!success)
                return errorMsg;

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

        private static bool ValidateInput(Camper camper, NextOfKin nextOfKin, int visitLength, out string error)
        {
            if (camper == null)
            {
                error = "The camper was not found in the database";
                return false;
            }

            if (nextOfKin == null)
            {
                error = "The visitor was not found as a registered next of kin";
                return false;
            }

            var camperVisitor = camper.NextOfKins.FirstOrDefault(v => v.Id == nextOfKin.Id);
            if (camperVisitor == null)
            {
                error = "The visitor is not allowed to visit this camper because the visitor is not registered as a next of kin for this camper";
                return false;
            }

            if (visitLength > 3)
            {
                error = "The length of the visit can not be longer than 3 hours";
                return false;
            }

            var time = DateTime.Now.TimeOfDay;
            if (time.Hours is < 10 or >= 20)
            {
                error = "The visit is not possible at this time. Visit hours are between 10 A.M and 8 P.M!";
                return false;
            }

            error = string.Empty;
            return true;
        }
    }
}