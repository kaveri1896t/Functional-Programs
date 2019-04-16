//--------------------------------------------------------------------------------------------------------------------
// <copyright file="PowerOfTwo.cs" company="BridgeLabz">
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
    /// Any power of two
    /// </summary>
    public class PowerOfTwo
    {
        int n;
        /// <summary>
        /// Inputs the number from user to calculate nth power of two .
        /// </summary>
        public void input()
        {
            try
            {
                Console.WriteLine("Enter the value : ");
                n = Convert.ToInt32(Console.ReadLine());
                int power = 1;
                Console.WriteLine("Powers of 2 that are less than 2^" + n);
                if (n < 31)
                {
                    for (int i = 0; i <= n; i++)
                    {
                        Console.WriteLine("2^" + i + " = " + power);
                        power = power * 2;
                    }
                }
                else
                {
                    Console.WriteLine("please provide value less than 31");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
