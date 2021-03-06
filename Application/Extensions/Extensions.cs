using System;
using Domain;

namespace Application.Extensions
{
    public static class Extensions
    {
        /// <summary>
        /// Provided a camper instance. The method returns a string with information about the camper
        /// </summary>
        /// <param name="camper"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Provided a cabin instance. The method returns a string with information about the cabin.
        /// If there is no counselor assigned. The method will notice that in the returen string
        /// </summary>
        /// <param name="cabin"></param>
        /// <returns></returns>
        public static string CabinInfoString(this Cabin cabin)
        {
            var counselor = cabin.Counselor?.Name;
            if (cabin.Counselor == null)
                counselor = "There is no counselor registered in this cabin";
            var str = $"Cabin number: {cabin.Id}\nName: {cabin.Name}\nRegistered counselor: {counselor}\n";
            
            str += $"Campers registered: {cabin.Campers.Count} campers.\n------------------\n";
            return str;
        }

        /// <summary>
        /// Provided a counselor instance. The method returns a string with information about the counselor
        /// </summary>
        /// <param name="counselor"></param>
        /// <returns></returns>
        public static string CounselorInfoString(this Counselor counselor)
        {
            return $"ID: {counselor.Id}.\nName: {counselor.Name}.\nPhone: {counselor.PhoneNumber}.\n" +
                      $"Assigned to cabin: {counselor.AssignedToCabin}.\nEmail: {counselor.Email}.\n" +
                      $"Date of birth: {counselor.DateOfBirth.ToLongDateString()}.\n----------------\n";
        }

        /// <summary>
        /// Provided a nextOfKin instance. The method returns a string with information about the nextOfKin.
        /// </summary>
        /// <param name="nextOfKin"></param>
        /// <returns></returns>
        public static string NextOfKinInfoString(this NextOfKin nextOfKin)
        {
            var str = $"ID: {nextOfKin.Id}.\nName: {nextOfKin.Name}.\nPhone: {nextOfKin.PhoneNumber}.\n" +
                      $"Email: {nextOfKin.Email}.\n" +
                      $"Address: {nextOfKin.Address}.\n";
            if (nextOfKin.Camper != null)
            {
                str += $"\tName of child(camper): {nextOfKin.Camper.Name}\n" +
                       $"\tCurrently resident in cabin: {nextOfKin.Camper.CabinId}\n";
            }
            else
            {
                str += "There is no child assigned to this next of kin! \n";
            }
                   
            str += $"\n----------------\n";

            return str;
        }

        /// <summary>
        /// Provided a CounselorRegistry instance. The method returns a string with information about the CounselorRegistry.
        /// </summary>
        /// <param name="registry"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Provided a CamperRegistry instance. The method returns a string with information about the CamperRegistry.
        /// </summary>
        /// <param name="registry"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Provided a visit instance. The method returns a string with information about the visit.
        /// </summary>
        /// <param name="visit"></param>
        /// <returns></returns>
        public static string VisitInfoString(this Visit visit)
        {
            var str = string.Empty;
            if (visit.Id != 0)
            {
                str += $"\n\n\n\t\tVisit ID: {visit.Id}.\n";
            }
            if (visit.Camper != null)
            {
                str += $"Camper info: {visit.Camper.CamperInfoString()}";
            }
            if (visit.Visitor != null)
            {
                str += $"Visitor info: {visit.Visitor.NextOfKinInfoString()}";
            }

            if (visit?.Camper?.Cabin.Counselor != null)
            {
                str += $"The visit takes place in cabin number {visit.Camper.Cabin.Id}.\n";
                str += $"Assigned counselor: {visit.Camper.Cabin.Counselor.Name}.\n";
            }

            str += $"Visit date: {visit.StartTime.ToLongDateString()}.\n";
            str +=
                $"Visit time from: {visit.StartTime.ToShortTimeString()} - To: {visit.EndTime.ToShortTimeString()}.\n---------\n";
            return str;
        }
    }
}