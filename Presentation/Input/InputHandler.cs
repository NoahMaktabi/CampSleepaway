﻿using System;

namespace Presentation.Input
{
    public class InputHandler
    {

        #region BirthdayHandler

        public static DateTime GetBirthday()
        {
            var year = GetYear();
            var month = GetMonth();
            var day = GetDay(month);
            return new DateTime(year, month, day);
        }

        private static int GetDay(int month)
        {
            Console.Clear();
            Console.CursorVisible = true;
            const string msg = "Please enter the day of birth";
            var maxDaysInMonth = MaxDaysInMonth(month);
            var invalidMsg = $"Invalid input. Please enter a number between 1 - {maxDaysInMonth}";
            var day = GetIntFromUserInput(msg, invalidMsg, 1, maxDaysInMonth);
            Console.CursorVisible = false;
            return day;
        }
        private static int MaxDaysInMonth(int month)
        {
            var maxDays = month switch
            {
                1 => 31,
                2 => 28,
                3 => 31,
                4 => 30,
                5 => 31,
                6 => 30,
                7 => 31,
                8 => 31,
                9 => 30,
                10 => 31,
                11 => 30,
                12 => 31,
                _ => 0
            };

            return maxDays;
        }
        private static int GetMonth()
        {
            Console.Clear();
            Console.CursorVisible = true;
            const string msg = "Please enter the month of birth";
            var invalidMsg = $"Invalid input. Please enter a number between 1 - 12";
            var month = GetIntFromUserInput(msg, invalidMsg, 1, 12);
            Console.CursorVisible = false;
            return month;
        }
        private static int GetYear()
        {
            Console.Clear();
            Console.CursorVisible = true;
            const string msg = "Please enter the year of birth";
            var invalidMsg = $"Invalid input. Please enter a number between 1930 - {DateTime.Now.Year}";
            var year = GetIntFromUserInput(msg, invalidMsg, 1930, DateTime.Now.Year);
            Console.CursorVisible = false;
            return year;
        }

        #endregion


        #region IntBoolStringHandlers

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

        #endregion

        

    }
}