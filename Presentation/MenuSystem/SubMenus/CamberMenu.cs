using System;
using System.Threading.Tasks;
using Application;
using Persistence;

namespace Presentation.MenuSystem.SubMenus
{
    public class CamberMenu
    {
        private readonly CamperHandler _handler;
        public CamberMenu(DataContext context)
        {
            _handler = new CamperHandler(context);
        }
        public async Task<bool> Run()
        {
            const string prompt = "Please choose an option below:";
            var options = new string[]
            {
                "Show all registered campers.",
                "Show a specific camper by ID",
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

                    break;

                case 2:
                    return false;
            }
            Console.WriteLine(result);

            Console.WriteLine("Press any key to return to campers menu...");
            Console.ReadKey(true);
            await this.Run();

            return false;
        }
    }
}