using System;
using Domain;

namespace Application.Extensions
{
    public static class Extensions
    {
        public static string CamperInfoString(this Camper camper)
        {
            var result = $"Camper ID: {camper.Id}.\nCamper name: {camper.Name}.\n" +
                         $"Phone: {camper.PhoneNumber}\n" +
                         $"Birthday: {camper.DateOfBirth.ToLongDateString()}\n";
            if (camper.Cabin != null)
            {
                result += $"Cabin name: {camper.Cabin.Name}\n";
            }
            else
            {
                result += "No cabin has been assigned!\n";
            }
            
            result += $"Next of kin:\n";
            foreach (var camperNextOfKin in camper.NextOfKins)
            {
                result += $"\tName: {camperNextOfKin.Name}\n";
                result += $"\tAddress: {camperNextOfKin.Address}\n";
                result += $"\tPhone: {camperNextOfKin.PhoneNumber}\n----------------\n";
            }
            if (camper.NextOfKins.Count == 0)
            {
                result += "\tNo next of kin has been assigned!\n";
            }
            return result;
        }

        public static string CabinInfoString(this Cabin cabin)
        {
            var counselor = cabin.Counselor?.Name;
            if (cabin.Counselor == null)
                counselor = "There is no counselor registered in this cabin";
            var str = $"Cabin number: {cabin.Id}\nName: {cabin.Name}\nRegistered counselor: {counselor}\n";
            
            str += $"Campers registered: {cabin.Campers.Count} campers.\n------------------\n";
            return str;
        }

        public static string CounselorInfoString(this Counselor counselor)
        {
            return $"ID: {counselor.Id}.\nName: {counselor.Name}.\nPhone: {counselor.PhoneNumber}.\n" +
                      $"Assigned to cabin: {counselor.AssignedToCabin}.\nEmail: {counselor.Email}.\n" +
                      $"Date of birth: {counselor.DateOfBirth.ToLongDateString()}.\n----------------\n";
        }

        public static string NextOfKinInfoString(this NextOfKin nextOfKin)
        {
            var str = $"ID: {nextOfKin.Id}.\nName: {nextOfKin.Name}.\nPhone: {nextOfKin.PhoneNumber}.\n" +
                      $"Email: {nextOfKin.Email}.\n" +
                      $"Address: {nextOfKin.Address}.\n";
            if (nextOfKin.Camper != null)
            {
                str += $"\tName of child(camper): {nextOfKin.Camper.Name}\n" +
                       $"\nCurrently resident in cabin: {nextOfKin.Camper.CabinId}\n";
            }
            else
            {
                str += "There is no child assigned to this next of kin! \n";
            }
                   
            str += $"\n----------------\n";

            return str;
        }

        public static string CounselorRegistryInfoString(this CounselorRegistry registry)
        {
            var str = $"ID: {registry.Id}. \n";
            if (registry.Cabin != null)
            {
                str += $"Cabin: {registry.CabinId}.\n";
            }
            if (registry.Counselor != null)
            {
                str += $"Counselor: {registry.Counselor.Name}.\n";
            }

            str += $"Assignment start: {registry.AssignmentStart.ToLongDateString()}.\n";
            str += $"Assignment end: {registry.AssignmentEnd.ToLongDateString()}.\n";

            var assignment = registry.AssignmentEnd.CompareTo(DateTime.Now);
            if (assignment <= 0)
            {
                str += $"The assignment has already ended\n";
            }
            else
            {
                str += "The assignment is currently active\n";
            }

            str += $"Notes: {registry.Notes ?? ""}\n-----------\n";

            return str;
        }

        public static string CamperRegistryInfoString(this CamperRegistry registry)
        {
            var str = $"ID: {registry.Id}. \n";
            if (registry.Cabin != null)
            {
                str += $"Cabin: {registry.CabinId}.\n";
            }

            if (registry.Camper != null)
            {
                str += $"Camper: {registry.Camper.Name}.\n";
            }

            str += $"Check in date: {registry.CheckIn.ToLongDateString()}.\n";
            str += $"Check out date: {registry.CheckOut.ToLongDateString()}.\n";

            var assignment = registry.CheckOut.CompareTo(DateTime.Now);
            if (assignment <= 0)
            {
                str += $"The assignment has already ended. The camper is no longer assigned to this cabin.\n";
            }
            else
            {
                str += "The assignment is currently active.\n";
            }
            str += $"Notes: {registry.Notes ?? ""}\n-----------\n";

            return str;
        }

        public static string VisitInfoString(this Visit visit)
        {
            var str = string.Empty;
            if (visit.Id != 0)
            {
                str += $"Visit ID: {visit.Id}.\n";
            }
            if (visit.Camper != null)
            {
                str += $"Camper info: {visit.Camper.CamperInfoString()}.\n";
            }
            if (visit.Visitor != null)
            {
                str += $"Visitor info: {visit.Visitor.NextOfKinInfoString()}.\n";
            }

            str += $"Visit date: {visit.StartTime.ToLongDateString()}.\n";
            str +=
                $"Visit time from: {visit.StartTime.ToShortTimeString()} - To: {visit.EndTime.ToShortTimeString().Length}.\n---------\n";
            return str;
        }
    }
}