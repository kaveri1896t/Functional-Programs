//--------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeFactor.cs" company="BridgeLabz">
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
    /// Prime Factor
    /// </summary>
    public class PrimeFactor
    {
        /// <summary>
        /// Prime Factors of given number.
        /// </summary>
        public void Factor()
        {
            int n;
            Console.WriteLine("Enter a number :");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime Factors are :");
            for (int i = 2; i <= n; i++)
            {
                ////Check for factors which are prime numbers
                while (n % i == 0)
                {
                    Console.WriteLine(i + " ");
                    n = n / i;
                }
            }

            if (n >= 2)
            {
                Console.WriteLine(n);
            }
        }
    }
}
