using Application;
using Persistence;
using System.Threading.Tasks;

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
                "Add a new cabin",
                "Add camper to cabin",
                "Register a counselor to cabin",
                "Change cabin counselor",
                "Return to main menu",
            };
        }
    }
}