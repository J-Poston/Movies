using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Movies.ConsoleApp
{
    public static class ConsoleInputHelper
    {
        public static int GetInt()
        {
            bool validInt = false;
            int input = 0;

            /*
            while(validInt == false)
            {
                validInt = int.TryParse(Console.ReadLine(), out input);
                if (!validInt)
                {
                    //Console.WriteLine("Please enter a whole number.");
                    throw new FormatException();
                }
            }*/

            try
            {
                validInt = int.TryParse(Console.ReadLine(), out input);
                if (!validInt)
                {
                    throw new FormatException();
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("The value you entered is not a whole number.");
            }
            catch (Exception)
            {
                // 
            }

            return input;
        }

        public static double GetDouble()
        {
            bool validDouble = false;
            double input = 0;

            while(validDouble == false)
            {
                validDouble = double.TryParse(Console.ReadLine(), out input);
                if (!validDouble)
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }            
            return input;
        }

        public static bool GetBool()
        {
            bool validBool = false;
            bool input = false;
            
            while(validBool == false)
            {
                validBool = bool.TryParse(Console.ReadLine(), out input);
                if (!validBool)
                {
                    Console.WriteLine("Please enter \"true\" or \"false\".");
                }
            }
            return input;
        }
    }
}
