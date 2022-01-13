using System.Threading.Tasks;
using Presentation.MenuSystem;

namespace Presentation
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var menu = new MainMenu();
            await menu.Run();
        }
    }
}
