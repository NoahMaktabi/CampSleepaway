using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Persistence.Repository;
using Presentation.MenuSystem.SubMenus;

namespace Presentation.MenuSystem
{
    public class MainMenu
    {
        private readonly DataContext _context;

        public MainMenu()
        {
            _context = new DataContext();
            _context.Database.Migrate();
        }

        /// <summary>
        /// Runs the menu and presents options to choose from.
        /// </summary>
        /// <returns>Void</returns>
        public async Task Run()
        {
            var prompt = @$"
Welcome to CampAway.
At the moment we have the following in the camp: 
{_context.Cabins.Count()} Cabins.
{_context.Counselors.Count()} Counselors.
{_context.Campers.Count()} Campers.
{(!_context.Cabins.Any(c => c.Counselor == null)
    ? "All cabins have counselors" 
    : $"There are {_context.Cabins.Count(c => c.Counselor == null) == 0} cabins with no counselors.")} 
What would you like to do?
(Use the arrow keys to cycle through options and press enter to select an option)
";
            string[] options =
            {
                "Reports",
                "Cabins",
                "Campers",
                "Counselors",
                "Next of kins",
                "Visits",
                "Exit",
            };
            var menu = new MenuBuilder(prompt, options);
            var selectedIndex = menu.Run();
            switch (selectedIndex)
            {
                case 0:
                    await ShowReportMenu();
                    break;
                case 1:
                    await ShowCabinMenu();
                    break;
                case 2:
                    await ShowCamperMenu();
                    break;
                case 3:
                    await ShowCounselorMenu();
                    break;
                case 4:
                    await ShowNextOfKinMenu();
                    break;
                case 5:
                    await ShowVisitMenu();
                    break;
                case 6:
                    ExitApp();
                    break;
            }
        }


        private async Task ShowReportMenu()
        {
            var menu = new ReportMenu(_context);
            while (! await menu.Run())
            {
                await this.Run();
            }
        }

        private async Task ShowCabinMenu()
        {
            var menu = new CabinMenu(_context);
            while (! await menu.Run())
            {
                await this.Run();
            }
        }

        private async Task ShowCamperMenu()
        {
            var menu = new CamperMenu(_context);
            while (! await menu.Run())
            {
                await this.Run();
            }
        }

        private async Task ShowCounselorMenu()
        {
            var menu = new CounselorMenu(_context);
            while (! await menu.Run())
            {
                await this.Run();
            }
        }

        private async Task ShowNextOfKinMenu()
        {
            var menu = new NextOfKinMenu(_context);
            while (! await menu.Run())
            {
                await this.Run();
            }
        }

        private async Task ShowVisitMenu()
        {
            var menu = new VisitMenu(_context);
            while (! await menu.Run())
            {
                await this.Run();
            }
        }

        private static void ExitApp()
        {
            Console.WriteLine("Thank you for using this app. Take care");
            Environment.Exit(0);
        }
    }
}