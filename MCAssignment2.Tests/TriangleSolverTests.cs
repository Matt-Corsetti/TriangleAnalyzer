/* TriangleSolverTests.cs
 * Assignment 2 - This is the code for the unit tests
 * 
 * Revision History
 *      Matt Corsetti, 2018.02-12: Created
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MCAssignment2.Tests
{

    [TestFixture]

    ///<summary>
    /// This is the class that handles 
    /// all the unit testing for the 
    /// assignment
    ///</summary>
    public class TriangleSolverTests
    {
        [Test]
        /// <summary>
        /// This method tests if the proper string 
        /// returns for an equailateral triangle
        /// </summary>
        public void Equilateral_Triangle_Expect()
        {
            string expectedString = "It is an Equailateral triangle.";

            Assert.That(expectedString, 
                Is.EqualTo(TriangleSolver.Analyze(3, 3, 3)));
        }

        [Test]
        /// <summary>
        /// This method tests if the proper string 
        /// returns for an isosceles triangle
        /// </summary>
        public void Isosceles_Triangle_Expect_Test_One()
        {
            string expectedString = "It is an Isosceles Triangle";
            Assert.That(expectedString, 
                Is.EqualTo(TriangleSolver.Analyze(3, 3, 1)));
        }

        [Test]
        /// <summary>
        /// This method tests if the proper string 
        /// returns for an isosceles triangle
        /// </summary>
        public void Isosceles_Triangle_Expect_Test_Two()
        {
            string expectedString = "It is an Isosceles Triangle";
            Assert.That(expectedString, 
                Is.EqualTo(TriangleSolver.Analyze(1, 3, 3)));
        }

        [Test]
        /// <summary>
        /// This method tests if the proper string 
        /// returns for an isosceles triangle
        /// </summary>
        public void Isosceles_Triangle_Expect_Test_Three()
        {
            string expectedString = "It is an Isosceles Triangle";
            Assert.That(expectedString, 
                Is.EqualTo(TriangleSolver.Analyze(1, 3, 1)));
        }

        [Test]
        /// <summary>
        /// This method tests if the proper string 
        /// returns for a scalene triangle
        /// </summary>
        public void Scalene_Triangle_Expect()
        {
            string expectedString = "It is a Scalene Triangle";
            Assert.That(expectedString, 
                Is.EqualTo(TriangleSolver.Analyze(1, 2, 3)));
        }

        [Test]
        /// <summary>
        /// This method tests if the proper string 
        /// returns for not a triangle
        /// </summary>
        public void Not_A_Triangle_Expect_Test_One()
        {
            string expectedString = "It is not a triangle";
            Assert.That(expectedString, 
                Is.EqualTo(TriangleSolver.Analyze(0, 2, 3)));
        }

        [Test]
        /// <summary>
        /// This method tests if the proper string 
        /// returns for not a triangle
        /// </summary>
        public void Not_A_Triangle_Expect_Test_Two()
        {
            string expectedString = "It is not a triangle";
            Assert.That(expectedString, 
                Is.EqualTo(TriangleSolver.Analyze(1, 0, 3)));
        }

        [Test]
        /// <summary>
        /// This method tests if the proper string 
        /// returns for not a triangle
        /// </summary>
        public void Not_A_Triangle_Expect_Test_Three()
        {
            string expectedString = "It is not a triangle";
            Assert.That(expectedString, 
                Is.EqualTo(TriangleSolver.Analyze(1, 2, 0)));
        }
    }
}
