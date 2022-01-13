using System;
using System.Collections.Generic;
using Domain;

namespace Persistence
{
    public class SeedData
    {
        public List<Cabin> Cabins { get; set; }
        public List<NextOfKin> NextOfKins { get; set; }
        public List<Counselor> Counselors { get; set; }
        public List<Camper> Campers { get; set; }
        public List<CounselorRegistry> CounselorRegistries { get; set; }
        public List<CamperRegistry> CamperRegistries { get; set; }
        public List<Visit> Visits { get; set; }

        public SeedData()
        {
            Cabins = PopulateCabins();
            NextOfKins = PopulateNextOfKins();
            Counselors = PopulateCounselors();
            Campers = PopulateCampers();
            CamperRegistries = PopulateCamperRegistries();
            CounselorRegistries = PopulateCounselorRegistries();
            Visits = PopulateVisitorRegistries();
        }

        private static List<Cabin> PopulateCabins()
        {
            var list = new List<Cabin>
            {
                new Cabin {Id = 1, Name = "First", CounselorId = 1},
                new Cabin {Id = 2, Name = "Second", CounselorId = 2},
                new Cabin {Id = 3, Name = "Third", CounselorId = 3},
                new Cabin {Id = 4, Name = "Fourth", CounselorId = 4},
                new Cabin {Id = 5, Name = "Fifth", CounselorId = 5},
            };
            return list;
        }

        private static List<Counselor> PopulateCounselors()
        {
            var list = new List<Counselor>
            {
                new Counselor {Id = 1, Name = "Anders Counselsson", CabinId = 1, Address = "Storgatan10", DateOfBirth = DateTime.Now.AddYears(-30), Email = "counc1@th.com", PhoneNumber = "0700545641"},
                new Counselor {Id = 2, Name = "Erik Test", CabinId = 2, Address = "Göteborgsvägen 2", DateOfBirth = DateTime.Now.AddYears(-23), Email = "counc2@th.com", PhoneNumber = "0700274641"},
                new Counselor {Id = 3, Name = "Johan Svart", CabinId = 3, Address = "Torggatan1", DateOfBirth = DateTime.Now.AddYears(-26), Email = "counc3@th.com", PhoneNumber = "0703545641"},
                new Counselor {Id = 4, Name = "Jimmie Svensson", CabinId = 4, Address = "Lillegatan4", DateOfBirth = DateTime.Now.AddYears(-29), Email = "counc4@th.com", PhoneNumber = "0787445641"},
                new Counselor {Id = 5, Name = "Maja Andersson", CabinId = 5, Address = "Kunggatan3", DateOfBirth = DateTime.Now.AddYears(-25), Email = "counc5@th.com", PhoneNumber = "0700543421"},
            };
            return list;
        }

        private static List<Camper> PopulateCampers()
        {
            return new List<Camper>
            {
                new Camper {Id = 1, Name = "Niklas", PhoneNumber = "0711254895", CabinId = 1, DateOfBirth = DateTime.Now.AddYears(-10)},
                new Camper {Id = 2, Name = "Maja", PhoneNumber = "0711254895", CabinId = 1, DateOfBirth = DateTime.Now.AddYears(-11)},
                new Camper {Id = 3, Name = "Lina", PhoneNumber = "0711254895", CabinId = 1, DateOfBirth = DateTime.Now.AddYears(-12)},
                new Camper {Id = 4, Name = "Paula", PhoneNumber = "0711254895", CabinId = 1, DateOfBirth = DateTime.Now.AddYears(-10)},
                new Camper {Id = 5, Name = "Anders", PhoneNumber = "0711254895", CabinId = 2, DateOfBirth = DateTime.Now.AddYears(-9)},
                new Camper {Id = 6, Name = "Ahmed", PhoneNumber = "0711254895", CabinId = 2, DateOfBirth = DateTime.Now.AddYears(-8)},
                new Camper {Id = 7, Name = "Erik", PhoneNumber = "0711254895", CabinId = 2, DateOfBirth = DateTime.Now.AddYears(-9)},
                new Camper {Id = 8, Name = "Frida", PhoneNumber = "0711254895", CabinId = 2, DateOfBirth = DateTime.Now.AddYears(-10)},
                new Camper {Id = 9, Name = "Paul", PhoneNumber = "0711254895", CabinId = 3, DateOfBirth = DateTime.Now.AddYears(-11)},
                new Camper {Id = 10, Name = "Mikael", PhoneNumber = "0711254895", CabinId = 3, DateOfBirth = DateTime.Now.AddYears(-11)},
                new Camper {Id = 11, Name = "John", PhoneNumber = "0711254895", CabinId = 3, DateOfBirth = DateTime.Now.AddYears(-12)},
                new Camper {Id = 12, Name = "Silvio", PhoneNumber = "0711254895", CabinId = 3, DateOfBirth = DateTime.Now.AddYears(-13)},
                new Camper {Id = 13, Name = "Per", PhoneNumber = "0711254895", CabinId = 4, DateOfBirth = DateTime.Now.AddYears(-11)},
                new Camper {Id = 14, Name = "Leo", PhoneNumber = "0711254895", CabinId = 4, DateOfBirth = DateTime.Now.AddYears(-12)},
                new Camper {Id = 15, Name = "Howard", PhoneNumber = "0711254895", CabinId = 4, DateOfBirth = DateTime.Now.AddYears(-11)},
                new Camper {Id = 16, Name = "Ross", PhoneNumber = "0711254895", CabinId = 4, DateOfBirth = DateTime.Now.AddYears(-10)},
                new Camper {Id = 17, Name = "Rachel", PhoneNumber = "0711254895", CabinId = 5, DateOfBirth = DateTime.Now.AddYears(-11)},
                new Camper {Id = 18, Name = "Jakob", PhoneNumber = "0711254895", CabinId = 5, DateOfBirth = DateTime.Now.AddYears(-9)},
            };
        }

        private static List<NextOfKin> PopulateNextOfKins()
        {
            return new List<NextOfKin>()
            {
                new NextOfKin {Id = 1, Name = "Ken", Address = "Gata6", CamperId = 1, Email = "parent1@test.com", PhoneNumber = "071254864"},
                new NextOfKin {Id = 2, Name = "Anders", Address = "Gata7", CamperId = 2, Email = "parent2@test.com", PhoneNumber = "071254864"},
                new NextOfKin {Id = 3, Name = "Lina", Address = "Gata8", CamperId = 3, Email = "parent3@test.com", PhoneNumber = "071254864"},
                new NextOfKin {Id = 4, Name = "Per", Address = "Gata4", CamperId = 4, Email = "parent4@test.com", PhoneNumber = "071254864"},
                new NextOfKin {Id = 5, Name = "Mikael", Address = "Gata5", CamperId = 5, Email = "parent5@test.com", PhoneNumber = "071254864"},
                new NextOfKin {Id = 6, Name = "Johnny", Address = "Gata1", CamperId = 6, Email = "parent6@test.com", PhoneNumber = "071254864"},
                new NextOfKin {Id = 7, Name = "Leonard", Address = "Gata45", CamperId = 7, Email = "parent7@test.com", PhoneNumber = "071254864"},
                new NextOfKin {Id = 8, Name = "Ross", Address = "Gata54", CamperId = 8, Email = "parent8@test.com", PhoneNumber = "071254864"},
                new NextOfKin {Id = 9, Name = "Chandler", Address = "Gata42", CamperId = 9, Email = "parent9@test.com", PhoneNumber = "071254864"},
                new NextOfKin {Id = 10, Name = "Gunther", Address = "Gata64", CamperId = 10, Email = "parent10@test.com", PhoneNumber = "071254864"},
                new NextOfKin {Id = 11, Name = "Joey", Address = "Gata61", CamperId = 11, Email = "parent11@test.com", PhoneNumber = "071254864"},
                new NextOfKin {Id = 12, Name = "Josef", Address = "Gata45", CamperId = 12, Email = "parent12@test.com", PhoneNumber = "071254864"},
                new NextOfKin {Id = 13, Name = "Stefan", Address = "Gata25", CamperId = 13, Email = "parent13@test.com", PhoneNumber = "071254864"},
                new NextOfKin {Id = 14, Name = "Fredrick", Address = "Gata48", CamperId = 14, Email = "parent14@test.com", PhoneNumber = "071254864"},
                new NextOfKin {Id = 15, Name = "Marco", Address = "Gata66", CamperId = 15, Email = "parent15@test.com", PhoneNumber = "071254864"},
                new NextOfKin {Id = 16, Name = "Polo", Address = "Gata69", CamperId = 16, Email = "parent16@test.com", PhoneNumber = "071254864"},
                new NextOfKin {Id = 17, Name = "Cameron", Address = "Gata74", CamperId = 17, Email = "parent17@test.com", PhoneNumber = "071254864"},
                new NextOfKin {Id = 18, Name = "Mitchel", Address = "Gata87", CamperId = 18, Email = "parent18@test.com", PhoneNumber = "071254864"},
            };
        }

        private static List<CounselorRegistry> PopulateCounselorRegistries()
        {
            return new List<CounselorRegistry>()
            {
                new CounselorRegistry {Id = 1, CounselorId = 1, CabinId = 1, AssignmentStart = DateTime.Now, AssignmentEnd = DateTime.Now.AddMonths(3)},
                new CounselorRegistry {Id = 2, CounselorId = 2, CabinId = 2, AssignmentStart = DateTime.Now, AssignmentEnd = DateTime.Now.AddMonths(3)},
                new CounselorRegistry {Id = 3, CounselorId = 3, CabinId = 3, AssignmentStart = DateTime.Now, AssignmentEnd = DateTime.Now.AddMonths(3)},
                new CounselorRegistry {Id = 4, CounselorId = 4, CabinId = 4, AssignmentStart = DateTime.Now, AssignmentEnd = DateTime.Now.AddMonths(3)},
                new CounselorRegistry {Id = 5, CounselorId = 5, CabinId = 5, AssignmentStart = DateTime.Now, AssignmentEnd = DateTime.Now.AddMonths(3)},
            };
        }

        private static List<CamperRegistry> PopulateCamperRegistries()
        {
            return new List<CamperRegistry>()
            {
                new CamperRegistry{Id = 1, CabinId = 1, CamperId = 1, CheckIn = DateTime.Now, CheckOut = DateTime.Now.AddMonths(3)},
                new CamperRegistry{Id = 2, CabinId = 1, CamperId = 2, CheckIn = DateTime.Now, CheckOut = DateTime.Now.AddMonths(3)},
                new CamperRegistry{Id = 3, CabinId = 1, CamperId = 3, CheckIn = DateTime.Now, CheckOut = DateTime.Now.AddMonths(3)},
                new CamperRegistry{Id = 4, CabinId = 1, CamperId = 4, CheckIn = DateTime.Now, CheckOut = DateTime.Now.AddMonths(3)},
                new CamperRegistry{Id = 5, CabinId = 2, CamperId = 5, CheckIn = DateTime.Now, CheckOut = DateTime.Now.AddMonths(3)},
                new CamperRegistry{Id = 6, CabinId = 2, CamperId = 6, CheckIn = DateTime.Now, CheckOut = DateTime.Now.AddMonths(3)},
                new CamperRegistry{Id = 7, CabinId = 2, CamperId = 7, CheckIn = DateTime.Now, CheckOut = DateTime.Now.AddMonths(3)},
                new CamperRegistry{Id = 8, CabinId = 2, CamperId = 8, CheckIn = DateTime.Now, CheckOut = DateTime.Now.AddMonths(3)},
                new CamperRegistry{Id = 9, CabinId = 3, CamperId = 9, CheckIn = DateTime.Now, CheckOut = DateTime.Now.AddMonths(3)},
                new CamperRegistry{Id = 10, CabinId = 3, CamperId = 10, CheckIn = DateTime.Now, CheckOut = DateTime.Now.AddMonths(3)},
                new CamperRegistry{Id = 11, CabinId = 3, CamperId = 11, CheckIn = DateTime.Now, CheckOut = DateTime.Now.AddMonths(3)},
                new CamperRegistry{Id = 12, CabinId = 3, CamperId = 12, CheckIn = DateTime.Now, CheckOut = DateTime.Now.AddMonths(3)},
                new CamperRegistry{Id = 13, CabinId = 4, CamperId = 13, CheckIn = DateTime.Now, CheckOut = DateTime.Now.AddMonths(3)},
                new CamperRegistry{Id = 14, CabinId = 4, CamperId = 14, CheckIn = DateTime.Now, CheckOut = DateTime.Now.AddMonths(3)},
                new CamperRegistry{Id = 15, CabinId = 4, CamperId = 15, CheckIn = DateTime.Now, CheckOut = DateTime.Now.AddMonths(3)},
                new CamperRegistry{Id = 16, CabinId = 4, CamperId = 16, CheckIn = DateTime.Now, CheckOut = DateTime.Now.AddMonths(3)},
                new CamperRegistry{Id = 17, CabinId = 5, CamperId = 17, CheckIn = DateTime.Now, CheckOut = DateTime.Now.AddMonths(3)},
                new CamperRegistry{Id = 18, CabinId = 5, CamperId = 18, CheckIn = DateTime.Now, CheckOut = DateTime.Now.AddMonths(3)},
            };
        }

        private static List<Visit> PopulateVisitorRegistries()
        {
            return new List<Visit>()
            {
                new Visit{Id = 1, CamperId = 1, StartTime = DateTime.Now, EndTime = DateTime.Now.AddHours(2), VisitorId = 1},
                new Visit{Id = 2, CamperId = 2, StartTime = DateTime.Now, EndTime = DateTime.Now.AddHours(1), VisitorId = 2},
                new Visit{Id = 3, CamperId = 3, StartTime = DateTime.Now, EndTime = DateTime.Now.AddHours(3), VisitorId = 3},
            };
        }
    }
}