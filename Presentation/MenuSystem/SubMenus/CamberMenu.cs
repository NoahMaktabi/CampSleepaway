using System;
using System.Threading.Tasks;
using Application;
using Domain;
using Persistence;
using Persistence.Repository;
using Presentation.Input;

namespace Presentation.MenuSystem.SubMenus
{
    public class CamberMenu
    {
        private readonly CamperHandler _handler;
        private readonly CamperRepository _repository;
        public CamberMenu(DataContext context)
        {
            _handler = new CamperHandler(context);
            _repository = new CamperRepository(context);
        }
        public async Task<bool> Run()
        {
            const string prompt = "Please choose an option below:";
            var options = new string[]
            {
                "Show all registered campers.",
                "Show a specific camper by ID",
                "Add a new camper",
                "Update a camper",
                "Return to main menu",
            };
            var menu = new MenuBuilder(prompt, options);
            var selectedIndex = menu.Run();
            var result = "";
            switch (selectedIndex)
            {
                case 0:
                    result = await _handler.GetAllCampers();
                    break;
                case 1:
                    result = await _handler.GetCamperById(InputHandler.GetIdFromUser("camper", "show"));
                    break;
                case 2:
                    result = await AddNewCamper();
                    break;
                case 3:
                    result = await UpdateCamper();
                    break;
                case 4:
                    return false;
            }
            Console.WriteLine(result);

            Console.WriteLine("Press any key to return to campers menu...");
            Console.ReadKey(true);
            await this.Run();

            return false;
        }

        private async Task<string> AddNewCamper()
        {
            var camper = new Camper
            {
                Name = InputHandler.GetString("Please enter the name of the camper!"),
                PhoneNumber = InputHandler.GetString("Please enter the phone number of the camper."),
                DateOfBirth = InputHandler.GetBirthday()
            };

            return await _handler.AddCamper(camper);
        }
        private async Task<string> UpdateCamper()
        {
            var id = InputHandler.GetIdFromUser("camper", "update");
            var camper = await _repository.FindById(id);
            if (camper == null) return "The camper was not found in the database";

            var oldCamperDetails = await _handler.GetCamperById(id);
            Console.WriteLine($"Here are the details of the camper: \n{oldCamperDetails}");
            Console.WriteLine("Press enter to change those details...");
            Console.ReadKey(true);
            camper.Name = InputHandler.GetString("Please enter the new name of the camper!");
            camper.PhoneNumber = InputHandler.GetString("Please enter the new phone number of the camper.");
            camper.DateOfBirth = InputHandler.GetBirthday();
            
            return await _handler.UpdateCamper(camper);
        }
    }
}