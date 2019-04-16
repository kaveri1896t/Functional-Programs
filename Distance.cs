//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Distance.cs" company="BridgeLabz">
// copyright @2019 
// </copyright>
// <creater name="Kaveri Tekawade"/>
//--------------------------------------------------------------------------------------------------------------------
namespace Functional_Programs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Distance class
    /// </summary>
    public class Distance
    {
        /// <summary>
        /// Euclidean distance.
        /// </summary>
        public void EuclideanDistance()
        {
            try
            {
                int x, y;
                Console.WriteLine("Enter values of x  : ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter values of y : ");
                y = Convert.ToInt32(Console.ReadLine());
                double edistance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                Console.WriteLine("Euclidean distance from the point (" + x + "," + y + ") to the origin (0,0) is " + edistance);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
