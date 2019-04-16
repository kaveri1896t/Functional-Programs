//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Leapyear1.cs" company="BridgeLabz">
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
    /// Leap year1
    /// </summary>
    public class Leapyear1
    {
        /// <summary>
        /// check whether the year1 is leap year1 or not.
        /// </summary>
        public void CalcLeapYear()
        {
            try
            {
                Console.WriteLine("enter year : ");
                string year = Console.ReadLine();
                int year1 = Convert.ToInt32(year);
                if (year.Length == 4)
                {
                    ////The year1 divisible by 4 && not a centurial || Centurial but divisible by 400
                    if ((year1 % 4 == 0) && (year1 % 100 != 0 || year1 % 400 == 0))
                    {
                        Console.WriteLine("entered year {0} is leap year", year1);
                    }
                    else
                    {
                        Console.WriteLine("entered year {0} is not leap year", year1);
                    }
                }
                else
                {
                    Console.WriteLine(year1 + " is not a valid year...");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
