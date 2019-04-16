//--------------------------------------------------------------------------------------------------------------------
// <copyright file="FlipCoin.cs" company="BridgeLabz">
// copyright @2019 
// </copyright>
//<creater name="Kaveri Tekawade"/>
//--------------------------------------------------------------------------------------------------------------------
namespace Functional_Programs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    /// <summary>
    /// Gambler 
    /// </summary>
    public class Gambler
    {
        /// <summary>
        /// Gamblers the play to achieve goal state or Broke state.
        /// </summary>
        public void GamblerPlay()
        {
            try
            {
                ////gambler's stating bankroll
                Console.WriteLine("Enter stake : ");
                int stake = Convert.ToInt32(Console.ReadLine());
                ////gambler's desired bankroll
                Console.WriteLine("Enter Goal : ");
                int goal = Convert.ToInt32(Console.ReadLine());
                ////number of trials to perform
                Console.WriteLine("Enter no of Trials : ");
                int trials = Convert.ToInt32(Console.ReadLine());
                ////total number of bets made
                int bets = 0;
                ////total number of games won
                int wins = 0;     
                int loss = 0;

                Random random = new Random();

                ////repeat trials no of times
                for (int t = 0; t < trials; t++)
                {

                    ////One gambler's ruin simulation
                    int cash = stake;
                    while (cash > 0 && cash < goal)
                    {
                        bets++;
                        if (random.NextDouble() < 0.5)
                            ////win $1
                            cash++;     
                        else
                            ////lose $1
                            cash--;     
                    }

                    if (cash == goal)
                        wins++;
                    else
                        loss++;
                }

                ////print results
                Console.WriteLine(wins + " wins of " + trials);
                Console.WriteLine("Percent of games won = " + 100.0 * wins / trials);
                Console.WriteLine("Percent of games loose = " + 100.0 * loss / trials);
                double win = 100.0 * wins / trials;
                double loose = 100.0 * loss / trials;
                if (win == loose)
                    Console.WriteLine("Final Result : Its a tie...\n ");
                else if (win > loose)
                    Console.WriteLine("Final Result : Gambler won...\n ");
                else
                    Console.WriteLine("Final Result : Gambler loose...\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

