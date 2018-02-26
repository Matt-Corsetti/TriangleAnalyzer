/* Program.cs
 * Assignment 2 - This is the code for the console application
 * 
 * Revision History
 *      Matt Corsetti, 2018.02-18: Created
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAssignment2
{
    /// <summary>
    /// This is the main program with
    /// the code for the console application
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // declaring variables
            string userMenuInput;
            int userInputOne;
            int userInputTwo;
            int userInputThree;

            bool appRunning = true;

            while (appRunning)
            {
                // displaying the menu
                Console.Clear();
                Console.WriteLine("1. Enter Triangle Dimensions");
                Console.WriteLine("2. Exit");
                userMenuInput = Console.ReadLine().Trim();

                // handling the user input
                switch (userMenuInput)
                {
                    case "1":
                        try
                        {
                            // obtaining the triangle dimensions
                            Console.Clear();
                            Console.Write("Please enter the first dimension: ");
                            userInputOne = int.Parse(Console.ReadLine().Trim());
                            Console.Clear();
                            Console.Write("Please enter the second dimension: ");
                            userInputTwo = int.Parse(Console.ReadLine().Trim());
                            Console.Clear();
                            Console.Write("Please enter the third dimension: ");
                            userInputThree = int.Parse(Console.ReadLine().Trim());
                            // calling the triangle solver method
                            TriangleSolver.Analyze(userInputOne, userInputTwo, 
                                userInputThree);
                            Console.ReadLine();
                        }
                        catch (Exception ex)
                        {
                            Console.Clear();
                            Console.WriteLine("You cannot enter a non-numeric " +
                                "character." + "\n", ex);
                            Console.Write("... Press Enter to Continue ...");
                            Console.ReadLine();
                        }
                        break;
                    case "2":
                        // closing the application
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("You cannot enter a" +
                            " non-numeric character.");
                        Console.Write("... Press Enter to Continue ...");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
