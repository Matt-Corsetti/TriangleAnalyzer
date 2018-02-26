/* TriangleSolver.cs
 * Assignment 2 - This is the code for the TriangleSolver class
 * 
 * Revision History
 *      Matt Corsetti, 2018.02-12: Created
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAssignment2
{
    /// <summary>
    /// Static class that analyzes the dimensions 
    /// inputed from the user
    /// </summary>
    public static class TriangleSolver
    {
        /// <summary>
        /// The static method that determines
        /// what type of triangle the user's 
        /// inputs would create, or if they 
        /// would not create a triangle at all
        /// </summary>
        /// <param name="dimensionOne"></param>
        /// <param name="dimensionTwo"></param>
        /// <param name="dimensionThree"></param>
        /// <returns></returns>
        public static string Analyze(int dimensionOne, int dimensionTwo, int dimensionThree)
        {
            // if the user entered a number 0 or less than 0
            if (dimensionOne <= 0 
                || dimensionTwo <= 0 
                || dimensionThree <= 0)
            {
                string notTriangle = "It is not a triangle";
                Console.WriteLine("It is not a triangle");
                return notTriangle;
            }

            // if all the dimensions are the same
            else if (dimensionOne == dimensionTwo 
                && dimensionTwo == dimensionThree)
            {
                string isEquailateral = "It is an Equailateral triangle.";
                Console.WriteLine("It is an Equailateral Triangle");
                return isEquailateral;
            }
            
            // if the first two dimensions are equal
            else if (dimensionOne == dimensionTwo 
                && dimensionOne != dimensionThree 
                && dimensionTwo != dimensionThree)
            {
                string isIsosceles = "It is an Isosceles Triangle";
                Console.WriteLine("It is an Isosceles Triangle");
                return isIsosceles;
            }

            // if the second and third dimensions are equal
            else if (dimensionTwo == dimensionThree
                && dimensionOne != dimensionTwo)
            {
                string isIsosceles = "It is an Isosceles Triangle";
                Console.WriteLine("It is an Isosceles Triangle");
                return isIsosceles;
            }

            // if the first and last dimensions are equal
            else if (dimensionOne == dimensionThree
                && dimensionTwo != dimensionOne)
            {
                string isIsosceles = "It is an Isosceles Triangle";
                Console.WriteLine("It is an Isosceles Triangle");
                return isIsosceles;
            }
            
            // if none of the above conditions are met, triangle is
            // a scalene triangle
            else 
            {
                string isScalene = "It is a Scalene Triangle";
                Console.WriteLine("It is a Scalene Triangle");
                return isScalene;
            }
        }
    }
}
