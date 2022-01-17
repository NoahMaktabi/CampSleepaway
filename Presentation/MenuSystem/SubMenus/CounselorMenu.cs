using Application;
using Domain;
using Persistence;
using Persistence.Repository;
using Presentation.Input;
using System;
using System.Threading.Tasks;

namespace Presentation.MenuSystem.SubMenus
{
    public class CounselorMenu
    {
        private readonly CounselorRepository _repository;
        private readonly CounselorHandler _handler;

        public CounselorMenu(DataContext context)
        {
            _repository = new CounselorRepository(context);
            _handler = new CounselorHandler(context);
        }

        public async Task<bool> Run()
        {
            const string prompt = "Please choose an option below:";
            var options = new string[]
            {
                "Show all registered counselors",
                "Show a specific counselor by ID",
                "Add a new counselor",
                "Update a counselor",
                "Return to main menu",
            };
            var menu = new MenuBuilder(prompt, options);
            var selectedIndex = menu.Run();
            var result = "";
            switch (selectedIndex)
            {
                case 0:
                    result = await _handler.GetAllCounselors();
                    break;
                case 1:
                    result = await _handler.GetCounselorById(InputHandler.GetIdFromUser("counselor", "show"));
                    break;
                case 2:
                    result = await AddNewCounselor();
                    break;
                case 3:
                    result = await UpdateCounselor();
                    break;
                case 4:
                    return false;
            }
            Console.WriteLine(result);

            Console.WriteLine("Press any key to return to counselor menu...");
            Console.ReadKey(true);
            await this.Run();

            return false;
        }

        private async Task<string> AddNewCounselor()
        {
            var counselor = new Counselor
            {
                Name = InputHandler.GetString("Please enter the name of the counselor:"),
                PhoneNumber = InputHandler.GetString("Please enter the phone number of the counselor:"),
                Address = InputHandler.GetString("Please enter the address of the counselor:"),
                Email = InputHandler.GetString("Please enter the email of the counselor:"),
                DateOfBirth = InputHandler.GetBirthday(),
                AssignedToCabin = false,
            };

            return await _handler.AddNewCounselor(counselor);
        }
        private async Task<string> UpdateCounselor()
        {
            var id = InputHandler.GetIdFromUser("counselor", "update");
            var counselor = await _repository.FindById(id);
            if (counselor == null) return "The counselor was not found in the database";

            var oldCounselorDetails = await _handler.GetCounselorById(id);
            Console.WriteLine($"Here are the details of the counselor: \n{oldCounselorDetails}");
            Console.WriteLine("Press enter to change those details...");
            Console.ReadKey(true);
            counselor.Name = InputHandler.GetString("Please enter the new name of the counselor:");
            counselor.PhoneNumber = InputHandler.GetString("Please enter the new phone number of the camper:");
            counselor.Address = InputHandler.GetString("Please enter the address of the counselor:");
            counselor.Email = InputHandler.GetString("Please enter the email of the counselor:");
            counselor.DateOfBirth = InputHandler.GetBirthday();
            
            return await _handler.UpdateCounselor(counselor);
        }

    }
}