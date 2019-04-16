//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="BridgeLabz">
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
    /// Menu for all programs
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            char condition;
            do
            {
                Console.WriteLine("Press 1 for  : Replace the string");
                Console.WriteLine("Press 2 for  : Probability Percentage for flip coin");
                Console.WriteLine("Press 3 for  : Identify leap year or not");
                Console.WriteLine("Press 4 for  : Print Power Of two");
                Console.WriteLine("Press 5 for  : To print harmonic series");
                Console.WriteLine("Press 6 for  : To print Prime Factors");
                Console.WriteLine("Press 7 for  : Gambler Play");
                Console.WriteLine("Press 8 for  : Distinct Coupons");
                Console.WriteLine("Press 9 for  : Two Dimentional Array");
                Console.WriteLine("Press 10 for : Print Triplet sums to zero");
                Console.WriteLine("Press 11 for : Print Euclidean Distance of point(x,y) from origin (0,0)");
                Console.WriteLine("Press 12 for : Print roots of quadratic equation");
                Console.WriteLine("Press 13 for : Calculate the Wind Chill ");
                Console.WriteLine("Press 14 for : Calulate Elapsed Time ");
                Console.WriteLine("Press 15 for : Play Tic-Tac-Toe Game");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        ReplaceString rs = new ReplaceString();
                        rs.ReplaceString1();
                        break;
                    case 2:
                        FlipCoin fp = new FlipCoin();

                        fp.FlipCoin1();
                        break;
                    case 3:
                        Leapyear1 lp = new Leapyear1();
                        lp.CalcLeapYear();
                        break;
                    case 4:
                        PowerOfTwo p = new PowerOfTwo();
                        p.Input();
                        break;
                    case 5:
                        HarmonicSeries hs = new HarmonicSeries();
                        hs.Harmonic();
                        break;
                    case 6:
                        PrimeFactor pf = new PrimeFactor();
                        pf.Factor();
                        break;
                    case 7:
                        Gambler g = new Gambler();
                        g.GamblerPlay();
                        break;
                    case 8:
                        Coupon c = new Coupon();
                        c.DistinctCoupon();
                        break;
                    case 9:
                        TwoDArray td = new TwoDArray();
                        td.TwoDArrays();
                        break;
                    case 10:
                        Triplet t = new Triplet();
                        t.Tripletsumzero();
                        break;
                    case 11:
                        Distance d = new Distance();
                        d.EuclideanDistance();
                        break;
                    case 12:
                        Quadratic q = new Quadratic();
                        q.RootsOfQuadraticEquation();
                        break;
                    case 13:
                        WindChill wc = new WindChill();
                        wc.CalculateWindChill();
                        break;
                    case 14:
                        StopWatch sw = new StopWatch();
                        sw.CalculateElapsedTime();
                        break;
                    case 15:
                        TicTacToeTest tp = new TicTacToeTest();
                        tp.PlayTicTacToeTest();
                        break;
                    default:
                        Console.WriteLine("no not in range");
                        break;
                }

                Console.WriteLine("enter Y to continue and enter N to exit");
                condition = Convert.ToChar(Console.ReadLine());
            }
            while (condition == 'y');
        }
    }
}
