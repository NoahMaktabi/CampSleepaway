using Application;
using Persistence;
using Persistence.Repository;
using Presentation.Input;
using System.Threading.Tasks;
using System;
using Domain;

namespace Presentation.MenuSystem.SubMenus
{
    public class CabinMenu
    {
        private readonly CabinRepository _repository;
        private readonly CabinHandler _handler;
        private readonly CamperRepository _camperRepository;
        private readonly CounselorRepository _counselorRepository;
        public CabinMenu(DataContext context)
        {
            _repository = new CabinRepository(context);
            _handler = new CabinHandler(context);
            _camperRepository = new CamperRepository(context);
            _counselorRepository = new CounselorRepository(context);
        }

        public async Task<bool> Run()
        {
            const string prompt = "Please choose an option below:";
            var options = new string[]
            {
                "Show all cabins",
                "Show a specific cabin by ID",
                "Add a new cabin",
                "Add camper to cabin",
                "Register a counselor to cabin",
                "Change cabin counselor",
                "Check out campers",
                "Return to main menu",
            };
            var menu = new MenuBuilder(prompt, options);
            var selectedIndex = menu.Run();
            var result = "";
            switch (selectedIndex)
            {
                case 0:
                    result = await _handler.GetAllCabins();
                    break;
                case 1:
                    Console.WriteLine(await ShowCabinsWithId());
                    result = await _handler.GetCabinById(InputHandler.GetIdFromUser("cabin", "show"));
                    break;
                case 2:
                    result = await AddNewCabin();
                    break;
                case 3:
                    result = await AddCamperToCabin();
                    break;
                case 4:
                    result = await AddCounselorToCabin();
                    break;
                case 5:
                    result = await ChangeCabinCounselor();
                    break;
                case 6:
                    result = await CheckOutCamper();
                    break;
                case 7:
                    return false;
            }
            Console.WriteLine(result);

            Console.WriteLine("Press any key to return to cabin menu...");
            Console.ReadKey(true);
            await this.Run();

            return false;
        }

        public async Task<string> AddNewCabin()
        {
            var cabin = new Cabin
            {
                Name = InputHandler.GetString("Please enter the name of the cabin:")
            };
            return await _handler.AddCabin(cabin);
        }

        public async Task<string> AddCamperToCabin()
        {
            Console.WriteLine(await ShowAllCampersWithId());

            var camperId = InputHandler.GetIdFromUser("camper", "assign to cabin");
            var camper = await _camperRepository.FindById(camperId);
            if (camper == null) return "The camper was not found in the database";

            Console.WriteLine(await ShowCabinsWithId());

            var cabinId = InputHandler.GetIdFromUser("cabin", "register a new camper");
            return await _handler.AddCamperToCabin(cabinId, camper);
        }

        private async Task<string> AddCounselorToCabin()
        {
            Console.WriteLine(await ShowAllCounselorsWithId());

            var counselorId = InputHandler.GetIdFromUser("counselor", "assign to cabin");
            var counselor = await _counselorRepository.FindById(counselorId);
            if (counselor == null) return "The counselor was not found in the database";

            Console.WriteLine(await ShowCabinsWithId());

            var cabinId = InputHandler.GetIdFromUser("cabin", "register a new counselor");
            return await _handler.AddCounselorToCabin(cabinId, counselor);
        }

        private async Task<string> ChangeCabinCounselor()
        {
            Console.WriteLine(await ShowAllCounselorsWithId());

            var counselorId = InputHandler.GetIdFromUser("counselor", "assign to cabin");
            var counselor = await _counselorRepository.FindById(counselorId);
            if (counselor == null) return "The counselor was not found in the database";

            Console.WriteLine(await ShowCabinsWithId());
    
            var cabinId = InputHandler.GetIdFromUser("cabin", "change a counselor");
            return await _handler.ChangeCabinCounselor(cabinId, counselor);
        }

        private async Task<string> CheckOutCamper()
        {
            Console.WriteLine(await ShowCabinsWithId());
       
            var cabinId = InputHandler.GetIdFromUser("cabin", "Check out a camper");
            var cabin = await _repository.FindById(cabinId);
            if (cabin == null) return "The cabin was not found in the database";

            Console.Clear();
            Console.WriteLine(ShowCampersInCabinWithId(cabin));
      
            var camperId = InputHandler.GetIdFromUser("camper", "Check out from cabin");
            return await _handler.CheckOutCamper(camperId, cabinId);
        }

        private async Task<string> ShowCabinsWithId()
        {
            var list = await _repository.FindAll();
            var str = "Here are the cabins to choose from:\n";
            list.ForEach(c =>
            {
                str += $"ID: [{c.Id}] -- Name: {c.Name}\n";
            });
            return str;
        }

        private static string ShowCampersInCabinWithId(Cabin cabin)
        {
            var str = "Here are the campers to choose from: \n";
            cabin.Campers.ForEach(c =>
            {
                str += $"Camper ID: [{c.Id}] -- Name: {c.Name}\n";
            });
            return str;
        }

        private async Task<string> ShowAllCampersWithId()
        {
            var list = await _camperRepository.FindAll();
            var str = "Here are the campers to choose from: \n";
            list.ForEach(c =>
            {
                str += $"ID: [{c.Id}] -- Name: {c.Name}\n";
            });
            return str;
        }

        private async Task<string> ShowAllCounselorsWithId()
        {
            var list = await _counselorRepository.FindAll();
            var str = "Here are the counselors to choose from: \n";
            list.ForEach(c =>
            {
                str += $"ID: [{c.Id}] -- Name: {c.Name}\n";
            });
            return str;
        }

    }
}