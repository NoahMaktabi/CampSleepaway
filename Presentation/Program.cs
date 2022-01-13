using System;
using System.Threading.Tasks;
using Application;
using Persistence;
using Persistence.Repository;

namespace Presentation
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var dataContext = new DataContext();
            var camperRepository = new CamperRepository(dataContext);
            var report = new Report(camperRepository);

            Console.WriteLine(await  report.GetAllCampersByCounselor());
        }
    }
}
