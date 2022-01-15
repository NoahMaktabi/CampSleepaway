﻿using System;
using System.Reflection.Metadata.Ecma335;
using Persistence;
using Persistence.Repository;
using System.Threading.Tasks;
using Application;

namespace Presentation.MenuSystem.SubMenus
{
    public class ReportMenu
    {
        private readonly Report _report;

        public ReportMenu(DataContext context)
        {
            _report = new Report(context);
        }

        public async Task<bool> Run()
        {
            const string prompt = "Please choose which report you want to see";
            var options = new string[]
            {
                "Campers sorted by cabins",
                "Campers sorted by counselors",
                "Return to main menu",
            };
            var menu = new MenuBuilder(prompt, options);
            var selectedIndex = menu.Run();
            var result = "";
            switch (selectedIndex)
            {
                case 0:
                    result = await _report.GetAllCampersByCabin();
                    break;
                case 1:
                    result = await _report.GetAllCampersByCounselor();
                    break;
                case 2:
                    return false;
            }

            Console.WriteLine(result);

            Console.WriteLine("Press any key to return to report menu...");
            Console.ReadKey(true);
            await this.Run();

            return false;
        }
    }
}