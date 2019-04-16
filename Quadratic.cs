//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Quadratic.cs" company="BridgeLabz">
// copyright @2019 
// </copyright>
// <creater name="Kaveri Tekawade"/>
//------------------------------------------------------------------------------------------------------------------
namespace Functional_Programs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Roots of quadratic equation
    /// </summary>
    public class Quadratic
    {
        /// <summary>
        /// a,b,c are the three coefficients of the quadratic equations
        /// </summary>
        private double a, b, c;

        /// <summary>
        /// Inputs this instance.
        /// </summary>
        public void Input()
        {
            try
            {
                Console.WriteLine("Enter the value of a :");
                this.a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the value of b :");
                this.b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the value of c :");
                this.c = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Roots the of quadratic equation.
        /// </summary>
        public void RootsOfQuadraticEquation()
        {
            try
            {
                this.Input();
                double rootx1 = 0.0;
                double rootx2 = 0.0;
                Console.WriteLine("The entered expression is : " + this.a + "x*x+" + this.b + "x+" + this.c);
                double delta = (this.b * this.b) - (4 * this.a * this.c);
                if (delta > 0)
                {
                    rootx1 = (-this.b + Math.Sqrt(delta)) / (2 * this.a);
                    rootx2 = (-this.b - Math.Sqrt(delta)) / (2 * this.a);
                }

                Console.WriteLine("Two roots of x are : " + rootx1 + " & " + rootx2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}