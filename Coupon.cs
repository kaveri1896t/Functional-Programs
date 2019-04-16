//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Coupon.cs" company="BridgeLabz">
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
    /// Distinct Coupons
    /// </summary>
    public class Coupon
    {
        /// <summary>
        /// Distinct the coupon.
        /// </summary>
        public void DistinctCoupon()
        {
            try
            {
                Random random = new Random();
                Console.WriteLine("enter numbers");
                int n = Convert.ToInt32(Console.ReadLine());
                bool[] isCollected = new bool[n];
                int count = 0;
                int distinct = 0;
                //// repeatedly choose a random card and check whether it's a new one
                while (distinct < n)
                {
                    int value = Convert.ToInt32(random.Next(n));
                    count++;
                    if (!isCollected[value])
                    {
                        distinct++;
                        Console.WriteLine("distinct values are:" + distinct);
                        isCollected[value] = true;
                    }
                }
                //// print the total number of cards collected
                Console.WriteLine("Total Random nos needed to make all Distinct");
                Console.WriteLine(count);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}