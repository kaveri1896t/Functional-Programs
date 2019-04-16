//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Triplet.cs" company="BridgeLabz">
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
    /// Distinct Triplets sums to zero 
    /// </summary>
    public class Triplet
    {
        /// <summary>
        /// Triplet sums to zero
        /// </summary>
        public void Tripletsumzero()
        {
            try
            {
                int n;
                Console.WriteLine("Enter the value of n : ");
                n = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[n];
                int count = 0;
                Console.WriteLine("Enter the numbers : ");
                for (int i = 0; i < n; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Entered Array is : ");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(arr[i]);
                }

                ////Check condition for distinct triplets sums to zero
                for (int i = 0; i < n - 2; i++)
                {
                    for (int j = i + 1; j < n - 1; j++)
                    {
                        for (int k = j + 1; k < n; k++)
                        {
                            if ((arr[i] + arr[j] + arr[k]) == 0)
                            {
                                count = count + 1;
                                Console.WriteLine("Triplet is (" + arr[i] + "," + arr[j] + "," + arr[k] + ")");
                            }
                        }
                    }
                }

                Console.WriteLine("Total no of triplets is : " + count);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
