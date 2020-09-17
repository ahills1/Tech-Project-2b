
// Programmer: Ashley Hills
// Project: Tech Project 2a
// Date: 09/14/2020
// Description:  A console program that demonstrates the use of conditional statements after getting input from a user
using System;

namespace Tech_Project_2b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the grade you expect to receive in ISM 4300. (This should an integer value) ");
            try
            {
                string input = Console.ReadLine();
                int value_of_input = int.Parse(input);

                if ((value_of_input >= 93) && (value_of_input <= 100))
                {
                    Console.WriteLine("You should expect to receive an A in ISM 4300 with a grade value of" + " " + value_of_input);
                    Console.WriteLine("Please press any key to exit the progam...");
                    Console.ReadKey(true);
                }

                else if ((value_of_input >= 90) && (value_of_input <= 92))
                {
                    Console.WriteLine("You should expect to receive an A- in ISM 4300 with a grade value of" + " " + value_of_input);
                    Console.WriteLine("Please press any key to exit the progam...");
                    Console.ReadKey(true);
                }

                else if ((value_of_input >= 87) && (value_of_input <= 89))
                {
                    Console.WriteLine("You should expect to receive a B+ in ISM 4300 with a grade value of" + " " + value_of_input);
                    Console.WriteLine("Please press any key to exit the progam...");
                    Console.ReadKey(true);
                }

                else if ((value_of_input >= 83) && (value_of_input <= 86))
                {
                    Console.WriteLine("You should expect to receive a B in ISM 4300 with a grade value of" + " " + value_of_input);
                    Console.WriteLine("Please press any key to exit the progam...");
                    Console.ReadKey(true);
                }

                else if ((value_of_input >= 80) && (value_of_input <= 82))
                {
                    Console.WriteLine("You should expect to receive a B- in ISM 4300 with a grade value of" + " " + value_of_input);
                    Console.WriteLine("Please press any key to exit the progam...");
                    Console.ReadKey(true);
                }

                else if ((value_of_input >= 77) && (value_of_input <= 79))
                {
                    Console.WriteLine("You should expect to receive a C+ in ISM 4300 with a grade value of" + " " + value_of_input);
                    Console.WriteLine("Please press any key to exit the progam...");
                    Console.ReadKey(true);
                }

                else if ((value_of_input >= 73) && (value_of_input <= 76))
                {
                    Console.WriteLine("You should expect to receive a C in ISM 4300 with a grade value of" + " " + value_of_input);
                    Console.WriteLine("Please press any key to exit the progam...");
                    Console.ReadKey(true);
                }

                else if ((value_of_input >= 70) && (value_of_input <= 72))
                {
                    Console.WriteLine("You should expect to receive a C- in ISM 4300 with a grade value of" + " " + value_of_input);
                    Console.WriteLine("Please press any key to exit the progam...");
                    Console.ReadKey(true);
                }

                else if ((value_of_input >= 67) && (value_of_input <= 69))
                {
                    Console.WriteLine("You should expect to receive a D+ in ISM 4300 with a grade value of" + " " + value_of_input);
                    Console.WriteLine("Please press any key to exit the progam...");
                    Console.ReadKey(true);

                }

                else if ((value_of_input >= 63) && (value_of_input <= 66))
                {
                    Console.WriteLine("You should expect to receive a D in ISM 4300 with a grade value of" + " " + value_of_input);
                    Console.WriteLine("Please press any key to exit the progam...");
                    Console.ReadKey(true);
                }

                else if ((value_of_input >= 60) && (value_of_input <= 62))
                {
                    Console.WriteLine("You should expect to receive a D- in ISM 4300 with a grade value of" + " " + value_of_input);
                    Console.WriteLine("Please press any key to exit the progam...");
                    Console.ReadKey(true);
                }

                else if ((value_of_input >= 0) && (value_of_input <= 59))
                {
                    Console.WriteLine("You should expect to receive an F in ISM 4300 with a grade value of" + " " + value_of_input);
                    Console.WriteLine("Please press any key to exit the progam...");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                Console.WriteLine("Please enter a valid integar value between 0 - 100 of the grade you expect to receive in ISM 4300.");
                Console.WriteLine("Please press any key to exit the progam and try again");
                Console.ReadKey(true);
            }
        }
    }
}
