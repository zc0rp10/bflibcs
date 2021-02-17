using System;
using System.Collections.Generic;
using System.Text;

namespace bflibcs
{
    /// <summary>
    /// Represents enhanced utility functions for console applications.
    /// </summary>
    public class ConsoleExt
    {
        #region GetNumber Promt for user input and get a number back..
        /// <summary>
        /// Promts the user for a numerical input using the provided string. Then reads
        /// the next line of characters from the input stream and atempts to parse it to an double value type.
        /// If the parse failed the user will be promted for a new input untill sucessfull.
        /// </summary>
        /// <param name="value">
        /// The value passed to Console.Write to prompt the user for the input.</param>
        /// <returns>
        /// The next line of characters from the input stream parsed as a double.
        /// </returns>
        public static int GetInt(string value)
        {
            int num;
            bool isValid;
            bool isFirst = true;
            
            do
            {
                if (!isFirst)
                    Console.WriteLine("Incorrect input, please try again.");

                Console.Write(value);
                string input = Console.ReadLine();
                isValid = int.TryParse(input, out num);
                isFirst = false;
            } while (!isValid);
            return num;
        }

        public static float GetFloat(string value)
        {
            float num;
            bool isValid;
            bool isFirst = true;
            
            do
            {
                if (!isFirst)
                    Console.WriteLine("Incorrect input, please try again.");

                Console.Write(value);
                string input = Console.ReadLine();
                isValid = float.TryParse(input, out num);
                isFirst = false;
            } while (!isValid);
            return num;
        }

        public static double GetDouble(string value)
        {
            double num;
            bool isValid;
            bool isFirst = true;

            do
            {
                if (!isFirst)
                    Console.WriteLine("Incorrect input, please try again.");

                Console.Write(value);
                string input = Console.ReadLine();
                isValid = double.TryParse(input, out num);
                isFirst = false;
            } while (!isValid);
            return num;
        }

        public static decimal GetDecimal(string value)
        {
            decimal num;
            bool isValid;
            bool isFirst = true;

            do
            {
                if (!isFirst)
                    Console.WriteLine("Incorrect input, please try again.");

                Console.Write(value);
                string input = Console.ReadLine();
                isValid = decimal.TryParse(input, out num);
                isFirst = false;
            } while (!isValid);
            return num;
        }
        #endregion


    }
}
