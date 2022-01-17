using System;
using System.Threading.Tasks;
using Persistence;
using Persistence.Repository;
using Presentation.MenuSystem.SubMenus;

namespace Presentation.MenuSystem
{
    public class MainMenu
    {
        private readonly CamperRepository _camperRepository;
        private readonly DataContext _context;

        public MainMenu()
        {
            _context = new DataContext();
            _camperRepository = new CamperRepository(_context);
        }

        public async Task Run()
        {
            var prompt = @"
Welcome to CampAway.What would you like to do?
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

        private async Task ShowCamperMenu()
        {
            var menu = new CamberMenu(_context);
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

        private static void ExitApp()
        {
            Console.WriteLine("Thank you for using this app. Take care");
            Environment.Exit(0);
        }
    }
}