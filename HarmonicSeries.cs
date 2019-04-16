//--------------------------------------------------------------------------------------------------------------------
// <copyright file="HarmonicSeries.cs" company="BridgeLabz">
// copyright @2019 
// </copyright>
//<creater name="Kaveri Tekawade"/>
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
        ///Get n'th Harmonics value.
        /// </summary>
        public void Harmonic()
        {
            try
            {
                float harmonic = 1;
                int n = 1;
                Console.WriteLine("enter the value of n up to which u want harmonic series");
                //Scanner sc= new Scanner(System.in);
                n = Convert.ToInt32(Console.ReadLine());
                if (n != 0)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        Console.WriteLine("harmonic series up to given number is: " + harmonic);
                        harmonic += (float)1 / i;

                    }
                }
                else
                {
                    Console.WriteLine("please provide values other than zero");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}