using Application;
using Domain;
using Persistence;
using Persistence.Repository;
using Presentation.Input;
using System.Threading.Tasks;
using System;

namespace Presentation.MenuSystem.SubMenus
{
    public class NextOfKinMenu
    {
        private readonly NextOfKinRepository _repository;
        private readonly NextOfKinHandler _handler;

        public NextOfKinMenu(DataContext context)
        {
            _repository = new NextOfKinRepository(context);
            _handler = new NextOfKinHandler(context);
        }

        public async Task<bool> Run()
        {
            const string prompt = "Please choose an option below:";
            var options = new string[]
            {
                "Show all registered next of kins",
                "Show a specific next of kin by ID",
                "Add a new next of kin",
                "Update a next of kin",
                "Return to main menu",
            };
            var menu = new MenuBuilder(prompt, options);
            var selectedIndex = menu.Run();
            var result = "";
            switch (selectedIndex)
            {
                case 0:
                    result = await _handler.GetAllNextOfKins();
                    break;
                case 1:
                    result = await _handler.GetNextOfKinById(InputHandler.GetIdFromUser("next of kin", "show"));
                    break;
                case 2:
                    result = await AddNewNextOfKin();
                    break;
                case 3:
                    result = await UpdateNextOfKin();
                    break;
                case 4:
                    return false;
            }
            Console.WriteLine(result);

            Console.WriteLine("Press any key to return to next of kin menu...");
            Console.ReadKey(true);
            await this.Run();

            return false;
        }

        private async Task<string> AddNewNextOfKin()
        {
            var nextOfKin = new NextOfKin
            {
                Name = InputHandler.GetString("Please enter the name of the next of kin:"),
                PhoneNumber = InputHandler.GetString("Please enter the phone number of the next of kin:"),
                Address = InputHandler.GetString("Please enter the address of the next of kin:"),
                Email = InputHandler.GetString("Please enter the email of the next of kin:"),
            };

            return await _handler.AddNextOfKin(nextOfKin);
        }
        private async Task<string> UpdateNextOfKin()
        {
            var id = InputHandler.GetIdFromUser("next of kin", "update");
            var nextOfKin = await _repository.FindById(id);
            if (nextOfKin == null) return "The next of kin was not found in the database";

            var oldNextOfKinDetails = await _handler.GetNextOfKinById(id);
            Console.WriteLine($"Here are the details of the next of kin: \n{oldNextOfKinDetails}");
            Console.WriteLine("Press enter to change those details...");
            Console.ReadKey(true);
            nextOfKin.Name = InputHandler.GetString("Please enter the new name of the next of kin:");
            nextOfKin.PhoneNumber = InputHandler.GetString("Please enter the new phone number of the next of kin:");
            nextOfKin.Address = InputHandler.GetString("Please enter the address of the next of kin:");
            nextOfKin.Email = InputHandler.GetString("Please enter the email of the next of kin:");

            return await _handler.UpdateNextOfKin(nextOfKin);
        }
    }
}