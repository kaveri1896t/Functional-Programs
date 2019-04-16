//--------------------------------------------------------------------------------------------------------------------
// <copyright file="HarmonicSeries.cs" company="BridgeLabz">
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
    /// Harmonic Series
    /// </summary>
    public class HarmonicSeries
    {
        /// <summary>
        /// Get Harmonics value.
        /// </summary>
        public void Harmonic()
        {
            try
            {
                float harmonic = 1;
                int n = 1;
                Console.WriteLine("enter the value of n up to which you want harmonic series");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("harmonic series up to given number is: ");
                if (n != 0)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        Console.Write("(1 / {0}) + ", i);
                        harmonic += (float)1 / i;
                    }

                }
                else
                {
                    Console.WriteLine("please provide values other than zero");
                }

                Console.WriteLine("\n{0}th Harmonic value is : {1}", n, harmonic);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}