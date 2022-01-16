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
            var counselor = cabin.Counselor.Name;
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
            return $"ID: {nextOfKin.Id}.\nName: {nextOfKin.Name}.\nPhone: {nextOfKin.PhoneNumber}.\n" +
                   $"Email: {nextOfKin.Email}.\n" +
                   $"Address: {nextOfKin.Address}.\n" +
                   $"\tName of child(camper): {nextOfKin.Camper.Name}\n" +
                   $"\nCurrently resident in cabin: {nextOfKin.Camper.CabinId}\n" +
                   $"\n----------------\n";
        }
    }
}