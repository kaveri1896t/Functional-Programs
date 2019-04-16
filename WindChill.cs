//--------------------------------------------------------------------------------------------------------------------
// <copyright file="WindChill.cs" company="BridgeLabz">
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
    /// Wind Chill
    /// </summary>
    public class WindChill
    {
        /// <summary>
        /// The t is the temperature
        /// </summary>
        private double t = 0.0, v = 0.0;

        /// <summary>
        /// Get data from user.
        /// </summary>
        public void Getdata()
        {
            Console.WriteLine("Enter the value of t : ");
            this.t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of v: ");
            this.v = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// Calculates the wind chill.
        /// </summary>
        public void CalculateWindChill()
        {
            this.Getdata();
            if (this.t < 50 || this.v < 120 || this.v > 3)
            {
                double w = 34.74 + (0.6215 * this.t) + (((0.4275 * this.t) - 35.75) * Math.Pow(this.v, 0.16));
                Console.WriteLine("WindChill = " + w);
            }
        }
    }
}
