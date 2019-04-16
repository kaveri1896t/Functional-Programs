//--------------------------------------------------------------------------------------------------------------------
// <copyright file="FlipCoin.cs" company="BridgeLabz">
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
    /// Flips Coin multiple time and check win condition
    /// </summary>
    public class FlipCoin
    {
        /// <summary>
        /// The random is a object of Random class
        /// </summary>
        private Random random = new Random();

        /// <summary>
        /// Flips the coin and check for the win condition
        /// </summary>
        public void FlipCoin1()
        {
            try
            {
                double heads = 0;
                double tails = 0;
                int n;
                Console.WriteLine("enter the number of times the coin to be flips : ");
                n = Convert.ToInt32(Console.ReadLine());
                Random rd = new Random();
                if (n > 0)
                {
                    for (int i = 0; i < n; i++)
                    {
                        double result = this.random.NextDouble();
                        Console.WriteLine(result);
                        if (result <= 0.5)
                        {
                            heads++;
                        }
                        else
                        {
                            tails++;
                        }
                    }
                    ////Calculate the percentage of flips for head and tail
                    double percentHeads = heads / n * 100;
                    double percentTails = (n - heads) / n * 100;
                    Console.WriteLine("percentage of heads is: " + percentHeads);
                    Console.WriteLine("percentage of tails is: " + percentTails);
                    if (percentHeads > percentTails)
                    {
                        Console.WriteLine("Head Wins");
                    }
                    else
                    {
                        Console.WriteLine("Tail Wins");
                    }
                }
                else
                {
                    Console.WriteLine("please enter enter positive number");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}