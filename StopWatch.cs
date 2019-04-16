//--------------------------------------------------------------------------------------------------------------------
// <copyright file="StopWatch.cs" company="BridgeLabz">
// copyright @2019 
// </copyright>
// <creater name="Kaveri Tekawade"/>
//------------------------------------------------------------------------------------------------------------------
namespace Functional_Programs
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// To Calculate |Elapsed time between start and stop 
    /// </summary>
    public class StopWatch
    {
        /// <summary>
        /// Start the stopwatch
        /// </summary>
        public void Start1()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
        }

        /// <summary>
        /// Stop the stopwatch
        /// </summary>
        public void Stop1()
        {
            Stopwatch sw = new Stopwatch();
            sw.Stop();
        }

        /// <summary>
        /// Elapsed the time.
        /// </summary>
        public void ElapsedTime()
        {
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("ElapsedTime is : " + sw.ElapsedMilliseconds);
        }

        /// <summary>
        /// Calculates the elapsed time.
        /// </summary>
        public void CalculateElapsedTime()
        {
            int ch;
            char ans;
            try
            {
                do
                {
                    Console.WriteLine("1.Start\n2.Stop\nEnter your choice : ");
                    ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            this.Start1();
                            break;
                        case 2:
                            this.Stop1();
                            break;
                        default:
                            break;
                    }

                    Console.WriteLine("Do you want to continue(y/n) : ");
                    ans = Convert.ToChar(Console.ReadLine());
                }
                while (ans == 'y' || ans == 'Y');
                this.ElapsedTime();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
