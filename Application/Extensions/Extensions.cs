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
            result += $"Cabin name: {camper.Cabin.Name}\n";
            result += $"Next of kin:\n";
            foreach (var camperNextOfKin in camper.NextOfKins)
            {
                result += $"\tName: {camperNextOfKin.Name}\n";
                result += $"\tAddress: {camperNextOfKin.Address}\n";
                result += $"\tPhone: {camperNextOfKin.PhoneNumber}\n----------------\n";
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
    }
}