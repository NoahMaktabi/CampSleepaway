using System;

namespace Presentation.Input
{
    public class InputHandler
    {
        /// <summary>
        /// Get boolean value from user by asking for Y or N input.
        /// You have to provide a msg to show the user, ex. Is your pet insured?
        /// </summary>
        /// <param name="message"></param>
        /// <param name="clearConsole"></param>
        /// <returns>Boolean value</returns>
        public static bool GetBoolValue(string message, bool clearConsole = true)
        {
            if (clearConsole)
                Console.Clear();

            Console.WriteLine(message);
            Console.WriteLine("Please press Y or N for yes or no.");
            var keyPressed = Console.ReadKey(true);

            while ((keyPressed.Key != ConsoleKey.Y) && (keyPressed.Key != ConsoleKey.N))
            {
                Console.WriteLine(message);
                Console.WriteLine("Please press Y or N for yes or no.");
                keyPressed = Console.ReadKey(true);
            }

            return keyPressed.Key == ConsoleKey.Y;
        }

        /// <summary>
        /// Print out the provided prompt to console and asks for a string
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns>string from console ReadLine</returns>
        public static string GetString(string prompt)
        {
            Console.Clear();
            Console.WriteLine(prompt);
            Console.CursorVisible = true;
            var str = Console.ReadLine();
            Console.CursorVisible = false;
            return str;
        }

        /// <summary>
        /// Writes msgToUser, then request input from user,
        /// then converts input into int,
        /// checks that int is between or equals min and max before returning.
        /// invalidMsg must be provided in case the user types wrong input
        /// </summary>
        /// <param name="msgToUser">Msg to write to user before asking for input. Ex: Type your age,</param>
        /// <param name="invalidMsg">Msg to provide in case the input is not a number or not inside the min/max param</param>
        /// <param name="min">Minimum number allowed</param>
        /// <param name="max">Maximum number allowed</param>
        /// <returns>Valid int from the criteria defined in the parameters</returns>
        public static int GetIntFromUserInput(string msgToUser, string invalidMsg, int min, int max)
        {
            Console.Clear();
            Console.WriteLine(msgToUser);
            Console.CursorVisible = true;
            var input = Console.ReadLine();
            var success = int.TryParse(input, out var number);
            while (!success || !ValidInt(number, min, max))
            {
                Console.WriteLine(invalidMsg);
                input = Console.ReadLine();
                success = int.TryParse(input, out number);
            }
            Console.CursorVisible = false;
            return number;
        }

        private static bool ValidInt(int number, int min, int max)
        {
            return number >= min && number <= max;
        }

    }
}