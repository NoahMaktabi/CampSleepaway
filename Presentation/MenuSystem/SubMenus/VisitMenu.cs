using Application;
using Persistence;
using System;
using System.Threading.Tasks;
using Presentation.Input;

namespace Presentation.MenuSystem.SubMenus
{
    public class VisitMenu
    {
        private readonly VisitHandler _handler;
        public VisitMenu(DataContext context)
        {
            _handler = new VisitHandler(context);
        }

        public async Task<bool> Run()
        {
            const string prompt = "Please choose an option below:";
            var options = new string[]
            {
                "Show all registered visits",
                "Show a specific visit by ID",
                "Register a new visit",
                "Return to main menu",
            };
            var menu = new MenuBuilder(prompt, options);
            var selectedIndex = menu.Run();
            var result = "";
            switch (selectedIndex)
            {
                case 0:
                    result = await _handler.GetAllVisits();
                    break;
                case 1:
                    result = await _handler.GetVisitById(InputHandler.GetIdFromUser("visit", "show"));
                    break;
                case 2:
                    result = await RegisterVisit();
                    break;
                case 3:
                    return false;
            }
            Console.WriteLine(result);

            Console.WriteLine("Press any key to return to cabin menu...");
            Console.ReadKey(true);
            await this.Run();

            return false;
        }

        private async Task<string> RegisterVisit()
        {
            var camperId = InputHandler.GetIdFromUser("camper", "register a visitor");
            var visitorId = InputHandler.GetIdFromUser("next of kin", "register as visitor");
            var visitLength = InputHandler.GetVisitLength();
            return await _handler.RegisterVisit(camperId, visitorId, visitLength);
        }
    }
}